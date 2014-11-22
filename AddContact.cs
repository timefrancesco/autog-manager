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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int ret;
                //acquisisco i dati
                if ((tbox_contatto.Text.Equals(string.Empty)) || (tbox_tipo.Text.Equals(String.Empty)))
                    MessageBox.Show("Entrambi i campi son necessari!", "Errore", MessageBoxButtons.OK);
                else
                {
                  /*  if (DataAccess.Instance.IsContactModifyOn)
                    {
                        SqliteOperations sqlop1 = new SqliteOperations();
                        ret = sqlop1.RemoveContact(DataAccess.Instance.CodiceFiscale.ToUpper(), DataAccess.Instance.ContattoSelezionato.numero);
                        if (ret == -1)
                        {
                            MessageBox.Show("E' avvenuto un errore", "Errore", MessageBoxButtons.OK);
                            return;
                        }
                    }*/
                    string numero = tbox_contatto.Text;
                    string tipo = tbox_tipo.Text;
                    string codicefiscale = DataAccess.Instance.CodiceFiscale.ToUpper();
                    SqliteOperations sqlop = new SqliteOperations();
                    if (DataAccess.Instance.IsContactModifyOn)
                        ret = sqlop.ModifyContactInDB(numero, tipo, codicefiscale,DataAccess.Instance.UtenteSelezionato.CodiceFiscale,DataAccess.Instance.ContattoSelezionato.tipo,DataAccess.Instance.ContattoSelezionato.numero, false);
                    else
                        ret = sqlop.InsertContactInDB(numero, tipo, codicefiscale);
                    if (ret == -1)
                        MessageBox.Show("E' avvenuto un errore nell'inserimento del contatto", "Errore", MessageBoxButtons.OK);
                    else
                    {
                        DataAccess.Instance.ContattoSelezionato.numero = numero;
                        DataAccess.Instance.ContattoSelezionato.tipo = tipo;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 6 - ";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.Instance.IsContactModifyOn)
                {
                    tbox_tipo.Text = DataAccess.Instance.ContattoSelezionato.tipo;
                    tbox_contatto.Text = DataAccess.Instance.ContattoSelezionato.numero;
                }
            }
            catch (Exception ex)
            {
                string error = "E' Avvenuto un errore: ERRORE 7";
                MessageBox.Show(error, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddContact_Shown(object sender, EventArgs e)
        {
            tbox_tipo.Focus();
        }
    }
}
