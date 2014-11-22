namespace VillaUserManager
{
    partial class SearchTown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTown));
            this.Grid_ListaComuni = new System.Windows.Forms.DataGridView();
            this.tbox_ComuneDaCercare = new System.Windows.Forms.TextBox();
            this.btn_AvviaRicerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modif = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.comuneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListaComuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comuniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_ListaComuni
            // 
            this.Grid_ListaComuni.AllowUserToAddRows = false;
            this.Grid_ListaComuni.AllowUserToDeleteRows = false;
            this.Grid_ListaComuni.AutoGenerateColumns = false;
            this.Grid_ListaComuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ListaComuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ListaComuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comuneDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn});
            this.Grid_ListaComuni.DataSource = this.comuniBindingSource;
            this.Grid_ListaComuni.Location = new System.Drawing.Point(12, 56);
            this.Grid_ListaComuni.MultiSelect = false;
            this.Grid_ListaComuni.Name = "Grid_ListaComuni";
            this.Grid_ListaComuni.ReadOnly = true;
            this.Grid_ListaComuni.RowHeadersVisible = false;
            this.Grid_ListaComuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ListaComuni.Size = new System.Drawing.Size(268, 184);
            this.Grid_ListaComuni.TabIndex = 0;
            this.Grid_ListaComuni.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_ListaComuni_CellDoubleClick);
            this.Grid_ListaComuni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_ListaComuni_CellClick);
            // 
            // tbox_ComuneDaCercare
            // 
            this.tbox_ComuneDaCercare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_ComuneDaCercare.Location = new System.Drawing.Point(12, 30);
            this.tbox_ComuneDaCercare.MaxLength = 200;
            this.tbox_ComuneDaCercare.Name = "tbox_ComuneDaCercare";
            this.tbox_ComuneDaCercare.Size = new System.Drawing.Size(217, 20);
            this.tbox_ComuneDaCercare.TabIndex = 1;
            this.tbox_ComuneDaCercare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_ComuneDaCercare_KeyPress);
            // 
            // btn_AvviaRicerca
            // 
            this.btn_AvviaRicerca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AvviaRicerca.Image = ((System.Drawing.Image)(resources.GetObject("btn_AvviaRicerca.Image")));
            this.btn_AvviaRicerca.Location = new System.Drawing.Point(235, 30);
            this.btn_AvviaRicerca.Name = "btn_AvviaRicerca";
            this.btn_AvviaRicerca.Size = new System.Drawing.Size(45, 20);
            this.btn_AvviaRicerca.TabIndex = 2;
            this.btn_AvviaRicerca.UseVisualStyleBackColor = true;
            this.btn_AvviaRicerca.Click += new System.EventHandler(this.btn_AvviaRicerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cerca Comune:";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(12, 247);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(36, 24);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Modif
            // 
            this.btn_Modif.Enabled = false;
            this.btn_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modif.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modif.Image")));
            this.btn_Modif.Location = new System.Drawing.Point(54, 247);
            this.btn_Modif.Name = "btn_Modif";
            this.btn_Modif.Size = new System.Drawing.Size(36, 24);
            this.btn_Modif.TabIndex = 5;
            this.btn_Modif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Modif.UseVisualStyleBackColor = true;
            this.btn_Modif.Visible = false;
            this.btn_Modif.Click += new System.EventHandler(this.btn_Modif_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(180, 246);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 25);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // comuneDataGridViewTextBoxColumn
            // 
            this.comuneDataGridViewTextBoxColumn.DataPropertyName = "Comune";
            this.comuneDataGridViewTextBoxColumn.FillWeight = 180.9797F;
            this.comuneDataGridViewTextBoxColumn.HeaderText = "Comune";
            this.comuneDataGridViewTextBoxColumn.Name = "comuneDataGridViewTextBoxColumn";
            this.comuneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.FillWeight = 68.02031F;
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comuniBindingSource
            // 
            this.comuniBindingSource.DataSource = typeof(VillaUserManager.Comuni);
            // 
            // SearchTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 278);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Modif);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AvviaRicerca);
            this.Controls.Add(this.tbox_ComuneDaCercare);
            this.Controls.Add(this.Grid_ListaComuni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchTown";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ricerca Comune";
            this.Load += new System.EventHandler(this.SearchTown_Load);
            this.Shown += new System.EventHandler(this.SearchTown_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListaComuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comuniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_ListaComuni;
        private System.Windows.Forms.TextBox tbox_ComuneDaCercare;
        private System.Windows.Forms.Button btn_AvviaRicerca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Modif;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.BindingSource comuniBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
    }
}