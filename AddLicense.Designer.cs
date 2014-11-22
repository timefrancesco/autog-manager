namespace VillaUserManager
{
    partial class AddLicense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_TipoPatente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Categoria = new System.Windows.Forms.TextBox();
            this.tbox_Numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_dataRilascio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Enterilascio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_DataScadenza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // cbox_TipoPatente
            // 
            this.cbox_TipoPatente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_TipoPatente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_TipoPatente.FormattingEnabled = true;
            this.cbox_TipoPatente.Items.AddRange(new object[] {
            "PATENTE",
            "FOGLIO ROSA",
            "CQC",
            "KAP",
            "CARTA IDENTITA\'",
            "PERMESSO SOGG."});
            this.cbox_TipoPatente.Location = new System.Drawing.Point(88, 18);
            this.cbox_TipoPatente.Name = "cbox_TipoPatente";
            this.cbox_TipoPatente.Size = new System.Drawing.Size(111, 21);
            this.cbox_TipoPatente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:";
            // 
            // tbox_Categoria
            // 
            this.tbox_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Categoria.Location = new System.Drawing.Point(278, 18);
            this.tbox_Categoria.MaxLength = 6;
            this.tbox_Categoria.Name = "tbox_Categoria";
            this.tbox_Categoria.Size = new System.Drawing.Size(61, 20);
            this.tbox_Categoria.TabIndex = 3;
            // 
            // tbox_Numero
            // 
            this.tbox_Numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Numero.Location = new System.Drawing.Point(88, 45);
            this.tbox_Numero.MaxLength = 20;
            this.tbox_Numero.Name = "tbox_Numero";
            this.tbox_Numero.Size = new System.Drawing.Size(251, 20);
            this.tbox_Numero.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero:";
            // 
            // tbox_dataRilascio
            // 
            this.tbox_dataRilascio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_dataRilascio.Location = new System.Drawing.Point(88, 71);
            this.tbox_dataRilascio.MaxLength = 20;
            this.tbox_dataRilascio.Name = "tbox_dataRilascio";
            this.tbox_dataRilascio.Size = new System.Drawing.Size(94, 20);
            this.tbox_dataRilascio.TabIndex = 7;
            this.tbox_dataRilascio.Leave += new System.EventHandler(this.tbox_dataRilascio_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rilasciata il:";
            // 
            // tbox_Enterilascio
            // 
            this.tbox_Enterilascio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Enterilascio.Location = new System.Drawing.Point(88, 97);
            this.tbox_Enterilascio.MaxLength = 100;
            this.tbox_Enterilascio.Name = "tbox_Enterilascio";
            this.tbox_Enterilascio.Size = new System.Drawing.Size(251, 20);
            this.tbox_Enterilascio.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rilasciata da:";
            // 
            // tbox_DataScadenza
            // 
            this.tbox_DataScadenza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_DataScadenza.Location = new System.Drawing.Point(245, 71);
            this.tbox_DataScadenza.MaxLength = 20;
            this.tbox_DataScadenza.Name = "tbox_DataScadenza";
            this.tbox_DataScadenza.Size = new System.Drawing.Size(94, 20);
            this.tbox_DataScadenza.TabIndex = 11;
            this.tbox_DataScadenza.Leave += new System.EventHandler(this.tbox_DataScadenza_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Scade il:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(276, 138);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "Salva";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(8, 138);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Annulla";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 131);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // AddLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 168);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tbox_DataScadenza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbox_Enterilascio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_dataRilascio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_Numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_Categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_TipoPatente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddLicense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserisci Patente o Foglio Rosa";
            this.Load += new System.EventHandler(this.AddLicense_Load);
            this.Shown += new System.EventHandler(this.AddLicense_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_TipoPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Categoria;
        private System.Windows.Forms.TextBox tbox_Numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_dataRilascio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_Enterilascio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_DataScadenza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}