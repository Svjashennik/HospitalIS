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
            this.nameradioBut = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.syndromBut = new System.Windows.Forms.RadioButton();
            this.ageradioBut = new System.Windows.Forms.RadioButton();
            this.departradioBut = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DescradioButton = new System.Windows.Forms.RadioButton();
            this.AscradioButton = new System.Windows.Forms.RadioButton();
            this.Accept_but = new System.Windows.Forms.Button();
            this.Cansel_but = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameradioBut
            // 
            this.nameradioBut.AutoSize = true;
            this.nameradioBut.Location = new System.Drawing.Point(6, 29);
            this.nameradioBut.Name = "nameradioBut";
            this.nameradioBut.Size = new System.Drawing.Size(99, 19);
            this.nameradioBut.TabIndex = 1;
            this.nameradioBut.TabStop = true;
            this.nameradioBut.Text = "По фамилии";
            this.nameradioBut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.syndromBut);
            this.groupBox1.Controls.Add(this.ageradioBut);
            this.groupBox1.Controls.Add(this.departradioBut);
            this.groupBox1.Controls.Add(this.nameradioBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Варианты сортировки";
            // 
            // syndromBut
            // 
            this.syndromBut.AutoSize = true;
            this.syndromBut.Location = new System.Drawing.Point(6, 105);
            this.syndromBut.Name = "syndromBut";
            this.syndromBut.Size = new System.Drawing.Size(95, 19);
            this.syndromBut.TabIndex = 4;
            this.syndromBut.TabStop = true;
            this.syndromBut.Text = "По диагнозу";
            this.syndromBut.UseVisualStyleBackColor = true;
            // 
            // ageradioBut
            // 
            this.ageradioBut.AutoSize = true;
            this.ageradioBut.Location = new System.Drawing.Point(6, 80);
            this.ageradioBut.Name = "ageradioBut";
            this.ageradioBut.Size = new System.Drawing.Size(96, 19);
            this.ageradioBut.TabIndex = 3;
            this.ageradioBut.TabStop = true;
            this.ageradioBut.Text = "По возрасту";
            this.ageradioBut.UseVisualStyleBackColor = true;
            // 
            // departradioBut
            // 
            this.departradioBut.AutoSize = true;
            this.departradioBut.Location = new System.Drawing.Point(6, 54);
            this.departradioBut.Name = "departradioBut";
            this.departradioBut.Size = new System.Drawing.Size(109, 19);
            this.departradioBut.TabIndex = 2;
            this.departradioBut.TabStop = true;
            this.departradioBut.Text = "По отделению";
            this.departradioBut.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DescradioButton);
            this.groupBox2.Controls.Add(this.AscradioButton);
            this.groupBox2.Location = new System.Drawing.Point(183, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим";
            // 
            // DescradioButton
            // 
            this.DescradioButton.AutoSize = true;
            this.DescradioButton.Location = new System.Drawing.Point(6, 55);
            this.DescradioButton.Name = "DescradioButton";
            this.DescradioButton.Size = new System.Drawing.Size(128, 19);
            this.DescradioButton.TabIndex = 1;
            this.DescradioButton.TabStop = true;
            this.DescradioButton.Text = "По возрастванию";
            this.DescradioButton.UseVisualStyleBackColor = true;
            this.DescradioButton.CheckedChanged += new System.EventHandler(this.DescradioButton_CheckedChanged);
            // 
            // AscradioButton
            // 
            this.AscradioButton.AutoSize = true;
            this.AscradioButton.Location = new System.Drawing.Point(6, 29);
            this.AscradioButton.Name = "AscradioButton";
            this.AscradioButton.Size = new System.Drawing.Size(102, 19);
            this.AscradioButton.TabIndex = 0;
            this.AscradioButton.TabStop = true;
            this.AscradioButton.Text = "По убыванию";
            this.AscradioButton.UseVisualStyleBackColor = true;
            // 
            // Accept_but
            // 
            this.Accept_but.Location = new System.Drawing.Point(183, 103);
            this.Accept_but.Name = "Accept_but";
            this.Accept_but.Size = new System.Drawing.Size(90, 30);
            this.Accept_but.TabIndex = 4;
            this.Accept_but.Text = "Принять";
            this.Accept_but.UseVisualStyleBackColor = true;
            this.Accept_but.Click += new System.EventHandler(this.Accept_but_Click);
            // 
            // Cansel_but
            // 
            this.Cansel_but.Location = new System.Drawing.Point(183, 139);
            this.Cansel_but.Name = "Cansel_but";
            this.Cansel_but.Size = new System.Drawing.Size(90, 30);
            this.Cansel_but.TabIndex = 5;
            this.Cansel_but.Text = "Отмена";
            this.Cansel_but.UseVisualStyleBackColor = true;
            this.Cansel_but.Click += new System.EventHandler(this.Cansel_but_Click);
            // 
            // SortPac_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 179);
            this.Controls.Add(this.Cansel_but);
            this.Controls.Add(this.Accept_but);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SortPac_form";
            this.Text = "Сортировка";
            this.Load += new System.EventHandler(this.SortPac_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton nameradioBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton syndromBut;
        private System.Windows.Forms.RadioButton ageradioBut;
        private System.Windows.Forms.RadioButton departradioBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton DescradioButton;
        private System.Windows.Forms.RadioButton AscradioButton;
        private System.Windows.Forms.Button Accept_but;
        private System.Windows.Forms.Button Cansel_but;
    }
}