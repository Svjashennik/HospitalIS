namespace Hospital
{
    partial class add_dep_form
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
            this.cansel_but = new System.Windows.Forms.Button();
            this.Accept_but = new System.Windows.Forms.Button();
            this.maximumbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox = new System.Windows.Forms.TextBox();
            this.managerbox = new System.Windows.Forms.TextBox();
            this.phonebox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cansel_but
            // 
            this.cansel_but.Location = new System.Drawing.Point(143, 139);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.Size = new System.Drawing.Size(75, 23);
            this.cansel_but.TabIndex = 14;
            this.cansel_but.Text = "Отмена";
            this.cansel_but.UseVisualStyleBackColor = true;
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // Accept_but
            // 
            this.Accept_but.Location = new System.Drawing.Point(12, 139);
            this.Accept_but.Name = "Accept_but";
            this.Accept_but.Size = new System.Drawing.Size(75, 23);
            this.Accept_but.TabIndex = 13;
            this.Accept_but.Text = "Принять";
            this.Accept_but.UseVisualStyleBackColor = true;
            this.Accept_but.Click += new System.EventHandler(this.Accept_but_Click);
            // 
            // maximumbox
            // 
            this.maximumbox.Location = new System.Drawing.Point(143, 64);
            this.maximumbox.Name = "maximumbox";
            this.maximumbox.Size = new System.Drawing.Size(131, 20);
            this.maximumbox.TabIndex = 10;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(143, 12);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(131, 20);
            this.namebox.TabIndex = 11;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Телефон";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Лимит палат";
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(12, 38);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.ReadOnly = true;
            this.textbox2.Size = new System.Drawing.Size(100, 20);
            this.textbox2.TabIndex = 7;
            this.textbox2.Text = "Заведующий";
            this.textbox2.UseSystemPasswordChar = true;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(12, 12);
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(100, 20);
            this.textbox.TabIndex = 8;
            this.textbox.Text = "Отделение";
            // 
            // managerbox
            // 
            this.managerbox.Location = new System.Drawing.Point(143, 38);
            this.managerbox.Name = "managerbox";
            this.managerbox.Size = new System.Drawing.Size(131, 20);
            this.managerbox.TabIndex = 15;
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(143, 90);
            this.phonebox.Mask = "8-000-000-00-00";
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(131, 20);
            this.phonebox.TabIndex = 16;
            // 
            // add_dep_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 174);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.managerbox);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.Accept_but);
            this.Controls.Add(this.maximumbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox);
            this.Name = "add_dep_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.add_dep_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cansel_but;
        private System.Windows.Forms.Button Accept_but;
        public System.Windows.Forms.TextBox maximumbox;
        public System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox;
        public System.Windows.Forms.TextBox managerbox;
        public System.Windows.Forms.MaskedTextBox phonebox;
    }
}