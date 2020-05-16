namespace Hospital
{
    partial class visualform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visualform));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.depplotcheck = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageplotcheck = new System.Windows.Forms.RadioButton();
            this.syndromplotcheck = new System.Windows.Forms.RadioButton();
            this.dateclosecheck = new System.Windows.Forms.RadioButton();
            this.dateaddcheck = new System.Windows.Forms.RadioButton();
            this.roomplotcheck = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doesrad = new System.Windows.Forms.RadioButton();
            this.nothearrad = new System.Windows.Forms.RadioButton();
            this.hearrad = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxplot = new System.Windows.Forms.RadioButton();
            this.pointplot = new System.Windows.Forms.RadioButton();
            this.barplot = new System.Windows.Forms.RadioButton();
            this.pieplot = new System.Windows.Forms.RadioButton();
            this.columnplot = new System.Windows.Forms.RadioButton();
            this.depbox = new System.Windows.Forms.ComboBox();
            this.depcheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Black;
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.LightGray;
            series2.Legend = "Legend1";
            series2.MarkerSize = 15;
            series2.Name = "График";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(590, 471);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // depplotcheck
            // 
            this.depplotcheck.AutoSize = true;
            this.depplotcheck.Location = new System.Drawing.Point(6, 19);
            this.depplotcheck.Name = "depplotcheck";
            this.depplotcheck.Size = new System.Drawing.Size(155, 17);
            this.depplotcheck.TabIndex = 1;
            this.depplotcheck.TabStop = true;
            this.depplotcheck.Text = "Пациенты по отделениям";
            this.depplotcheck.UseVisualStyleBackColor = true;
            this.depplotcheck.CheckedChanged += new System.EventHandler(this.depplotcheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ageplotcheck);
            this.groupBox1.Controls.Add(this.syndromplotcheck);
            this.groupBox1.Controls.Add(this.dateclosecheck);
            this.groupBox1.Controls.Add(this.dateaddcheck);
            this.groupBox1.Controls.Add(this.roomplotcheck);
            this.groupBox1.Controls.Add(this.depplotcheck);
            this.groupBox1.Location = new System.Drawing.Point(609, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список визуализаций";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ageplotcheck
            // 
            this.ageplotcheck.AutoSize = true;
            this.ageplotcheck.Location = new System.Drawing.Point(6, 134);
            this.ageplotcheck.Name = "ageplotcheck";
            this.ageplotcheck.Size = new System.Drawing.Size(140, 17);
            this.ageplotcheck.TabIndex = 1;
            this.ageplotcheck.TabStop = true;
            this.ageplotcheck.Text = "Пациенты по возрасту";
            this.ageplotcheck.UseVisualStyleBackColor = true;
            this.ageplotcheck.CheckedChanged += new System.EventHandler(this.ageplotcheck_CheckedChanged);
            // 
            // syndromplotcheck
            // 
            this.syndromplotcheck.AutoSize = true;
            this.syndromplotcheck.Location = new System.Drawing.Point(6, 111);
            this.syndromplotcheck.Name = "syndromplotcheck";
            this.syndromplotcheck.Size = new System.Drawing.Size(140, 17);
            this.syndromplotcheck.TabIndex = 1;
            this.syndromplotcheck.TabStop = true;
            this.syndromplotcheck.Text = "Пациенты по диагнозу";
            this.syndromplotcheck.UseVisualStyleBackColor = true;
            this.syndromplotcheck.CheckedChanged += new System.EventHandler(this.syndormplotcheck_CheckedChanged);
            // 
            // dateclosecheck
            // 
            this.dateclosecheck.AutoSize = true;
            this.dateclosecheck.Location = new System.Drawing.Point(6, 88);
            this.dateclosecheck.Name = "dateclosecheck";
            this.dateclosecheck.Size = new System.Drawing.Size(187, 17);
            this.dateclosecheck.TabIndex = 1;
            this.dateclosecheck.TabStop = true;
            this.dateclosecheck.Text = "Пациенты по месяцам выписки";
            this.dateclosecheck.UseVisualStyleBackColor = true;
            this.dateclosecheck.CheckedChanged += new System.EventHandler(this.dateclosecheck_CheckedChanged);
            // 
            // dateaddcheck
            // 
            this.dateaddcheck.AutoSize = true;
            this.dateaddcheck.Location = new System.Drawing.Point(6, 65);
            this.dateaddcheck.Name = "dateaddcheck";
            this.dateaddcheck.Size = new System.Drawing.Size(181, 17);
            this.dateaddcheck.TabIndex = 1;
            this.dateaddcheck.TabStop = true;
            this.dateaddcheck.Text = "Пациенты по месяцам приема";
            this.dateaddcheck.UseVisualStyleBackColor = true;
            this.dateaddcheck.CheckedChanged += new System.EventHandler(this.dateaddcheck_CheckedChanged);
            // 
            // roomplotcheck
            // 
            this.roomplotcheck.AutoSize = true;
            this.roomplotcheck.Location = new System.Drawing.Point(6, 42);
            this.roomplotcheck.Name = "roomplotcheck";
            this.roomplotcheck.Size = new System.Drawing.Size(137, 17);
            this.roomplotcheck.TabIndex = 1;
            this.roomplotcheck.TabStop = true;
            this.roomplotcheck.Text = "Пациенты по палатам";
            this.roomplotcheck.UseVisualStyleBackColor = true;
            this.roomplotcheck.CheckedChanged += new System.EventHandler(this.roomplotcheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doesrad);
            this.groupBox2.Controls.Add(this.nothearrad);
            this.groupBox2.Controls.Add(this.hearrad);
            this.groupBox2.Location = new System.Drawing.Point(609, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Условия";
            // 
            // doesrad
            // 
            this.doesrad.AutoSize = true;
            this.doesrad.Location = new System.Drawing.Point(6, 65);
            this.doesrad.Name = "doesrad";
            this.doesrad.Size = new System.Drawing.Size(74, 17);
            this.doesrad.TabIndex = 0;
            this.doesrad.TabStop = true;
            this.doesrad.Text = "Не важно";
            this.doesrad.UseVisualStyleBackColor = true;
            this.doesrad.CheckedChanged += new System.EventHandler(this.doesrad_CheckedChanged);
            // 
            // nothearrad
            // 
            this.nothearrad.AutoSize = true;
            this.nothearrad.Location = new System.Drawing.Point(6, 42);
            this.nothearrad.Name = "nothearrad";
            this.nothearrad.Size = new System.Drawing.Size(88, 17);
            this.nothearrad.TabIndex = 0;
            this.nothearrad.TabStop = true;
            this.nothearrad.Text = "Не числятся";
            this.nothearrad.UseVisualStyleBackColor = true;
            this.nothearrad.CheckedChanged += new System.EventHandler(this.nothearrad_CheckedChanged);
            // 
            // hearrad
            // 
            this.hearrad.AutoSize = true;
            this.hearrad.Location = new System.Drawing.Point(6, 19);
            this.hearrad.Name = "hearrad";
            this.hearrad.Size = new System.Drawing.Size(74, 17);
            this.hearrad.TabIndex = 0;
            this.hearrad.TabStop = true;
            this.hearrad.Text = "Числятся";
            this.hearrad.UseVisualStyleBackColor = true;
            this.hearrad.CheckedChanged += new System.EventHandler(this.hearrad_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxplot);
            this.groupBox3.Controls.Add(this.pointplot);
            this.groupBox3.Controls.Add(this.barplot);
            this.groupBox3.Controls.Add(this.pieplot);
            this.groupBox3.Controls.Add(this.columnplot);
            this.groupBox3.Location = new System.Drawing.Point(609, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 138);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вид графика";
            // 
            // boxplot
            // 
            this.boxplot.AutoSize = true;
            this.boxplot.Location = new System.Drawing.Point(7, 66);
            this.boxplot.Name = "boxplot";
            this.boxplot.Size = new System.Drawing.Size(77, 17);
            this.boxplot.TabIndex = 1;
            this.boxplot.TabStop = true;
            this.boxplot.Text = "Пирамида";
            this.boxplot.UseVisualStyleBackColor = true;
            this.boxplot.CheckedChanged += new System.EventHandler(this.boxplot_CheckedChanged);
            // 
            // pointplot
            // 
            this.pointplot.AutoSize = true;
            this.pointplot.Location = new System.Drawing.Point(6, 112);
            this.pointplot.Name = "pointplot";
            this.pointplot.Size = new System.Drawing.Size(72, 17);
            this.pointplot.TabIndex = 0;
            this.pointplot.TabStop = true;
            this.pointplot.Text = "Точечная";
            this.pointplot.UseVisualStyleBackColor = true;
            this.pointplot.CheckedChanged += new System.EventHandler(this.pointplot_CheckedChanged);
            // 
            // barplot
            // 
            this.barplot.AutoSize = true;
            this.barplot.Location = new System.Drawing.Point(6, 89);
            this.barplot.Name = "barplot";
            this.barplot.Size = new System.Drawing.Size(93, 17);
            this.barplot.TabIndex = 0;
            this.barplot.TabStop = true;
            this.barplot.Text = "Гистограмма";
            this.barplot.UseVisualStyleBackColor = true;
            this.barplot.CheckedChanged += new System.EventHandler(this.barplot_CheckedChanged);
            // 
            // pieplot
            // 
            this.pieplot.AutoSize = true;
            this.pieplot.Location = new System.Drawing.Point(6, 43);
            this.pieplot.Name = "pieplot";
            this.pieplot.Size = new System.Drawing.Size(132, 17);
            this.pieplot.TabIndex = 0;
            this.pieplot.TabStop = true;
            this.pieplot.Text = "Круговая диаграмма";
            this.pieplot.UseVisualStyleBackColor = true;
            this.pieplot.CheckedChanged += new System.EventHandler(this.pieplot_CheckedChanged);
            // 
            // columnplot
            // 
            this.columnplot.AutoSize = true;
            this.columnplot.Location = new System.Drawing.Point(6, 20);
            this.columnplot.Name = "columnplot";
            this.columnplot.Size = new System.Drawing.Size(143, 17);
            this.columnplot.TabIndex = 0;
            this.columnplot.TabStop = true;
            this.columnplot.Text = "Столбчатая диаграмма";
            this.columnplot.UseVisualStyleBackColor = true;
            this.columnplot.CheckedChanged += new System.EventHandler(this.columnplot_CheckedChanged);
            // 
            // depbox
            // 
            this.depbox.DisplayMember = "name";
            this.depbox.FormattingEnabled = true;
            this.depbox.Location = new System.Drawing.Point(609, 320);
            this.depbox.Name = "depbox";
            this.depbox.Size = new System.Drawing.Size(192, 21);
            this.depbox.TabIndex = 6;
            this.depbox.ValueMember = "name";
            this.depbox.SelectedIndexChanged += new System.EventHandler(this.depbox_SelectedIndexChanged);
            // 
            // depcheck
            // 
            this.depcheck.AutoSize = true;
            this.depcheck.Location = new System.Drawing.Point(609, 297);
            this.depcheck.Name = "depcheck";
            this.depcheck.Size = new System.Drawing.Size(104, 17);
            this.depcheck.TabIndex = 7;
            this.depcheck.Text = "По отделениям";
            this.depcheck.UseVisualStyleBackColor = true;
            this.depcheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // visualform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.depcheck);
            this.Controls.Add(this.depbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "visualform";
            this.Text = "Визуализация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton depplotcheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton roomplotcheck;
        private System.Windows.Forms.RadioButton dateclosecheck;
        private System.Windows.Forms.RadioButton dateaddcheck;
        private System.Windows.Forms.RadioButton syndromplotcheck;
        private System.Windows.Forms.RadioButton ageplotcheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton doesrad;
        private System.Windows.Forms.RadioButton nothearrad;
        private System.Windows.Forms.RadioButton hearrad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton columnplot;
        private System.Windows.Forms.RadioButton barplot;
        private System.Windows.Forms.RadioButton pieplot;
        private System.Windows.Forms.RadioButton pointplot;
        public System.Windows.Forms.ComboBox depbox;
        private System.Windows.Forms.CheckBox depcheck;
        private System.Windows.Forms.RadioButton boxplot;
    }
}