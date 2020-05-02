using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class add_dep_form : Form
    {
        public bool flag = false;
        public bool chanfl = false;
        public bool again;
        public List<Department> departments;
        public DataGridViewRow sel;
        public add_dep_form()
        {
            InitializeComponent();
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            
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

            if (!chanfl&&MessageBox.Show("Отделение " + namebox.Text + " добавлено. \n\nПовторить ввод?", "Вопросы ввода", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                namebox.Text = sel.Cells["name"].Value.ToString();
                managerbox.Text = sel.Cells["manager"].Value.ToString();
                phonebox.Text = sel.Cells["phone"].Value.ToString();
                maximumbox.Text = sel.Cells["maximum"].Value.ToString();
            }
        }
    }
}
