namespace Hospital
{
    partial class startform
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ownfile = new System.Windows.Forms.RadioButton();
            this.newfile = new System.Windows.Forms.RadioButton();
            this.sample = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.acceptbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл для открытия или создайте новый.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ownfile
            // 
            this.ownfile.AutoSize = true;
            this.ownfile.Location = new System.Drawing.Point(12, 72);
            this.ownfile.Name = "ownfile";
            this.ownfile.Size = new System.Drawing.Size(112, 19);
            this.ownfile.TabIndex = 3;
            this.ownfile.TabStop = true;
            this.ownfile.Text = "Выбрать файл";
            this.ownfile.UseVisualStyleBackColor = true;
            // 
            // newfile
            // 
            this.newfile.AutoSize = true;
            this.newfile.Location = new System.Drawing.Point(12, 138);
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(149, 19);
            this.newfile.TabIndex = 3;
            this.newfile.TabStop = true;
            this.newfile.Text = "Создать новый файл";
            this.newfile.UseVisualStyleBackColor = true;
            // 
            // sample
            // 
            this.sample.AutoSize = true;
            this.sample.Location = new System.Drawing.Point(169, 138);
            this.sample.Name = "sample";
            this.sample.Size = new System.Drawing.Size(128, 19);
            this.sample.TabIndex = 3;
            this.sample.TabStop = true;
            this.sample.Text = "Открыть образец";
            this.sample.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // acceptbut
            // 
            this.acceptbut.Location = new System.Drawing.Point(323, 136);
            this.acceptbut.Name = "acceptbut";
            this.acceptbut.Size = new System.Drawing.Size(75, 23);
            this.acceptbut.TabIndex = 2;
            this.acceptbut.Text = "Принять";
            this.acceptbut.UseVisualStyleBackColor = true;
            this.acceptbut.Click += new System.EventHandler(this.acceptbut_Click);
            // 
            // startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 174);
            this.Controls.Add(this.sample);
            this.Controls.Add(this.newfile);
            this.Controls.Add(this.ownfile);
            this.Controls.Add(this.acceptbut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "startform";
            this.Text = "Работа с файлами";
            this.Load += new System.EventHandler(this.startform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ownfile;
        private System.Windows.Forms.RadioButton sample;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button acceptbut;
        public System.Windows.Forms.RadioButton newfile;
    }
}