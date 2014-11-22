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
    public partial class AddLicense : Form
    {
        public AddLicense()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = 0;
                //acquisisco i dati
                if (tbox_Numero.Text.Equals(string.Empty))
                    MessageBox.Show("Stai cercando di aggiungere un patente senza aver inserito nessun numero!", "Errore", MessageBoxButtons.OK);
                else
                {
                    /*if (DataAccess.Instance.IsPatModifyOn)
                    {
                        SqliteOperations sqlop1 = new SqliteOperations();
                        ret = sqlop1.RemoveLicense(DataAccess.Instance.CodiceFiscale.ToUpper(), DataAccess.Instance.PatenteSelezionata.numero);
                        if (ret == -1)
                        {
                            MessageBox.Show("E' avvenuto un errore", "Errore", MessageBoxButtons.OK);
                            return;
                        }
                    }*/
                    string numero = tbox_Numero.Text.ToUpper();
                    string tipo = cbox_TipoPatente.SelectedItem.ToString();
                    string categoria = tbox_Categoria.Text.ToUpper();
                    if (tbox_dataRilascio.Text.Equals(string.Empty))
                        tbox_dataRilascio.Text = "01 / 01 / 1900";
                    DateTime DataRilascio = Convert.ToDateTime(tbox_dataRilascio.Text);
                    if (tbox_DataScadenza.Text.Equals(string.Empty))
                        tbox_DataScadenza.Text = "01 / 01 / 1900";
                    DateTime DataScadenza = Convert.ToDateTime(tbox_DataScadenza.Text);
                    string enterilascio = tbox_Enterilascio.Text.ToUpper();
                    string codicefiscale = DataAccess.Instance.CodiceFiscale.ToUpper();
                    SqliteOperations sqlop = new SqliteOperations();
                    if (DataAccess.Instance.IsPatModifyOn)
                        ret = sqlop.ModifyLicenseInDB(numero, tipo, categoria, DataRilascio, DataScadenza, enterilascio, codicefiscale,DataAccess.Instance.PatenteSelezionata.numero,DataAccess.Instance.UtenteSelezionato.CodiceFiscale,false);
                    else
                        ret = sqlop.InsertLicenseInDB(numero, tipo, categoria, DataRilascio, DataScadenza, enterilascio, codicefiscale);
                    if (ret == -1)
                        MessageBox.Show("E' avvenuto un errore nell'inserimento della patente", "Errore", MessageBoxButtons.OK);
                    else
                    {
                        DataAccess.Instance.PatenteSelezionata.categoria = categoria;
                        DataAccess.Instance.PatenteSelezionata.datarilascio = DataRilascio;
                        DataAccess.Instance.PatenteSelezionata.datascadenza = DataScadenza;
                        DataAccess.Instance.PatenteSelezionata.enterilascio = enterilascio;
                        DataAccess.Instance.PatenteSelezionata.numero = numero;
                        DataAccess.Instance.PatenteSelezionata.tipo = tipo;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 11";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbox_dataRilascio_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!tbox_dataRilascio.Text.Equals(string.Empty))
                {
                    SqliteOperations sqlop = new SqliteOperations();
                    tbox_dataRilascio.Text = sqlop.TransformDate(tbox_dataRilascio.Text);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void tbox_DataScadenza_Leave(object sender, EventArgs e)
        {
            if (!tbox_DataScadenza.Text.Equals(string.Empty))
            {
                SqliteOperations sqlop = new SqliteOperations();
                tbox_DataScadenza.Text = sqlop.TransformDate(tbox_DataScadenza.Text);
            }
        }

        private void AddLicense_Load(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.Instance.IsPatModifyOn)
                {
                    tbox_Categoria.Text = DataAccess.Instance.PatenteSelezionata.categoria;
                    tbox_dataRilascio.Text = DataAccess.Instance.PatenteSelezionata.datarilascio.ToString("dd/MM/yyyy");
                    tbox_DataScadenza.Text = DataAccess.Instance.PatenteSelezionata.datascadenza.ToString("dd/MM/yyyy");
                    tbox_Enterilascio.Text = DataAccess.Instance.PatenteSelezionata.enterilascio;
                    tbox_Numero.Text = DataAccess.Instance.PatenteSelezionata.numero;
                    cbox_TipoPatente.SelectedIndex = cbox_TipoPatente.FindStringExact( DataAccess.Instance.PatenteSelezionata.tipo);
                }
                else
                    cbox_TipoPatente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 10";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLicense_Shown(object sender, EventArgs e)
        {
            cbox_TipoPatente.Focus();
        }
    }
}
