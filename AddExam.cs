using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VillaUserManager
{
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = 0;
                if ((tbox_cat.Text.Equals(String.Empty)) || (tbox_Data.Equals(string.Empty)))
                    MessageBox.Show("Non hai inserito tutti i dati", "Errore", MessageBoxButtons.OK);
                else
                {
                    /*if (DataAccess.Instance.IsEsamModifyOn)
                    {
                        string tmpstr1 = DataAccess.Instance.EsameSelezionato.DataEsame.ToString("yyyy-MM-dd");
                        tmpstr1 = tmpstr1 + " 00:00:00";
                        SqliteOperations sqlop1 = new SqliteOperations();
                        ret = sqlop1.RemoveExam(DataAccess.Instance.CodiceFiscale.ToUpper(), tmpstr1, DataAccess.Instance.EsameSelezionato.Esito, DataAccess.Instance.EsameSelezionato.tipo, DataAccess.Instance.EsameSelezionato.Categoria);
                        if (ret == -1)
                        {
                            MessageBox.Show("E' avvenuto un errore", "Errore", MessageBoxButtons.OK);
                            return;
                        }
                    }*/

                    string tipo = cbox_tipo.SelectedItem.ToString();
                    string cat = tbox_cat.Text;
                    if (tbox_Data.Text.Equals(string.Empty))
                        tbox_Data.Text = "01 / 01 / 1900";
                    DateTime data = Convert.ToDateTime(tbox_Data.Text);
                    string esito = cbox_esito.SelectedItem.ToString();
                    string cfisc = DataAccess.Instance.CodiceFiscale.ToUpper();
                    SqliteOperations SqlOp = new SqliteOperations();
                    if (DataAccess.Instance.IsEsamModifyOn)
                        ret = SqlOp.ModifyExamInDB(cfisc, tipo, data, cat, esito, DataAccess.Instance.UtenteSelezionato.CodiceFiscale, DataAccess.Instance.EsameSelezionato.tipo, DataAccess.Instance.EsameSelezionato.Categoria, DataAccess.Instance.EsameSelezionato.DataEsame, false);
                    else
                        ret = SqlOp.InsertExamInDB(cfisc, tipo, data, cat, esito);
                    if (ret == -1)
                        MessageBox.Show("E' avvenuto un errore nell'inserimento dell'esame", "Errore", MessageBoxButtons.OK);
                    else
                    {
                        DataAccess.Instance.EsameSelezionato.Categoria = cat;
                        DataAccess.Instance.EsameSelezionato.DataEsame = data;
                        DataAccess.Instance.EsameSelezionato.Esito = esito;
                        DataAccess.Instance.EsameSelezionato.tipo = tipo;
                    }
                    this.DialogResult = DialogResult.OK;

                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 8";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbox_Data_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!tbox_Data.Text.Equals(string.Empty))
                {
                    SqliteOperations sqlop = new SqliteOperations();
                    tbox_Data.Text = sqlop.TransformDate(tbox_Data.Text);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.Instance.IsEsamModifyOn)
                {
                    tbox_cat.Text = DataAccess.Instance.EsameSelezionato.Categoria;
                    tbox_Data.Text = DataAccess.Instance.EsameSelezionato.DataEsame.ToString("dd/MM/yyyy");
                    cbox_esito.SelectedItem = DataAccess.Instance.EsameSelezionato.Esito;
                    cbox_tipo.SelectedItem = DataAccess.Instance.EsameSelezionato.tipo;
                }
                else
                {
                    cbox_esito.SelectedIndex = 0;
                    cbox_tipo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 9";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddExam_Shown(object sender, EventArgs e)
        {
            cbox_tipo.Focus();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
