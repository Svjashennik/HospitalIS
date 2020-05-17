namespace Hospital
{
    partial class sort_dep_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sort_dep_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.acceptbut = new System.Windows.Forms.Button();
            this.canselbut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Descradiobut = new System.Windows.Forms.RadioButton();
            this.Ascradiobut = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 129);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(131, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "По номеру телефона";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 104);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(130, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "По кол-ву пациентов";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 79);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "По кол-ву палат";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По заведующему";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По названию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // acceptbut
            // 
            this.acceptbut.Location = new System.Drawing.Point(176, 105);
            this.acceptbut.Name = "acceptbut";
            this.acceptbut.Size = new System.Drawing.Size(90, 30);
            this.acceptbut.TabIndex = 1;
            this.acceptbut.Text = "Принять";
            this.acceptbut.UseVisualStyleBackColor = true;
            this.acceptbut.Click += new System.EventHandler(this.acceptbut_Click);
            // 
            // canselbut
            // 
            this.canselbut.Location = new System.Drawing.Point(176, 141);
            this.canselbut.Name = "canselbut";
            this.canselbut.Size = new System.Drawing.Size(90, 30);
            this.canselbut.TabIndex = 1;
            this.canselbut.Text = "Отмена";
            this.canselbut.UseVisualStyleBackColor = true;
            this.canselbut.Click += new System.EventHandler(this.canselbut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Descradiobut);
            this.groupBox2.Controls.Add(this.Ascradiobut);
            this.groupBox2.Location = new System.Drawing.Point(176, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим";
            // 
            // Descradiobut
            // 
            this.Descradiobut.AutoSize = true;
            this.Descradiobut.Location = new System.Drawing.Point(6, 29);
            this.Descradiobut.Name = "Descradiobut";
            this.Descradiobut.Size = new System.Drawing.Size(109, 17);
            this.Descradiobut.TabIndex = 0;
            this.Descradiobut.TabStop = true;
            this.Descradiobut.Text = "По возрастанию";
            this.Descradiobut.UseVisualStyleBackColor = true;
            // 
            // Ascradiobut
            // 
            this.Ascradiobut.AutoSize = true;
            this.Ascradiobut.Location = new System.Drawing.Point(6, 54);
            this.Ascradiobut.Name = "Ascradiobut";
            this.Ascradiobut.Size = new System.Drawing.Size(93, 17);
            this.Ascradiobut.TabIndex = 0;
            this.Ascradiobut.TabStop = true;
            this.Ascradiobut.Text = "По убыванию";
            this.Ascradiobut.UseVisualStyleBackColor = true;
            // 
            // sort_dep_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 183);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.canselbut);
            this.Controls.Add(this.acceptbut);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sort_dep_form";
            this.Text = "Сортировка отделений";
            this.Load += new System.EventHandler(this.sort_dep_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button acceptbut;
        private System.Windows.Forms.Button canselbut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Descradiobut;
        private System.Windows.Forms.RadioButton Ascradiobut;
    }
}