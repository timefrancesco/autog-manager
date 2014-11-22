namespace VillaUserManager
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_avvia = new System.Windows.Forms.Button();
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.tbox_destpath = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_attendere = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.chk_ResorePic = new System.Windows.Forms.CheckBox();
            this.chk_restoreComun = new System.Windows.Forms.CheckBox();
            this.chk_restoreUser = new System.Windows.Forms.CheckBox();
            this.btn_selectfiletorestore = new System.Windows.Forms.Button();
            this.tbox_filetorestore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_avvia);
            this.groupBox1.Controls.Add(this.btn_OpenFolder);
            this.groupBox1.Controls.Add(this.tbox_destpath);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cartella di destinazione:";
            // 
            // btn_avvia
            // 
            this.btn_avvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avvia.Location = new System.Drawing.Point(77, 82);
            this.btn_avvia.Name = "btn_avvia";
            this.btn_avvia.Size = new System.Drawing.Size(121, 48);
            this.btn_avvia.TabIndex = 5;
            this.btn_avvia.Text = "Avvia";
            this.btn_avvia.UseVisualStyleBackColor = true;
            this.btn_avvia.Click += new System.EventHandler(this.btn_avvia_Click);
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenFolder.Image")));
            this.btn_OpenFolder.Location = new System.Drawing.Point(236, 44);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(31, 20);
            this.btn_OpenFolder.TabIndex = 4;
            this.btn_OpenFolder.UseVisualStyleBackColor = true;
            this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFolder_Click);
            // 
            // tbox_destpath
            // 
            this.tbox_destpath.Location = new System.Drawing.Point(8, 44);
            this.tbox_destpath.Name = "tbox_destpath";
            this.tbox_destpath.Size = new System.Drawing.Size(222, 20);
            this.tbox_destpath.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(203, 201);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(91, 30);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_attendere
            // 
            this.lbl_attendere.AutoSize = true;
            this.lbl_attendere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attendere.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_attendere.Location = new System.Drawing.Point(17, 209);
            this.lbl_attendere.Name = "lbl_attendere";
            this.lbl_attendere.Size = new System.Drawing.Size(166, 13);
            this.lbl_attendere.TabIndex = 2;
            this.lbl_attendere.Text = "Attendere - Backup in corso";
            this.lbl_attendere.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 188);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(285, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(285, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ripristina";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Restore);
            this.groupBox3.Controls.Add(this.chk_ResorePic);
            this.groupBox3.Controls.Add(this.chk_restoreComun);
            this.groupBox3.Controls.Add(this.chk_restoreUser);
            this.groupBox3.Controls.Add(this.btn_selectfiletorestore);
            this.groupBox3.Controls.Add(this.tbox_filetorestore);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ripristina Backup";
            // 
            // btn_Restore
            // 
            this.btn_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restore.ForeColor = System.Drawing.Color.Red;
            this.btn_Restore.Location = new System.Drawing.Point(172, 87);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(96, 40);
            this.btn_Restore.TabIndex = 12;
            this.btn_Restore.Text = "Avvia";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // chk_ResorePic
            // 
            this.chk_ResorePic.AutoSize = true;
            this.chk_ResorePic.Checked = true;
            this.chk_ResorePic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ResorePic.Location = new System.Drawing.Point(12, 110);
            this.chk_ResorePic.Name = "chk_ResorePic";
            this.chk_ResorePic.Size = new System.Drawing.Size(119, 17);
            this.chk_ResorePic.TabIndex = 11;
            this.chk_ResorePic.Text = "Ripristina Fotografie";
            this.chk_ResorePic.UseVisualStyleBackColor = true;
            // 
            // chk_restoreComun
            // 
            this.chk_restoreComun.AutoSize = true;
            this.chk_restoreComun.Checked = true;
            this.chk_restoreComun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_restoreComun.Location = new System.Drawing.Point(12, 87);
            this.chk_restoreComun.Name = "chk_restoreComun";
            this.chk_restoreComun.Size = new System.Drawing.Size(107, 17);
            this.chk_restoreComun.TabIndex = 10;
            this.chk_restoreComun.Text = "Ripristina Comuni";
            this.chk_restoreComun.UseVisualStyleBackColor = true;
            // 
            // chk_restoreUser
            // 
            this.chk_restoreUser.AutoSize = true;
            this.chk_restoreUser.Checked = true;
            this.chk_restoreUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_restoreUser.Location = new System.Drawing.Point(12, 64);
            this.chk_restoreUser.Name = "chk_restoreUser";
            this.chk_restoreUser.Size = new System.Drawing.Size(100, 17);
            this.chk_restoreUser.TabIndex = 9;
            this.chk_restoreUser.Text = "Ripristina Utenti";
            this.chk_restoreUser.UseVisualStyleBackColor = true;
            // 
            // btn_selectfiletorestore
            // 
            this.btn_selectfiletorestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectfiletorestore.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectfiletorestore.Image")));
            this.btn_selectfiletorestore.Location = new System.Drawing.Point(235, 37);
            this.btn_selectfiletorestore.Name = "btn_selectfiletorestore";
            this.btn_selectfiletorestore.Size = new System.Drawing.Size(33, 20);
            this.btn_selectfiletorestore.TabIndex = 8;
            this.btn_selectfiletorestore.UseVisualStyleBackColor = true;
            this.btn_selectfiletorestore.Click += new System.EventHandler(this.btn_selectfiletorestore_Click);
            // 
            // tbox_filetorestore
            // 
            this.tbox_filetorestore.Location = new System.Drawing.Point(12, 37);
            this.tbox_filetorestore.Name = "tbox_filetorestore";
            this.tbox_filetorestore.Size = new System.Drawing.Size(217, 20);
            this.tbox_filetorestore.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File di Backup:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 237);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_attendere);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BackupForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_avvia;
        private System.Windows.Forms.Button btn_OpenFolder;
        private System.Windows.Forms.TextBox tbox_destpath;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbl_attendere;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.CheckBox chk_ResorePic;
        private System.Windows.Forms.CheckBox chk_restoreComun;
        private System.Windows.Forms.CheckBox chk_restoreUser;
        private System.Windows.Forms.Button btn_selectfiletorestore;
        private System.Windows.Forms.TextBox tbox_filetorestore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}