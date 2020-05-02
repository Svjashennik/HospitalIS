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
    public partial class departments_list : Form
    {
        public List<Department> departments;
        public List<String> filter;
        public List<Pacient> lst_people;
        public departments_list()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_dep_form add_dialog = new add_dep_form();
            add_dialog.Owner = this;
            add_dialog.departments = departments;
            Add:
            add_dialog.ShowDialog();
            if (add_dialog.flag)
            {
                departments.Add(new Department(add_dialog.namebox.Text, int.Parse(add_dialog.maximumbox.Text), add_dialog.managerbox.Text, add_dialog.phonebox.Text));
                departmentBindingSource.ResetBindings(false);
                if (add_dialog.again)
                {
                    add_dialog.flag = false;
                    add_dialog.again = false;
                    goto Add;
                }
            }
            add_dialog.Close();
        }

        private void chan_button_Click(object sender, EventArgs e)
        {
            add_dep_form add_dialog = new add_dep_form();
            add_dialog.Owner = this;
            add_dialog.departments = departments;
            add_dialog.chanfl = true;
            add_dialog.sel = departmentDataGridView.CurrentRow;
            add_dialog.ShowDialog();
            int i = departmentDataGridView.CurrentRow.Index;
            if (add_dialog.flag)
            {
                departments[i].maximum = int.Parse(add_dialog.maximumbox.Text);
                departments[i].phone = add_dialog.phonebox.Text;
                departments[i].manager = add_dialog.managerbox.Text;
                departmentBindingSource.ResetBindings(false);
                if (departments[i].name != add_dialog.namebox.Text)
                {
                    departments[i].ChangeName(add_dialog.namebox.Text);
                }
                MessageBox.Show("Информация об отделении успешна обновлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            add_dialog.chanfl = false;
            add_dialog.Close();
        }

        private void departments_list_Load(object sender, EventArgs e)
        {
            departmentBindingSource.DataSource = departments;
        }


        private void настройкаЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor; // Текущий цвет в рамке
            if (colorDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            BackColor = colorDialog1.Color;
            toolStrip1.BackColor = colorDialog1.Color;
            Owner.BackColor = BackColor;
        }

        private void departmentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = departmentDataGridView.CurrentCell.RowIndex;
            filter.Add(departmentDataGridView.Rows[i].Cells["name"].Value.ToString());
            Hide();
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены? Данная операция удалит всех пациентов данного департамента.","Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning )== DialogResult.OK)
            {
                int i = departmentDataGridView.CurrentCell.RowIndex;
                foreach (Pacient pac in departments[i].people)
                {
                    lst_people.Remove(pac);
                }
                departments.Remove(departments[i]);
                departmentBindingSource.ResetBindings(false);
            }
        }

        private void настройкаШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = this.Font;
            fontDialog1.Color = this.ForeColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
                this.ForeColor = fontDialog1.Color;
                Owner.Font = fontDialog1.Font;
                Owner.ForeColor = fontDialog1.Color;
            }
        }

        private void отделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departmentBindingSource.ResetBindings(false);
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void exitbut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
