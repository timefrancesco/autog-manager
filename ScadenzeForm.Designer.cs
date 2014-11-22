namespace VillaUserManager
{
    partial class ScadenzeForm
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
            this.grid_Utenti = new System.Windows.Forms.DataGridView();
            this.scadenzaPatenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPatenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaPatenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuneResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utentiScadenzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpbox = new System.Windows.Forms.GroupBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Utenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiScadenzaBindingSource)).BeginInit();
            this.gpbox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_Utenti
            // 
            this.grid_Utenti.AllowUserToAddRows = false;
            this.grid_Utenti.AllowUserToDeleteRows = false;
            this.grid_Utenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Utenti.AutoGenerateColumns = false;
            this.grid_Utenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Utenti.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid_Utenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Utenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scadenzaPatenteDataGridViewTextBoxColumn,
            this.numeroPatenteDataGridViewTextBoxColumn,
            this.categoriaPatenteDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.indirizzoDataGridViewTextBoxColumn,
            this.comuneResDataGridViewTextBoxColumn,
            this.provinciaResDataGridViewTextBoxColumn});
            this.grid_Utenti.DataSource = this.utentiScadenzaBindingSource;
            this.grid_Utenti.Location = new System.Drawing.Point(12, 12);
            this.grid_Utenti.Name = "grid_Utenti";
            this.grid_Utenti.ReadOnly = true;
            this.grid_Utenti.RowHeadersVisible = false;
            this.grid_Utenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Utenti.Size = new System.Drawing.Size(767, 399);
            this.grid_Utenti.TabIndex = 0;
            // 
            // scadenzaPatenteDataGridViewTextBoxColumn
            // 
            this.scadenzaPatenteDataGridViewTextBoxColumn.DataPropertyName = "ScadenzaPatente";
            this.scadenzaPatenteDataGridViewTextBoxColumn.HeaderText = "Scadenza";
            this.scadenzaPatenteDataGridViewTextBoxColumn.Name = "scadenzaPatenteDataGridViewTextBoxColumn";
            this.scadenzaPatenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPatenteDataGridViewTextBoxColumn
            // 
            this.numeroPatenteDataGridViewTextBoxColumn.DataPropertyName = "NumeroPatente";
            this.numeroPatenteDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroPatenteDataGridViewTextBoxColumn.Name = "numeroPatenteDataGridViewTextBoxColumn";
            this.numeroPatenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaPatenteDataGridViewTextBoxColumn
            // 
            this.categoriaPatenteDataGridViewTextBoxColumn.DataPropertyName = "CategoriaPatente";
            this.categoriaPatenteDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaPatenteDataGridViewTextBoxColumn.Name = "categoriaPatenteDataGridViewTextBoxColumn";
            this.categoriaPatenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indirizzoDataGridViewTextBoxColumn
            // 
            this.indirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.Name = "indirizzoDataGridViewTextBoxColumn";
            this.indirizzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comuneResDataGridViewTextBoxColumn
            // 
            this.comuneResDataGridViewTextBoxColumn.DataPropertyName = "ComuneRes";
            this.comuneResDataGridViewTextBoxColumn.HeaderText = "Comune";
            this.comuneResDataGridViewTextBoxColumn.Name = "comuneResDataGridViewTextBoxColumn";
            this.comuneResDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinciaResDataGridViewTextBoxColumn
            // 
            this.provinciaResDataGridViewTextBoxColumn.DataPropertyName = "ProvinciaRes";
            this.provinciaResDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaResDataGridViewTextBoxColumn.Name = "provinciaResDataGridViewTextBoxColumn";
            this.provinciaResDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utentiScadenzaBindingSource
            // 
            this.utentiScadenzaBindingSource.DataSource = typeof(VillaUserManager.UtentiScadenza);
            // 
            // gpbox
            // 
            this.gpbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbox.Controls.Add(this.btn_Print);
            this.gpbox.Controls.Add(this.btn_Open);
            this.gpbox.Location = new System.Drawing.Point(785, 7);
            this.gpbox.Name = "gpbox";
            this.gpbox.Size = new System.Drawing.Size(123, 404);
            this.gpbox.TabIndex = 1;
            this.gpbox.TabStop = false;
            this.gpbox.Text = "Strumenti";
            // 
            // btn_Print
            // 
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Location = new System.Drawing.Point(6, 48);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(111, 23);
            this.btn_Print.TabIndex = 1;
            this.btn_Print.Text = "Stampa Selezionati";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Open.Location = new System.Drawing.Point(6, 19);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(111, 23);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Apri Selezionati";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // ScadenzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gpbox);
            this.Controls.Add(this.grid_Utenti);
            this.Name = "ScadenzeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Patenti in scadenza";
            this.Load += new System.EventHandler(this.ScadenzeForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScadenzeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Utenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiScadenzaBindingSource)).EndInit();
            this.gpbox.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Utenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn scadenzaPatenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPatenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaPatenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaResDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource utentiScadenzaBindingSource;
        private System.Windows.Forms.GroupBox gpbox;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}