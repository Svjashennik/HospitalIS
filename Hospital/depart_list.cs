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
        public List<Department> dep_onscreen;
        public List<string> filter;
        public filt_dep_form filt_form = new filt_dep_form();
        public List<Pacient> lst_people;
        public bool rights { get; set; }
        public departments_list()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void add_button_Click(object sender, EventArgs e)
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
            add_dialog.sel = dep_onscreen[departmentDataGridView.CurrentRow.Index];
            add_dialog.ShowDialog();
            int i = departmentDataGridView.CurrentRow.Index;
            if (add_dialog.flag)
            {
                dep_onscreen[i].maximum = int.Parse(add_dialog.maximumbox.Text);
                dep_onscreen[i].phone = add_dialog.phonebox.Text;
                dep_onscreen[i].manager = add_dialog.managerbox.Text;
                departmentBindingSource.ResetBindings(false);
                if (dep_onscreen[i].name != add_dialog.namebox.Text)
                {
                    dep_onscreen[i].ChangeName(add_dialog.namebox.Text);
                }
                _ = MessageBox.Show("Информация об отделении успешна обновлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            add_dialog.chanfl = false;
            add_dialog.Close();
        }

        private void departments_list_Load(object sender, EventArgs e)
        {
            dep_onscreen = departments;
            departmentBindingSource.DataSource = dep_onscreen;
            if (!rights) groupBox1.Enabled = false;
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
                foreach (Pacient pac in dep_onscreen[i].people)
                {
                    lst_people.Remove(pac);
                }
                if (dep_onscreen==departments)
                {
                    dep_onscreen.RemoveAt(i);
                }
                else
                {
                    departments.Remove(dep_onscreen[i]);
                    dep_onscreen.RemoveAt(i);
                }
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

        private void sortbut_Click(object sender, EventArgs e)
        {
            sort_dep_form sort_form = new sort_dep_form();
            sort_form.Owner = this;
            sort_form.ShowDialog();
            if (sort_form.flag)
            {
                if (!sort_form.typesort)
                {
                    switch (sort_form.sort)
                    {
                        case "По названию":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.name).ToList();
                            break;
                        case "По заведующему":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.manager).ToList();
                            break;
                        case "По кол-ву палат":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.maximum).ToList();
                            break;
                        case "По кол-ву пациентов":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.countpac).ToList();
                            break;
                        case "По номеру телефона":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.phone).ToList();
                            break;
                    }
                }
                else
                {
                    switch (sort_form.sort)
                    {
                        case "По названию":
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.name).ToList();
                            break;
                        case "По заведующему":
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.manager).ToList();
                            break;
                        case "По кол-ву палат":
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.maximum).ToList();
                            break;
                        case "По кол-ву пациентов":
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.countpac).ToList();
                            break;
                        case "По номеру телефона":
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.phone).ToList();
                            break;
                    }
                }
                departmentBindingSource.DataSource = dep_onscreen;
                departmentBindingSource.ResetBindings(false);
            }
        }

        private void clearfiltbut_Click(object sender, EventArgs e)
        {
            dep_onscreen = departments;
            departmentBindingSource.DataSource = dep_onscreen;
            departmentBindingSource.ResetBindings(false);
            filt_form.checkBox1.Checked = false;
            filt_form.checkBox2.Checked = false;
            filtbut.BackColor = chan_button.BackColor;
        }

        private void filtbut_Click(object sender, EventArgs e)
        {
            filt_form.Owner = this;
            dep_onscreen = departments;
            filt_form.flag = false;
            filt_form.ShowDialog();
            if (!filt_form.flag) return;

            if (filt_form.checkBox1.Checked)
            {
                if (filt_form.namesubcheck.Checked)
                {
                    dep_onscreen = dep_onscreen.FindAll(dep => dep.name.Contains(filt_form.namesubbox.Text));
                }
                if (filt_form.managersubcheck.Checked)
                {
                    dep_onscreen = dep_onscreen.FindAll(dep => dep.manager.Contains(filt_form.managersubox.Text));
                }
                if (filt_form.phonesubcheck.Checked)
                {
                    dep_onscreen = dep_onscreen.FindAll(dep => dep.phone.Contains(filt_form.phonesubbox.Text));
                }
            }

            if (filt_form.checkBox2.Checked)
            {
                if (filt_form.countcheck.Checked)
                {
                    dep_onscreen = dep_onscreen.FindAll(dep => (int.Parse(filt_form.count1.Text) <= dep.countpac && int.Parse(filt_form.count2.Text) >= dep.countpac));
                }

                if (filt_form.maximumcheck.Checked)
                {
                    dep_onscreen = dep_onscreen.FindAll(dep => (int.Parse(filt_form.max1.Text) <= dep.maximum && int.Parse(filt_form.max2.Text) >= dep.maximum));
                }
            }
            if (filt_form.checkBox1.Checked || filt_form.checkBox2.Checked) filtbut.BackColor = System.Drawing.Color.Aqua;
            else filtbut.BackColor = chan_button.BackColor;
            departmentBindingSource.DataSource = dep_onscreen;
            departmentBindingSource.ResetBindings(false);
        }
    }
}
