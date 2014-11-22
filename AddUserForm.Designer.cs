namespace VillaUserManager
{
    partial class AddUserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.tbox_Cognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Nome = new System.Windows.Forms.TextBox();
            this.cbox_Sesso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_DataNascita = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_ComuneNascita = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_CFiscale = new System.Windows.Forms.TextBox();
            this.btn_CalcolaCF = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_ComuneResid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_ProvNascita = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_ProvResid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_Indirizzo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbox_CAP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_num = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pbox_ProfilePic = new System.Windows.Forms.PictureBox();
            this.btn_SearchComune = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SearchComune2 = new System.Windows.Forms.Button();
            this.btn_RmvContatto = new System.Windows.Forms.Button();
            this.btn_AddContatto = new System.Windows.Forms.Button();
            this.table_Contatti = new System.Windows.Forms.DataGridView();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dlg_SelectPic = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Patenti = new System.Windows.Forms.TabPage();
            this.table_Patenti = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_RmvPatente = new System.Windows.Forms.Button();
            this.btn_AddPatente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tab_Esami = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_RmvExam = new System.Windows.Forms.Button();
            this.btn_AddExam = new System.Windows.Forms.Button();
            this.table_Esami = new System.Windows.Forms.DataGridView();
            this.btn_Print = new System.Windows.Forms.Button();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datascadenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarilascioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterilascioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contattoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataEsameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ProfilePic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Contatti)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_Patenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Patenti)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tab_Esami.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Esami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_Cognome
            // 
            this.tbox_Cognome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Cognome.Location = new System.Drawing.Point(91, 16);
            this.tbox_Cognome.MaxLength = 100;
            this.tbox_Cognome.Name = "tbox_Cognome";
            this.tbox_Cognome.Size = new System.Drawing.Size(296, 20);
            this.tbox_Cognome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cognome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // tbox_Nome
            // 
            this.tbox_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Nome.Location = new System.Drawing.Point(91, 44);
            this.tbox_Nome.MaxLength = 100;
            this.tbox_Nome.Name = "tbox_Nome";
            this.tbox_Nome.Size = new System.Drawing.Size(296, 20);
            this.tbox_Nome.TabIndex = 1;
            // 
            // cbox_Sesso
            // 
            this.cbox_Sesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Sesso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox_Sesso.FormattingEnabled = true;
            this.cbox_Sesso.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.cbox_Sesso.Location = new System.Drawing.Point(91, 71);
            this.cbox_Sesso.Name = "cbox_Sesso";
            this.cbox_Sesso.Size = new System.Drawing.Size(102, 21);
            this.cbox_Sesso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sesso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data di Nascita:";
            // 
            // tbox_DataNascita
            // 
            this.tbox_DataNascita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_DataNascita.Location = new System.Drawing.Point(293, 72);
            this.tbox_DataNascita.MaxLength = 12;
            this.tbox_DataNascita.Name = "tbox_DataNascita";
            this.tbox_DataNascita.Size = new System.Drawing.Size(94, 20);
            this.tbox_DataNascita.TabIndex = 3;
            this.tbox_DataNascita.Leave += new System.EventHandler(this.tbox_DataNascita_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nato a:";
            // 
            // tbox_ComuneNascita
            // 
            this.tbox_ComuneNascita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_ComuneNascita.Location = new System.Drawing.Point(91, 100);
            this.tbox_ComuneNascita.MaxLength = 100;
            this.tbox_ComuneNascita.Name = "tbox_ComuneNascita";
            this.tbox_ComuneNascita.Size = new System.Drawing.Size(157, 20);
            this.tbox_ComuneNascita.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codice Fiscale:";
            // 
            // tbox_CFiscale
            // 
            this.tbox_CFiscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_CFiscale.Location = new System.Drawing.Point(91, 132);
            this.tbox_CFiscale.MaxLength = 20;
            this.tbox_CFiscale.Name = "tbox_CFiscale";
            this.tbox_CFiscale.Size = new System.Drawing.Size(157, 20);
            this.tbox_CFiscale.TabIndex = 7;
            // 
            // btn_CalcolaCF
            // 
            this.btn_CalcolaCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CalcolaCF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CalcolaCF.Image = ((System.Drawing.Image)(resources.GetObject("btn_CalcolaCF.Image")));
            this.btn_CalcolaCF.Location = new System.Drawing.Point(254, 132);
            this.btn_CalcolaCF.Name = "btn_CalcolaCF";
            this.btn_CalcolaCF.Size = new System.Drawing.Size(34, 20);
            this.btn_CalcolaCF.TabIndex = 8;
            this.btn_CalcolaCF.UseVisualStyleBackColor = true;
            this.btn_CalcolaCF.Click += new System.EventHandler(this.btn_CalcolaCF_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comune:";
            // 
            // tbox_ComuneResid
            // 
            this.tbox_ComuneResid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_ComuneResid.Location = new System.Drawing.Point(91, 20);
            this.tbox_ComuneResid.MaxLength = 100;
            this.tbox_ComuneResid.Name = "tbox_ComuneResid";
            this.tbox_ComuneResid.Size = new System.Drawing.Size(223, 20);
            this.tbox_ComuneResid.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Prov:";
            // 
            // tbox_ProvNascita
            // 
            this.tbox_ProvNascita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_ProvNascita.Location = new System.Drawing.Point(347, 100);
            this.tbox_ProvNascita.MaxLength = 3;
            this.tbox_ProvNascita.Name = "tbox_ProvNascita";
            this.tbox_ProvNascita.Size = new System.Drawing.Size(40, 20);
            this.tbox_ProvNascita.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Provincia:";
            // 
            // tbox_ProvResid
            // 
            this.tbox_ProvResid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_ProvResid.Location = new System.Drawing.Point(450, 20);
            this.tbox_ProvResid.MaxLength = 3;
            this.tbox_ProvResid.Name = "tbox_ProvResid";
            this.tbox_ProvResid.Size = new System.Drawing.Size(47, 20);
            this.tbox_ProvResid.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Indirizzo:";
            // 
            // tbox_Indirizzo
            // 
            this.tbox_Indirizzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Indirizzo.Location = new System.Drawing.Point(91, 47);
            this.tbox_Indirizzo.MaxLength = 100;
            this.tbox_Indirizzo.Name = "tbox_Indirizzo";
            this.tbox_Indirizzo.Size = new System.Drawing.Size(263, 20);
            this.tbox_Indirizzo.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "CAP:";
            // 
            // tbox_CAP
            // 
            this.tbox_CAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_CAP.Location = new System.Drawing.Point(422, 47);
            this.tbox_CAP.MaxLength = 6;
            this.tbox_CAP.Name = "tbox_CAP";
            this.tbox_CAP.Size = new System.Drawing.Size(75, 20);
            this.tbox_CAP.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_num);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.pbox_ProfilePic);
            this.groupBox1.Controls.Add(this.btn_SearchComune);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbox_CFiscale);
            this.groupBox1.Controls.Add(this.tbox_ComuneNascita);
            this.groupBox1.Controls.Add(this.cbox_Sesso);
            this.groupBox1.Controls.Add(this.tbox_ProvNascita);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_CalcolaCF);
            this.groupBox1.Controls.Add(this.tbox_Nome);
            this.groupBox1.Controls.Add(this.tbox_Cognome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbox_DataNascita);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 164);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anagrafica";
            // 
            // tbox_num
            // 
            this.tbox_num.BackColor = System.Drawing.Color.PeachPuff;
            this.tbox_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_num.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tbox_num.Location = new System.Drawing.Point(347, 132);
            this.tbox_num.MaxLength = 3;
            this.tbox_num.Name = "tbox_num";
            this.tbox_num.ReadOnly = true;
            this.tbox_num.Size = new System.Drawing.Size(40, 20);
            this.tbox_num.TabIndex = 19;
            this.tbox_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Num:";
            // 
            // pbox_ProfilePic
            // 
            this.pbox_ProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_ProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_ProfilePic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbox_ProfilePic.ErrorImage")));
            this.pbox_ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbox_ProfilePic.Image")));
            this.pbox_ProfilePic.InitialImage = null;
            this.pbox_ProfilePic.Location = new System.Drawing.Point(393, 15);
            this.pbox_ProfilePic.Name = "pbox_ProfilePic";
            this.pbox_ProfilePic.Size = new System.Drawing.Size(118, 137);
            this.pbox_ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_ProfilePic.TabIndex = 18;
            this.pbox_ProfilePic.TabStop = false;
            this.pbox_ProfilePic.Click += new System.EventHandler(this.pbox_ProfilePic_Click);
            // 
            // btn_SearchComune
            // 
            this.btn_SearchComune.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchComune.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SearchComune.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchComune.Image")));
            this.btn_SearchComune.Location = new System.Drawing.Point(254, 100);
            this.btn_SearchComune.Name = "btn_SearchComune";
            this.btn_SearchComune.Size = new System.Drawing.Size(34, 20);
            this.btn_SearchComune.TabIndex = 5;
            this.btn_SearchComune.UseVisualStyleBackColor = true;
            this.btn_SearchComune.Click += new System.EventHandler(this.btn_SearchComune_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SearchComune2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbox_ComuneResid);
            this.groupBox2.Controls.Add(this.tbox_CAP);
            this.groupBox2.Controls.Add(this.tbox_Indirizzo);
            this.groupBox2.Controls.Add(this.tbox_ProvResid);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(9, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 77);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Residenza";
            // 
            // btn_SearchComune2
            // 
            this.btn_SearchComune2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchComune2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SearchComune2.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchComune2.Image")));
            this.btn_SearchComune2.Location = new System.Drawing.Point(320, 20);
            this.btn_SearchComune2.Name = "btn_SearchComune2";
            this.btn_SearchComune2.Size = new System.Drawing.Size(34, 20);
            this.btn_SearchComune2.TabIndex = 10;
            this.btn_SearchComune2.UseVisualStyleBackColor = true;
            this.btn_SearchComune2.Click += new System.EventHandler(this.btn_SearchComune2_Click);
            // 
            // btn_RmvContatto
            // 
            this.btn_RmvContatto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RmvContatto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RmvContatto.Image = ((System.Drawing.Image)(resources.GetObject("btn_RmvContatto.Image")));
            this.btn_RmvContatto.Location = new System.Drawing.Point(112, 180);
            this.btn_RmvContatto.Name = "btn_RmvContatto";
            this.btn_RmvContatto.Size = new System.Drawing.Size(60, 26);
            this.btn_RmvContatto.TabIndex = 26;
            this.btn_RmvContatto.UseVisualStyleBackColor = true;
            this.btn_RmvContatto.Click += new System.EventHandler(this.btn_RmvContatto_Click);
            // 
            // btn_AddContatto
            // 
            this.btn_AddContatto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddContatto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddContatto.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddContatto.Image")));
            this.btn_AddContatto.Location = new System.Drawing.Point(49, 180);
            this.btn_AddContatto.Name = "btn_AddContatto";
            this.btn_AddContatto.Size = new System.Drawing.Size(57, 26);
            this.btn_AddContatto.TabIndex = 15;
            this.btn_AddContatto.UseVisualStyleBackColor = true;
            this.btn_AddContatto.Click += new System.EventHandler(this.btn_AddContatto_Click);
            // 
            // table_Contatti
            // 
            this.table_Contatti.AllowUserToAddRows = false;
            this.table_Contatti.AllowUserToDeleteRows = false;
            this.table_Contatti.AutoGenerateColumns = false;
            this.table_Contatti.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.table_Contatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Contatti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn1,
            this.tipoDataGridViewTextBoxColumn1});
            this.table_Contatti.DataSource = this.contattoBindingSource;
            this.table_Contatti.Location = new System.Drawing.Point(6, 20);
            this.table_Contatti.Name = "table_Contatti";
            this.table_Contatti.ReadOnly = true;
            this.table_Contatti.RowHeadersVisible = false;
            this.table_Contatti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Contatti.Size = new System.Drawing.Size(166, 152);
            this.table_Contatti.TabIndex = 23;
            this.table_Contatti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Contatti_CellDoubleClick);
            this.table_Contatti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Contatti_CellClick);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(413, 517);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(114, 26);
            this.Btn_Save.TabIndex = 17;
            this.Btn_Save.Text = "Salva e Chiudi";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(9, 517);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 26);
            this.btn_Exit.TabIndex = 29;
            this.btn_Exit.Text = "Annulla";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dlg_SelectPic
            // 
            this.dlg_SelectPic.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Patenti);
            this.tabControl1.Controls.Add(this.tab_Esami);
            this.tabControl1.Location = new System.Drawing.Point(8, 260);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 247);
            this.tabControl1.TabIndex = 25;
            // 
            // tab_Patenti
            // 
            this.tab_Patenti.Controls.Add(this.table_Patenti);
            this.tab_Patenti.Controls.Add(this.groupBox3);
            this.tab_Patenti.Controls.Add(this.groupBox4);
            this.tab_Patenti.Location = new System.Drawing.Point(4, 22);
            this.tab_Patenti.Name = "tab_Patenti";
            this.tab_Patenti.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Patenti.Size = new System.Drawing.Size(511, 221);
            this.tab_Patenti.TabIndex = 0;
            this.tab_Patenti.Text = "Documenti e Contatti";
            this.tab_Patenti.UseVisualStyleBackColor = true;
            // 
            // table_Patenti
            // 
            this.table_Patenti.AllowUserToAddRows = false;
            this.table_Patenti.AllowUserToDeleteRows = false;
            this.table_Patenti.AutoGenerateColumns = false;
            this.table_Patenti.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.table_Patenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Patenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.datascadenzaDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.datarilascioDataGridViewTextBoxColumn,
            this.enterilascioDataGridViewTextBoxColumn});
            this.table_Patenti.DataSource = this.patenteBindingSource;
            this.table_Patenti.Location = new System.Drawing.Point(11, 26);
            this.table_Patenti.Name = "table_Patenti";
            this.table_Patenti.ReadOnly = true;
            this.table_Patenti.RowHeadersVisible = false;
            this.table_Patenti.RowHeadersWidth = 10;
            this.table_Patenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Patenti.Size = new System.Drawing.Size(303, 152);
            this.table_Patenti.TabIndex = 23;
            this.table_Patenti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Patenti_CellDoubleClick);
            this.table_Patenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Patenti_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_RmvPatente);
            this.groupBox3.Controls.Add(this.btn_AddPatente);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 212);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patenti e Fogli Rosa";
            // 
            // btn_RmvPatente
            // 
            this.btn_RmvPatente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RmvPatente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RmvPatente.Image = ((System.Drawing.Image)(resources.GetObject("btn_RmvPatente.Image")));
            this.btn_RmvPatente.Location = new System.Drawing.Point(75, 178);
            this.btn_RmvPatente.Name = "btn_RmvPatente";
            this.btn_RmvPatente.Size = new System.Drawing.Size(60, 26);
            this.btn_RmvPatente.TabIndex = 24;
            this.btn_RmvPatente.UseVisualStyleBackColor = true;
            this.btn_RmvPatente.Click += new System.EventHandler(this.btn_RmvPatente_Click);
            // 
            // btn_AddPatente
            // 
            this.btn_AddPatente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddPatente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddPatente.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddPatente.Image")));
            this.btn_AddPatente.Location = new System.Drawing.Point(9, 178);
            this.btn_AddPatente.Name = "btn_AddPatente";
            this.btn_AddPatente.Size = new System.Drawing.Size(60, 26);
            this.btn_AddPatente.TabIndex = 14;
            this.btn_AddPatente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AddPatente.UseVisualStyleBackColor = true;
            this.btn_AddPatente.Click += new System.EventHandler(this.btn_AddPatente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_RmvContatto);
            this.groupBox4.Controls.Add(this.table_Contatti);
            this.groupBox4.Controls.Add(this.btn_AddContatto);
            this.groupBox4.Location = new System.Drawing.Point(333, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 212);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contatti";
            // 
            // tab_Esami
            // 
            this.tab_Esami.Controls.Add(this.groupBox5);
            this.tab_Esami.Location = new System.Drawing.Point(4, 22);
            this.tab_Esami.Name = "tab_Esami";
            this.tab_Esami.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Esami.Size = new System.Drawing.Size(511, 221);
            this.tab_Esami.TabIndex = 1;
            this.tab_Esami.Text = "Esami";
            this.tab_Esami.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_RmvExam);
            this.groupBox5.Controls.Add(this.btn_AddExam);
            this.groupBox5.Controls.Add(this.table_Esami);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 209);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elenco Esami";
            // 
            // btn_RmvExam
            // 
            this.btn_RmvExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RmvExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RmvExam.Image = ((System.Drawing.Image)(resources.GetObject("btn_RmvExam.Image")));
            this.btn_RmvExam.Location = new System.Drawing.Point(337, 180);
            this.btn_RmvExam.Name = "btn_RmvExam";
            this.btn_RmvExam.Size = new System.Drawing.Size(75, 23);
            this.btn_RmvExam.TabIndex = 2;
            this.btn_RmvExam.UseVisualStyleBackColor = true;
            this.btn_RmvExam.Click += new System.EventHandler(this.btn_RmvExam_Click);
            // 
            // btn_AddExam
            // 
            this.btn_AddExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddExam.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddExam.Image")));
            this.btn_AddExam.Location = new System.Drawing.Point(418, 180);
            this.btn_AddExam.Name = "btn_AddExam";
            this.btn_AddExam.Size = new System.Drawing.Size(75, 23);
            this.btn_AddExam.TabIndex = 1;
            this.btn_AddExam.UseVisualStyleBackColor = true;
            this.btn_AddExam.Click += new System.EventHandler(this.btn_AddExam_Click);
            // 
            // table_Esami
            // 
            this.table_Esami.AllowUserToAddRows = false;
            this.table_Esami.AllowUserToDeleteRows = false;
            this.table_Esami.AutoGenerateColumns = false;
            this.table_Esami.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Esami.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.table_Esami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Esami.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataEsameDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn2,
            this.categoriaDataGridViewTextBoxColumn1,
            this.esitoDataGridViewTextBoxColumn});
            this.table_Esami.DataSource = this.esameBindingSource;
            this.table_Esami.Location = new System.Drawing.Point(6, 19);
            this.table_Esami.Name = "table_Esami";
            this.table_Esami.ReadOnly = true;
            this.table_Esami.RowHeadersVisible = false;
            this.table_Esami.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Esami.Size = new System.Drawing.Size(487, 155);
            this.table_Esami.TabIndex = 0;
            this.table_Esami.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Esami_CellDoubleClick);
            this.table_Esami.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Esami_CellClick);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(214, 517);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(114, 26);
            this.btn_Print.TabIndex = 16;
            this.btn_Print.Text = "Stampa";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datascadenzaDataGridViewTextBoxColumn
            // 
            this.datascadenzaDataGridViewTextBoxColumn.DataPropertyName = "datascadenza";
            this.datascadenzaDataGridViewTextBoxColumn.HeaderText = "Scadenza";
            this.datascadenzaDataGridViewTextBoxColumn.Name = "datascadenzaDataGridViewTextBoxColumn";
            this.datascadenzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Cat";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datarilascioDataGridViewTextBoxColumn
            // 
            this.datarilascioDataGridViewTextBoxColumn.DataPropertyName = "datarilascio";
            this.datarilascioDataGridViewTextBoxColumn.HeaderText = "Rilasciata";
            this.datarilascioDataGridViewTextBoxColumn.Name = "datarilascioDataGridViewTextBoxColumn";
            this.datarilascioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enterilascioDataGridViewTextBoxColumn
            // 
            this.enterilascioDataGridViewTextBoxColumn.DataPropertyName = "enterilascio";
            this.enterilascioDataGridViewTextBoxColumn.HeaderText = "Ente";
            this.enterilascioDataGridViewTextBoxColumn.Name = "enterilascioDataGridViewTextBoxColumn";
            this.enterilascioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patenteBindingSource
            // 
            this.patenteBindingSource.DataSource = typeof(VillaUserManager.Patente);
            // 
            // numeroDataGridViewTextBoxColumn1
            // 
            this.numeroDataGridViewTextBoxColumn1.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn1.HeaderText = "Contatto";
            this.numeroDataGridViewTextBoxColumn1.Name = "numeroDataGridViewTextBoxColumn1";
            this.numeroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn1
            // 
            this.tipoDataGridViewTextBoxColumn1.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.Name = "tipoDataGridViewTextBoxColumn1";
            this.tipoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // contattoBindingSource
            // 
            this.contattoBindingSource.DataSource = typeof(VillaUserManager.Contatto);
            // 
            // dataEsameDataGridViewTextBoxColumn
            // 
            this.dataEsameDataGridViewTextBoxColumn.DataPropertyName = "DataEsame";
            this.dataEsameDataGridViewTextBoxColumn.FillWeight = 92.7242F;
            this.dataEsameDataGridViewTextBoxColumn.HeaderText = "Data Esame";
            this.dataEsameDataGridViewTextBoxColumn.Name = "dataEsameDataGridViewTextBoxColumn";
            this.dataEsameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn2
            // 
            this.tipoDataGridViewTextBoxColumn2.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn2.FillWeight = 92.7242F;
            this.tipoDataGridViewTextBoxColumn2.HeaderText = "Tipo Esame";
            this.tipoDataGridViewTextBoxColumn2.Name = "tipoDataGridViewTextBoxColumn2";
            this.tipoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn1
            // 
            this.categoriaDataGridViewTextBoxColumn1.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.categoriaDataGridViewTextBoxColumn1.HeaderText = "Cat";
            this.categoriaDataGridViewTextBoxColumn1.Name = "categoriaDataGridViewTextBoxColumn1";
            this.categoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // esitoDataGridViewTextBoxColumn
            // 
            this.esitoDataGridViewTextBoxColumn.DataPropertyName = "Esito";
            this.esitoDataGridViewTextBoxColumn.FillWeight = 92.7242F;
            this.esitoDataGridViewTextBoxColumn.HeaderText = "Esito";
            this.esitoDataGridViewTextBoxColumn.Name = "esitoDataGridViewTextBoxColumn";
            this.esitoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // esameBindingSource
            // 
            this.esameBindingSource.DataSource = typeof(VillaUserManager.Esame);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 552);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi Anagrafica";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.Shown += new System.EventHandler(this.AddUserForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ProfilePic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Contatti)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_Patenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Patenti)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tab_Esami.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Esami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Cognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Nome;
        private System.Windows.Forms.ComboBox cbox_Sesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_DataNascita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_ComuneNascita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_CFiscale;
        private System.Windows.Forms.Button btn_CalcolaCF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_ComuneResid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_ProvNascita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_ProvResid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Indirizzo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbox_CAP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView table_Contatti;
        private System.Windows.Forms.Button btn_RmvContatto;
        private System.Windows.Forms.Button btn_AddContatto;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SearchComune;
        private System.Windows.Forms.Button btn_SearchComune2;
        private System.Windows.Forms.PictureBox pbox_ProfilePic;
        private System.Windows.Forms.OpenFileDialog dlg_SelectPic;
        private System.Windows.Forms.BindingSource patenteBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Patenti;
        private System.Windows.Forms.DataGridView table_Patenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datascadenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarilascioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterilascioDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_RmvPatente;
        private System.Windows.Forms.Button btn_AddPatente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tab_Esami;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_RmvExam;
        private System.Windows.Forms.Button btn_AddExam;
        private System.Windows.Forms.DataGridView table_Esami;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource contattoBindingSource;
        private System.Windows.Forms.BindingSource esameBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEsameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.TextBox tbox_num;
        private System.Windows.Forms.Label label12;
    }
}