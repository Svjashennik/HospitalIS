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
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.shrift_button = new System.Windows.Forms.ToolStripMenuItem();
            this.color_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.департаментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.quite_save = new System.Windows.Forms.Button();
            this.resetfilterbut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pacientDataGridView = new System.Windows.Forms.DataGridView();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depart_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_close = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syndrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayhear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hear = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).BeginInit();
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
            this.toolStripButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton3, "toolStripDropDownButton3");
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
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
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.resetfilterbut);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.name,
            this.depart_name,
            this.date,
            this.age,
            this.date_add,
            this.date_close,
            this.syndrom,
            this.dayhear,
            this.hear});
            this.pacientDataGridView.DataSource = this.pacientBindingSource;
            this.pacientDataGridView.Name = "pacientDataGridView";
            this.pacientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientDataGridView_CellContentClick_1);
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataSource = typeof(Pacient);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Department);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // depart_name
            // 
            this.depart_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depart_name.DataPropertyName = "depart_name";
            resources.ApplyResources(this.depart_name, "depart_name");
            this.depart_name.Name = "depart_name";
            this.depart_name.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.DataPropertyName = "date";
            this.date.FillWeight = 110F;
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.age.DataPropertyName = "age";
            resources.ApplyResources(this.age, "age");
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // date_add
            // 
            this.date_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date_add.DataPropertyName = "date_add";
            resources.ApplyResources(this.date_add, "date_add");
            this.date_add.Name = "date_add";
            this.date_add.ReadOnly = true;
            // 
            // date_close
            // 
            this.date_close.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date_close.DataPropertyName = "date_close";
            resources.ApplyResources(this.date_close, "date_close");
            this.date_close.Name = "date_close";
            this.date_close.ReadOnly = true;
            // 
            // syndrom
            // 
            this.syndrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.syndrom.DataPropertyName = "syndrom";
            resources.ApplyResources(this.syndrom, "syndrom");
            this.syndrom.Name = "syndrom";
            this.syndrom.ReadOnly = true;
            // 
            // dayhear
            // 
            this.dayhear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dayhear.DataPropertyName = "dayhear";
            resources.ApplyResources(this.dayhear, "dayhear");
            this.dayhear.Name = "dayhear";
            this.dayhear.ReadOnly = true;
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
            // hospital
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private System.Windows.Forms.DataGridView pacientDataGridView;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn depart_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn syndrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayhear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hear;
    }
}

