namespace Hospital
{
    partial class hospital
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospital));
            this.Add_pole = new System.Windows.Forms.Button();
            this.change_but = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.shrift_button = new System.Windows.Forms.ToolStripMenuItem();
            this.color_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.департаментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.quite_save = new System.Windows.Forms.Button();
            this.resetfilterbut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.filtbut = new System.Windows.Forms.Button();
            this.pacientDataGridView = new System.Windows.Forms.DataGridView();
            this.medicinecard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hear = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hearlab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daylab = new System.Windows.Forms.Label();
            this.medicinelab = new System.Windows.Forms.Label();
            this.datecloselab = new System.Windows.Forms.Label();
            this.dateaddlab = new System.Windows.Forms.Label();
            this.syndromlab = new System.Windows.Forms.Label();
            this.agelab = new System.Windows.Forms.Label();
            this.datelab = new System.Windows.Forms.Label();
            this.depart_lab = new System.Windows.Forms.Label();
            this.namelab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depart_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syndrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_pole
            // 
            resources.ApplyResources(this.Add_pole, "Add_pole");
            this.Add_pole.Name = "Add_pole";
            this.Add_pole.UseVisualStyleBackColor = true;
            this.Add_pole.Click += new System.EventHandler(this.Add_pole_Click);
            // 
            // change_but
            // 
            resources.ApplyResources(this.change_but, "change_but");
            this.change_but.Name = "change_but";
            this.change_but.UseVisualStyleBackColor = true;
            this.change_but.Click += new System.EventHandler(this.change_but_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton4,
            this.toolStripButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem2});
            resources.ApplyResources(this.toolStripDropDownButton3, "toolStripDropDownButton3");
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            resources.ApplyResources(this.сохранитьКакToolStripMenuItem, "сохранитьКакToolStripMenuItem");
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            resources.ApplyResources(this.открытьToolStripMenuItem, "открытьToolStripMenuItem");
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shrift_button,
            this.color_but});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // shrift_button
            // 
            this.shrift_button.Name = "shrift_button";
            resources.ApplyResources(this.shrift_button, "shrift_button");
            this.shrift_button.Click += new System.EventHandler(this.shrift_button_Click);
            // 
            // color_but
            // 
            this.color_but.Name = "color_but";
            resources.ApplyResources(this.color_but, "color_but");
            this.color_but.Click += new System.EventHandler(this.color_but_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.департаментыToolStripMenuItem,
            this.пациентыToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton2, "toolStripDropDownButton2");
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            // 
            // департаментыToolStripMenuItem
            // 
            this.департаментыToolStripMenuItem.Name = "департаментыToolStripMenuItem";
            resources.ApplyResources(this.департаментыToolStripMenuItem, "департаментыToolStripMenuItem");
            this.департаментыToolStripMenuItem.Click += new System.EventHandler(this.департаментыToolStripMenuItem_Click);
            // 
            // пациентыToolStripMenuItem
            // 
            this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            resources.ApplyResources(this.пациентыToolStripMenuItem, "пациентыToolStripMenuItem");
            this.пациентыToolStripMenuItem.Click += new System.EventHandler(this.пациентыToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton4, "toolStripDropDownButton4");
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // quite_save
            // 
            resources.ApplyResources(this.quite_save, "quite_save");
            this.quite_save.Name = "quite_save";
            this.quite_save.UseVisualStyleBackColor = true;
            this.quite_save.Click += new System.EventHandler(this.quite_save_Click);
            // 
            // resetfilterbut
            // 
            resources.ApplyResources(this.resetfilterbut, "resetfilterbut");
            this.resetfilterbut.Name = "resetfilterbut";
            this.resetfilterbut.UseVisualStyleBackColor = true;
            this.resetfilterbut.Click += new System.EventHandler(this.resetfilterbut_Click);
            // 
            // deletebut
            // 
            resources.ApplyResources(this.deletebut, "deletebut");
            this.deletebut.Name = "deletebut";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.change_but);
            this.groupBox1.Controls.Add(this.Add_pole);
            this.groupBox1.Controls.Add(this.deletebut);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.filtbut);
            this.groupBox2.Controls.Add(this.resetfilterbut);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sortbut_Click);
            // 
            // filtbut
            // 
            resources.ApplyResources(this.filtbut, "filtbut");
            this.filtbut.Name = "filtbut";
            this.filtbut.UseVisualStyleBackColor = true;
            this.filtbut.Click += new System.EventHandler(this.filt_Click);
            // 
            // pacientDataGridView
            // 
            this.pacientDataGridView.AllowUserToAddRows = false;
            this.pacientDataGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.pacientDataGridView, "pacientDataGridView");
            this.pacientDataGridView.AutoGenerateColumns = false;
            this.pacientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pacientDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.pacientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicinecard,
            this.name,
            this.depart_name,
            this.syndrom,
            this.date,
            this.hear});
            this.pacientDataGridView.DataSource = this.pacientBindingSource;
            this.pacientDataGridView.Name = "pacientDataGridView";
            this.pacientDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientDataGridView_CellContentDoubleClick_1);
            this.pacientDataGridView.SelectionChanged += new System.EventHandler(this.pacientDataGridView_SelectionChanged);
            // 
            // medicinecard
            // 
            this.medicinecard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.medicinecard.DataPropertyName = "medicinecard";
            resources.ApplyResources(this.medicinecard, "medicinecard");
            this.medicinecard.Name = "medicinecard";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.FillWeight = 91.27502F;
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            // 
            // hear
            // 
            this.hear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hear.DataPropertyName = "hear";
            this.hear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.hear, "hear");
            this.hear.Name = "hear";
            this.hear.ReadOnly = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.hearlab);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.daylab);
            this.groupBox3.Controls.Add(this.medicinelab);
            this.groupBox3.Controls.Add(this.datecloselab);
            this.groupBox3.Controls.Add(this.dateaddlab);
            this.groupBox3.Controls.Add(this.syndromlab);
            this.groupBox3.Controls.Add(this.agelab);
            this.groupBox3.Controls.Add(this.datelab);
            this.groupBox3.Controls.Add(this.depart_lab);
            this.groupBox3.Controls.Add(this.namelab);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // hearlab
            // 
            resources.ApplyResources(this.hearlab, "hearlab");
            this.hearlab.Name = "hearlab";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // daylab
            // 
            resources.ApplyResources(this.daylab, "daylab");
            this.daylab.Name = "daylab";
            // 
            // medicinelab
            // 
            resources.ApplyResources(this.medicinelab, "medicinelab");
            this.medicinelab.Name = "medicinelab";
            // 
            // datecloselab
            // 
            resources.ApplyResources(this.datecloselab, "datecloselab");
            this.datecloselab.Name = "datecloselab";
            // 
            // dateaddlab
            // 
            resources.ApplyResources(this.dateaddlab, "dateaddlab");
            this.dateaddlab.Name = "dateaddlab";
            // 
            // syndromlab
            // 
            resources.ApplyResources(this.syndromlab, "syndromlab");
            this.syndromlab.Name = "syndromlab";
            // 
            // agelab
            // 
            resources.ApplyResources(this.agelab, "agelab");
            this.agelab.Name = "agelab";
            // 
            // datelab
            // 
            resources.ApplyResources(this.datelab, "datelab");
            this.datelab.Name = "datelab";
            // 
            // depart_lab
            // 
            this.depart_lab.AutoEllipsis = true;
            resources.ApplyResources(this.depart_lab, "depart_lab");
            this.depart_lab.Name = "depart_lab";
            // 
            // namelab
            // 
            resources.ApplyResources(this.namelab, "namelab");
            this.namelab.Name = "namelab";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 129.1674F;
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // depart_name
            // 
            this.depart_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depart_name.DataPropertyName = "depart_name";
            this.depart_name.FillWeight = 89.66995F;
            resources.ApplyResources(this.depart_name, "depart_name");
            this.depart_name.Name = "depart_name";
            this.depart_name.ReadOnly = true;
            // 
            // syndrom
            // 
            this.syndrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.syndrom.DataPropertyName = "syndrom";
            this.syndrom.FillWeight = 89.88763F;
            resources.ApplyResources(this.syndrom, "syndrom");
            this.syndrom.Name = "syndrom";
            this.syndrom.ReadOnly = true;
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataSource = typeof(Pacient);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Department);
            // 
            // hospital
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pacientDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quite_save);
            this.Controls.Add(this.toolStrip1);
            this.Name = "hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_pole;
        private System.Windows.Forms.Button change_but;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem shrift_button;
        private System.Windows.Forms.ToolStripMenuItem color_but;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem департаментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;
        private System.Windows.Forms.Button quite_save;
        private System.Windows.Forms.Button resetfilterbut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button filtbut;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private System.Windows.Forms.DataGridView pacientDataGridView;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label depart_lab;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinecard;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn depart_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn syndrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label medicinelab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label datecloselab;
        private System.Windows.Forms.Label dateaddlab;
        private System.Windows.Forms.Label syndromlab;
        private System.Windows.Forms.Label datelab;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label agelab;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label hearlab;
        private System.Windows.Forms.Label daylab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

