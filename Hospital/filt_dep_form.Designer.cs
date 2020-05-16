namespace Hospital
{
    partial class filt_dep_form
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
            this.phonesubbox = new System.Windows.Forms.MaskedTextBox();
            this.managersubox = new System.Windows.Forms.TextBox();
            this.namesubbox = new System.Windows.Forms.TextBox();
            this.phonesubcheck = new System.Windows.Forms.CheckBox();
            this.managersubcheck = new System.Windows.Forms.CheckBox();
            this.namesubcheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.room2 = new System.Windows.Forms.TextBox();
            this.room1 = new System.Windows.Forms.TextBox();
            this.count2 = new System.Windows.Forms.TextBox();
            this.count1 = new System.Windows.Forms.TextBox();
            this.roomcheck = new System.Windows.Forms.CheckBox();
            this.countcheck = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.acceptbut = new System.Windows.Forms.Button();
            this.canselbut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phonesubbox);
            this.groupBox1.Controls.Add(this.managersubox);
            this.groupBox1.Controls.Add(this.namesubbox);
            this.groupBox1.Controls.Add(this.phonesubcheck);
            this.groupBox1.Controls.Add(this.managersubcheck);
            this.groupBox1.Controls.Add(this.namesubcheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Строковые фильтры";
            // 
            // phonesubbox
            // 
            this.phonesubbox.Location = new System.Drawing.Point(201, 68);
            this.phonesubbox.Mask = "8-000-000-00-00";
            this.phonesubbox.Name = "phonesubbox";
            this.phonesubbox.Size = new System.Drawing.Size(218, 20);
            this.phonesubbox.TabIndex = 2;
            // 
            // managersubox
            // 
            this.managersubox.Location = new System.Drawing.Point(201, 44);
            this.managersubox.Name = "managersubox";
            this.managersubox.Size = new System.Drawing.Size(218, 20);
            this.managersubox.TabIndex = 1;
            // 
            // namesubbox
            // 
            this.namesubbox.Location = new System.Drawing.Point(201, 20);
            this.namesubbox.Name = "namesubbox";
            this.namesubbox.Size = new System.Drawing.Size(218, 20);
            this.namesubbox.TabIndex = 1;
            // 
            // phonesubcheck
            // 
            this.phonesubcheck.AutoSize = true;
            this.phonesubcheck.Location = new System.Drawing.Point(7, 70);
            this.phonesubcheck.Name = "phonesubcheck";
            this.phonesubcheck.Size = new System.Drawing.Size(164, 17);
            this.phonesubcheck.TabIndex = 0;
            this.phonesubcheck.Text = "Номер телефона содержит";
            this.phonesubcheck.UseVisualStyleBackColor = true;
            // 
            // managersubcheck
            // 
            this.managersubcheck.AutoSize = true;
            this.managersubcheck.Location = new System.Drawing.Point(7, 45);
            this.managersubcheck.Name = "managersubcheck";
            this.managersubcheck.Size = new System.Drawing.Size(172, 17);
            this.managersubcheck.TabIndex = 0;
            this.managersubcheck.Text = "Имя заведующего содержит";
            this.managersubcheck.UseVisualStyleBackColor = true;
            // 
            // namesubcheck
            // 
            this.namesubcheck.AutoSize = true;
            this.namesubcheck.Location = new System.Drawing.Point(7, 20);
            this.namesubcheck.Name = "namesubcheck";
            this.namesubcheck.Size = new System.Drawing.Size(128, 17);
            this.namesubcheck.TabIndex = 0;
            this.namesubcheck.Text = "Название содержит";
            this.namesubcheck.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Включить фильтры по подстрокам";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.room2);
            this.groupBox2.Controls.Add(this.room1);
            this.groupBox2.Controls.Add(this.count2);
            this.groupBox2.Controls.Add(this.count1);
            this.groupBox2.Controls.Add(this.roomcheck);
            this.groupBox2.Controls.Add(this.countcheck);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Числовые фильтры";
            // 
            // room2
            // 
            this.room2.Location = new System.Drawing.Point(314, 40);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(105, 20);
            this.room2.TabIndex = 5;
            // 
            // room1
            // 
            this.room1.Location = new System.Drawing.Point(201, 40);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(105, 20);
            this.room1.TabIndex = 6;
            this.room1.TextChanged += new System.EventHandler(this.max1_TextChanged);
            // 
            // count2
            // 
            this.count2.Location = new System.Drawing.Point(314, 17);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(105, 20);
            this.count2.TabIndex = 7;
            // 
            // count1
            // 
            this.count1.Location = new System.Drawing.Point(201, 17);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(105, 20);
            this.count1.TabIndex = 8;
            this.count1.TextChanged += new System.EventHandler(this.count1_TextChanged);
            // 
            // roomcheck
            // 
            this.roomcheck.AutoSize = true;
            this.roomcheck.Location = new System.Drawing.Point(7, 42);
            this.roomcheck.Name = "roomcheck";
            this.roomcheck.Size = new System.Drawing.Size(92, 17);
            this.roomcheck.TabIndex = 3;
            this.roomcheck.Text = "Кол-во палат";
            this.roomcheck.UseVisualStyleBackColor = true;
            // 
            // countcheck
            // 
            this.countcheck.AutoSize = true;
            this.countcheck.Location = new System.Drawing.Point(7, 19);
            this.countcheck.Name = "countcheck";
            this.countcheck.Size = new System.Drawing.Size(116, 17);
            this.countcheck.TabIndex = 4;
            this.countcheck.Text = "Кол-во пациентов";
            this.countcheck.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 137);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(202, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Включить фильтры по подстрокам";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // acceptbut
            // 
            this.acceptbut.Location = new System.Drawing.Point(12, 236);
            this.acceptbut.Name = "acceptbut";
            this.acceptbut.Size = new System.Drawing.Size(90, 30);
            this.acceptbut.TabIndex = 3;
            this.acceptbut.Text = "Принять";
            this.acceptbut.UseVisualStyleBackColor = true;
            this.acceptbut.Click += new System.EventHandler(this.acceptbut_Click);
            // 
            // canselbut
            // 
            this.canselbut.Location = new System.Drawing.Point(108, 236);
            this.canselbut.Name = "canselbut";
            this.canselbut.Size = new System.Drawing.Size(90, 30);
            this.canselbut.TabIndex = 3;
            this.canselbut.Text = "Отмена";
            this.canselbut.UseVisualStyleBackColor = true;
            this.canselbut.Click += new System.EventHandler(this.canselbut_Click);
            // 
            // filt_dep_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 282);
            this.Controls.Add(this.canselbut);
            this.Controls.Add(this.acceptbut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "filt_dep_form";
            this.Text = "Фильтрация";
            this.Load += new System.EventHandler(this.filt_dep_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox room2;
        public System.Windows.Forms.TextBox room1;
        public System.Windows.Forms.TextBox count2;
        public System.Windows.Forms.TextBox count1;
        public System.Windows.Forms.CheckBox roomcheck;
        public System.Windows.Forms.CheckBox countcheck;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox namesubcheck;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox managersubox;
        public System.Windows.Forms.TextBox namesubbox;
        public System.Windows.Forms.CheckBox phonesubcheck;
        public System.Windows.Forms.CheckBox managersubcheck;
        public System.Windows.Forms.MaskedTextBox phonesubbox;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button acceptbut;
        private System.Windows.Forms.Button canselbut;
    }
}