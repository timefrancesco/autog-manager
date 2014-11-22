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

    public partial class PrintForm : Form
    {
        BindingList<Patente> m_ListaPatenti = new BindingList<Patente>();
        BindingList<Contatto> m_ListaContatti = new BindingList<Contatto>();
        bool m_Diabete = false;
        string m_TipoCert;
        string m_nDoc;
        string m_Cat;
        Patente Documento = new Patente();
        string P1 = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\cmedico_f1.doc";
        string P1_nofoto = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\cmedico_f1x.doc";
        string P2 = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\cmedico_f2.doc";
        string P3 = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\cmedico_f3.doc";
        string P3_Diabete = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\cmedico_f3x.doc";
            

        public PrintForm(BindingList<Patente> m_listapat,BindingList<Contatto>m_listacontact)
        {
            InitializeComponent();
            m_ListaContatti = m_listacontact;
            m_ListaPatenti = m_listapat;
        }

        private void btn_Stampa_Click(object sender, EventArgs e)
        {
            try
            {
                //uccido tutti i word aperti
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.StartsWith("WINWORD"))
                    {
                        clsProcess.Kill();
                    }
                }

                lbl_Status.Text = "Attendere, sto creando la cartellina";
                lbl_Status.Visible = true;
                Application.DoEvents();
                string posizionecartellina = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\modcartellina.doc";
                StampaCartellina(posizionecartellina);
                lbl_Status.Text = "Cartellina stampata con successo";
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 40";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        string error = "E' Avvenuto un errore: ERRORE 41";
                        MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

        }

        private void StampaCartellina(object fileName)
        {
           
                //Set Missing Value parameter - used to represent
                // a missing value when calling methods through
                // interop.
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<COGNOME>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<NOME>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNascita>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<CFiscale>", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    this.FindAndReplace(wordApp, "<PaeseRes>", DataAccess.Instance.UtenteSelezionato.ComuneResidenza);
                    this.FindAndReplace(wordApp, "<ProvRes>", DataAccess.Instance.UtenteSelezionato.ProvResidenza);
                    this.FindAndReplace(wordApp, "<Indirizzo>", DataAccess.Instance.UtenteSelezionato.Indirizzo);

                    if (m_ListaContatti.Count >= 1)
                    {
                        this.FindAndReplace(wordApp, "<Tipo1>", m_ListaContatti[0].tipo);
                        this.FindAndReplace(wordApp, "<Contatto1>", m_ListaContatti[0].numero);
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<Tipo1>", " ");
                        this.FindAndReplace(wordApp, "<Contatto1>", " ");
                    }
                    if (m_ListaContatti.Count >= 2)
                    {
                        this.FindAndReplace(wordApp, "<Tipo2>", m_ListaContatti[1].tipo);
                        this.FindAndReplace(wordApp, "<Contatto2>", m_ListaContatti[1].numero);
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<Tipo2>", " ");
                        this.FindAndReplace(wordApp, "<Contatto2>", " ");
                    }
                    if (m_ListaContatti.Count >= 3)
                    {
                        this.FindAndReplace(wordApp, "<Tipo3>", m_ListaContatti[2].tipo);
                        this.FindAndReplace(wordApp, "<Contatto3>", m_ListaContatti[2].numero);
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<Tipo3>", " ");
                        this.FindAndReplace(wordApp, "<Contatto3>", " ");
                    }


                }
                else
                {
                    MessageBox.Show("Errore, file non trovato","Errore");
                    return;
                }

                //Save the document as the correct file name.



                object copies = "1";
                object pages = "";
                object range = Word.WdPrintOutRange.wdPrintAllDocument;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;

                //Close the document - you have to do this.

                aDoc.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);


                aDoc.Close(ref oFalse, ref missing, ref missing);
                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 43";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
        }

        private void ApriCartellina(object fileName, object saveAs)
        {
           
                //Set Missing Value parameter - used to represent
                // a missing value when calling methods through
                // interop.
                object missing = System.Reflection.Missing.Value;

                //Setup the Word.Application class.
                Word.Application wordApp =
                    new Word.ApplicationClass();

                //Setup our Word.Document class we'll use.
                Word.Document aDoc = null;

                object readOnly = false;
                object isVisible = false;
                try
                {
                // Check to see that file exists
                if (File.Exists((string)fileName))
                {
                    DateTime today = DateTime.Now;


                    SqliteOperations sql = new SqliteOperations();
                    
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);
                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<COGNOME>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<NOME>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNascita>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<CFiscale>", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    this.FindAndReplace(wordApp, "<PaeseRes>", DataAccess.Instance.UtenteSelezionato.ComuneResidenza);
                    this.FindAndReplace(wordApp, "<ProvRes>", DataAccess.Instance.UtenteSelezionato.ProvResidenza);
                    this.FindAndReplace(wordApp, "<Indirizzo>", DataAccess.Instance.UtenteSelezionato.Indirizzo);

                    if (m_ListaContatti.Count >= 1)
                    {
                        this.FindAndReplace(wordApp, "<Tipo1>", m_ListaContatti[0].tipo);
                        this.FindAndReplace(wordApp, "<Contatto1>", m_ListaContatti[0].numero);
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<Tipo1>", " ");
                        this.FindAndReplace(wordApp, "<Contatto1>", " ");
                    }
                    if (m_ListaContatti.Count >= 2)
                    {
                        this.FindAndReplace(wordApp, "<Tipo2>", m_ListaContatti[1].tipo);
                        this.FindAndReplace(wordApp, "<Contatto2>", m_ListaContatti[1].numero);
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<Tipo2>", " ");
                        this.FindAndReplace(wordApp, "<Contatto2>", " ");
                    }
                    if (m_ListaContatti.Count >= 3)
                    {
                        this.FindAndReplace(wordApp, "<Tipo3>", m_ListaContatti[2].tipo);
                        this.FindAndReplace(wordApp, "<Contatto3>", m_ListaContatti[2].numero);
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<Tipo3>", " ");
                        this.FindAndReplace(wordApp, "<Contatto3>", " ");
                    }


                }
                else
                {
                    MessageBox.Show("Errore File non trovato!");
                    return;
                }

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
                string error = "E' Avvenuto un errore: ERRORE 44";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref readOnly, ref missing, ref missing);
            }

        }

        /// <summary>
        /// This is simply a helper method to find/replace 
        /// text.
        /// </summary>
        /// <param name="WordApp">Word Application to use</param>
        /// <param name="findText">Text to find</param>
        /// <param name="replaceWithText">Replacement text</param>
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

        private void btn_ApriCartellina_Click(object sender, EventArgs e)
        {
            try
            {
                //uccido tutti i word aperti
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.StartsWith("WINWORD"))
                    {
                        clsProcess.Kill();
                    }
                }

                lbl_Status.Text = "Attendere, sto creando la cartellina";
                lbl_Status.Visible = true;
                Application.DoEvents();
                string posizionecartellina = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\modcartellina.doc";
                string newcartellina = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\" + DataAccess.Instance.UtenteSelezionato.CodiceFiscale;

                ApriCartellina(posizionecartellina, newcartellina);
                lbl_Status.Text = "Cartellina aperta!";
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 45";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string newcartellina = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\Documents\\" + DataAccess.Instance.UtenteSelezionato.CodiceFiscale;

                if (File.Exists(newcartellina))
                    File.Delete(newcartellina);
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
            }

             this.DialogResult = DialogResult.Cancel;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            foreach(Patente doc in m_ListaPatenti)
                cbox_doc.Items.Add(doc.numero.ToString());
            cbox_tipo.SelectedIndex = 0;
            if (cbox_doc.Items.Count > 0)
            {
                cbox_doc.SelectedIndex = 0;
            }
            else
            {

                btn_StampaCertificato.Enabled = false;
                btn_ApriCertficato.Enabled = false;
            }
        }

        private void RetrieveInformations()
        {
            m_Cat = tbox_cat.Text;
            m_Diabete = chk_diabete.Checked;
            m_nDoc = cbox_doc.SelectedItem.ToString();
            m_TipoCert = cbox_tipo.SelectedItem.ToString(); 

            foreach (Patente pat in m_ListaPatenti)
            {
                if (pat.numero.Equals(m_nDoc))
                {
                    Documento = pat;
                    break;
                }
            }
        }

        private void btn_StampaCertificato_Click(object sender, EventArgs e)
        {
            try
            {

                RetrieveInformations();
                //uccido tutti i word aperti
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.StartsWith("WINWORD"))
                    {
                        clsProcess.Kill();
                    }
                }

                if (m_TipoCert.Equals("CONSEGUIMENTO"))
                {
                    lbl_Status.Text = "Stampo Pagina 1";
                    Application.DoEvents();
                    StampaPagina1(P1);
                    lbl_Status.Text = "Stampo Pagina 2";
                    Application.DoEvents();
                    StampaPagina2(P2);
                    lbl_Status.Text = "Stampa Completata";
                }
                else if (m_TipoCert.Equals("DUPLICATO NOFOTO"))
                {
                    lbl_Status.Text = "Stampo Pagina 1";
                    Application.DoEvents();
                    StampaPagina1(P1_nofoto);
                    lbl_Status.Text = "Stampo Pagina 2";
                    Application.DoEvents();
                    StampaPagina2(P2);
                    lbl_Status.Text = "Stampo Pagina 3";
                    Application.DoEvents();
                    if (m_Diabete)
                        StampaPagina3(P3_Diabete);
                    else
                        StampaPagina3(P3);
                    lbl_Status.Text = "Stampa completata";
                }
                else
                {
                    lbl_Status.Text = "Stampo Pagina 1";
                    Application.DoEvents();
                    StampaPagina1(P1);
                    lbl_Status.Text = "Stampo Pagina 2";
                    Application.DoEvents();
                    StampaPagina2(P2);
                    lbl_Status.Text = "Stampo Pagina 3";
                    Application.DoEvents();
                    if (m_Diabete)
                        StampaPagina3(P3_Diabete);
                    else
                        StampaPagina3(P3);
                    lbl_Status.Text = "Stampa Completata";
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 46";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StampaPagina1(object fileName)
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<nome>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNascita>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<conseguimento>", m_TipoCert);
                    this.FindAndReplace(wordApp, "<Documento>", Documento.tipo);
                    this.FindAndReplace(wordApp, "<nDocumento>", Documento.numero);
                    this.FindAndReplace(wordApp, "<EnteRilDoc>", Documento.enterilascio);
                    this.FindAndReplace(wordApp, "<DataRilDoc>", Documento.datarilascio.ToString("dd/MM/yyyy"));
                    if (DataAccess.Instance.UtenteSelezionato.Sex)
                        this.FindAndReplace(wordApp, "<o>", "o");
                    else
                        this.FindAndReplace(wordApp, "<o>", "a");


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
                string error = "E' Avvenuto un errore: ERRORE 47";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }

        }

        private void StampaPagina2(object fileName)
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<nome>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNasc>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<cfiscale>", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    this.FindAndReplace(wordApp, "<PaeseRes>", DataAccess.Instance.UtenteSelezionato.ComuneResidenza);
                    this.FindAndReplace(wordApp, "<ProvRes>", DataAccess.Instance.UtenteSelezionato.ProvResidenza);
                    this.FindAndReplace(wordApp, "<Indirizzo>", DataAccess.Instance.UtenteSelezionato.Indirizzo);
                   
                    if (m_TipoCert.Equals("CONSEGUIMENTO"))
                    {
                        this.FindAndReplace(wordApp, "<catpat>", "   ");
                        this.FindAndReplace(wordApp, "<npat>", "   ");
                        this.FindAndReplace(wordApp, "<enteRil>", "   ");
                        this.FindAndReplace(wordApp, "<dataril>", "   ");
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<catpat>", Documento.categoria);
                        this.FindAndReplace(wordApp, "<npat>", Documento.numero);
                        this.FindAndReplace(wordApp, "<enteRil>", Documento.enterilascio);
                        this.FindAndReplace(wordApp, "<dataril>", Documento.datarilascio.ToString("dd/MM/yyyy"));
                    }
                    
                    

                    if (DataAccess.Instance.UtenteSelezionato.Sex)
                    {

                        this.FindAndReplace(wordApp, "<IL sottoscritto>", "Il sottoscritto");
                        this.FindAndReplace(wordApp, "<nato>", "nato");
                    }
                    else
                    {

                        this.FindAndReplace(wordApp, "<IL sottoscritto>", "La sottoscritta");
                        this.FindAndReplace(wordApp, "<nato>", "nata");
                    }

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
                string error = "E' Avvenuto un errore: ERRORE 48";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }

        }
        private void StampaPagina3(object fileName)
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<nome>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNasc>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<cfiscale>", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    this.FindAndReplace(wordApp, "<PaeseRes>", DataAccess.Instance.UtenteSelezionato.ComuneResidenza);
                    this.FindAndReplace(wordApp, "<ProvRes>", DataAccess.Instance.UtenteSelezionato.ProvResidenza);
                    this.FindAndReplace(wordApp, "<Indirizzo>", DataAccess.Instance.UtenteSelezionato.Indirizzo);
                    this.FindAndReplace(wordApp, "<cap>", DataAccess.Instance.UtenteSelezionato.CAP);
                 
                    this.FindAndReplace(wordApp, "<catpat>", Documento.categoria);
                    this.FindAndReplace(wordApp, "<npat>", Documento.numero);
                    this.FindAndReplace(wordApp, "<enteRil>", Documento.enterilascio);
                    this.FindAndReplace(wordApp, "<dataril>", Documento.datarilascio.ToString("dd/MM/yyyy"));
                    



                    if (DataAccess.Instance.UtenteSelezionato.Sex)
                    {

                        this.FindAndReplace(wordApp, "<il>", "Il");
                        this.FindAndReplace(wordApp, "<nato>", "nato");
                    }
                    else
                    {

                        this.FindAndReplace(wordApp, "<il>", "La");
                        this.FindAndReplace(wordApp, "<nato>", "nata");
                    }

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
                string error = "E' Avvenuto un errore: ERRORE 49";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
        }

        private void ApriPagina1(object fileName)
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<nome>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNascita>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<conseguimento>", m_TipoCert);
                    this.FindAndReplace(wordApp, "<Documento>", Documento.tipo);
                    this.FindAndReplace(wordApp, "<nDocumento>", Documento.numero);
                    this.FindAndReplace(wordApp, "<EnteRilDoc>", Documento.enterilascio);
                    this.FindAndReplace(wordApp, "<DataRilDoc>", Documento.datarilascio.ToString("dd/MM/yyyy"));
                    if (DataAccess.Instance.UtenteSelezionato.Sex)
                        this.FindAndReplace(wordApp, "<o>", "o");
                    else
                        this.FindAndReplace(wordApp, "<o>", "a");


                }
                else
                {
                    MessageBox.Show("Errore, file non trovato", "Errore");
                    return;
                }
                object saveAs = fileName + DataAccess.Instance.UtenteSelezionato.CodiceFiscale;

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
                string error = "E' Avvenuto un errore: ERRORE 50";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
        }

        private void ApriPagina2(object fileName)
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<nome>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNasc>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<cfiscale>", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    this.FindAndReplace(wordApp, "<PaeseRes>", DataAccess.Instance.UtenteSelezionato.ComuneResidenza);
                    this.FindAndReplace(wordApp, "<ProvRes>", DataAccess.Instance.UtenteSelezionato.ProvResidenza);
                    this.FindAndReplace(wordApp, "<Indirizzo>", DataAccess.Instance.UtenteSelezionato.Indirizzo);
                    this.FindAndReplace(wordApp, "<cap>", DataAccess.Instance.UtenteSelezionato.CAP);
                    if (m_TipoCert.Equals("CONSEGUIMENTO"))
                    {
                        this.FindAndReplace(wordApp, "<catpat>", "   ");
                        this.FindAndReplace(wordApp, "<npat>", "   ");
                        this.FindAndReplace(wordApp, "<enteRil>", "   ");
                        this.FindAndReplace(wordApp, "<dataril>", "   ");
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<catpat>", Documento.categoria);
                        this.FindAndReplace(wordApp, "<npat>", Documento.numero);
                        this.FindAndReplace(wordApp, "<enteRil>", Documento.enterilascio);
                        this.FindAndReplace(wordApp, "<dataril>", Documento.datarilascio.ToString("dd/MM/yyyy"));
                    }



                    if (DataAccess.Instance.UtenteSelezionato.Sex)
                    {

                        this.FindAndReplace(wordApp, "<IL sottoscritto>", "Il sottoscritto");
                        this.FindAndReplace(wordApp, "<nato>", "nato");
                    }
                    else
                    {

                        this.FindAndReplace(wordApp, "<IL sottoscritto>", "La sottoscritta");
                        this.FindAndReplace(wordApp, "<nato>", "nata");
                    }

                }
                else
                {
                    MessageBox.Show("Errore, file non trovato", "Errore");
                    return;
                }

                object saveAs = fileName + DataAccess.Instance.UtenteSelezionato.CodiceFiscale;

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
                string error = "E' Avvenuto un errore: ERRORE 51";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }

        }
        private void ApriPagina3(object fileName)
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

                    string str = DataAccess.Instance.UtenteSelezionato.DataNascita.ToString();
                    int temp = str.LastIndexOf(' ');
                    str = str.Remove(temp);

                    // Find Place Holders and Replace them with Values.
                    this.FindAndReplace(wordApp, "<cognome>", DataAccess.Instance.UtenteSelezionato.Cognome);
                    this.FindAndReplace(wordApp, "<nome>", DataAccess.Instance.UtenteSelezionato.Nome);
                    this.FindAndReplace(wordApp, "<PaeseNascita>", DataAccess.Instance.UtenteSelezionato.ComuneNascita);
                    this.FindAndReplace(wordApp, "<DataNascita>", str);
                    this.FindAndReplace(wordApp, "<ProvNasc>", DataAccess.Instance.UtenteSelezionato.ProvNascita);
                    this.FindAndReplace(wordApp, "<cfiscale>", DataAccess.Instance.UtenteSelezionato.CodiceFiscale);
                    this.FindAndReplace(wordApp, "<PaeseRes>", DataAccess.Instance.UtenteSelezionato.ComuneResidenza);
                    this.FindAndReplace(wordApp, "<ProvRes>", DataAccess.Instance.UtenteSelezionato.ProvResidenza);
                    this.FindAndReplace(wordApp, "<Indirizzo>", DataAccess.Instance.UtenteSelezionato.Indirizzo);
                    this.FindAndReplace(wordApp, "<cap>", DataAccess.Instance.UtenteSelezionato.CAP);
                 
                    this.FindAndReplace(wordApp, "<catpat>", Documento.categoria);
                    this.FindAndReplace(wordApp, "<npat>", Documento.numero);
                    this.FindAndReplace(wordApp, "<enteRil>", Documento.enterilascio);
                    this.FindAndReplace(wordApp, "<dataril>", Documento.datarilascio.ToString("dd/MM/yyyy"));




                    if (DataAccess.Instance.UtenteSelezionato.Sex)
                    {

                        this.FindAndReplace(wordApp, "<il>", "Il");
                        this.FindAndReplace(wordApp, "<nato>", "nato");
                    }
                    else
                    {

                        this.FindAndReplace(wordApp, "<il>", "La");
                        this.FindAndReplace(wordApp, "<nato>", "nata");
                    }

                }
                else
                {
                    MessageBox.Show("Errore, file non trovato", "Errore");
                    return;
                }

                object saveAs = fileName + DataAccess.Instance.UtenteSelezionato.CodiceFiscale;

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
                string error = "E' Avvenuto un errore: ERRORE 52";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                wordApp.Quit(ref oFalse, ref missing, ref missing);
            }
        }

        private void btn_ApriCertficato_Click(object sender, EventArgs e)
        {
            try
            {
                RetrieveInformations();

                //uccido tutti i word aperti
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.StartsWith("WINWORD"))
                    {
                        clsProcess.Kill();
                    }
                }
                if (m_TipoCert.Equals("CONSEGUIMENTO"))
                {
                    lbl_Status.Text = "Stampo Pagina 1";
                    Application.DoEvents();
                    ApriPagina1(P1);
                    lbl_Status.Text = "Stampo Pagina 2";
                    Application.DoEvents();
                    ApriPagina2(P2);
                    lbl_Status.Text = "Stampa Completata";
                }
                else if (m_TipoCert.Equals("DUPLICATO NOFOTO"))
                {
                    lbl_Status.Text = "Stampo Pagina 1";
                    Application.DoEvents();
                    ApriPagina1(P1_nofoto);
                    lbl_Status.Text = "Stampo Pagina 2";
                    Application.DoEvents();
                    ApriPagina2(P2);
                    lbl_Status.Text = "Stampo Pagina 3";
                    Application.DoEvents();
                    if (m_Diabete)
                        ApriPagina3(P3_Diabete);
                    else
                        ApriPagina3(P3);
                    lbl_Status.Text = "Stampa completata";
                }
                else
                {
                    lbl_Status.Text = "Stampo Pagina 1";
                    Application.DoEvents();
                    ApriPagina1(P1);
                    lbl_Status.Text = "Stampo Pagina 2";
                    Application.DoEvents();
                    ApriPagina2(P2);
                    lbl_Status.Text = "Stampo Pagina 3";
                    Application.DoEvents();
                    if (m_Diabete)
                        ApriPagina3(P3_Diabete);
                    else
                        ApriPagina3(P3);
                    lbl_Status.Text = "Stampa Completata";
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 53";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RemoveAllFiles();
        }
       
    }
}
