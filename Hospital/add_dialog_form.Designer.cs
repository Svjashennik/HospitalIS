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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.TextBox();
            this.syndrombox = new System.Windows.Forms.TextBox();
            this.depbox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Accept_but = new System.Windows.Forms.Button();
            this.cansel_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Фамилия";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
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
            this.textBox3.Location = new System.Drawing.Point(12, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Год рождения";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Диагноз";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(129, 12);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(121, 20);
            this.namebox.TabIndex = 1;
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(129, 64);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(121, 20);
            this.datebox.TabIndex = 1;
            // 
            // syndrombox
            // 
            this.syndrombox.Location = new System.Drawing.Point(129, 90);
            this.syndrombox.Name = "syndrombox";
            this.syndrombox.Size = new System.Drawing.Size(121, 20);
            this.syndrombox.TabIndex = 1;
            // 
            // depbox
            // 
            this.depbox.BackColor = System.Drawing.SystemColors.Window;
            this.depbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "name", true));
            this.depbox.DataSource = this.departmentBindingSource;
            this.depbox.DisplayMember = "name";
            this.depbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depbox.Location = new System.Drawing.Point(129, 37);
            this.depbox.Name = "depbox";
            this.depbox.Size = new System.Drawing.Size(121, 21);
            this.depbox.TabIndex = 2;
            this.depbox.ValueMember = "name";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Department);
            // 
            // Accept_but
            // 
            this.Accept_but.Location = new System.Drawing.Point(12, 116);
            this.Accept_but.Name = "Accept_but";
            this.Accept_but.Size = new System.Drawing.Size(75, 23);
            this.Accept_but.TabIndex = 3;
            this.Accept_but.Text = "Принять";
            this.Accept_but.UseVisualStyleBackColor = true;
            this.Accept_but.Click += new System.EventHandler(this.Accept_but_Click);
            // 
            // cansel_but
            // 
            this.cansel_but.Location = new System.Drawing.Point(129, 116);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.Size = new System.Drawing.Size(75, 23);
            this.cansel_but.TabIndex = 4;
            this.cansel_but.Text = "Отмена";
            this.cansel_but.UseVisualStyleBackColor = true;
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // add_dialog_formpac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 154);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.Accept_but);
            this.Controls.Add(this.depbox);
            this.Controls.Add(this.syndrombox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "add_dialog_formpac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.add_dialog_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        public System.Windows.Forms.ComboBox depbox;
        private System.Windows.Forms.Button Accept_but;
        private System.Windows.Forms.Button cansel_but;
        public System.Windows.Forms.TextBox namebox;
        public System.Windows.Forms.TextBox datebox;
        public System.Windows.Forms.TextBox syndrombox;
    }
}