using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using ICSharpCode.SharpZipLib.Zip;

namespace VillaUserManager
{
    public partial class ConfigForm : Form
    {
        string m_Pagina1 = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents\\cmedico_f1.doc";
        string m_Pagina1nofoto = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents\\cmedico_f1x.doc";
        string m_Pagina2 = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents\\cmedico_f2.doc";
        string m_Pagina3 = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents\\cmedico_f3.doc";
        string m_Pagina3diabete = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents\\cmedico_f3x.doc";
        string m_cartellina = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents\\modcartellina.doc";
        string m_scadpat = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents\\scadpat.doc";

        string ConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AutoG\\config.ini";
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btn_OpenDButenti_Click(object sender, EventArgs e)
        {
           try{
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                CFileINI IniConfig = new CFileINI(ConfigFile);
                tbox_DbUtenti.Text = folderBrowserDialog1.SelectedPath;
                DataAccess.Instance.Path_DB_Utenti = tbox_DbUtenti.Text + "\\VillaDB.sqlite";
                DataAccess.Instance.Path_DB_Comuni= tbox_DbUtenti.Text + "\\Comuni.mdb";
                IniConfig.WriteValue("Config", "DButenti", DataAccess.Instance.Path_DB_Utenti);
                IniConfig.WriteValue("Config", "DBcomuni", DataAccess.Instance.Path_DB_Comuni);
            }
           }
           catch (Exception ex)
           {
               string error = "E' Avvenuto un errore: ERRORE 34";
               MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
 

            

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            
            if (!DataAccess.Instance.Path_DB_Utenti.Equals(string.Empty))
                tbox_DbUtenti.Text =Path.GetDirectoryName( DataAccess.Instance.Path_DB_Utenti);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_ApriPag1_Click(object sender, EventArgs e)
        {
            ApriDocumento(m_Pagina1);
        }


        private void ApriDocumento(object fileName)
        {
            object missing = System.Reflection.Missing.Value;

            //Setup the Word.Application class.
            Word.Application wordApp =
                new Word.ApplicationClass();

            //Setup our Word.Document class we'll use.
            Word.Document aDoc = null;
            object oFalse = false;
            try
            {
                // Check to see that file exists
                if (File.Exists((string)fileName))
                {
                    DateTime today = DateTime.Now;

                    object readOnly = false;
                    object isVisible = true;

                    //Set Word to be not visible.
                    wordApp.Visible = true;

                    //Open the word document
                    aDoc = wordApp.Documents.Open(ref fileName, ref missing,
                        ref readOnly, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref isVisible, ref missing, ref missing,
                        ref missing, ref missing);

                    // Activate the document
                    aDoc.Activate();

                }
                else
                {
                    MessageBox.Show("Errore, file non trovato", "Errore");
                    return;
                }
               

            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 35";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
        }

        private void btn_ApriPag1NoFoto_Click(object sender, EventArgs e)
        {
            ApriDocumento(m_Pagina1nofoto);
        }

        private void btn_ApriPag2_Click(object sender, EventArgs e)
        {
            ApriDocumento(m_Pagina2);
        }

        private void btn_ApriCartellina_Click(object sender, EventArgs e)
        {
            ApriDocumento(m_cartellina);
        }

        private void btn_ApriPag3_Click(object sender, EventArgs e)
        {
            ApriDocumento(m_Pagina3);
        }

        private void btn_ApriPag3Diabete_Click(object sender, EventArgs e)
        {
            ApriDocumento(m_Pagina3diabete);
        }

        private void btn_RestoreDoc_Click(object sender, EventArgs e)
        {
            string ZipOrigine = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents.bak";
            string Destinazione = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents";
            try
            {
                if (MessageBox.Show("Verranno CANCELLATI tutti i dati attuali, SEI SICURO DI VOLER CONTINUARE??", "ATTENZIONE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    try
                    {
                        File.Delete(m_cartellina);
                        File.Delete(m_Pagina1);
                        File.Delete(m_Pagina1nofoto);
                        File.Delete(m_Pagina2);
                        File.Delete(m_Pagina3);
                        File.Delete(m_Pagina3diabete);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore, hai forse lasciato i documenti aperti in word?", "Errore");
                        return;
                    }
                    
               
                    Zip Unzip = new Zip();
                    Unzip.UnZipFiles(ZipOrigine, Destinazione, string.Empty, false);
                    
                }

            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 36";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_OpenScadPat_Click(object sender, EventArgs e)
        {
            ApriDocumento(m_scadpat);
        }
        

    }
}
