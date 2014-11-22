using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Net;
using System.Data.OleDb;

namespace VillaUserManager
{
    public partial class SynchForm : Form
    {
        string m_Password = "H1ll@riOu_$$$_1984";
        string m_Host = "ftp.drivehq.com";
        string m_FtpUser = "villaone";
        string m_FtpPass = "risiko1984";
        string m_FileOnFtp = "SynchFile.vdb";
        string m_tempExtDirName = "vSynchtemp";
        string m_PathDownloadedFile = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        SqliteOperations SQLop = new SqliteOperations();
        BindingList<Comuni> m_ListaComuni = new BindingList<Comuni>();
        

        public SynchForm()
        {
            InitializeComponent();
        }

        private void btn_Synch_Click(object sender, EventArgs e)
        {
        
            try
            {
                if (chk_backup.Checked)
                {
                    lbl_synchstatus.Text = "Eseguendo backup";
                    bar_synchprogress.Value = 5;
                    Application.DoEvents();
                    EseguiBackup(true);
                }
                lbl_synchstatus.Text = "Downloading";
                bar_synchprogress.Value = 10;
                Application.DoEvents();
                int ret = DownloadFile();
                if (ret == 0)
                    throw new Exception();
                else if (ret == 1)
                {
                    lbl_synchstatus.Text = "Estraggo";
                    bar_synchprogress.Value = 20;
                    Application.DoEvents();
                    ret = EstraiFiles();
                    if (ret == 0)
                        throw new Exception();
                    lbl_synchstatus.Text = "Sincronizzo Anagrafiche";
                    bar_synchprogress.Value = 30;
                    Application.DoEvents();
                    ret = SincronizzaUtenti();
                    if (ret == 0)
                        throw new Exception();
                    lbl_synchstatus.Text = "Sincronizzo Contatti";
                    bar_synchprogress.Value = 40;
                    Application.DoEvents();
                    ret = SincronizzaContatti();
                    if (ret == 0)
                        throw new Exception();
                    lbl_synchstatus.Text = "Sincronizzo esami";
                    bar_synchprogress.Value = 50;
                    Application.DoEvents();
                    ret = SincronizzaEsami();
                    if (ret == 0)
                        throw new Exception();
                    lbl_synchstatus.Text = "Sincronizzo Patenti";
                    bar_synchprogress.Value = 60;
                    Application.DoEvents();
                    ret = SincronizzaPatenti();
                    if (ret == 0)
                        throw new Exception();
                    if (chk_ComuniSynch.Checked)
                    {
                        lbl_synchstatus.Text = "Sincronizzo Comuni";
                        bar_synchprogress.Value = 70;
                        Application.DoEvents();
                        ret = SincronizzaComuni();
                        if (ret == 0)
                            throw new Exception();
                    }
                    lbl_synchstatus.Text = "Sincronizzo Foto";
                    bar_synchprogress.Value = 80;
                    Application.DoEvents();
                    ret = SincronizzaFoto();
                    if (ret == 0)
                        throw new Exception();
                }
                lbl_synchstatus.Text = "Preparo Upload";
                bar_synchprogress.Value = 90;
                Application.DoEvents();
                EseguiBackup(false);
                lbl_synchstatus.Text = "Uploading";
                bar_synchprogress.Value = 94;
                Application.DoEvents();
                ret = UploadFile();
                if (ret == -1)
                    tbox_Status.Text += "\r\nImpossibile UPLOADARE IL FILE! SINCRONIZZAZIONE NON COMPLETATA";

            }
            catch (Exception ex)
            {
            }
            lbl_synchstatus.Text = "Rimuovo file temporanei";
            bar_synchprogress.Value = 97;
            Application.DoEvents();
            RemoveTemporaryFiles();
            lbl_synchstatus.Text = "Sincronizzazione completata";
            bar_synchprogress.Value = 100;
            Application.DoEvents();

        }

        private void RemoveTemporaryFiles()
        {
            string downloadedfile = m_PathDownloadedFile +"\\"+ m_FileOnFtp;
            if (File.Exists(downloadedfile))
                File.Delete(downloadedfile);
            string dirtodel = m_PathDownloadedFile + "\\"+ m_tempExtDirName;
            if (Directory.Exists(dirtodel))
                Directory.Delete(dirtodel, true);
        }

        private int SincronizzaFoto()
        {
            int ret = 0;
            string ExtPath = m_PathDownloadedFile +"\\"+ m_tempExtDirName + "\\Risorse\\ProfilePictures";
            string LocalPat = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Comuni) + "\\ProfilePictures";
            try
            {
                DirectoryInfo di = new DirectoryInfo(ExtPath);
                FileInfo[] listafiles = di.GetFiles();

                foreach (FileInfo file in listafiles)
                {
                    string destfile = LocalPat + "\\" + file.Name;
                    if (!File.Exists(destfile))
                        File.Copy(file.FullName, destfile, true);
                    tbox_Status.Text += "\r\n Copio Foto" + file.Name;
                }
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = 0;
            }

