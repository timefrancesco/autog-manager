namespace VillaUserManager
{
    partial class AddExam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_esito = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_cat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_Data = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_esito);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbox_cat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbox_Data);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbox_tipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbox_esito
            // 
            this.cbox_esito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_esito.FormattingEnabled = true;
            this.cbox_esito.Items.AddRange(new object[] {
            "IDONEO",
            "RESPINTO"});
            this.cbox_esito.Location = new System.Drawing.Point(61, 104);
            this.cbox_esito.Name = "cbox_esito";
            this.cbox_esito.Size = new System.Drawing.Size(142, 21);
            this.cbox_esito.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Esito:";
            // 
            // tbox_cat
            // 
            this.tbox_cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_cat.Location = new System.Drawing.Point(61, 75);
            this.tbox_cat.MaxLength = 5;
            this.tbox_cat.Name = "tbox_cat";
            this.tbox_cat.Size = new System.Drawing.Size(62, 20);
            this.tbox_cat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cat:";
            // 
            // tbox_Data
            // 
            this.tbox_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Data.Location = new System.Drawing.Point(61, 46);
            this.tbox_Data.MaxLength = 20;
            this.tbox_Data.Name = "tbox_Data";
            this.tbox_Data.Size = new System.Drawing.Size(142, 20);
            this.tbox_Data.TabIndex = 3;
            this.tbox_Data.Leave += new System.EventHandler(this.tbox_Data_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_tipo.FormattingEnabled = true;
            this.cbox_tipo.Items.AddRange(new object[] {
            "TEORIA",
            "GUIDA"});
            this.cbox_tipo.Location = new System.Drawing.Point(61, 16);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Size = new System.Drawing.Size(142, 21);
            this.cbox_tipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(144, 152);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Salva";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(3, 152);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Annulla";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 180);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi Esame";
            this.Load += new System.EventHandler(this.AddExam_Load);
            this.Shown += new System.EventHandler(this.AddExam_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_esito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
    }
}