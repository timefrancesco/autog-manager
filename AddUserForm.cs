using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
using System.Collections;
using System.IO;

namespace VillaUserManager
{
    public partial class AddUserForm : Form
    {
        BindingList<Patente> m_ListaPatenti = new BindingList<Patente>();
        BindingList<Contatto> m_ListaContatti = new BindingList<Contatto>();
        BindingList<Esame> m_ListaEsami = new BindingList<Esame>();

        public AddUserForm()
        {
            InitializeComponent();
        }


        int SalvaUtenteInDB()
        {
            try
            {
                //Acquisisco i dati
                string Cognome = tbox_Cognome.Text;
                string Nome = tbox_Nome.Text;
                bool IsMale = false;
                if (cbox_Sesso.SelectedIndex == 0)
                    IsMale = true;
                if (tbox_DataNascita.Text.Equals(string.Empty))
                    tbox_DataNascita.Text = "01 / 01 / 1900";
                DateTime DataNascita = Convert.ToDateTime(tbox_DataNascita.Text);
                string ComuneNascita = tbox_ComuneNascita.Text;
                string ProvinciaNascita = tbox_ProvNascita.Text;
                string CodiceFiscale = tbox_CFiscale.Text;
                string ComuneResidenza = tbox_ComuneResid.Text;
                string ProvinciaResidenza = tbox_ProvResid.Text;
                string Indirizzo = tbox_Indirizzo.Text;
                string CAP = tbox_CAP.Text;
                string ImagePath = string.Empty;
                SqliteOperations SQLiteOP = new SqliteOperations();
                int ret = -1;

                if (!DataAccess.Instance.IsUserModifyOn)
                {
                    //controllo se esiste già nel database
                    ret = SQLiteOP.CheckIfAlreadyExist("CodiceFiscale", "Utenti", CodiceFiscale);
                    if (ret > 0)
                    {
                        MessageBox.Show("Errore, l'utente esiste già nel database", "ATTENZIONE", MessageBoxButtons.OK);
                        return -1;
                    }
                }
                //non esiste quindi copio l'immagine nella directory delle immagini
                string GlobalImgPath = Path.GetDirectoryName( DataAccess.Instance.Path_DB_Comuni) +"\\ProfilePictures\\";
                if ((pbox_ProfilePic.ImageLocation != null) && (pbox_ProfilePic.ImageLocation != GlobalImgPath))
                {
                    if (!pbox_ProfilePic.ImageLocation.EndsWith("\\"))
                    {
                        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                        ImagePath = string.Format("{0}\\ProfilePictures\\{1}.dat", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), CodiceFiscale);
                        string tmp = pbox_ProfilePic.ImageLocation;
                        if (!ImagePath.Equals(tmp))
                            File.Copy(pbox_ProfilePic.ImageLocation, ImagePath, true);
                        ImagePath = string.Format("{0}.dat", CodiceFiscale);
                    }
                }

                if (DataAccess.Instance.IsUserModifyOn)
                {
                    ret = SQLiteOP.ModifyUserInDB(Cognome, Nome, IsMale, DataNascita, ComuneNascita, ProvinciaNascita, CodiceFiscale,
                                        ComuneResidenza, ProvinciaResidenza, Indirizzo, CAP, ImagePath, DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    if (!DataAccess.Instance.UtenteSelezionato.CodiceFiscale.Equals(CodiceFiscale))
                    {
                        // è cambiato il codice fiscale quindi cambio tutte le patenti contatti e esami
                        foreach (Patente pat in m_ListaPatenti)
                        {
                            SQLiteOP.ModifyLicenseInDB(pat.numero, pat.tipo, pat.categoria,
                                pat.datarilascio, pat.datascadenza, pat.enterilascio, CodiceFiscale,
                                pat.numero, pat.codicefiscale, false);
                        }
                        foreach (Contatto ct in m_ListaContatti)
                            SQLiteOP.ModifyContactInDB(ct.numero, ct.tipo, CodiceFiscale, ct.codicefiscale, ct.tipo, ct.numero, false);

                        foreach (Esame ex in m_ListaEsami)
                            SQLiteOP.ModifyExamInDB(CodiceFiscale, ex.tipo, ex.DataEsame, ex.Categoria, ex.Esito, ex.codicefiscale, ex.tipo, ex.Categoria, ex.DataEsame, false);
                    }
                }
                else
                    ret = SQLiteOP.InsertUserInDB(Cognome, Nome, IsMale, DataNascita, ComuneNascita, ProvinciaNascita, CodiceFiscale,
                                        ComuneResidenza, ProvinciaResidenza, Indirizzo, CAP, ImagePath);

                if (ret == -1)
                    MessageBox.Show("E' avvenuto un errore nell'inserire l'utente nel database", "ERRORE!!!!", MessageBoxButtons.OK);
                else
                {
                    DataAccess.Instance.UtenteSelezionato.CAP = CAP;
                    DataAccess.Instance.UtenteSelezionato.CodiceFiscale = CodiceFiscale;
                    DataAccess.Instance.UtenteSelezionato.Cognome = Cognome;
                    DataAccess.Instance.UtenteSelezionato.ComuneNascita = ComuneNascita;
                    DataAccess.Instance.UtenteSelezionato.ComuneResidenza = ComuneResidenza;
                    DataAccess.Instance.UtenteSelezionato.DataNascita = DataNascita;
                    DataAccess.Instance.UtenteSelezionato.foto = ImagePath;
                    DataAccess.Instance.UtenteSelezionato.Indirizzo = Indirizzo;
                    DataAccess.Instance.UtenteSelezionato.Nome = Nome;
                    DataAccess.Instance.UtenteSelezionato.ProvNascita = ProvinciaNascita;
                    DataAccess.Instance.UtenteSelezionato.ProvResidenza = ProvinciaResidenza;
                    DataAccess.Instance.UtenteSelezionato.Sex = IsMale;
                }
                return ret;
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 14";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            int ret = SalvaUtente();
            if (ret == 1)
                this.DialogResult = DialogResult.OK;
        }

        private int  SalvaUtente()
        {
            try
            {
                tbox_Cognome.Text = tbox_Cognome.Text.ToUpper();
                tbox_ComuneNascita.Text = tbox_ComuneNascita.Text.ToUpper();
                tbox_CFiscale.Text = tbox_CFiscale.Text.ToUpper();
                tbox_ComuneResid.Text = tbox_ComuneResid.Text.ToUpper();
                tbox_Indirizzo.Text = tbox_Indirizzo.Text.ToUpper();
                tbox_Nome.Text = tbox_Nome.Text.ToUpper();
                tbox_ProvNascita.Text = tbox_ProvNascita.Text.ToUpper();
                tbox_ProvResid.Text = tbox_ProvResid.Text.ToUpper();
                int ret = 0;
                if ((tbox_Cognome.Text.Equals(string.Empty)) || (tbox_Nome.Text.Equals(String.Empty)) || (tbox_CFiscale.Text.Equals(string.Empty)))
                {
                    MessageBox.Show("Cognome, nome e codice fiscale non possono essere vuoti", "ERRORE!", MessageBoxButtons.OK);
                    return 0;
                }
               /* if (DataAccess.Instance.IsUserModifyOn)
                {
                    SqliteOperations SqlOp = new SqliteOperations();
                    ret = SqlOp.RemoveUserFromDB(DataAccess.Instance.CodiceFiscale.ToUpper());
                    //controllo se il cfisc è cambiato, in tal caso devo rimuovere le patenti i contatti e gli esami associati a quel codice e associarli a quello nuovo
                }
                if (ret >= 0)*/
                    ret = SalvaUtenteInDB();
                if (ret != -1)
                    return 1;
                else
                {
                    MessageBox.Show("E' avvenuto un errore nell'inserire l'utente, ricontrolla i dati", "Errore", MessageBoxButtons.OK);
                    return 0;
                }
                }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 15";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void tbox_DataNascita_Leave(object sender, EventArgs e)
        {
            if (!tbox_DataNascita.Text.Equals(string.Empty)) //NEL CASO NON SIA VUOTO
            {
                SqliteOperations sqlop = new SqliteOperations();
                tbox_DataNascita.Text = sqlop.TransformDate(tbox_DataNascita.Text);
            }
        }

        private void btn_SearchComune_Click(object sender, EventArgs e)
        {
            try
            {
                SearchTown STform = new SearchTown();
                if (STform.ShowDialog() == DialogResult.OK)
                {
                    tbox_ComuneNascita.Text = DataAccess.Instance.ComuneSelezionato.Comune;
                    tbox_ProvNascita.Text = DataAccess.Instance.ComuneSelezionato.Provincia;

                    tbox_ComuneResid.Text = DataAccess.Instance.ComuneSelezionato.Comune;
                    tbox_ProvResid.Text = DataAccess.Instance.ComuneSelezionato.Provincia;
                    tbox_CAP.Text = DataAccess.Instance.ComuneSelezionato.CAP;

                    // DataAccess.Instance.ComuneSelezionato = null;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 16";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CalcolaCF_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbox_Nome.Text.Equals(string.Empty)) || (tbox_Cognome.Text.Equals(String.Empty))
                    || (tbox_DataNascita.Text.Equals(string.Empty)) || (tbox_ComuneNascita.Text.Equals(String.Empty))
                    || (tbox_ProvNascita.Text.Equals(string.Empty)))
                    MessageBox.Show("Errore, ci sono campi vuoti che non permettono il calcolo del codice fiscale", "errore", MessageBoxButtons.OK);
                else
                {
                    ClsCodiceFiscale objCF = new ClsCodiceFiscale();
                    string sex = "F";
                    string strErrore = string.Empty;
                    ArrayList vetStrErrori = new ArrayList();
                    if (cbox_Sesso.SelectedIndex == 0)
                        sex = "M";
                    char cSesso = sex[0];

                    string strCodiceFiscale = objCF.CalcolaCF(tbox_Nome.Text, tbox_Cognome.Text, cSesso, tbox_DataNascita.Text,
                                                        tbox_ComuneNascita.Text, tbox_ProvNascita.Text, vetStrErrori);

                    if (vetStrErrori.Count > 0) //Errore nel calcolo? Lo/Li stampo
                    {
                        for (byte i = 0; i < vetStrErrori.Count; i++)
                            strErrore += vetStrErrori[i].ToString() + "\n\n";
                        MessageBox.Show(strErrore, "Errore.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        vetStrErrori.Clear();
                    }
                    //Sia che il calcolo è Ok che nonOk, stampo il codice fiscale
                    tbox_CFiscale.Text = strCodiceFiscale;
                    //LblCFCalcolato.Text = objCF.strCodiceFiscale;

                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 17";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.Instance.IsUserModifyOn)
                {
                    tbox_Nome.Text = DataAccess.Instance.UtenteSelezionato.Nome;
                    tbox_Cognome.Text = DataAccess.Instance.UtenteSelezionato.Cognome;
                    tbox_ComuneNascita.Text = DataAccess.Instance.UtenteSelezionato.ComuneNascita;
                    tbox_ComuneResid.Text = DataAccess.Instance.UtenteSelezionato.ComuneResidenza;
                    tbox_Indirizzo.Text = DataAccess.Instance.UtenteSelezionato.Indirizzo;
                    tbox_ProvNascita.Text = DataAccess.Instance.UtenteSelezionato.ProvNascita;
                    tbox_ProvResid.Text = DataAccess.Instance.UtenteSelezionato.ProvResidenza;
                    tbox_CAP.Text = DataAccess.Instance.UtenteSelezionato.CAP;
                    tbox_CFiscale.Text = DataAccess.Instance.UtenteSelezionato.CodiceFiscale;
                    tbox_num.Text = DataAccess.Instance.UtenteSelezionato.IdUtente.ToString();
                    if (DataAccess.Instance.UtenteSelezionato.Sex)
                        cbox_Sesso.SelectedIndex = 0;
                    else
                        cbox_Sesso.SelectedIndex = 1;
                    tbox_DataNascita.Text = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString("dd/MM/yyyy");
                    if (!DataAccess.Instance.UtenteSelezionato.foto.Equals(string.Empty))
                    {
                        if (!DataAccess.Instance.UtenteSelezionato.foto.Contains("ProfilePictures"))
                        {
                            string pathfoto = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\ProfilePictures\\";
                            pbox_ProfilePic.ImageLocation = pathfoto + DataAccess.Instance.UtenteSelezionato.foto;
                        }
                        else
                            pbox_ProfilePic.ImageLocation = DataAccess.Instance.UtenteSelezionato.foto;
                        pbox_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    SqliteOperations SqlOp = new SqliteOperations();
                    m_ListaPatenti = SqlOp.ReadAllLicense("codice", "patenti", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    m_ListaContatti = SqlOp.ReadAllContatcs("codice", "contatti", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    m_ListaEsami = SqlOp.ReadAllExams("codice", "esami", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    DataAccess.Instance.CodiceFiscale = DataAccess.Instance.UtenteSelezionato.CodiceFiscale;
                    table_Patenti.DataSource = m_ListaPatenti;
                    table_Contatti.DataSource = m_ListaContatti;
                    table_Esami.DataSource = m_ListaEsami;
                }
                else
                {
                    cbox_Sesso.SelectedIndex = 0;
                    if (!DataAccess.Instance.TempString.Equals(string.Empty))
                    {
                        tbox_Cognome.Text = DataAccess.Instance.TempString;
                        DataAccess.Instance.TempString = string.Empty;
                    }
                }
                DataAccess.Instance.PatenteSelezionata = new Patente();
                DataAccess.Instance.ContattoSelezionato = new Contatto();
                DataAccess.Instance.EsameSelezionato = new Esame();
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 18";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbox_ProfilePic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg_SelectPic = new OpenFileDialog();
                dlg_SelectPic.Filter = "jpg images (*.jpg)|*.jpg|jpeg images (*.jpeg)|*.jpeg|png images (*.png)|*.png|bmp images (*.bmp)|*.bmp|All files (*.*)|*.*";

                if (dlg_SelectPic.ShowDialog() == DialogResult.OK)
                {
                    Bitmap ProfileImage;
                    ProfileImage = new Bitmap(dlg_SelectPic.OpenFile());
                    string filename = System.IO.Path.GetFileName(dlg_SelectPic.FileName);
                    string path = System.IO.Path.GetDirectoryName(dlg_SelectPic.FileName);
                    path = string.Format("{0}\\{1}", path, filename);
                    //string img = dlg_SelectPic.OpenFile();
                    // string imgloc = pbox_ProfilePic.ImageLocation;
                    pbox_ProfilePic.ImageLocation = path;
                    pbox_ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbox_ProfilePic.Image = (Image)ProfileImage;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 19";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddPatente_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_CFiscale.Text.Equals(string.Empty))
                    MessageBox.Show("Il codice fiscale è necessario per inserire patenti o contatti", "Errore", MessageBoxButtons.OK);
                else
                {
                    DataAccess.Instance.CodiceFiscale = tbox_CFiscale.Text;
                    AddLicense AL = new AddLicense();
                    if (AL.ShowDialog(this) == DialogResult.OK)
                    {
                        SqliteOperations sqlop = new SqliteOperations();
                        m_ListaPatenti.Clear();
                        m_ListaPatenti = sqlop.ReadAllLicense("CODICE", "Patenti", DataAccess.Instance.CodiceFiscale);
                        table_Patenti.DataSource = m_ListaPatenti;
                        table_Patenti.Refresh();
                        DataAccess.Instance.PatenteSelezionata = m_ListaPatenti[0];
                    }
                    DataAccess.Instance.CodiceFiscale = string.Empty;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 20";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SearchComune2_Click(object sender, EventArgs e)
        {
            try
            {

                SearchTown STform = new SearchTown();
                if (STform.ShowDialog() == DialogResult.OK)
                {
                    tbox_ComuneResid.Text = DataAccess.Instance.ComuneSelezionato.Comune;
                    tbox_ProvResid.Text = DataAccess.Instance.ComuneSelezionato.Provincia;
                    tbox_CAP.Text = DataAccess.Instance.ComuneSelezionato.CAP;
                    //DataAccess.Instance.ComuneSelezionato = null;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 21";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddContatto_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_CFiscale.Text.Equals(string.Empty))
                    MessageBox.Show("Il codice fiscale è necessario per inserire patenti o contatti", "Errore", MessageBoxButtons.OK);
                else
                {
                    DataAccess.Instance.CodiceFiscale = tbox_CFiscale.Text;
                    AddContact AL = new AddContact();
                    if (AL.ShowDialog(this) == DialogResult.OK)
                    {
                        SqliteOperations sqlop = new SqliteOperations();
                        m_ListaContatti = sqlop.ReadAllContatcs("CODICE", "Contatti", DataAccess.Instance.CodiceFiscale);
                        table_Contatti.DataSource = m_ListaContatti;
                        table_Contatti.Refresh();
                    }
                    DataAccess.Instance.CodiceFiscale = string.Empty;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 22";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RmvPatente_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_CFiscale.Text.Equals(string.Empty))
                    MessageBox.Show("Il codice fiscale è necessario", "Errore", MessageBoxButtons.OK);
                else
                {
                    foreach (Patente PatenteSelezionata in m_ListaPatenti)
                    {
                        if (PatenteSelezionata.numero.Equals(DataAccess.Instance.PatenteSelezionata.numero))
                        {
                            m_ListaPatenti.Remove(PatenteSelezionata);
                            SqliteOperations SqlOp = new SqliteOperations();
                            SqlOp.RemoveLicense(tbox_CFiscale.Text.ToUpper(), PatenteSelezionata.numero);
                            break;
                        }
                    }
                    table_Patenti.DataSource = m_ListaPatenti;
                    table_Patenti.Refresh();

                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 23";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void table_Patenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataAccess.Instance.PatenteSelezionata.numero = table_Patenti.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
        }

        private void btn_RmvContatto_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_CFiscale.Text.Equals(string.Empty))
                    MessageBox.Show("Il codice fiscale è necessario", "Errore", MessageBoxButtons.OK);
                else
                {
                    foreach (Contatto ContattoSelezionato in m_ListaContatti)
                    {
                        if (ContattoSelezionato.numero.Equals(DataAccess.Instance.ContattoSelezionato.numero))
                        {
                            m_ListaContatti.Remove(ContattoSelezionato);
                            SqliteOperations SqlOp = new SqliteOperations();
                            SqlOp.RemoveContact(tbox_CFiscale.Text.ToUpper(), ContattoSelezionato.numero);
                            break;
                        }
                    }
                    table_Contatti.DataSource = m_ListaContatti;
                    table_Contatti.Refresh();

                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 24";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void table_Contatti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataAccess.Instance.ContattoSelezionato.numero = table_Contatti.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
        }

        private void btn_AddExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_CFiscale.Text.Equals(string.Empty))
                    MessageBox.Show("Il codice fiscale è necessario", "Errore", MessageBoxButtons.OK);
                else
                {
                    DataAccess.Instance.CodiceFiscale = tbox_CFiscale.Text.ToUpper();
                    AddExam AL = new AddExam();
                    if (AL.ShowDialog(this) == DialogResult.OK)
                    {
                        SqliteOperations sqlop = new SqliteOperations();
                        m_ListaEsami = sqlop.ReadAllExams("CODICE", "Esami", DataAccess.Instance.CodiceFiscale);

                        table_Esami.DataSource = m_ListaEsami;
                        table_Esami.Refresh();
                    }
                    DataAccess.Instance.CodiceFiscale = string.Empty;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 25";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void table_Patenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    foreach (Patente PatenteSelezionata in m_ListaPatenti)
                    {
                        if (PatenteSelezionata.numero.Equals(table_Patenti.Rows[e.RowIndex].Cells[0].Value.ToString()))
                        {
                            DataAccess.Instance.PatenteSelezionata = PatenteSelezionata;
                            DataAccess.Instance.IsPatModifyOn = true;
                            DataAccess.Instance.CodiceFiscale = tbox_CFiscale.Text;
                            break;
                        }
                    }

                    if (DataAccess.Instance.IsPatModifyOn)
                    {
                        AddLicense addlic = new AddLicense();
                        if (addlic.ShowDialog() == DialogResult.OK)
                        {
                            SqliteOperations sqlop = new SqliteOperations();
                            m_ListaPatenti.Clear();
                            m_ListaPatenti = sqlop.ReadAllLicense("CODICE", "Patenti", DataAccess.Instance.CodiceFiscale);
                            table_Patenti.DataSource = m_ListaPatenti;
                            table_Patenti.Refresh();
                            DataAccess.Instance.PatenteSelezionata = m_ListaPatenti[0];
                        }
                        DataAccess.Instance.IsPatModifyOn = false;
                    }


                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 26";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void table_Contatti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    foreach (Contatto contattosel in m_ListaContatti)
                    {
                        if (contattosel.numero.Equals(table_Contatti.Rows[e.RowIndex].Cells[0].Value.ToString()))
                        {
                            DataAccess.Instance.ContattoSelezionato = contattosel;
                            DataAccess.Instance.IsContactModifyOn = true;
                            DataAccess.Instance.CodiceFiscale = tbox_CFiscale.Text;
                            break;
                        }
                    }

                    if (DataAccess.Instance.IsContactModifyOn)
                    {
                        AddContact addcon = new AddContact();
                        if (addcon.ShowDialog() == DialogResult.OK)
                        {
                            SqliteOperations sqlop = new SqliteOperations();
                            m_ListaContatti.Clear();
                            m_ListaContatti = sqlop.ReadAllContatcs("CODICE", "contatti", DataAccess.Instance.CodiceFiscale);
                            table_Contatti.DataSource = m_ListaContatti;
                            table_Contatti.Refresh();
                            DataAccess.Instance.ContattoSelezionato = m_ListaContatti[0];
                        }
                        DataAccess.Instance.IsContactModifyOn = false;
                    }


                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 27";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void table_Esami_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    foreach (Esame esamesel in m_ListaEsami)
                    {
                        if ((esamesel.DataEsame.Equals(table_Esami.Rows[e.RowIndex].Cells[0].Value))
                            && (esamesel.tipo.EndsWith(table_Esami.Rows[e.RowIndex].Cells[1].Value.ToString()))
                            && (esamesel.Categoria.Equals(table_Esami.Rows[e.RowIndex].Cells[2].Value.ToString())))
                        {
                            DataAccess.Instance.EsameSelezionato = esamesel;
                            DataAccess.Instance.IsEsamModifyOn = true;
                            DataAccess.Instance.CodiceFiscale = tbox_CFiscale.Text;
                            break;
                        }
                    }

                    if (DataAccess.Instance.IsEsamModifyOn)
                    {
                        AddExam ae = new AddExam();
                        if (ae.ShowDialog() == DialogResult.OK)
                        {
                            SqliteOperations sqlop = new SqliteOperations();
                            m_ListaEsami.Clear();
                            m_ListaEsami = sqlop.ReadAllExams("CODICE", "esami", DataAccess.Instance.CodiceFiscale);
                            table_Esami.DataSource = m_ListaEsami;
                            table_Esami.Refresh();
                            DataAccess.Instance.EsameSelezionato = m_ListaEsami[0];
                        }
                        DataAccess.Instance.IsEsamModifyOn = false;
                    }


                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 28";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RmvExam_Click(object sender, EventArgs e)
        {
            try
            {
                int ret;
                if (tbox_CFiscale.Text.Equals(string.Empty))
                    MessageBox.Show("Il codice fiscale è necessario", "Errore", MessageBoxButtons.OK);
                else
                {
                    foreach (Esame EsameSelezionato in m_ListaEsami)
                    {
                        if ((EsameSelezionato.DataEsame.Equals(DataAccess.Instance.EsameSelezionato.DataEsame))
                             && (EsameSelezionato.tipo.EndsWith(DataAccess.Instance.EsameSelezionato.tipo))
                             && (EsameSelezionato.Categoria.Equals(DataAccess.Instance.EsameSelezionato.Categoria)))
                        {
                            m_ListaEsami.Remove(EsameSelezionato);
                            string tmpstr1 = EsameSelezionato.DataEsame.ToString("yyyy-MM-dd");
                            tmpstr1 = tmpstr1 + " 00:00:00";
                            SqliteOperations sqlop1 = new SqliteOperations();
                            ret = sqlop1.RemoveExam(tbox_CFiscale.Text.ToUpper(), tmpstr1, EsameSelezionato.Esito, EsameSelezionato.tipo, EsameSelezionato.Categoria);
                            if (ret == -1)
                            {
                                MessageBox.Show("E' avvenuto un errore", "Errore", MessageBoxButtons.OK);
                                return;
                            }
                            break;
                        }
                    }
                    table_Contatti.DataSource = m_ListaContatti;
                    table_Contatti.Refresh();

                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 29";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void table_Esami_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
            if (e.RowIndex >= 0)
            {
                string data = table_Esami.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataAccess.Instance.EsameSelezionato.DataEsame = Convert.ToDateTime(data);
                DataAccess.Instance.EsameSelezionato.tipo = table_Esami.Rows[e.RowIndex].Cells[1].Value.ToString();
                DataAccess.Instance.EsameSelezionato.Categoria = table_Esami.Rows[e.RowIndex].Cells[2].Value.ToString();
                DataAccess.Instance.EsameSelezionato.Esito = table_Esami.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 30";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUserForm_Shown(object sender, EventArgs e)
        {
            tbox_Cognome.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            int ret = SalvaUtente();
            if (ret == 1)
            {
                PrintForm PF = new PrintForm(m_ListaPatenti, m_ListaContatti);
                PF.ShowDialog();
            }
            else
                MessageBox.Show("E' avvenuto un errore ricontrolla i dati", "Errore");
        }

       

        

    


    }
}
