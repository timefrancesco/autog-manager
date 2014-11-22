namespace VillaUserManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_AddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Synch = new System.Windows.Forms.ToolStripButton();
            this.btn_Backup = new System.Windows.Forms.ToolStripButton();
            this.btn_Options = new System.Windows.Forms.ToolStripButton();
            this.btn_Info = new System.Windows.Forms.ToolStripButton();
            this.tbox_Search = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo_NumPatente = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.rdo_Telefono = new System.Windows.Forms.RadioButton();
            this.rdo_ComResid = new System.Windows.Forms.RadioButton();
            this.rdo_Nome = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_Frosa = new System.Windows.Forms.CheckBox();
            this.chk_CAP = new System.Windows.Forms.CheckBox();
            this.chk_CQC = new System.Windows.Forms.CheckBox();
            this.chk_Patente = new System.Windows.Forms.CheckBox();
            this.btn_SearchScadenzaPat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cal_Adata = new System.Windows.Forms.DateTimePicker();
            this.cal_DaData = new System.Windows.Forms.DateTimePicker();
            this.tbox_categoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.table_UtentiTrovati = new System.Windows.Forms.DataGridView();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuneNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuneResidenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodiceFiscale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUtente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utenteCercatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_pat1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_patinscad = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_frosa1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_frosinscad = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstrip_InviaMail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_UtentiTrovati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utenteCercatoBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddUser,
            this.toolStripSeparator1,
            this.btn_Synch,
            this.btn_Backup,
            this.btn_Options,
            this.btn_Info});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 60);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Tool";
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddUser.Image")));
            this.btn_AddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_AddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(60, 57);
            this.btn_AddUser.Text = "Aggiungi";
            this.btn_AddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddUser.ToolTipText = "Aggiungi una nuova anagrafica";
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // btn_Synch
            // 
            this.btn_Synch.Image = ((System.Drawing.Image)(resources.GetObject("btn_Synch.Image")));
            this.btn_Synch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Synch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Synch.Name = "btn_Synch";
            this.btn_Synch.Size = new System.Drawing.Size(70, 57);
            this.btn_Synch.Text = "Sincronizza";
            this.btn_Synch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Synch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Synch.Click += new System.EventHandler(this.btn_Synch_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.Image = ((System.Drawing.Image)(resources.GetObject("btn_Backup.Image")));
            this.btn_Backup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Backup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(50, 57);
            this.btn_Backup.Text = "Backup";
            this.btn_Backup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Backup.ToolTipText = "Salva i Database";
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Options
            // 
            this.btn_Options.Image = ((System.Drawing.Image)(resources.GetObject("btn_Options.Image")));
            this.btn_Options.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Options.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Options.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(64, 57);
            this.btn_Options.Text = "Configura";
            this.btn_Options.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Options.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Image = ((System.Drawing.Image)(resources.GetObject("btn_Info.Image")));
            this.btn_Info.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Info.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(36, 57);
            this.btn_Info.Text = "Info";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Info.ToolTipText = "Informazioni";
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // tbox_Search
            // 
            this.tbox_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Search.Location = new System.Drawing.Point(6, 33);
            this.tbox_Search.Name = "tbox_Search";
            this.tbox_Search.Size = new System.Drawing.Size(386, 20);
            this.tbox_Search.TabIndex = 0;
            this.tbox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_Search_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 89);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rdo_NumPatente);
            this.tabPage1.Controls.Add(this.btn_Search);
            this.tabPage1.Controls.Add(this.rdo_Telefono);
            this.tabPage1.Controls.Add(this.rdo_ComResid);
            this.tabPage1.Controls.Add(this.rdo_Nome);
            this.tabPage1.Controls.Add(this.tbox_Search);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 63);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ricerca Anagrafica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inserisci il cognome da cercare:";
            // 
            // rdo_NumPatente
            // 
            this.rdo_NumPatente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdo_NumPatente.AutoSize = true;
            this.rdo_NumPatente.Location = new System.Drawing.Point(421, 36);
            this.rdo_NumPatente.Name = "rdo_NumPatente";
            this.rdo_NumPatente.Size = new System.Drawing.Size(113, 17);
            this.rdo_NumPatente.TabIndex = 6;
            this.rdo_NumPatente.Text = "Numero di Patente";
            this.rdo_NumPatente.UseVisualStyleBackColor = true;
            this.rdo_NumPatente.CheckedChanged += new System.EventHandler(this.rdo_NumPatente_CheckedChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(730, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(125, 40);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Tag = "";
            this.btn_Search.Text = "Cerca";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // rdo_Telefono
            // 
            this.rdo_Telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdo_Telefono.AutoSize = true;
            this.rdo_Telefono.Location = new System.Drawing.Point(557, 13);
            this.rdo_Telefono.Name = "rdo_Telefono";
            this.rdo_Telefono.Size = new System.Drawing.Size(67, 17);
            this.rdo_Telefono.TabIndex = 4;
            this.rdo_Telefono.Text = "Telefono";
            this.rdo_Telefono.UseVisualStyleBackColor = true;
            this.rdo_Telefono.CheckedChanged += new System.EventHandler(this.rdo_Telefono_CheckedChanged);
            // 
            // rdo_ComResid
            // 
            this.rdo_ComResid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdo_ComResid.AutoSize = true;
            this.rdo_ComResid.Location = new System.Drawing.Point(557, 36);
            this.rdo_ComResid.Name = "rdo_ComResid";
            this.rdo_ComResid.Size = new System.Drawing.Size(112, 17);
            this.rdo_ComResid.TabIndex = 3;
            this.rdo_ComResid.Text = "Comune residenza";
            this.rdo_ComResid.UseVisualStyleBackColor = true;
            this.rdo_ComResid.CheckedChanged += new System.EventHandler(this.rdo_ComResid_CheckedChanged);
            // 
            // rdo_Nome
            // 
            this.rdo_Nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdo_Nome.AutoSize = true;
            this.rdo_Nome.Checked = true;
            this.rdo_Nome.Location = new System.Drawing.Point(421, 13);
            this.rdo_Nome.Name = "rdo_Nome";
            this.rdo_Nome.Size = new System.Drawing.Size(70, 17);
            this.rdo_Nome.TabIndex = 2;
            this.rdo_Nome.TabStop = true;
            this.rdo_Nome.Text = "Cognome";
            this.rdo_Nome.UseVisualStyleBackColor = true;
            this.rdo_Nome.CheckedChanged += new System.EventHandler(this.rdo_Nome_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 54);
            this.panel1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chk_Frosa);
            this.tabPage2.Controls.Add(this.chk_CAP);
            this.tabPage2.Controls.Add(this.chk_CQC);
            this.tabPage2.Controls.Add(this.chk_Patente);
            this.tabPage2.Controls.Add(this.btn_SearchScadenzaPat);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 63);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ricerca Scadenza Patente";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // chk_Frosa
            // 
            this.chk_Frosa.AutoSize = true;
            this.chk_Frosa.Location = new System.Drawing.Point(570, 35);
            this.chk_Frosa.Name = "chk_Frosa";
            this.chk_Frosa.Size = new System.Drawing.Size(82, 17);
            this.chk_Frosa.TabIndex = 11;
            this.chk_Frosa.Text = "Foglio Rosa";
            this.chk_Frosa.UseVisualStyleBackColor = true;
            // 
            // chk_CAP
            // 
            this.chk_CAP.AutoSize = true;
            this.chk_CAP.Checked = true;
            this.chk_CAP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_CAP.Location = new System.Drawing.Point(570, 13);
            this.chk_CAP.Name = "chk_CAP";
            this.chk_CAP.Size = new System.Drawing.Size(47, 17);
            this.chk_CAP.TabIndex = 10;
            this.chk_CAP.Text = "KAP";
            this.chk_CAP.UseVisualStyleBackColor = true;
            // 
            // chk_CQC
            // 
            this.chk_CQC.AutoSize = true;
            this.chk_CQC.Checked = true;
            this.chk_CQC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_CQC.Location = new System.Drawing.Point(455, 37);
            this.chk_CQC.Name = "chk_CQC";
            this.chk_CQC.Size = new System.Drawing.Size(48, 17);
            this.chk_CQC.TabIndex = 9;
            this.chk_CQC.Text = "CQC";
            this.chk_CQC.UseVisualStyleBackColor = true;
            // 
            // chk_Patente
            // 
            this.chk_Patente.AutoSize = true;
            this.chk_Patente.Checked = true;
            this.chk_Patente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Patente.Location = new System.Drawing.Point(455, 14);
            this.chk_Patente.Name = "chk_Patente";
            this.chk_Patente.Size = new System.Drawing.Size(63, 17);
            this.chk_Patente.TabIndex = 8;
            this.chk_Patente.Text = "Patente";
            this.chk_Patente.UseVisualStyleBackColor = true;
            // 
            // btn_SearchScadenzaPat
            // 
            this.btn_SearchScadenzaPat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SearchScadenzaPat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchScadenzaPat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchScadenzaPat.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchScadenzaPat.Image")));
            this.btn_SearchScadenzaPat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchScadenzaPat.Location = new System.Drawing.Point(730, 13);
            this.btn_SearchScadenzaPat.Name = "btn_SearchScadenzaPat";
            this.btn_SearchScadenzaPat.Size = new System.Drawing.Size(125, 40);
            this.btn_SearchScadenzaPat.TabIndex = 7;
            this.btn_SearchScadenzaPat.Tag = "";
            this.btn_SearchScadenzaPat.Text = "Cerca";
            this.btn_SearchScadenzaPat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchScadenzaPat.UseVisualStyleBackColor = true;
            this.btn_SearchScadenzaPat.Click += new System.EventHandler(this.btn_SearchScadenzaPat_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Data:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Da Data:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cal_Adata);
            this.panel2.Controls.Add(this.cal_DaData);
            this.panel2.Controls.Add(this.tbox_categoria);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 54);
            this.panel2.TabIndex = 12;
            // 
            // cal_Adata
            // 
            this.cal_Adata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cal_Adata.Location = new System.Drawing.Point(168, 27);
            this.cal_Adata.Name = "cal_Adata";
            this.cal_Adata.Size = new System.Drawing.Size(111, 20);
            this.cal_Adata.TabIndex = 8;
            // 
            // cal_DaData
            // 
            this.cal_DaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cal_DaData.Location = new System.Drawing.Point(7, 27);
            this.cal_DaData.Name = "cal_DaData";
            this.cal_DaData.Size = new System.Drawing.Size(112, 20);
            this.cal_DaData.TabIndex = 7;
            // 
            // tbox_categoria
            // 
            this.tbox_categoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbox_categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_categoria.Location = new System.Drawing.Point(329, 27);
            this.tbox_categoria.Name = "tbox_categoria";
            this.tbox_categoria.Size = new System.Drawing.Size(50, 20);
            this.tbox_categoria.TabIndex = 6;
            this.tbox_categoria.Leave += new System.EventHandler(this.tbox_categoria_Leave);
            this.tbox_categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_categoria_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria:";
            // 
            // table_UtentiTrovati
            // 
            this.table_UtentiTrovati.AllowUserToAddRows = false;
            this.table_UtentiTrovati.AllowUserToDeleteRows = false;
            this.table_UtentiTrovati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.table_UtentiTrovati.AutoGenerateColumns = false;
            this.table_UtentiTrovati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_UtentiTrovati.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.table_UtentiTrovati.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_UtentiTrovati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_UtentiTrovati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cognomeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn,
            this.comuneNascitaDataGridViewTextBoxColumn,
            this.comuneResidenzaDataGridViewTextBoxColumn,
            this.indirizzoDataGridViewTextBoxColumn,
            this.CodiceFiscale,
            this.IdUtente});
            this.table_UtentiTrovati.DataSource = this.utenteCercatoBindingSource;
            this.table_UtentiTrovati.Location = new System.Drawing.Point(4, 151);
            this.table_UtentiTrovati.MultiSelect = false;
            this.table_UtentiTrovati.Name = "table_UtentiTrovati";
            this.table_UtentiTrovati.ReadOnly = true;
            this.table_UtentiTrovati.RowHeadersVisible = false;
            this.table_UtentiTrovati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_UtentiTrovati.Size = new System.Drawing.Size(877, 428);
            this.table_UtentiTrovati.TabIndex = 4;
            this.table_UtentiTrovati.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_UtentiTrovati_CellDoubleClick);
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            this.dataNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comuneNascitaDataGridViewTextBoxColumn
            // 
            this.comuneNascitaDataGridViewTextBoxColumn.DataPropertyName = "ComuneNascita";
            this.comuneNascitaDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.comuneNascitaDataGridViewTextBoxColumn.HeaderText = "ComuneNascita";
            this.comuneNascitaDataGridViewTextBoxColumn.Name = "comuneNascitaDataGridViewTextBoxColumn";
            this.comuneNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comuneResidenzaDataGridViewTextBoxColumn
            // 
            this.comuneResidenzaDataGridViewTextBoxColumn.DataPropertyName = "ComuneResidenza";
            this.comuneResidenzaDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.comuneResidenzaDataGridViewTextBoxColumn.HeaderText = "ComuneResidenza";
            this.comuneResidenzaDataGridViewTextBoxColumn.Name = "comuneResidenzaDataGridViewTextBoxColumn";
            this.comuneResidenzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indirizzoDataGridViewTextBoxColumn
            // 
            this.indirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.indirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.Name = "indirizzoDataGridViewTextBoxColumn";
            this.indirizzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CodiceFiscale
            // 
            this.CodiceFiscale.DataPropertyName = "CodiceFiscale";
            this.CodiceFiscale.FillWeight = 108.4844F;
            this.CodiceFiscale.HeaderText = "C.Fiscale";
            this.CodiceFiscale.Name = "CodiceFiscale";
            this.CodiceFiscale.ReadOnly = true;
            // 
            // IdUtente
            // 
            this.IdUtente.DataPropertyName = "IdUtente";
            this.IdUtente.FillWeight = 35F;
            this.IdUtente.HeaderText = "ID";
            this.IdUtente.Name = "IdUtente";
            this.IdUtente.ReadOnly = true;
            // 
            // utenteCercatoBindingSource
            // 
            this.utenteCercatoBindingSource.DataSource = typeof(VillaUserManager.UtenteCercato);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_pat1,
            this.lbl_patinscad,
            this.toolStripStatusLabel3,
            this.lbl_frosa1,
            this.lbl_frosinscad,
            this.toolStripSplitButton1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_pat1
            // 
            this.lbl_pat1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pat1.Name = "lbl_pat1";
            this.lbl_pat1.Size = new System.Drawing.Size(246, 13);
            this.lbl_pat1.Text = " Patenti in scadenza nei prossimi 30 giorni:";
            this.lbl_pat1.Click += new System.EventHandler(this.lbl_pat1_Click);
            // 
            // lbl_patinscad
            // 
            this.lbl_patinscad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patinscad.Name = "lbl_patinscad";
            this.lbl_patinscad.Size = new System.Drawing.Size(17, 13);
            this.lbl_patinscad.Text = "--";
            this.lbl_patinscad.Click += new System.EventHandler(this.lbl_patinscad_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 15);
            this.toolStripStatusLabel3.Text = ":::";
            // 
            // lbl_frosa1
            // 
            this.lbl_frosa1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frosa1.Name = "lbl_frosa1";
            this.lbl_frosa1.Size = new System.Drawing.Size(259, 13);
            this.lbl_frosa1.Text = "Fogli Rosa in scadenza nei prossimi 30 giorni:";
            this.lbl_frosa1.Click += new System.EventHandler(this.lbl_frosa1_Click);
            // 
            // lbl_frosinscad
            // 
            this.lbl_frosinscad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frosinscad.Name = "lbl_frosinscad";
            this.lbl_frosinscad.Size = new System.Drawing.Size(17, 13);
            this.lbl_frosinscad.Text = "--";
            this.lbl_frosinscad.Click += new System.EventHandler(this.lbl_frosinscad_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_InviaMail});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolstrip_InviaMail
            // 
            this.toolstrip_InviaMail.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_InviaMail.Image")));
            this.toolstrip_InviaMail.Name = "toolstrip_InviaMail";
            this.toolstrip_InviaMail.Size = new System.Drawing.Size(185, 22);
            this.toolstrip_InviaMail.Text = "Invia Comunicazione";
            this.toolstrip_InviaMail.Click += new System.EventHandler(this.toolstrip_InviaMail_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 604);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.table_UtentiTrovati);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoG Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_UtentiTrovati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utenteCercatoBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox tbox_Search;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton btn_AddUser;
        private System.Windows.Forms.ToolStripButton btn_Options;
        private System.Windows.Forms.ToolStripButton btn_Info;
        private System.Windows.Forms.RadioButton rdo_Telefono;
        private System.Windows.Forms.RadioButton rdo_ComResid;
        private System.Windows.Forms.RadioButton rdo_Nome;
        private System.Windows.Forms.DataGridView table_UtentiTrovati;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RadioButton rdo_NumPatente;
        private System.Windows.Forms.BindingSource utenteCercatoBindingSource;
        private System.Windows.Forms.TextBox tbox_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SearchScadenzaPat;
        private System.Windows.Forms.ToolStripButton btn_Backup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneResidenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodiceFiscale;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUtente;
        private System.Windows.Forms.ToolStripButton btn_Synch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_pat1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_patinscad;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbl_frosa1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_frosinscad;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_InviaMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_Frosa;
        private System.Windows.Forms.CheckBox chk_CAP;
        private System.Windows.Forms.CheckBox chk_CQC;
        private System.Windows.Forms.CheckBox chk_Patente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker cal_DaData;
        private System.Windows.Forms.DateTimePicker cal_Adata;
    }
}

