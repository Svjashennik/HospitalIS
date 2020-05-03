namespace Hospital
{
    partial class filter_form
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
            this.nameCheck = new System.Windows.Forms.CheckBox();
            this.departsub = new System.Windows.Forms.CheckBox();
            this.datecheck = new System.Windows.Forms.CheckBox();
            this.syndromsub = new System.Windows.Forms.CheckBox();
            this.dateaddcheck = new System.Windows.Forms.CheckBox();
            this.datecloseCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.syndromsubtext = new System.Windows.Forms.TextBox();
            this.departsubtext = new System.Windows.Forms.TextBox();
            this.namesub = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateadd1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.dateclose2 = new System.Windows.Forms.DateTimePicker();
            this.dateclose1 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.dateadd2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.day2 = new System.Windows.Forms.TextBox();
            this.day1 = new System.Windows.Forms.TextBox();
            this.age2 = new System.Windows.Forms.TextBox();
            this.age1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.departbox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hearcheck = new System.Windows.Forms.CheckBox();
            this.dayhearcheck = new System.Windows.Forms.CheckBox();
            this.agecheck = new System.Windows.Forms.CheckBox();
            this.departcheck = new System.Windows.Forms.CheckBox();
            this.AcceptBut = new System.Windows.Forms.Button();
            this.CanselBut = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameCheck
            // 
            this.nameCheck.AutoSize = true;
            this.nameCheck.Location = new System.Drawing.Point(6, 19);
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Size = new System.Drawing.Size(127, 17);
            this.nameCheck.TabIndex = 0;
            this.nameCheck.Text = "Фамилия содержит";
            this.nameCheck.UseVisualStyleBackColor = true;
            // 
            // departsub
            // 
            this.departsub.AutoSize = true;
            this.departsub.Location = new System.Drawing.Point(6, 42);
            this.departsub.Name = "departsub";
            this.departsub.Size = new System.Drawing.Size(133, 17);
            this.departsub.TabIndex = 1;
            this.departsub.Text = "Отделение содержит";
            this.departsub.UseVisualStyleBackColor = true;
            // 
            // datecheck
            // 
            this.datecheck.AutoSize = true;
            this.datecheck.Location = new System.Drawing.Point(6, 65);
            this.datecheck.Name = "datecheck";
            this.datecheck.Size = new System.Drawing.Size(105, 17);
            this.datecheck.TabIndex = 1;
            this.datecheck.Text = "Дата рождения";
            this.datecheck.UseVisualStyleBackColor = true;
            // 
            // syndromsub
            // 
            this.syndromsub.AutoSize = true;
            this.syndromsub.Location = new System.Drawing.Point(6, 65);
            this.syndromsub.Name = "syndromsub";
            this.syndromsub.Size = new System.Drawing.Size(122, 17);
            this.syndromsub.TabIndex = 1;
            this.syndromsub.Text = "Диагноз содержит";
            this.syndromsub.UseVisualStyleBackColor = true;
            // 
            // dateaddcheck
            // 
            this.dateaddcheck.AutoSize = true;
            this.dateaddcheck.Location = new System.Drawing.Point(6, 19);
            this.dateaddcheck.Name = "dateaddcheck";
            this.dateaddcheck.Size = new System.Drawing.Size(93, 17);
            this.dateaddcheck.TabIndex = 1;
            this.dateaddcheck.Text = "Дата приема";
            this.dateaddcheck.UseVisualStyleBackColor = true;
            // 
            // datecloseCheck
            // 
            this.datecloseCheck.AutoSize = true;
            this.datecloseCheck.Location = new System.Drawing.Point(6, 42);
            this.datecloseCheck.Name = "datecloseCheck";
            this.datecloseCheck.Size = new System.Drawing.Size(99, 17);
            this.datecloseCheck.TabIndex = 1;
            this.datecloseCheck.Text = "Дата выписки";
            this.datecloseCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.syndromsubtext);
            this.groupBox1.Controls.Add(this.departsubtext);
            this.groupBox1.Controls.Add(this.namesub);
            this.groupBox1.Controls.Add(this.syndromsub);
            this.groupBox1.Controls.Add(this.departsub);
            this.groupBox1.Controls.Add(this.nameCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Строковые фильтры";
            // 
            // syndromsubtext
            // 
            this.syndromsubtext.Location = new System.Drawing.Point(163, 62);
            this.syndromsubtext.Name = "syndromsubtext";
            this.syndromsubtext.Size = new System.Drawing.Size(169, 20);
            this.syndromsubtext.TabIndex = 4;
            // 
            // departsubtext
            // 
            this.departsubtext.Location = new System.Drawing.Point(163, 39);
            this.departsubtext.Name = "departsubtext";
            this.departsubtext.Size = new System.Drawing.Size(169, 20);
            this.departsubtext.TabIndex = 3;
            // 
            // namesub
            // 
            this.namesub.Location = new System.Drawing.Point(163, 16);
            this.namesub.Name = "namesub";
            this.namesub.Size = new System.Drawing.Size(169, 20);
            this.namesub.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateadd1);
            this.groupBox2.Controls.Add(this.date2);
            this.groupBox2.Controls.Add(this.dateclose2);
            this.groupBox2.Controls.Add(this.dateclose1);
            this.groupBox2.Controls.Add(this.date1);
            this.groupBox2.Controls.Add(this.dateadd2);
            this.groupBox2.Controls.Add(this.dateaddcheck);
            this.groupBox2.Controls.Add(this.datecloseCheck);
            this.groupBox2.Controls.Add(this.datecheck);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтры по датам";
            // 
            // dateadd1
            // 
            this.dateadd1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateadd1.Location = new System.Drawing.Point(138, 19);
            this.dateadd1.Name = "dateadd1";
            this.dateadd1.Size = new System.Drawing.Size(94, 20);
            this.dateadd1.TabIndex = 2;
            this.dateadd1.ValueChanged += new System.EventHandler(this.dateadd1_ValueChanged);
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(238, 65);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(94, 20);
            this.date2.TabIndex = 2;
            // 
            // dateclose2
            // 
            this.dateclose2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateclose2.Location = new System.Drawing.Point(238, 42);
            this.dateclose2.Name = "dateclose2";
            this.dateclose2.Size = new System.Drawing.Size(94, 20);
            this.dateclose2.TabIndex = 2;
            // 
            // dateclose1
            // 
            this.dateclose1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateclose1.Location = new System.Drawing.Point(138, 42);
            this.dateclose1.Name = "dateclose1";
            this.dateclose1.Size = new System.Drawing.Size(94, 20);
            this.dateclose1.TabIndex = 2;
            this.dateclose1.ValueChanged += new System.EventHandler(this.dateclose1_ValueChanged);
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(138, 65);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(94, 20);
            this.date1.TabIndex = 2;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // dateadd2
            // 
            this.dateadd2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateadd2.Location = new System.Drawing.Point(238, 19);
            this.dateadd2.Name = "dateadd2";
            this.dateadd2.Size = new System.Drawing.Size(94, 20);
            this.dateadd2.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.day2);
            this.groupBox4.Controls.Add(this.day1);
            this.groupBox4.Controls.Add(this.age2);
            this.groupBox4.Controls.Add(this.age1);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.departbox);
            this.groupBox4.Controls.Add(this.hearcheck);
            this.groupBox4.Controls.Add(this.dayhearcheck);
            this.groupBox4.Controls.Add(this.agecheck);
            this.groupBox4.Controls.Add(this.departcheck);
            this.groupBox4.Location = new System.Drawing.Point(12, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 114);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фактические фильтры";
            // 
            // day2
            // 
            this.day2.Location = new System.Drawing.Point(246, 62);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(78, 20);
            this.day2.TabIndex = 2;
            // 
            // day1
            // 
            this.day1.Location = new System.Drawing.Point(162, 62);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(78, 20);
            this.day1.TabIndex = 2;
            this.day1.TextChanged += new System.EventHandler(this.day1_TextChanged);
            // 
            // age2
            // 
            this.age2.Location = new System.Drawing.Point(246, 39);
            this.age2.Name = "age2";
            this.age2.Size = new System.Drawing.Size(79, 20);
            this.age2.TabIndex = 2;
            // 
            // age1
            // 
            this.age1.Location = new System.Drawing.Point(162, 39);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(78, 20);
            this.age1.TabIndex = 2;
            this.age1.TextChanged += new System.EventHandler(this.age1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Числится",
            "Не числится"});
            this.comboBox2.Location = new System.Drawing.Point(162, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // departbox
            // 
            this.departbox.DataSource = this.departmentBindingSource;
            this.departbox.FormattingEnabled = true;
            this.departbox.Location = new System.Drawing.Point(162, 15);
            this.departbox.Name = "departbox";
            this.departbox.Size = new System.Drawing.Size(163, 21);
            this.departbox.TabIndex = 1;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Department);
            // 
            // hearcheck
            // 
            this.hearcheck.AutoSize = true;
            this.hearcheck.Location = new System.Drawing.Point(6, 87);
            this.hearcheck.Name = "hearcheck";
            this.hearcheck.Size = new System.Drawing.Size(119, 17);
            this.hearcheck.TabIndex = 0;
            this.hearcheck.Text = "Факт пребывания";
            this.hearcheck.UseVisualStyleBackColor = true;
            // 
            // dayhearcheck
            // 
            this.dayhearcheck.AutoSize = true;
            this.dayhearcheck.Location = new System.Drawing.Point(6, 64);
            this.dayhearcheck.Name = "dayhearcheck";
            this.dayhearcheck.Size = new System.Drawing.Size(87, 17);
            this.dayhearcheck.TabIndex = 0;
            this.dayhearcheck.Text = "Кол-во дней";
            this.dayhearcheck.UseVisualStyleBackColor = true;
            // 
            // agecheck
            // 
            this.agecheck.AutoSize = true;
            this.agecheck.Location = new System.Drawing.Point(6, 41);
            this.agecheck.Name = "agecheck";
            this.agecheck.Size = new System.Drawing.Size(68, 17);
            this.agecheck.TabIndex = 0;
            this.agecheck.Text = "Возраст";
            this.agecheck.UseVisualStyleBackColor = true;
            // 
            // departcheck
            // 
            this.departcheck.AutoSize = true;
            this.departcheck.Location = new System.Drawing.Point(6, 19);
            this.departcheck.Name = "departcheck";
            this.departcheck.Size = new System.Drawing.Size(81, 17);
            this.departcheck.TabIndex = 0;
            this.departcheck.Text = "Отделение";
            this.departcheck.UseVisualStyleBackColor = true;
            // 
            // AcceptBut
            // 
            this.AcceptBut.Location = new System.Drawing.Point(12, 393);
            this.AcceptBut.Name = "AcceptBut";
            this.AcceptBut.Size = new System.Drawing.Size(75, 23);
            this.AcceptBut.TabIndex = 4;
            this.AcceptBut.Text = "Принять";
            this.AcceptBut.UseVisualStyleBackColor = true;
            this.AcceptBut.Click += new System.EventHandler(this.AcceptBut_Click);
            // 
            // CanselBut
            // 
            this.CanselBut.Location = new System.Drawing.Point(112, 393);
            this.CanselBut.Name = "CanselBut";
            this.CanselBut.Size = new System.Drawing.Size(75, 23);
            this.CanselBut.TabIndex = 5;
            this.CanselBut.Text = "Отмена";
            this.CanselBut.UseVisualStyleBackColor = true;
            this.CanselBut.Click += new System.EventHandler(this.CanselBut_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 250);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(192, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Включить фактические фильтры";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(175, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Включить фильтры по датам ";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Включить фильтры по строкам";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // filter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 428);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.CanselBut);
            this.Controls.Add(this.AcceptBut);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "filter_form";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Button AcceptBut;
        private System.Windows.Forms.Button CanselBut;
        public System.Windows.Forms.CheckBox nameCheck;
        public System.Windows.Forms.CheckBox departsub;
        public System.Windows.Forms.CheckBox datecheck;
        public System.Windows.Forms.CheckBox syndromsub;
        public System.Windows.Forms.CheckBox dateaddcheck;
        public System.Windows.Forms.CheckBox datecloseCheck;
        public System.Windows.Forms.TextBox syndromsubtext;
        public System.Windows.Forms.TextBox departsubtext;
        public System.Windows.Forms.TextBox namesub;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker dateadd1;
        public System.Windows.Forms.DateTimePicker date2;
        public System.Windows.Forms.DateTimePicker dateclose2;
        public System.Windows.Forms.DateTimePicker dateclose1;
        public System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.DateTimePicker dateadd2;
        public System.Windows.Forms.CheckBox agecheck;
        public System.Windows.Forms.CheckBox departcheck;
        public System.Windows.Forms.ComboBox departbox;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox hearcheck;
        public System.Windows.Forms.CheckBox dayhearcheck;
        public System.Windows.Forms.TextBox day1;
        public System.Windows.Forms.TextBox age1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox day2;
        public System.Windows.Forms.TextBox age2;
    }
}