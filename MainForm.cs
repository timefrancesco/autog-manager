using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace VillaUserManager
{
    public partial class MainForm : Form
    {
        BindingList<UtenteCercato> m_UtentiTrovati = new BindingList<UtenteCercato>();
        BindingList<UtenteCercato> m_UtentiPatenteScadenza = new BindingList<UtenteCercato>();
        BindingList<UtenteCercato> m_UtentiFrosaScadenza = new BindingList<UtenteCercato>();
        BindingList<UtentiScadenza> m_UtentiaCuiscade2 = new BindingList<UtentiScadenza>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (!tbox_Search.Text.Equals(string.Empty))
                DataAccess.Instance.TempString = tbox_Search.Text;
            AddUserForm AddUser = new AddUserForm();
            AddUser.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CercaUtente();
        }

        private void btn_SearchScadenzaPat_Click(object sender, EventArgs e)
        {
            CercaScadPatente();


        }

      /*  private void tbox_Dadata_Leave(object sender, EventArgs e)
        {
            if (!tbox_Dadata.Text.Equals(string.Empty)) //NEL CASO NON SIA VUOTO
            {
                SqliteOperations sqlop = new SqliteOperations();
                tbox_Dadata.Text = sqlop.TransformDate(tbox_Dadata.Text);
            }
        }

        private void tbox_aData_Leave(object sender, EventArgs e)
        {
            if (!tbox_aData.Text.Equals(string.Empty)) //NEL CASO NON SIA VUOTO
            {
                SqliteOperations sqlop = new SqliteOperations();
                tbox_aData.Text = sqlop.TransformDate(tbox_aData.Text);
            }
        }*/

        private void tbox_categoria_Leave(object sender, EventArgs e)
        {
            if (!tbox_categoria.Text.Equals(String.Empty))
                tbox_categoria.Text.ToUpper();
        }

        private void table_UtentiTrovati_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    foreach (UtenteCercato User in m_UtentiTrovati)
                    {
                        if (User.CodiceFiscale.Equals(table_UtentiTrovati.Rows[e.RowIndex].Cells[6].Value.ToString()))
                        {
                            DataAccess.Instance.UtenteSelezionato = User;
                            DataAccess.Instance.IsUserModifyOn = true;
                            break;
                        }
                    }

                    if (DataAccess.Instance.IsUserModifyOn)
                    {
                        AddUserForm AddUser = new AddUserForm();
                        AddUser.ShowDialog();
                        DataAccess.Instance.IsUserModifyOn = false;
                        //DataAccess.Instance.UtenteSelezionato
                    }



                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: Errore 2";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            ConfigForm CF = new ConfigForm();
            CF.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string ConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AutoG\\config.ini";
                CFileINI ConfigIni = new CFileINI(ConfigFile);

                DataAccess.Instance.Path_DB_Comuni = ConfigIni.ReadValue("Config", "DBcomuni", string.Empty);
                DataAccess.Instance.Path_DB_Utenti = ConfigIni.ReadValue("Config", "DButenti", string.Empty);
                DataAccess.Instance.UtenteSelezionato = new UtenteCercato();
                DataAccess.Instance.PatenteSelezionata = new Patente();
                DataAccess.Instance.ContattoSelezionato = new Contatto();
                DataAccess.Instance.EsameSelezionato = new Esame();
                DataAccess.Instance.TempString = string.Empty;
                if (DataAccess.Instance.Path_DB_Utenti.Equals(string.Empty))
                {
                    ConfigForm CF = new ConfigForm();
                    CF.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                string error = "Errore nella lettura dei database o del file ini: ERRORE 1";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            BackupForm Backup = new BackupForm();
            Backup.ShowDialog();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.ShowDialog();
        }

        private void tbox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CercaUtente();
        }

        void CercaUtente()
        {
            try
            {
                if (tbox_Search.Text.Equals(string.Empty))
                {
                     if ( MessageBox.Show("Attenzione, saranno visualizzati tutti gli utenti registrati, questa operazione può richiedere molto tempo, CONTINUARE?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SqliteOperations SqlOp = new SqliteOperations();
                        m_UtentiTrovati = SqlOp.ViewAllUsers();
                        table_UtentiTrovati.DataSource = m_UtentiTrovati;
                        table_UtentiTrovati.Refresh();
                    }
                     return;
                }
                    
                if (rdo_Nome.Checked)   //ricerca per nome
                {
                    string cognome, nome;
                    DataAccess.Instance.StringaDaCercare = tbox_Search.Text.ToUpper();
                    //divido il nome dal cognome
                    string[] NomeDiviso = DataAccess.Instance.StringaDaCercare.Split(' ');
                    if (NomeDiviso.Count() == 1) //solo cognome
                    {
                        cognome = cognome = NomeDiviso[0];
                        nome = string.Empty;
                    }
                    else if (NomeDiviso.Count() > 2) //piu cognomi
                    {
                        nome = NomeDiviso[NomeDiviso.Count() - 1];
                        cognome = DataAccess.Instance.StringaDaCercare.Remove(DataAccess.Instance.StringaDaCercare.LastIndexOf(nome));
                    }
                    else
                    {
                        cognome = NomeDiviso[0];
                        nome = NomeDiviso[1];
                    }
                    SqliteOperations SqlOp = new SqliteOperations();
                    m_UtentiTrovati = SqlOp.SearchUser(nome, cognome);
                    table_UtentiTrovati.DataSource = m_UtentiTrovati;
                    table_UtentiTrovati.Refresh();
                    DataAccess.Instance.StringaDaCercare = string.Empty;

                }
                else if (rdo_ComResid.Checked) //ricerca per comune residenza
                {
                    DataAccess.Instance.StringaDaCercare = tbox_Search.Text.ToUpper();
                    SqliteOperations SqlOp = new SqliteOperations();
                    m_UtentiTrovati = SqlOp.SearchUserByTown(DataAccess.Instance.StringaDaCercare);
                    table_UtentiTrovati.DataSource = m_UtentiTrovati;
                    table_UtentiTrovati.Refresh();
                    DataAccess.Instance.StringaDaCercare = string.Empty;

                }
                else if (rdo_NumPatente.Checked) //richerca per numero patente
                {
                    SqliteOperations SqlOp = new SqliteOperations();
                    m_UtentiTrovati = SqlOp.SearchUserByLicense(tbox_Search.Text.ToUpper());
                    table_UtentiTrovati.DataSource = m_UtentiTrovati;
                    table_UtentiTrovati.Refresh();
                    DataAccess.Instance.StringaDaCercare = string.Empty;
                }
                else if (rdo_Telefono.Checked) //ricerca per numero di telefono
                {
                    SqliteOperations SqlOp = new SqliteOperations();
                    m_UtentiTrovati = SqlOp.SearchUserByPhone(tbox_Search.Text.ToUpper());
                    table_UtentiTrovati.DataSource = m_UtentiTrovati;
                    table_UtentiTrovati.Refresh();
                    DataAccess.Instance.StringaDaCercare = string.Empty;

                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 3";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CercaScadPatente()
        {
            try
            {
               /* if (tbox_Dadata.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Devi impostare la data da cui partire", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (tbox_aData.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Devi impostare la data termine", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }*/
                string[] dadata, todata;
               // dadata = tbox_Dadata.Text.Split('/');
               // todata = tbox_aData.Text.Split('/');
                dadata = cal_DaData.Text.Split('/');
                todata = cal_Adata.Text.Split('/');
                string DaDataOK = string.Format("{0}-{1}-{2} 00:00:00", dadata[2], dadata[1], dadata[0]);
                string ADataOK = string.Format("{0}-{1}-{2} 00:00:00", todata[2], todata[1], todata[0]);

                string a = cal_DaData.Text;


                string strcmd = string.Format("SELECT  * FROM PATENTI WHERE RILASCIATA >= \"{0}\"", DaDataOK);

                if (!ADataOK.Equals(String.Empty))
                    strcmd = string.Format("{0} AND SCADENZA <= \"{1}\" AND ( TIPO =", strcmd, ADataOK);

                if (chk_Patente.Checked)
                {
                    strcmd = strcmd + " \"PATENTE\"";
                    if (chk_CQC.Checked)
                        strcmd = strcmd + " OR TIPO = \"CQC\"";
                    if (chk_CAP.Checked)
                        strcmd = strcmd + " OR TIPO = \"KAP\"";
                    if (chk_Frosa.Checked)
                        strcmd = strcmd + " OR TIPO = \"FOGLIO ROSA\"";
                }
                else if (chk_CQC.Checked)
                {
                    strcmd = strcmd + " \"CQC\"";
                    if (chk_Patente.Checked)
                        strcmd = strcmd + " OR TIPO = \"PATENTE\"";
                    if (chk_CAP.Checked)
                        strcmd = strcmd + " OR TIPO = \"KAP\"";
                    if (chk_Frosa.Checked)
                        strcmd = strcmd + " OR TIPO = \"FOGLIO ROSA\"";
                }
                else if (chk_Frosa.Checked)
                {
                    strcmd = strcmd + " \"FOGLIO ROSA\"";
                    if (chk_Patente.Checked)
                        strcmd = strcmd + " OR TIPO = \"PATENTE\"";
                    if (chk_CAP.Checked)
                        strcmd = strcmd + " OR TIPO = \"KAP\"";
                    if (chk_CQC.Checked)
                        strcmd = strcmd + " OR TIPO = \"CQC\"";
                }
                else if (chk_CAP.Checked)
                {
                    strcmd = strcmd + " \"KAP\"";
                    if (chk_CQC.Checked)
                        strcmd = strcmd + " OR TIPO = \"CQC\"";
                    if (chk_Patente.Checked)
                        strcmd = strcmd + " OR TIPO = \"PATENTE\"";
                    if (chk_Frosa.Checked)
                        strcmd = strcmd + " OR TIPO = \"FOGLIO ROSA\"";
                }
                else
                {
                    MessageBox.Show("Non hai selezionato nessun tipo di documento in cui cercare", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                strcmd = string.Format("{0})", strcmd);

                if (!tbox_categoria.Text.Equals(string.Empty))
                    strcmd = string.Format("{0} and categoria = \"{1}\"", strcmd, tbox_categoria.Text.ToUpper());

                SqliteOperations SqlOp = new SqliteOperations();
                m_UtentiTrovati = SqlOp.SearchUserByLicenseSCAD_Doc(strcmd);
                table_UtentiTrovati.DataSource = m_UtentiTrovati;
                table_UtentiTrovati.Refresh();
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 4";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbox_Dadata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CercaScadPatente();
        }

        private void tbox_aData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CercaScadPatente();
        }

        private void tbox_categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CercaScadPatente();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            tbox_Search.Focus();
            Thread RicercaScadenze = new Thread(SearchScadenze);
            RicercaScadenze.Start();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //tbox_Dadata.Focus();
        }

        private void SearchScadenze()
        {
            try
            {
                DateTime datainizio = DateTime.Now;
                DateTime datafine = DateTime.Now.AddMonths(1);
                string dadata = datainizio.ToString("yyyy-MM-dd") + " 00:00:00";
                string adata = datafine.ToString("yyyy-MM-dd") + " 00:00:00";

                SqliteOperations sqlop = new SqliteOperations();
                m_UtentiPatenteScadenza = sqlop.SearchUserByLicenseSCAD(dadata, adata, string.Empty, "PATENTE");
                m_UtentiFrosaScadenza = sqlop.SearchUserByLicenseSCAD(dadata, adata, string.Empty, "FOGLIO ROSA");

                lbl_patinscad.Text = m_UtentiPatenteScadenza.Count.ToString();
                lbl_frosinscad.Text = m_UtentiFrosaScadenza.Count.ToString();
                Application.DoEvents();

                if (m_UtentiPatenteScadenza.Count > 0)
                {
                    m_UtentiaCuiscade2 = sqlop.SearchUserByLicenseSCAD_ForMail(dadata, adata, string.Empty, "PATENTE");
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 5";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbl_patinscad_Click(object sender, EventArgs e)
        {
            if (m_UtentiPatenteScadenza.Count > 0)
            {
                table_UtentiTrovati.DataSource = m_UtentiPatenteScadenza;
                table_UtentiTrovati.Refresh();
                m_UtentiTrovati.Clear();
                m_UtentiTrovati = m_UtentiPatenteScadenza;
            }
        }

        private void lbl_frosinscad_Click(object sender, EventArgs e)
        {
            if (m_UtentiFrosaScadenza.Count > 0)
            {
                table_UtentiTrovati.DataSource = m_UtentiFrosaScadenza;
                table_UtentiTrovati.Refresh();
                m_UtentiTrovati.Clear();
                m_UtentiTrovati = m_UtentiFrosaScadenza;
            }
        }

        private void lbl_pat1_Click(object sender, EventArgs e)
        {
            if (m_UtentiPatenteScadenza.Count > 0)
            {
                table_UtentiTrovati.DataSource = m_UtentiPatenteScadenza;
                table_UtentiTrovati.Refresh();
                m_UtentiTrovati.Clear();
                m_UtentiTrovati = m_UtentiPatenteScadenza;
            }
        }

        private void lbl_frosa1_Click(object sender, EventArgs e)
        {
            if (m_UtentiFrosaScadenza.Count > 0)
            {
                table_UtentiTrovati.DataSource = m_UtentiFrosaScadenza;
                table_UtentiTrovati.Refresh();
                m_UtentiTrovati.Clear();
                m_UtentiTrovati = m_UtentiFrosaScadenza;
            }
        }

        private void btn_Synch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Per abilitare la sincronizzazione contattare lo sviluppatore mandando una mail a: info@frapps.net", "Attenzione", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            /*SynchForm sf = new SynchForm();
            sf.ShowDialog();*/
        }

        private void toolstrip_InviaMail_Click(object sender, EventArgs e)
        {
            ScadenzeForm sf = new ScadenzeForm(m_UtentiaCuiscade2);
            sf.Show();
        }

        private void rdo_Nome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Nome.Checked)
                label4.Text = "Inserisci il cognome da cercare:";
        }

        private void rdo_NumPatente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_NumPatente.Checked)
                label4.Text = "Inserisci il numero di patente da cercare:";
        }

        private void rdo_Telefono_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Telefono.Checked)
                label4.Text = "Inserisci il numero di telefono da cercare:";
        }

        private void rdo_ComResid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_ComResid.Checked)
                label4.Text = "Inserisci il comune da cercare:";
        }

      



    }
}
