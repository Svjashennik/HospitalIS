namespace Hospital
{
    partial class departments_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(departments_list));
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.chan_button = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.настройкаЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.отделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.deletebut = new System.Windows.Forms.Button();
            this.exitbut = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countpac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.AllowUserToAddRows = false;
            this.departmentDataGridView.AllowUserToDeleteRows = false;
            this.departmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentDataGridView.AutoGenerateColumns = false;
            this.departmentDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.maximum,
            this.manager,
            this.countpac,
            this.phone});
            this.departmentDataGridView.DataSource = this.departmentBindingSource;
            this.departmentDataGridView.GridColor = System.Drawing.SystemColors.Info;
            this.departmentDataGridView.Location = new System.Drawing.Point(44, 33);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.RowHeadersWidth = 45;
            this.departmentDataGridView.Size = new System.Drawing.Size(600, 288);
            this.departmentDataGridView.TabIndex = 0;
            this.departmentDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentDataGridView_CellDoubleClick);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_button.Location = new System.Drawing.Point(44, 327);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(88, 33);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // chan_button
            // 
            this.chan_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chan_button.Location = new System.Drawing.Point(138, 327);
            this.chan_button.Name = "chan_button";
            this.chan_button.Size = new System.Drawing.Size(88, 33);
            this.chan_button.TabIndex = 2;
            this.chan_button.Text = "Изменить";
            this.chan_button.UseVisualStyleBackColor = true;
            this.chan_button.Click += new System.EventHandler(this.chan_button_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 26);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаЦветаToolStripMenuItem,
            this.настройкаШрифтаToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 23);
            this.toolStripDropDownButton1.Text = "Опции";
            // 
            // настройкаЦветаToolStripMenuItem
            // 
            this.настройкаЦветаToolStripMenuItem.Name = "настройкаЦветаToolStripMenuItem";
            this.настройкаЦветаToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.настройкаЦветаToolStripMenuItem.Text = "Настройка цвета";
            this.настройкаЦветаToolStripMenuItem.Click += new System.EventHandler(this.настройкаЦветаToolStripMenuItem_Click);
            // 
            // настройкаШрифтаToolStripMenuItem
            // 
            this.настройкаШрифтаToolStripMenuItem.Name = "настройкаШрифтаToolStripMenuItem";
            this.настройкаШрифтаToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.настройкаШрифтаToolStripMenuItem.Text = "Настройка шрифта";
            this.настройкаШрифтаToolStripMenuItem.Click += new System.EventHandler(this.настройкаШрифтаToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделенияToolStripMenuItem,
            this.пациентыToolStripMenuItem});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(73, 23);
            this.toolStripDropDownButton2.Text = "Данные";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // отделенияToolStripMenuItem
            // 
            this.отделенияToolStripMenuItem.Name = "отделенияToolStripMenuItem";
            this.отделенияToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.отделенияToolStripMenuItem.Text = "Отделения";
            this.отделенияToolStripMenuItem.Click += new System.EventHandler(this.отделенияToolStripMenuItem_Click);
            // 
            // пациентыToolStripMenuItem
            // 
            this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            this.пациентыToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.пациентыToolStripMenuItem.Text = "Пациенты";
            this.пациентыToolStripMenuItem.Click += new System.EventHandler(this.пациентыToolStripMenuItem_Click);
            // 
            // deletebut
            // 
            this.deletebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletebut.Location = new System.Drawing.Point(232, 327);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(88, 33);
            this.deletebut.TabIndex = 4;
            this.deletebut.Text = "Удалить";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // exitbut
            // 
            this.exitbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbut.Location = new System.Drawing.Point(528, 327);
            this.exitbut.Name = "exitbut";
            this.exitbut.Size = new System.Drawing.Size(116, 33);
            this.exitbut.TabIndex = 5;
            this.exitbut.Text = "Закрыть";
            this.exitbut.UseVisualStyleBackColor = true;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Отделение";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 110;
            // 
            // maximum
            // 
            this.maximum.DataPropertyName = "maximum";
            this.maximum.HeaderText = "Лимит палат";
            this.maximum.MinimumWidth = 6;
            this.maximum.Name = "maximum";
            this.maximum.ReadOnly = true;
            this.maximum.Width = 110;
            // 
            // manager
            // 
            this.manager.DataPropertyName = "manager";
            this.manager.HeaderText = "Заведующий";
            this.manager.MinimumWidth = 6;
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            this.manager.Width = 110;
            // 
            // countpac
            // 
            this.countpac.DataPropertyName = "countpac";
            this.countpac.HeaderText = "Кол-во пациентов";
            this.countpac.MinimumWidth = 6;
            this.countpac.Name = "countpac";
            this.countpac.ReadOnly = true;
            this.countpac.Width = 110;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Телефон";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 110;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Department);
            // 
            // departments_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 395);
            this.Controls.Add(this.exitbut);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chan_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.departmentDataGridView);
            this.Name = "departments_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отделения";
            this.Load += new System.EventHandler(this.departments_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button chan_button;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn countpac;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem настройкаЦветаToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Button exitbut;
        private System.Windows.Forms.ToolStripMenuItem настройкаШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem отделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;
    }
}