namespace VillaUserManager
{
    partial class SynchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynchForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_backup = new System.Windows.Forms.CheckBox();
            this.btn_Synch = new System.Windows.Forms.Button();
            this.bar_synchprogress = new System.Windows.Forms.ProgressBar();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_synchstatus = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbox_Status = new System.Windows.Forms.TextBox();
            this.chk_ComuniSynch = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_ComuniSynch);
            this.groupBox1.Controls.Add(this.tbox_Status);
            this.groupBox1.Controls.Add(this.lbl_synchstatus);
            this.groupBox1.Controls.Add(this.bar_synchprogress);
            this.groupBox1.Controls.Add(this.btn_Synch);
            this.groupBox1.Controls.Add(this.chk_backup);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chk_backup
            // 
            this.chk_backup.AutoSize = true;
            this.chk_backup.Checked = true;
            this.chk_backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_backup.Location = new System.Drawing.Point(111, 94);
            this.chk_backup.Name = "chk_backup";
            this.chk_backup.Size = new System.Drawing.Size(207, 17);
            this.chk_backup.TabIndex = 0;
            this.chk_backup.Text = "Esegui il backup prima di sincronizzare";
            this.chk_backup.UseVisualStyleBackColor = true;
            // 
            // btn_Synch
            // 
            this.btn_Synch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Synch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Synch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Synch.Image = ((System.Drawing.Image)(resources.GetObject("btn_Synch.Image")));
            this.btn_Synch.Location = new System.Drawing.Point(111, 19);
            this.btn_Synch.Name = "btn_Synch";
            this.btn_Synch.Size = new System.Drawing.Size(263, 69);
            this.btn_Synch.TabIndex = 1;
            this.btn_Synch.Text = "Avvia Sincronizzazione";
            this.btn_Synch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Synch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Synch.UseVisualStyleBackColor = true;
            this.btn_Synch.Click += new System.EventHandler(this.btn_Synch_Click);
            // 
            // bar_synchprogress
            // 
            this.bar_synchprogress.Location = new System.Drawing.Point(8, 142);
            this.bar_synchprogress.Name = "bar_synchprogress";
            this.bar_synchprogress.Size = new System.Drawing.Size(470, 23);
            this.bar_synchprogress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bar_synchprogress.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(414, 459);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Chiudi";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_synchstatus
            // 
            this.lbl_synchstatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_synchstatus.Location = new System.Drawing.Point(17, 168);
            this.lbl_synchstatus.Name = "lbl_synchstatus";
            this.lbl_synchstatus.Size = new System.Drawing.Size(450, 13);
            this.lbl_synchstatus.TabIndex = 3;
            this.lbl_synchstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_Status
            // 
            this.tbox_Status.BackColor = System.Drawing.Color.Black;
            this.tbox_Status.ForeColor = System.Drawing.Color.Lime;
            this.tbox_Status.Location = new System.Drawing.Point(6, 189);
            this.tbox_Status.Multiline = true;
            this.tbox_Status.Name = "tbox_Status";
            this.tbox_Status.ReadOnly = true;
            this.tbox_Status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_Status.Size = new System.Drawing.Size(470, 255);
            this.tbox_Status.TabIndex = 4;
            this.tbox_Status.Text = "Operazioni effettuate:";
            // 
            // chk_ComuniSynch
            // 
            this.chk_ComuniSynch.AutoSize = true;
            this.chk_ComuniSynch.Location = new System.Drawing.Point(111, 118);
            this.chk_ComuniSynch.Name = "chk_ComuniSynch";
            this.chk_ComuniSynch.Size = new System.Drawing.Size(237, 17);
            this.chk_ComuniSynch.TabIndex = 5;
            this.chk_ComuniSynch.Text = "Sincronizza Comuni (richiede MOLTO tempo)";
            this.chk_ComuniSynch.UseVisualStyleBackColor = true;
            // 
            // SynchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 494);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SynchForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar bar_synchprogress;
        private System.Windows.Forms.Button btn_Synch;
        private System.Windows.Forms.CheckBox chk_backup;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_synchstatus;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbox_Status;
        private System.Windows.Forms.CheckBox chk_ComuniSynch;
    }
}