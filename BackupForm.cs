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
using System.Diagnostics;

namespace VillaUserManager
{
    public partial class BackupForm : Form
    {
        string m_Password = "H1ll@riOu_$$$_1984";

        public BackupForm()
        {
            InitializeComponent();
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbox_destpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_avvia_Click(object sender, EventArgs e)
        {

            lbl_attendere.Visible = true;
            Application.DoEvents();
            string sourcep = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti);
            string strZipFileName = tbox_destpath.Text + "\\" + "BackupVilla_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".vdb";
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
                Zip zipfolder = new Zip();

                zipfolder.ZipFiles(sourcep, strZipFileName, m_Password);

                lbl_attendere.Text = "Backup Effettuato!";
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 31";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void CopyDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                // Check if the target directory exists, if not, create it.
                if (Directory.Exists(target.FullName) == false)
                {
                    Directory.CreateDirectory(target.FullName);
                }

                // Copy each file into it’s new directory.
                foreach (FileInfo fi in source.GetFiles())
                {

                    fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
                }

                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyDirectory(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 32";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_selectfiletorestore_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbox_filetorestore.Text = openFileDialog1.FileName;
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Verranno CANCELLATI tutti i dati attuali, SEI SICURO DI VOLER CONTINUARE??", "ATTENZIONE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    lbl_attendere.Text = "Attendere, Ripristino in corso";
                    lbl_attendere.Visible = true;
                    Application.DoEvents();
                    Zip Unzip = new Zip();
                    Unzip.UnZipFiles(tbox_filetorestore.Text, Path.GetDirectoryName(tbox_filetorestore.Text), m_Password, false);
                    if ((chk_ResorePic.Checked) && (chk_restoreComun.Checked) && (chk_restoreUser.Checked))
                    {
                        Directory.Delete(Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), true);

                        string dir = Path.GetDirectoryName(tbox_filetorestore.Text) + "\\Risorse";
                        Directory.Move(dir, Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti));
                    }
                    else
                    {
                        if (chk_ResorePic.Checked)
                        {
                            string str = Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti) + "\\ProfilePictures";
                            Directory.Delete(str, true);
                            string dir = Path.GetDirectoryName(tbox_filetorestore.Text) + "\\Risorse\\ProfilePictures";
                            Directory.Move(dir, str);
                            //Directory.Delete(Path.GetDirectoryName(tbox_filetorestore.Text) + "\\Risorse");
                        }
                        if (chk_restoreComun.Checked)
                        {

                            File.Delete(DataAccess.Instance.Path_DB_Comuni);
                            string dir = Path.GetDirectoryName(tbox_filetorestore.Text) + "\\Risorse\\Comuni.mdb";
                            File.Move(dir, DataAccess.Instance.Path_DB_Comuni);
                            // Directory.Delete(Path.GetDirectoryName(tbox_filetorestore.Text) + "\\Risorse");
                        }
                        if (chk_restoreUser.Checked)
                        {

                            File.Delete(DataAccess.Instance.Path_DB_Utenti);
                            string dir = Path.GetDirectoryName(tbox_filetorestore.Text) + "\\Risorse\\VillaDB.sqlite";
                            File.Move(dir, DataAccess.Instance.Path_DB_Utenti);
                        }

                        Directory.Delete(Path.GetDirectoryName(tbox_filetorestore.Text) + "\\Risorse", true);
                    }
                    lbl_attendere.Text = ("Ripristino completato!");
                }

            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 33";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }


}
