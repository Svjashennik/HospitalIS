using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    public partial class add_dep_form : Form
    {
        public bool flag = false;
        public bool chanfl = false;
        public bool again;
        public List<Department> departments;
        public Department sel;
        public add_dep_form()
        {
            InitializeComponent();
        }

        private void Accept_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text))
            {
                MessageBox.Show("Вы должны ввести название.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namebox.Focus();
                return;
            }
            if (!chanfl && departments.Where(dep => dep.name == namebox.Text).Any())
            {
                MessageBox.Show("Отделение с таким названием уже существует.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namebox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(managerbox.Text))
            {
                MessageBox.Show("Вы должны ввести имя Заведующего.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                managerbox.Focus();
                return;
            }
            if (!maximumbox.Text.All(char.IsDigit) || string.IsNullOrEmpty(maximumbox.Text))
            {
                MessageBox.Show("Необходим числовой формат ввода.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maximumbox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phonebox.Text))
            {
                MessageBox.Show("Вы должны ввести диагноз.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phonebox.Focus();
                return;
            }

            if (!chanfl && MessageBox.Show("Отделение " + namebox.Text + " добавлено. \n\nПовторить ввод?", "Вопросы ввода", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                again = true;
            }
            flag = true;
            this.Hide();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void add_dep_form_Load(object sender, EventArgs e)
        {
            if (chanfl)
            {
                namebox.Text = sel.name;
                managerbox.Text = sel.manager;
                phonebox.Text = sel.phone;
                maximumbox.Text = sel.maximum.ToString();
            }
        }
    }
}
