namespace Hospital
{
    partial class SortPac_form
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DescradioButton = new System.Windows.Forms.RadioButton();
            this.AscradioButton = new System.Windows.Forms.RadioButton();
            this.Accept_but = new System.Windows.Forms.Button();
            this.Cansel_but = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dayrad = new System.Windows.Forms.RadioButton();
            this.hearrad = new System.Windows.Forms.RadioButton();
            this.datecloseradioBut = new System.Windows.Forms.RadioButton();
            this.dateaddRad = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DescradioButton);
            this.groupBox2.Controls.Add(this.AscradioButton);
            this.groupBox2.Location = new System.Drawing.Point(183, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим";
            // 
            // DescradioButton
            // 
            this.DescradioButton.AutoSize = true;
            this.DescradioButton.Location = new System.Drawing.Point(6, 29);
            this.DescradioButton.Name = "DescradioButton";
            this.DescradioButton.Size = new System.Drawing.Size(128, 19);
            this.DescradioButton.TabIndex = 1;
            this.DescradioButton.TabStop = true;
            this.DescradioButton.Text = "По возрастванию";
            this.DescradioButton.UseVisualStyleBackColor = true;
            // 
            // AscradioButton
            // 
            this.AscradioButton.AutoSize = true;
            this.AscradioButton.Location = new System.Drawing.Point(6, 51);
            this.AscradioButton.Name = "AscradioButton";
            this.AscradioButton.Size = new System.Drawing.Size(102, 19);
            this.AscradioButton.TabIndex = 0;
            this.AscradioButton.TabStop = true;
            this.AscradioButton.Text = "По убыванию";
            this.AscradioButton.UseVisualStyleBackColor = true;
            // 
            // Accept_but
            // 
            this.Accept_but.Location = new System.Drawing.Point(183, 107);
            this.Accept_but.Name = "Accept_but";
            this.Accept_but.Size = new System.Drawing.Size(90, 30);
            this.Accept_but.TabIndex = 4;
            this.Accept_but.Text = "Принять";
            this.Accept_but.UseVisualStyleBackColor = true;
            this.Accept_but.Click += new System.EventHandler(this.Accept_but_Click);
            // 
            // Cansel_but
            // 
            this.Cansel_but.Location = new System.Drawing.Point(183, 143);
            this.Cansel_but.Name = "Cansel_but";
            this.Cansel_but.Size = new System.Drawing.Size(90, 30);
            this.Cansel_but.TabIndex = 5;
            this.Cansel_but.Text = "Отмена";
            this.Cansel_but.UseVisualStyleBackColor = true;
            this.Cansel_but.Click += new System.EventHandler(this.Cansel_but_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dayrad);
            this.groupBox3.Controls.Add(this.hearrad);
            this.groupBox3.Controls.Add(this.datecloseradioBut);
            this.groupBox3.Controls.Add(this.dateaddRad);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Варианты сортировки";
            // 
            // dayrad
            // 
            this.dayrad.AutoSize = true;
            this.dayrad.Location = new System.Drawing.Point(6, 226);
            this.dayrad.Name = "dayrad";
            this.dayrad.Size = new System.Drawing.Size(111, 19);
            this.dayrad.TabIndex = 5;
            this.dayrad.TabStop = true;
            this.dayrad.Text = "По кол-ву дней";
            this.dayrad.UseVisualStyleBackColor = true;
            // 
            // hearrad
            // 
            this.hearrad.AutoSize = true;
            this.hearrad.Location = new System.Drawing.Point(6, 201);
            this.hearrad.Name = "hearrad";
            this.hearrad.Size = new System.Drawing.Size(155, 19);
            this.hearrad.TabIndex = 5;
            this.hearrad.TabStop = true;
            this.hearrad.Text = "По факту пребывания";
            this.hearrad.UseVisualStyleBackColor = true;
            // 
            // datecloseradioBut
            // 
            this.datecloseradioBut.AutoSize = true;
            this.datecloseradioBut.Location = new System.Drawing.Point(6, 176);
            this.datecloseradioBut.Name = "datecloseradioBut";
            this.datecloseradioBut.Size = new System.Drawing.Size(124, 19);
            this.datecloseradioBut.TabIndex = 5;
            this.datecloseradioBut.TabStop = true;
            this.datecloseradioBut.Text = "По дате выписки";
            this.datecloseradioBut.UseVisualStyleBackColor = true;
            // 
            // dateaddRad
            // 
            this.dateaddRad.AutoSize = true;
            this.dateaddRad.Location = new System.Drawing.Point(6, 151);
            this.dateaddRad.Name = "dateaddRad";
            this.dateaddRad.Size = new System.Drawing.Size(119, 19);
            this.dateaddRad.TabIndex = 5;
            this.dateaddRad.TabStop = true;
            this.dateaddRad.Text = "По дате приема";
            this.dateaddRad.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 126);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(95, 19);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "По диагнозу";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 101);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(96, 19);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "По возрасту";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По мед.карте";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 76);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(109, 19);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "По отделению";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 29);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(99, 19);
            this.radioButton10.TabIndex = 1;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "По фамилии";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // SortPac_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 274);
            this.Controls.Add(this.Cansel_but);
            this.Controls.Add(this.Accept_but);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SortPac_form";
            this.Text = "Сортировка";
            this.Load += new System.EventHandler(this.SortPac_form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton DescradioButton;
        private System.Windows.Forms.RadioButton AscradioButton;
        private System.Windows.Forms.Button Accept_but;
        private System.Windows.Forms.Button Cansel_but;
        private System.Windows.Forms.RadioButton hearrad;
        private System.Windows.Forms.RadioButton datecloseradioBut;
        private System.Windows.Forms.RadioButton dateaddRad;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton dayrad;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.GroupBox groupBox3;
    }
}