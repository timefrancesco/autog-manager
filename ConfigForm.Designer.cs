namespace VillaUserManager
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_OpenDButenti = new System.Windows.Forms.Button();
            this.tbox_DbUtenti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_OpenScadPat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RestoreDoc = new System.Windows.Forms.Button();
            this.btn_ApriPag3Diabete = new System.Windows.Forms.Button();
            this.btn_ApriCartellina = new System.Windows.Forms.Button();
            this.btn_ApriPag1NoFoto = new System.Windows.Forms.Button();
            this.btn_ApriPag3 = new System.Windows.Forms.Button();
            this.btn_ApriPag2 = new System.Windows.Forms.Button();
            this.btn_ApriPag1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_OpenDButenti);
            this.groupBox2.Controls.Add(this.tbox_DbUtenti);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Percorsi";
            // 
            // btn_OpenDButenti
            // 
            this.btn_OpenDButenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenDButenti.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenDButenti.Image")));
            this.btn_OpenDButenti.Location = new System.Drawing.Point(273, 36);
            this.btn_OpenDButenti.Name = "btn_OpenDButenti";
            this.btn_OpenDButenti.Size = new System.Drawing.Size(33, 20);
            this.btn_OpenDButenti.TabIndex = 4;
            this.btn_OpenDButenti.UseVisualStyleBackColor = true;
            this.btn_OpenDButenti.Click += new System.EventHandler(this.btn_OpenDButenti_Click);
            // 
            // tbox_DbUtenti
            // 
            this.tbox_DbUtenti.Location = new System.Drawing.Point(12, 36);
            this.tbox_DbUtenti.Name = "tbox_DbUtenti";
            this.tbox_DbUtenti.Size = new System.Drawing.Size(255, 20);
            this.tbox_DbUtenti.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selezionare la cartella contenente i database:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(251, 296);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OpenScadPat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_RestoreDoc);
            this.groupBox1.Controls.Add(this.btn_ApriPag3Diabete);
            this.groupBox1.Controls.Add(this.btn_ApriCartellina);
            this.groupBox1.Controls.Add(this.btn_ApriPag1NoFoto);
            this.groupBox1.Controls.Add(this.btn_ApriPag3);
            this.groupBox1.Controls.Add(this.btn_ApriPag2);
            this.groupBox1.Controls.Add(this.btn_ApriPag1);
            this.groupBox1.Location = new System.Drawing.Point(8, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documenti";
            // 
            // btn_OpenScadPat
            // 
            this.btn_OpenScadPat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenScadPat.Location = new System.Drawing.Point(12, 171);
            this.btn_OpenScadPat.Name = "btn_OpenScadPat";
            this.btn_OpenScadPat.Size = new System.Drawing.Size(135, 27);
            this.btn_OpenScadPat.TabIndex = 8;
            this.btn_OpenScadPat.Text = "Apri Scadenza Patente";
            this.btn_OpenScadPat.UseVisualStyleBackColor = true;
            this.btn_OpenScadPat.Click += new System.EventHandler(this.btn_OpenScadPat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "ATTENZIONE: una volta aperti i documenti è possibile\r\nmodificarli. Se si eliminan" +
                "o i tag (le parole tra <>) il documento\r\npotrebbe non venire stampato correttame" +
                "nte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_RestoreDoc
            // 
            this.btn_RestoreDoc.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_RestoreDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RestoreDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_RestoreDoc.Location = new System.Drawing.Point(171, 171);
            this.btn_RestoreDoc.Name = "btn_RestoreDoc";
            this.btn_RestoreDoc.Size = new System.Drawing.Size(135, 27);
            this.btn_RestoreDoc.TabIndex = 6;
            this.btn_RestoreDoc.Text = "Ripristina Originali";
            this.btn_RestoreDoc.UseVisualStyleBackColor = false;
            this.btn_RestoreDoc.Click += new System.EventHandler(this.btn_RestoreDoc_Click);
            // 
            // btn_ApriPag3Diabete
            // 
            this.btn_ApriPag3Diabete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriPag3Diabete.Location = new System.Drawing.Point(171, 138);
            this.btn_ApriPag3Diabete.Name = "btn_ApriPag3Diabete";
            this.btn_ApriPag3Diabete.Size = new System.Drawing.Size(135, 27);
            this.btn_ApriPag3Diabete.TabIndex = 5;
            this.btn_ApriPag3Diabete.Text = "Apri Pagina 3 Diabete";
            this.btn_ApriPag3Diabete.UseVisualStyleBackColor = true;
            this.btn_ApriPag3Diabete.Click += new System.EventHandler(this.btn_ApriPag3Diabete_Click);
            // 
            // btn_ApriCartellina
            // 
            this.btn_ApriCartellina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriCartellina.Location = new System.Drawing.Point(171, 105);
            this.btn_ApriCartellina.Name = "btn_ApriCartellina";
            this.btn_ApriCartellina.Size = new System.Drawing.Size(135, 27);
            this.btn_ApriCartellina.TabIndex = 4;
            this.btn_ApriCartellina.Text = "Apri Cartellina";
            this.btn_ApriCartellina.UseVisualStyleBackColor = true;
            this.btn_ApriCartellina.Click += new System.EventHandler(this.btn_ApriCartellina_Click);
            // 
            // btn_ApriPag1NoFoto
            // 
            this.btn_ApriPag1NoFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriPag1NoFoto.Location = new System.Drawing.Point(171, 72);
            this.btn_ApriPag1NoFoto.Name = "btn_ApriPag1NoFoto";
            this.btn_ApriPag1NoFoto.Size = new System.Drawing.Size(135, 27);
            this.btn_ApriPag1NoFoto.TabIndex = 3;
            this.btn_ApriPag1NoFoto.Text = "Apri Pagina 1 No-Foto";
            this.btn_ApriPag1NoFoto.UseVisualStyleBackColor = true;
            this.btn_ApriPag1NoFoto.Click += new System.EventHandler(this.btn_ApriPag1NoFoto_Click);
            // 
            // btn_ApriPag3
            // 
            this.btn_ApriPag3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriPag3.Location = new System.Drawing.Point(12, 138);
            this.btn_ApriPag3.Name = "btn_ApriPag3";
            this.btn_ApriPag3.Size = new System.Drawing.Size(135, 27);
            this.btn_ApriPag3.TabIndex = 2;
            this.btn_ApriPag3.Text = "Apri Pagina 3";
            this.btn_ApriPag3.UseVisualStyleBackColor = true;
            this.btn_ApriPag3.Click += new System.EventHandler(this.btn_ApriPag3_Click);
            // 
            // btn_ApriPag2
            // 
            this.btn_ApriPag2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriPag2.Location = new System.Drawing.Point(12, 105);
            this.btn_ApriPag2.Name = "btn_ApriPag2";
            this.btn_ApriPag2.Size = new System.Drawing.Size(135, 27);
            this.btn_ApriPag2.TabIndex = 1;
            this.btn_ApriPag2.Text = "Apri Pagina 2";
            this.btn_ApriPag2.UseVisualStyleBackColor = true;
            this.btn_ApriPag2.Click += new System.EventHandler(this.btn_ApriPag2_Click);
            // 
            // btn_ApriPag1
            // 
            this.btn_ApriPag1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriPag1.Location = new System.Drawing.Point(12, 72);
            this.btn_ApriPag1.Name = "btn_ApriPag1";
            this.btn_ApriPag1.Size = new System.Drawing.Size(135, 27);
            this.btn_ApriPag1.TabIndex = 0;
            this.btn_ApriPag1.Text = "Apri Pagina 1";
            this.btn_ApriPag1.UseVisualStyleBackColor = true;
            this.btn_ApriPag1.Click += new System.EventHandler(this.btn_ApriPag1_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurazione";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_OpenDButenti;
        private System.Windows.Forms.TextBox tbox_DbUtenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ApriPag1;
        private System.Windows.Forms.Button btn_RestoreDoc;
        private System.Windows.Forms.Button btn_ApriPag3Diabete;
        private System.Windows.Forms.Button btn_ApriCartellina;
        private System.Windows.Forms.Button btn_ApriPag1NoFoto;
        private System.Windows.Forms.Button btn_ApriPag3;
        private System.Windows.Forms.Button btn_ApriPag2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OpenScadPat;
    }
}