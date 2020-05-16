namespace Hospital
{
    partial class add_dialog_formpac
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.syndrombox = new System.Windows.Forms.TextBox();
            this.depbox = new System.Windows.Forms.ComboBox();
            this.Accept_but = new System.Windows.Forms.Button();
            this.cansel_but = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateadd = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateclose = new System.Windows.Forms.DateTimePicker();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.medbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Фамилия";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 64);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Отделение";
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Год рождения";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Диагноз";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(129, 38);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(260, 20);
            this.namebox.TabIndex = 1;
            // 
            // syndrombox
            // 
            this.syndrombox.Location = new System.Drawing.Point(129, 116);
            this.syndrombox.Name = "syndrombox";
            this.syndrombox.Size = new System.Drawing.Size(260, 20);
            this.syndrombox.TabIndex = 1;
            // 
            // depbox
            // 
            this.depbox.BackColor = System.Drawing.SystemColors.Window;
            this.depbox.DisplayMember = "name";
            this.depbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depbox.Location = new System.Drawing.Point(129, 63);
            this.depbox.Name = "depbox";
            this.depbox.Size = new System.Drawing.Size(260, 21);
            this.depbox.TabIndex = 2;
            this.depbox.ValueMember = "name";
            // 
            // Accept_but
            // 
            this.Accept_but.Location = new System.Drawing.Point(12, 194);
            this.Accept_but.Name = "Accept_but";
            this.Accept_but.Size = new System.Drawing.Size(75, 23);
            this.Accept_but.TabIndex = 3;
            this.Accept_but.Text = "Принять";
            this.Accept_but.UseVisualStyleBackColor = true;
            this.Accept_but.Click += new System.EventHandler(this.Accept_but_Click);
            // 
            // cansel_but
            // 
            this.cansel_but.Location = new System.Drawing.Point(129, 194);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.Size = new System.Drawing.Size(75, 23);
            this.cansel_but.TabIndex = 4;
            this.cansel_but.Text = "Отмена";
            this.cansel_but.UseVisualStyleBackColor = true;
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Дата приема";
            // 
            // dateadd
            // 
            this.dateadd.Location = new System.Drawing.Point(129, 142);
            this.dateadd.Name = "dateadd";
            this.dateadd.Size = new System.Drawing.Size(260, 20);
            this.dateadd.TabIndex = 6;
            this.dateadd.Value = new System.DateTime(2020, 5, 2, 0, 0, 0, 0);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 168);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Дата приема";
            // 
            // dateclose
            // 
            this.dateclose.Location = new System.Drawing.Point(129, 168);
            this.dateclose.Name = "dateclose";
            this.dateclose.Size = new System.Drawing.Size(260, 20);
            this.dateclose.TabIndex = 7;
            this.dateclose.Value = new System.DateTime(2020, 5, 2, 0, 0, 0, 0);
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(129, 90);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(260, 20);
            this.datebox.TabIndex = 8;
            this.datebox.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Номер мед.карты";
            // 
            // medbox
            // 
            this.medbox.Location = new System.Drawing.Point(129, 12);
            this.medbox.Mask = "000-000";
            this.medbox.Name = "medbox";
            this.medbox.Size = new System.Drawing.Size(260, 20);
            this.medbox.TabIndex = 9;
            // 
            // add_dialog_formpac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 227);
            this.Controls.Add(this.medbox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.dateclose);
            this.Controls.Add(this.dateadd);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.Accept_but);
            this.Controls.Add(this.depbox);
            this.Controls.Add(this.syndrombox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_dialog_formpac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.add_dialog_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.ComboBox depbox;
        private System.Windows.Forms.Button Accept_but;
        private System.Windows.Forms.Button cansel_but;
        public System.Windows.Forms.TextBox namebox;
        public System.Windows.Forms.TextBox syndrombox;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.DateTimePicker dateadd;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.DateTimePicker dateclose;
        public System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.MaskedTextBox medbox;
    }
}