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
            this.namebox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox = new System.Windows.Forms.TextBox();
            this.managerbox = new System.Windows.Forms.TextBox();
            this.phonebox = new System.Windows.Forms.MaskedTextBox();
            this.roombox = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roombox)).BeginInit();
            this.SuspendLayout();
            // 
            // cansel_but
            // 
            this.cansel_but.Location = new System.Drawing.Point(143, 117);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.Size = new System.Drawing.Size(75, 23);
            this.cansel_but.TabIndex = 14;
            this.cansel_but.Text = "Отмена";
            this.cansel_but.UseVisualStyleBackColor = true;
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // Accept_but
            // 
            this.Accept_but.Location = new System.Drawing.Point(12, 116);
            this.Accept_but.Name = "Accept_but";
            this.Accept_but.Size = new System.Drawing.Size(75, 23);
            this.Accept_but.TabIndex = 13;
            this.Accept_but.Text = "Принять";
            this.Accept_but.UseVisualStyleBackColor = true;
            this.Accept_but.Click += new System.EventHandler(this.Accept_but_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(143, 12);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(244, 20);
            this.namebox.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Телефон";
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
            this.managerbox.Size = new System.Drawing.Size(244, 20);
            this.managerbox.TabIndex = 15;
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(143, 64);
            this.phonebox.Mask = "8-000-000-00-00";
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(244, 20);
            this.phonebox.TabIndex = 16;
            // 
            // roombox
            // 
            this.roombox.Location = new System.Drawing.Point(143, 91);
            this.roombox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roombox.Name = "roombox";
            this.roombox.Size = new System.Drawing.Size(104, 20);
            this.roombox.TabIndex = 17;
            this.roombox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Кол-во палат";
            // 
            // add_dep_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 149);
            this.Controls.Add(this.roombox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.managerbox);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.Accept_but);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_dep_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.add_dep_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roombox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cansel_but;
        private System.Windows.Forms.Button Accept_but;
        public System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox;
        public System.Windows.Forms.TextBox managerbox;
        public System.Windows.Forms.MaskedTextBox phonebox;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.NumericUpDown roombox;
    }
}