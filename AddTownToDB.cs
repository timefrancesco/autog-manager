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
    public partial class AddTownToDB : Form
    {
        public AddTownToDB()
        {
            InitializeComponent();
        }

        private void btn_AddTown_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbox_Cap.Text.Equals(string.Empty)) || (tbox_Codice.Text.Equals(String.Empty))
                    || (tbox_Comune.Text.Equals(string.Empty)) || (tbox_provincia.Text.Equals(string.Empty)))
                {
                    MessageBox.Show("Errore, non tutti i campi sono stati riempiti", "Errore", MessageBoxButtons.OK);
                }
                else
                {




                    if (DataAccess.Instance.IsModifyOn) //SE e' modifica rimuovo il valore
                    {
                        RimuoviComune();

                    }

                    //controllo se esiste gia
                    string percorsoDB = DataAccess.Instance.Path_DB_Comuni;
                    string str;

                    string strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + percorsoDB;
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
                            string str2 = tbox_Comune.Text.ToUpper();
                            if (str.Equals(str2))
                            {

                                MessageBox.Show("Il comune esiste già!", "Error", MessageBoxButtons.OK);
                                dataReaderDB.Close(); //Chiudo il dataReader
                                connessioneDB.Close();//Chiudo la connessione.
                                return;
                            }


                        }
                    }
                    catch (Exception objException)
                    {
                        string strErrore = "Si è verificato il seguente errore in:" +
                                     objException.Source + "\n" + objException.TargetSite + "\n" +
                                     objException.Message + "\n <CF_PIVA.TrovaCodiceCitta>.";
                    }
                    finally
                    {

                        dataReaderDB.Close(); //Chiudo il dataReader


                        connessioneDB.Close();//Chiudo la connessione.
                    }







                    string ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataAccess.Instance.Path_DB_Comuni;
                    OleDbConnection ConnDB = new OleDbConnection(ConnStr);

                    try
                    {
                        string InsertString = string.Format("INSERT INTO comuni (Comune, Provincia, CodiceComune, CAP)VALUES ('{0}','{1}','{2}','{3}')", tbox_Comune.Text, tbox_provincia.Text, tbox_Codice.Text, tbox_Cap.Text);
                        commandDB = new OleDbCommand(InsertString, ConnDB);
                        ConnDB.Open();
                        commandDB.ExecuteNonQuery();

                    }
                    catch (Exception objException)
                    {
                        string strErrore = "Si è verificato il seguente errore in:" +
                                     objException.Source + "\n" + objException.TargetSite + "\n" +
                                     objException.Message + "\n <CF_PIVA.TrovaCodiceCitta>.";
                    }
                    finally
                    {

                        ConnDB.Close();//Chiudo la connessione.
                    }

                    DataAccess.Instance.ComuneSelezionato.Comune = tbox_Comune.Text.ToUpper();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 12";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddTownToDB_Load(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.Instance.IsModifyOn)
                {
                    tbox_Comune.Text = DataAccess.Instance.ComuneSelezionato.Comune;
                    tbox_provincia.Text = DataAccess.Instance.ComuneSelezionato.Provincia;
                    tbox_Codice.Text = DataAccess.Instance.ComuneSelezionato.CodiceComune;
                    tbox_Cap.Text = DataAccess.Instance.ComuneSelezionato.CAP;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void RimuoviComune()
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
                    string strErrore = "Si è verificato il seguente errore in:" +
                                 objException.Source + "\n" + objException.TargetSite + "\n" +
                                 objException.Message + "\n <CF_PIVA.TrovaCodiceCitta>.";
                }
                finally
                {

                    connessioneDB.Close();//Chiudo la connessione.
                    DataAccess.Instance.IsModifyOn = false;
                }
            

        }

        private void AddTownToDB_Shown(object sender, EventArgs e)
        {
            tbox_Comune.Focus();
        }
        

    }
}
