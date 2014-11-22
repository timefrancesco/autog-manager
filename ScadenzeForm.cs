using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;

namespace VillaUserManager
{
    public partial class ScadenzeForm : Form
    {
        string Cognome, nome, Indirizzo, ComuneRes, ProvRes, NumeroPat, ScadenzaPat, CatPat;
        BindingList<UtentiScadenza> m_UtentiaCuiscade2 = new BindingList<UtentiScadenza>();
        public ScadenzeForm(BindingList<UtentiScadenza> UtentiScad)
        {
            InitializeComponent();
            m_UtentiaCuiscade2 = UtentiScad;
        }

        private void ScadenzeForm_Load(object sender, EventArgs e)
        {
            grid_Utenti.DataSource = m_UtentiaCuiscade2;
            grid_Utenti.Refresh();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            PrintTrueOpenFalse(false);
        }

        private void PrintTrueOpenFalse(bool printOrOpen)
        {
            string lettera = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\scadpat.doc";
      
            foreach (DataGridViewRow Riga in grid_Utenti.SelectedRows)
            {
                DataRow dataRow = null;

                try
                {
                    Cognome = Riga.Cells[3].Value.ToString();
                    nome = Riga.Cells[4].Value.ToString();
                    Indirizzo = Riga.Cells[5].Value.ToString();
                    ComuneRes = Riga.Cells[6].Value.ToString();
                    ProvRes = Riga.Cells[7].Value.ToString();
                    NumeroPat = Riga.Cells[1].Value.ToString();
                    ScadenzaPat = Riga.Cells[0].Value.ToString();
                    CatPat = Riga.Cells[2].Value.ToString();
                    ScadenzaPat = ScadenzaPat.Remove(ScadenzaPat.IndexOf(' '));

                    if (printOrOpen)
                        StampaLettera(lettera);
                    else
                        ApriLettera(lettera);

                }
                catch (Exception ex)
                {
                    string error = "E' Avvenuto un errore: ERRORE 54";
                    MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FindAndReplace(Word.Application WordApp,
                                    object findText,
                                    object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object nmatchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            WordApp.Selection.Find.Execute(ref findText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike,
                ref nmatchAllWordForms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiacritics, ref matchAlefHamza,
                ref matchControl);
        }


        private void ApriLettera(object fileName)
        {
            object missing = System.Reflection.Missing.Value;

            //uccido tutti i word aperti
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.StartsWith("WINWORD"))
                {
                    clsProcess.Kill();
                }
            }

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
                    object isVisible = false;

                    //Set Word to be not visible.
                    wordApp.Visible = false;

                    //Open the word document
                    aDoc = wordApp.Documents.Open(ref fileName, ref missing,
                        ref readOnly, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref isVisible, ref missing, ref missing,
                        ref missing, ref missing);

                    // Activate the document
                    aDoc.Activate();

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", Cognome);
                    this.FindAndReplace(wordApp, "<nome>", nome);
                    this.FindAndReplace(wordApp, "<indirizzo>", Indirizzo);
                    this.FindAndReplace(wordApp, "<comuneres>", ComuneRes);
                    this.FindAndReplace(wordApp, "<provres>", ProvRes);
                    this.FindAndReplace(wordApp, "<numpat>", NumeroPat);
                    this.FindAndReplace(wordApp, "<cat>", CatPat);
                    this.FindAndReplace(wordApp, "<datascadenza>", ScadenzaPat);
                   

                }
                else
                {
                    MessageBox.Show("Errore, file non trovato", "Errore");
                    return;
                }
                object saveAs = fileName + NumeroPat;

                //Save the document as the correct file name.
                aDoc.SaveAs(ref saveAs, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing);
                object afalse = false;

                aDoc.Close(ref afalse, ref missing, ref missing);

                aDoc = wordApp.Documents.Open(ref saveAs, ref missing,
                        ref afalse, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref afalse, ref missing, ref missing,
                        ref missing, ref missing);
                aDoc.Activate();

                //Close the document - you have to do this.
                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 55";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
        }

        private void StampaLettera(object fileName)
        {

            object missing = System.Reflection.Missing.Value;

            //uccido tutti i word aperti
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.StartsWith("WINWORD"))
                {
                    clsProcess.Kill();
                }
            }

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
                    object isVisible = false;

                    //Set Word to be not visible.
                    wordApp.Visible = false;

                    //Open the word document
                    aDoc = wordApp.Documents.Open(ref fileName, ref missing,
                        ref readOnly, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref isVisible, ref missing, ref missing,
                        ref missing, ref missing);

                    // Activate the document
                    aDoc.Activate();


                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", Cognome);
                    this.FindAndReplace(wordApp, "<nome>", Cognome);
                    this.FindAndReplace(wordApp, "<indirizzo>", Indirizzo);
                    this.FindAndReplace(wordApp, "<comuneres>", ComuneRes);
                    this.FindAndReplace(wordApp, "<provres>", ProvRes);
                    this.FindAndReplace(wordApp, "<numpat>", NumeroPat);
                    this.FindAndReplace(wordApp, "<cat>", CatPat);
                    this.FindAndReplace(wordApp, "<datascadenza>", ScadenzaPat);


                }
                else
                {
                    MessageBox.Show("Errore, file non trovato", "Errore");
                    return;
                }

                object copies = "1";
                object pages = "";
                object range = Word.WdPrintOutRange.wdPrintAllDocument;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;



                aDoc.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);


                aDoc.Close(ref oFalse, ref missing, ref missing);
                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 56";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintTrueOpenFalse(true);
        }

        private void RemoveAllFiles()
        {
            //uccido tutti i word aperti
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.StartsWith("WINWORD"))
                {
                    clsProcess.Kill();
                }
            }

            DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\Documents");
            foreach (FileInfo fileindir in dir.GetFiles())
            {
                if ((fileindir.Name.Equals("cmedico_f1.doc"))
                    || (fileindir.Name.Equals("cmedico_f1x.doc"))
                         || (fileindir.Name.Equals("cmedico_f2.doc"))
                          || (fileindir.Name.Equals("cmedico_f3.doc"))
                           || (fileindir.Name.Equals("cmedico_f3x.doc"))
                            || (fileindir.Name.Equals("modcartellina.doc"))
                             || (fileindir.Name.Equals("scadpat.doc")))
                {
                    ;

                }
                else
                    try
                    {
                        File.Delete(fileindir.FullName);
                    }
                    catch (Exception ex)
                    {
                        string error = "E' Avvenuto un errore: ERRORE 57";
                        MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

        }

        private void ScadenzeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemoveAllFiles();
        }

    }
}
