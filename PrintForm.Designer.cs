namespace VillaUserManager
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_StampaCertificato = new System.Windows.Forms.Button();
            this.btn_ApriCertficato = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_doc = new System.Windows.Forms.ComboBox();
            this.chk_diabete = new System.Windows.Forms.CheckBox();
            this.tbox_cat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_tipo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ApriCartellina = new System.Windows.Forms.Button();
            this.btn_Stampa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 206);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_StampaCertificato);
            this.tabPage1.Controls.Add(this.btn_ApriCertficato);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbox_doc);
            this.tabPage1.Controls.Add(this.chk_diabete);
            this.tabPage1.Controls.Add(this.tbox_cat);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbox_tipo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Certificato Medico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_StampaCertificato
            // 
            this.btn_StampaCertificato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StampaCertificato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StampaCertificato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StampaCertificato.Image = ((System.Drawing.Image)(resources.GetObject("btn_StampaCertificato.Image")));
            this.btn_StampaCertificato.Location = new System.Drawing.Point(150, 97);
            this.btn_StampaCertificato.Name = "btn_StampaCertificato";
            this.btn_StampaCertificato.Size = new System.Drawing.Size(123, 75);
            this.btn_StampaCertificato.TabIndex = 8;
            this.btn_StampaCertificato.Text = "Stampa Certificato";
            this.btn_StampaCertificato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_StampaCertificato.UseVisualStyleBackColor = true;
            this.btn_StampaCertificato.Click += new System.EventHandler(this.btn_StampaCertificato_Click);
            // 
            // btn_ApriCertficato
            // 
            this.btn_ApriCertficato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ApriCertficato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriCertficato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApriCertficato.Image = ((System.Drawing.Image)(resources.GetObject("btn_ApriCertficato.Image")));
            this.btn_ApriCertficato.Location = new System.Drawing.Point(6, 97);
            this.btn_ApriCertficato.Name = "btn_ApriCertficato";
            this.btn_ApriCertficato.Size = new System.Drawing.Size(122, 75);
            this.btn_ApriCertficato.TabIndex = 7;
            this.btn_ApriCertficato.Text = "Apri Certificato";
            this.btn_ApriCertficato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ApriCertficato.UseVisualStyleBackColor = true;
            this.btn_ApriCertficato.Click += new System.EventHandler(this.btn_ApriCertficato_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stampa per:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Documento:";
            // 
            // cbox_doc
            // 
            this.cbox_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_doc.FormattingEnabled = true;
            this.cbox_doc.Location = new System.Drawing.Point(6, 66);
            this.cbox_doc.Name = "cbox_doc";
            this.cbox_doc.Size = new System.Drawing.Size(160, 21);
            this.cbox_doc.TabIndex = 4;
            // 
            // chk_diabete
            // 
            this.chk_diabete.AutoSize = true;
            this.chk_diabete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_diabete.Location = new System.Drawing.Point(202, 69);
            this.chk_diabete.Name = "chk_diabete";
            this.chk_diabete.Size = new System.Drawing.Size(68, 17);
            this.chk_diabete.TabIndex = 3;
            this.chk_diabete.Text = "Diabetico";
            this.chk_diabete.UseVisualStyleBackColor = true;
            // 
            // tbox_cat
            // 
            this.tbox_cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_cat.Location = new System.Drawing.Point(202, 27);
            this.tbox_cat.Name = "tbox_cat";
            this.tbox_cat.Size = new System.Drawing.Size(65, 20);
            this.tbox_cat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cat:";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_tipo.Items.AddRange(new object[] {
            "CONSEGUIMENTO",
            "RINNOVO",
            "DUPLICATO",
            "DUPLICATO NOFOTO"});
            this.cbox_tipo.Location = new System.Drawing.Point(6, 26);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Size = new System.Drawing.Size(160, 21);
            this.cbox_tipo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ApriCartellina);
            this.tabPage2.Controls.Add(this.btn_Stampa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(279, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cartellina";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ApriCartellina
            // 
            this.btn_ApriCartellina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ApriCartellina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ApriCartellina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApriCartellina.Image = ((System.Drawing.Image)(resources.GetObject("btn_ApriCartellina.Image")));
            this.btn_ApriCartellina.Location = new System.Drawing.Point(6, 6);
            this.btn_ApriCartellina.Name = "btn_ApriCartellina";
            this.btn_ApriCartellina.Size = new System.Drawing.Size(267, 75);
            this.btn_ApriCartellina.TabIndex = 1;
            this.btn_ApriCartellina.Text = "Apri Cartellina";
            this.btn_ApriCartellina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ApriCartellina.UseVisualStyleBackColor = true;
            this.btn_ApriCartellina.Click += new System.EventHandler(this.btn_ApriCartellina_Click);
            // 
            // btn_Stampa
            // 
            this.btn_Stampa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stampa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Stampa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stampa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stampa.Image")));
            this.btn_Stampa.Location = new System.Drawing.Point(6, 99);
            this.btn_Stampa.Name = "btn_Stampa";
            this.btn_Stampa.Size = new System.Drawing.Size(267, 75);
            this.btn_Stampa.TabIndex = 0;
            this.btn_Stampa.Text = "Stampa Cartellina";
            this.btn_Stampa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Stampa.UseVisualStyleBackColor = true;
            this.btn_Stampa.Click += new System.EventHandler(this.btn_Stampa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chiudi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_Status.Location = new System.Drawing.Point(3, 220);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(41, 13);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "label2";
            this.lbl_Status.Visible = false;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 243);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrintForm";
            this.ShowInTaskbar = false;
            this.Text = "Stampa";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Stampa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_ApriCartellina;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_StampaCertificato;
        private System.Windows.Forms.Button btn_ApriCertficato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_doc;
        private System.Windows.Forms.CheckBox chk_diabete;
        private System.Windows.Forms.TextBox tbox_cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_tipo;
    }
}