using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VillaUserManager
{
    public partial class SearchTown : Form
    {
        BindingList<Comuni> m_ListaComuni = new BindingList<Comuni>();
        public SearchTown()
        {
            InitializeComponent();
        }

        private void SearchTown_Load(object sender, EventArgs e)
        {
            DataAccess.Instance.RigaSelezionata = -1;
            //leggo il db e carico i comuni nella griglia
            PopulateGridComuni();
        }

        private void PopulateGridComuni()
        {
            string percorsoDB = DataAccess.Instance.Path_DB_Comuni;
            string str;

			string strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+percorsoDB;
			OleDbConnection connessioneDB = new OleDbConnection(strStringaConnessione);
			OleDbCommand commandDB = new OleDbCommand("select * from comuni", connessioneDB);
			connessioneDB.Open();
			OleDbDataReader dataReaderDB = commandDB.ExecuteReader();
			try
			{
				//Interrogo LINEARMENTE il DB 
				while (dataReaderDB.Read()) //Và al record successivo
				{
                    Comuni ComuneLetto = new Comuni();
					 str = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Comune"));
					str = str.ToUpper().Trim();
                    ComuneLetto.Comune = str;

                     str = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Provincia"));
					str = str.ToUpper().Trim();
                    ComuneLetto.Provincia = str;

                    str = dataReaderDB.GetString(dataReaderDB.GetOrdinal("CodiceComune"));
                    ComuneLetto.CodiceComune = str;

                    str = dataReaderDB.GetString(dataReaderDB.GetOrdinal("CAP"));
                    ComuneLetto.CAP = str;
                    m_ListaComuni.Add(ComuneLetto);
                    
					
				}
                Grid_ListaComuni.DataSource = m_ListaComuni;
                Grid_ListaComuni.Refresh();
			}
			catch (Exception objException)
			{
				string strErrore = "Si è verificato il seguente errore in:"+
					         objException.Source+"\n"+objException.TargetSite+"\n" + 
					         objException.Message+"\n <CF_PIVA.TrovaCodiceCitta>.";
			}
			finally
			{
				dataReaderDB.Close(); //Chiudo il dataReader
				connessioneDB.Close();//Chiudo la connessione.
			}
			
		}

        private void btn_AvviaRicerca_Click(object sender, EventArgs e)
        {
            CercaComune();
            
            
        }

        private void CercaComune()
        {
            try{
            tbox_ComuneDaCercare.Text = tbox_ComuneDaCercare.Text.ToUpper();
            BindingList<Comuni> ComuniTrovati = new BindingList<Comuni>();
            if (tbox_ComuneDaCercare.Text.Equals(string.Empty))
                MessageBox.Show("Errore, campo vuoto", "Errore", MessageBoxButtons.OK);
            else
            {
                foreach (Comuni ComuneCercato in m_ListaComuni)
                {
                    if (ComuneCercato.Comune.Contains(tbox_ComuneDaCercare.Text))
                        ComuniTrovati.Add(ComuneCercato);
                }
                Grid_ListaComuni.DataSource = ComuniTrovati;
                Grid_ListaComuni.Refresh();
            }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 58";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AggiungiComune();
        }

        private void AggiungiComune()
        {
            try{
            BindingList<Comuni> ComuniTrovati = new BindingList<Comuni>();
            AddTownToDB addtown = new AddTownToDB();
            
            if (addtown.ShowDialog(this) == DialogResult.OK)
            {
                m_ListaComuni.Clear();
                PopulateGridComuni();
                foreach (Comuni ComuneCercato in m_ListaComuni)
                {
                    if (ComuneCercato.Comune.Equals(DataAccess.Instance.ComuneSelezionato.Comune))
                    {
                        ComuniTrovati.Add(ComuneCercato);
                        break;
                    }
                }
                Grid_ListaComuni.DataSource = ComuniTrovati;
                Grid_ListaComuni.Refresh();
            }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 59";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
          try{
            if (DataAccess.Instance.RigaSelezionata == -1)
              DataAccess.Instance.ComuneSelezionato.Comune = Grid_ListaComuni.Rows[0].Cells[0].Value.ToString();
                
            
            foreach (Comuni ComuneScelto in m_ListaComuni)
            {
                if (ComuneScelto.Comune.Equals(DataAccess.Instance.ComuneSelezionato.Comune))
                {
                    DataAccess.Instance.ComuneSelezionato = ComuneScelto;
                    break;
                }
            }
            this.DialogResult = DialogResult.OK;
          }
          catch (Exception ex)
          {
              string error = "E' Avvenuto un errore: ERRORE 60";
              MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }

        private void Grid_ListaComuni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
            if (e.RowIndex >= 0)
            {
                DataAccess.Instance.ComuneSelezionato.Comune = Grid_ListaComuni.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataAccess.Instance.RigaSelezionata = e.RowIndex;
            }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 61";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modif_Click(object sender, EventArgs e)
        {
           
            string strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataAccess.Instance.Path_DB_Comuni;
            OleDbConnection connessioneDB = new OleDbConnection(strStringaConnessione);
            try
            {

                string str = string.Format("DELETE FROM comuni WHERE Comune = '{0}'", DataAccess.Instance.ComuneSelezionato.Comune);
                OleDbCommand commandDB = new OleDbCommand(str, connessioneDB);
                connessioneDB.Open();
                commandDB.ExecuteNonQuery();
            }
            catch (Exception objException)
            {
                string strErrore = "Si Ã¨ verificato il seguente errore in:" +
                             objException.Source + "\n" + objException.TargetSite + "\n" +
                             objException.Message + "\n <CF_PIVA.TrovaCodiceCitta>.";
            }
            finally
            {

                connessioneDB.Close();//Chiudo la connessione.
                DataAccess.Instance.IsModifyOn = false;
            }
            m_ListaComuni.Clear();
            PopulateGridComuni();
        }

        private void tbox_ComuneDaCercare_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventArgs ed = new EventArgs();
            if (e.KeyChar == (char)Keys.Enter)
                CercaComune();
        }

        private void Grid_ListaComuni_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
            if (e.RowIndex >= 0)
            {
                DataAccess.Instance.ComuneSelezionato.Comune = Grid_ListaComuni.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataAccess.Instance.RigaSelezionata = e.RowIndex;

                foreach (Comuni ComuneScelto in m_ListaComuni)
                {
                    if (ComuneScelto.Comune.Equals(DataAccess.Instance.ComuneSelezionato.Comune))
                    {
                        DataAccess.Instance.ComuneSelezionato = ComuneScelto;
                        DataAccess.Instance.IsModifyOn = true;
                    }
                }
                BindingList<Comuni> ComuniTrovati = new BindingList<Comuni>();
                AddTownToDB Adform = new AddTownToDB();
                if (Adform.ShowDialog(this) == DialogResult.OK)
                {
                    m_ListaComuni.Clear();
                    PopulateGridComuni();
                    foreach (Comuni ComuneCercato in m_ListaComuni)
                    {
                        if (ComuneCercato.Comune.Equals(DataAccess.Instance.ComuneSelezionato.Comune))
                        {
                            ComuniTrovati.Add(ComuneCercato);
                            m_ListaComuni.Add(ComuneCercato);
                            break;
                        }
                    }
                    Grid_ListaComuni.DataSource = ComuniTrovati;
                    Grid_ListaComuni.Refresh();
                }
            }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 62";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void SearchTown_Shown(object sender, EventArgs e)
        {
            tbox_ComuneDaCercare.Focus();
        }
            
        
    }
}