            return ret;
        }

        private void EseguiBackup(bool userbackup)
        {
            string strZipFileName;
            if (userbackup)
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                    strZipFileName = folderBrowserDialog1.SelectedPath + "\\" + "BackupVilla_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".vdb";
                else
                    return;
            }
            else
            {
                strZipFileName = m_PathDownloadedFile + "\\"+ m_FileOnFtp;
                if (File.Exists(strZipFileName))
                    File.Delete(strZipFileName);
            }

            
               
            string sourcep = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti);
           // string strZipFileName = folderBrowserDialog1.SelectedPath + "\\" + "BackupVilla_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".vdb";
            try
            {
                Zip zipfolder = new Zip();

                zipfolder.ZipFiles(sourcep, strZipFileName, m_Password);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("E' avvenuto un errore", "Errore", MessageBoxButtons.OK);
                File.Delete(strZipFileName);
            }
            
        }

        private int DownloadFile()
        {
            int ret = 0;
            string filedown = m_PathDownloadedFile + "\\" + m_FileOnFtp;
            try
            {
                FtpClient ftp = new FtpClient(m_Host, m_FtpUser, m_FtpPass);
                ftp.Login();
                string[] files = ftp.GetFileList();
                foreach (string file in files)
                {
                    if (file.Equals(m_FileOnFtp))
                    {
                        ftp.Download(m_FileOnFtp, filedown);
                        ret = 1;
                        break;
                    }
                }
                if (ret == 0)
                    ret = -1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            return ret;
        }

        private int EstraiFiles()
        {
            string filedownloaded = m_PathDownloadedFile + "\\" + m_FileOnFtp;
            string extdir = m_PathDownloadedFile +"\\"+ m_tempExtDirName;
            int ret = 0;
            try{
                if (Directory.Exists(extdir))
                    Directory.Delete(extdir, true);
            Directory.CreateDirectory(extdir);
            Zip Unzip = new Zip();
            Unzip.UnZipFiles(filedownloaded,extdir, m_Password, false);
             ret = 1;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        private int SincronizzaUtenti()
        {
           int ret = 0;
            BindingList<UtenteCercato> ListaUtentiOtherDB = new BindingList<UtenteCercato>();
            try
            {
                string DatabaseLoc = m_PathDownloadedFile + "\\"+ m_tempExtDirName + "\\Risorse\\VillaDB.sqlite";
                ListaUtentiOtherDB = SQLop.ReadAllUsersExtDB(DatabaseLoc);
                if (ListaUtentiOtherDB.Count > 0)
                {
                    int tempret = 0;
                    foreach (UtenteCercato utente in ListaUtentiOtherDB)
                    {
                        if (SQLop.CheckIfAlreadyExist("Codicefiscale", "Utenti", utente.CodiceFiscale) == 0)
                        {
                            tempret = SQLop.InsertUserInDB(utente.Cognome, utente.Nome, utente.Sex, utente.DataNascita, utente.ComuneNascita, utente.ProvNascita, utente.CodiceFiscale, utente.ComuneResidenza, utente.ProvResidenza, utente.Indirizzo, utente.CAP, utente.foto);
                            if (tempret == 1)
                                tbox_Status.Text += "\r\n Aggiunto " + utente.Cognome + " " + utente.Nome;
                            else
                                tbox_Status.Text += "\r\n Errore nell'aggiungere " + utente.Cognome + " " + utente.Nome;
                        }
                    }

                    ret = 1;
                }
                else
                {
                    tbox_Status.Text +="\r\n Nessuna anagrafica da aggiungere";
                    ret = 1;
                }
            }
            catch (Exception ex)
            {
                ret = 0;
            }
           return ret;
        }

        //se una patente non c'è la aggiungo, se c'è la patente controllo se nel db locale è cancellata,
        //se nel db locale NON è cancellata e in quello scaricato LO E' allora modifico quella locale e
        //la marco a cancellata (la cancellazione vince sempre)
        private int SincronizzaPatenti()
        {
            int ret = 0;
            BindingList<Patente> ListaPatentiOtherDB = new BindingList<Patente>();
            try
            {
                string DatabaseLoc = m_PathDownloadedFile + "\\"+m_tempExtDirName + "\\Risorse\\VillaDB.sqlite";
                ListaPatentiOtherDB = SQLop.ReadAllLicenseExtDb(DatabaseLoc);
                if (ListaPatentiOtherDB.Count > 0)
                {
                    int tempret = 0;
                    foreach (Patente patente in ListaPatentiOtherDB)
                    {
                        int esiste = SQLop.CheckIfAlreadyExist("Numero", "Patenti", patente.numero);
                        if ( esiste == 0)
                        {
                            if (!patente.deleted)
                            {
                                tempret = SQLop.InsertLicenseInDB(patente.numero, patente.tipo, patente.categoria, patente.datarilascio, patente.datascadenza, patente.enterilascio, patente.codicefiscale);
                                if (tempret == 1)
                                    tbox_Status.Text += "\r\n Aggiunta patente " + patente.numero;
                                else
                                    tbox_Status.Text += "\r\n Errore nell'aggiungere la patente " + patente.numero;
                            }
                        }
                        else if (esiste > 0)
                        {
                            if (patente.deleted) //è cancellata quindi contro
                            {
                                BindingList<Patente> TempList = new BindingList<Patente>();
                                TempList = SQLop.ReadAllLicense("Numero", "Patenti", patente.numero);
                                if (TempList.Count > 0)
                                {
                                    if (!TempList[0].deleted) //in locale non è cancellata mentre sul ftp si
                                    {
                                        tempret = SQLop.ModifyLicenseInDB(patente.numero, patente.tipo, patente.categoria, patente.datarilascio, patente.datascadenza, patente.enterilascio, patente.codicefiscale, patente.numero, patente.codicefiscale, patente.deleted);
                                        if (tempret == 1)
                                            tbox_Status.Text += "\r\n Eliminata la patente " + patente.numero;
                                        else
                                            tbox_Status.Text += "\r\n Errore nell'eliminare la patente " + patente.numero;
                                    }
                                }
                            }
                        }

                    }

                    ret = 1;
                }
                else
                {
                    tbox_Status.Text += "\r\n Nessuna patente da aggiungere";
                    ret = 1;
                }
            }
            catch (Exception ex)
            {
                ret = 0;
            }

            return ret;
        }

        //Stessa logica delle patenti
        private int SincronizzaContatti()
        {
            int ret = 0;
            BindingList<Contatto> ListaContattiOtherDB = new BindingList<Contatto>();
            try
            {
                string DatabaseLoc = m_PathDownloadedFile +"\\"+ m_tempExtDirName + "\\Risorse\\VillaDB.sqlite";
                ListaContattiOtherDB = SQLop.ReadAllContatcsExtDB(DatabaseLoc);
                if (ListaContattiOtherDB.Count > 0)
                {
                    int tempret = 0;
                    foreach (Contatto contact in ListaContattiOtherDB)
                    {
                        int esiste = SQLop.CheckIfAlreadyExist("Contatto", "Contatti", contact.numero);
                        if (esiste == 0)
                        {
                            if (!contact.deleted)
                            {
                                tempret = SQLop.InsertContactInDB(contact.numero, contact.tipo, contact.codicefiscale);
                                if (tempret == 1)
                                    tbox_Status.Text += "\r\n Aggiunta il contatto " + contact.numero;
                                else
                                    tbox_Status.Text += "\r\n Errore nell'aggiungere il contatto " + contact.numero;
                            }
                        }
                        else if (esiste > 0)
                        {
                            if (contact.deleted) //è cancellata quindi contro
                            {
                                BindingList<Contatto> TempList = new BindingList<Contatto>();
                                TempList = SQLop.ReadAllContatcs("Contatto", "Contatti", contact.numero);
                                if (TempList.Count > 0)
                                {
                                    if (!TempList[0].deleted) //in locale non è cancellata mentre sul ftp si
                                    {
                                        tempret = SQLop.ModifyContactInDB(contact.numero, contact.tipo, contact.codicefiscale, contact.codicefiscale, contact.tipo, contact.numero, contact.deleted);
                                        if (tempret == 1)
                                            tbox_Status.Text += "\r\n Eliminato il contatto " + contact.numero;
                                        else
                                            tbox_Status.Text += "\r\n Errore nell'eliminare il contatto " + contact.numero;
                                    }
                                }
                            }
                        }

                    }

                    ret = 1;
                }
                else
                {
                    tbox_Status.Text += "\r\n Nessun contatto da aggiungere";
                    ret = 1;
                }
            }
            catch (Exception ex)
            {
                ret = 0;
            }

            return ret;
        }

        //Stessa logica delle patenti
        private int SincronizzaEsami()
        {
            int ret = 0;
            BindingList<Esame> ListaEsamiOtherDB = new BindingList<Esame>();
            try
            {
                string DatabaseLoc = m_PathDownloadedFile +"\\"+ m_tempExtDirName + "\\Risorse\\VillaDB.sqlite";
                ListaEsamiOtherDB = SQLop.ReadAllExamsExtDB(DatabaseLoc);
                if (ListaEsamiOtherDB.Count > 0)
                {
                    int tempret = 0;
                    foreach (Esame exam in ListaEsamiOtherDB)
                    {
                        BindingList<Esame> Tempexam = new BindingList<Esame>();
                        string dataesame = exam.DataEsame.ToString("yyyy-MM-dd 00:00:00");
                        Tempexam = SQLop.ReadExamSpec(exam.codicefiscale, dataesame, exam.Esito, exam.Categoria, exam.tipo);
                        if (Tempexam.Count == 0)
                        {
                            if (!exam.deleted)
                            {
                                tempret = SQLop.InsertExamInDB(exam.codicefiscale, exam.tipo, exam.DataEsame, exam.Categoria, exam.Esito);
                                if (tempret == 1)
                                    tbox_Status.Text += "\r\n Aggiunta esame " + exam.codicefiscale;
                                else
                                    tbox_Status.Text += "\r\n Errore nell'aggiungere l'esame " + exam.codicefiscale;
                            }
                        }
                        else if (Tempexam.Count > 0)
                        {
                            if (exam.deleted) //è cancellata quindi contro
                            {
                                BindingList<Esame> TempList = new BindingList<Esame>();
                                if (Tempexam.Count > 0)
                                {
                                    if (!Tempexam[0].deleted) //in locale non è cancellata mentre sul ftp si
                                    {
                                        tempret = SQLop.ModifyExamInDB(exam.codicefiscale, exam.tipo, exam.DataEsame, exam.Categoria, exam.Esito, exam.codicefiscale, exam.tipo, exam.codicefiscale, exam.DataEsame, exam.deleted);
                                        if (tempret == 1)
                                            tbox_Status.Text += "\r\n Eliminato esame " + exam.codicefiscale;
                                        else
                                            tbox_Status.Text += "\r\n Errore nell'eliminare l'esame " + exam.codicefiscale;
                                    }
                                }
                            }
                        }

                    }

                    ret = 1;
                }
                else
                {
                    tbox_Status.Text += "\r\n Nessun contatto da aggiungere";
                    ret = 1;
                }
            }
            catch (Exception ex)
            {
                ret = 0;
            }

            return ret;
        }

        private int SincronizzaComuni()
        {
            int ret = 0;
            if (PopulateGridComuniFTP() == 1)
            {
                try
                {
                    foreach (Comuni comuneftp in m_ListaComuni)
                    {
                        //controllo se esiste gia
                        string percorsoDB = DataAccess.Instance.Path_DB_Comuni;
                        string str;
                        int esistegia = 0;

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
                                string str2 = comuneftp.Comune;
                                if (str.Equals(str2))
                                {
                                    esistegia = 1;
                                    break;
                                }


                            }
                        }
                        catch (Exception objException)
                        {
                            ret = -1;
                        }
                        finally
                        {

                            dataReaderDB.Close(); //Chiudo il dataReader


                            connessioneDB.Close();//Chiudo la connessione.
                        }

                        if (esistegia == 0)
                        {
                            string ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataAccess.Instance.Path_DB_Comuni;
                            OleDbConnection ConnDB = new OleDbConnection(ConnStr);

                            try
                            {
                                string InsertString = string.Format("INSERT INTO comuni (Comune, Provincia, CodiceComune, CAP)VALUES ('{0}','{1}','{2}','{3}')", comuneftp.Comune, comuneftp.Provincia, comuneftp.CodiceComune, comuneftp.CAP);
                                commandDB = new OleDbCommand(InsertString, ConnDB);
                                ConnDB.Open();
                                commandDB.ExecuteNonQuery();

                            }
                            catch (Exception objException)
                            {
                                ret = -1;
                            }
                            finally
                            {

                                ConnDB.Close();//Chiudo la connessione.
                            }
                        }
                    }
                    if (ret == 0)
                        ret = 1;
                    
                }
                catch (Exception ex)
                {
                    ret = 0;
                }
            }

            return ret;
        }


        private int PopulateGridComuniFTP()
        {
            string percorsoDB =  m_PathDownloadedFile +"\\"+ m_tempExtDirName + "\\Risorse\\Comuni.mdb";
            string str;
            int ret = 0;

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
                ret = 1;
                
            }
            catch (Exception objException)
            {
                ret = 0;
            }
            finally
            {
                dataReaderDB.Close(); //Chiudo il dataReader
                connessioneDB.Close();//Chiudo la connessione.
            }
            return ret;

        }

        private int UploadFile()
        {
            int ret = 0;
           string toupload = m_PathDownloadedFile + "\\"+m_FileOnFtp;
            try
            {
                FtpClient ftp = new FtpClient(m_Host, m_FtpUser, m_FtpPass);
                ftp.Login();
                string[] files = ftp.GetFileList();
                foreach (string file in files)
                {
                    if (file.Equals(m_FileOnFtp))
                    {
                        ftp.DeleteFile(m_FileOnFtp);
                        ret = 1;
                        break;
                    }
                }
                ftp.Upload(toupload);
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            return ret;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

       
    }

}
