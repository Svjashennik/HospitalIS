using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Windows.Forms;


namespace Hospital
{
    public partial class hospital : Form
    {
        public hospital()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        FileStream fsdep;
        XmlSerializer xsdep;
        public List<Department> departments;
        public List<Pacient> lst_people = new List<Pacient>();
        public List<string> filter = new List<string>();
        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Отделения.xml"))
            {
                fsdep = new FileStream("Отделения.xml", FileMode.Open);
                xsdep = new XmlSerializer(typeof(List<Department>));
                departments = (List<Department>)xsdep.Deserialize(fsdep);
                foreach(Department dep in departments)
                {
                    foreach (Pacient pac in dep.people)
                    {
                        lst_people.Add(pac);
                    }                   
                }
                fsdep.Close();
            }
            else
            {
                Department dep1 = new Department("Венерическое", 20, "Купитман", "8-800-555-35-35");
                Department dep2 = new Department("Гастрологическое", 15, "Степанов", "8-900-555-35-35");
                Department dep3 = new Department("Психиатрическое", 40, "Колганова", "8-228-555-35-35");
                departments = new List<Department>();
                departments.Add(dep1);
                departments.Add(dep2);
                departments.Add(dep3);
                lst_people.Add(new Pacient("Кириллкин", 2000, "Модник", "Венерическое", departments));
                lst_people.Add(new Pacient("Райбекас", 2000, "Котики", "Венерическое", departments));
                lst_people.Add(new Pacient("Никитин", 2000, "Соболев", "Венерическое", departments));
                lst_people.Add(new Pacient("Калашникова", 2001, "Мразь", "Гастрологическое", departments));
                lst_people.Add(new Pacient("Лебедь", 2000, "Тряпка", "Гастрологическое", departments));
                lst_people.Add(new Pacient("Федоренков", 2000, "Робот", "Гастрологическое", departments));
                lst_people.Add(new Pacient("Рогозникова", 2000, "Словпок", "Гастрологическое", departments));
                lst_people.Add(new Pacient("Акаев", 2000, "Лентяево", "Психиатрическое", departments));
                lst_people.Add(new Pacient("Комарницкий", 1999, "ЦСВ", "Психиатрическое", departments));
                
            }
            pacientBindingSource.DataSource = lst_people;
            departmentBindingSource.DataSource = departments;
        }


        private void Add_pole_Click(object sender, EventArgs e)
        {
            add_dialog_formpac add_dialog = new add_dialog_formpac();
            add_dialog.Owner = this;
            add_dialog.depbox.DataSource = departmentBindingSource; 
            Add:
            add_dialog.ShowDialog();
            if (add_dialog.flag)
            {
                Pacient newpac = new Pacient(add_dialog.namebox.Text, int.Parse(add_dialog.datebox.Text), add_dialog.syndrombox.Text, ((Department)add_dialog.depbox.SelectedItem).name, departments);
                lst_people.Add(newpac);
                pacientBindingSource.ResetBindings(false);
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

        private void change_but_Click(object sender, EventArgs e)
        {
            add_dialog_formpac add_dialog = new add_dialog_formpac();
            add_dialog.Owner = this;
            add_dialog.chanfl = true;
            add_dialog.sel = pacientDataGridView.CurrentRow;
            add_dialog.depbox.DataSource = departmentBindingSource;
            add_dialog.ShowDialog();
            if (add_dialog.flag)
            {
                lst_people[pacientDataGridView.CurrentRow.Index].name = add_dialog.namebox.Text;
                lst_people[pacientDataGridView.CurrentRow.Index].ChangeDepart((Department)add_dialog.depbox.SelectedItem, add_dialog.syndrombox.Text, departments);
                lst_people[pacientDataGridView.CurrentRow.Index].ChangeDate(int.Parse(add_dialog.datebox.Text));
                pacientBindingSource.ResetBindings(false);
                departmentBindingSource.ResetBindings(false);
            }
          
            add_dialog.chanfl = false;
            add_dialog.Close();
        }

       

        private void shrift_button_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true; 
            fontDialog1.Font = this.Font; 
            fontDialog1.Color = this.ForeColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font; 
                this.ForeColor = fontDialog1.Color; 
            }
        }

        private void color_but_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor; // Текущий цвет в рамке
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                toolStrip1.BackColor = colorDialog1.Color;
            }
        }


        private void департаментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departments_list depart_lst = new departments_list();
            depart_lst.Owner = this;
            depart_lst.departments = departments;
            depart_lst.filter = filter;
            depart_lst.lst_people = lst_people;
            depart_lst.Font = Font;
            depart_lst.BackColor = BackColor;
            this.Hide();
            depart_lst.ShowDialog();
            this.Show();
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            if (!filter.Any())
            {
                return;
            }
            pacientBindingSource.DataSource = lst_people.FindAll(pac => pac.depart_name == filter[0]);
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
        
        }

        private void quite_save_Click(object sender, EventArgs e)
        {
            fsdep = new FileStream("Отделения.xml", FileMode.Create);
            xsdep = new XmlSerializer(typeof(List<Department>));
            xsdep.Serialize(fsdep, departments);
            fsdep.Close();
            Close();
        }

        private void pacientDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = pacientDataGridView.CurrentCell.RowIndex;
            pacientBindingSource.DataSource = lst_people.FindAll(pac => pac.depart_name == pacientDataGridView.Rows[i].Cells["depart_name"].Value.ToString());
            pacientBindingSource.ResetBindings(false);
        }

        private void resetfilterbut_Click(object sender, EventArgs e)
        {
            pacientBindingSource.DataSource = lst_people;
            pacientBindingSource.ResetBindings(false);
            filter.Clear();
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            int i = pacientDataGridView.CurrentCell.RowIndex;
            lst_people[i].Out(departments);
            lst_people.RemoveAt(i);
            pacientBindingSource.ResetBindings(false);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsdep = new FileStream("Отделения.xml", FileMode.Create);
            xsdep = new XmlSerializer(typeof(List<Department>));
            xsdep.Serialize(fsdep, departments);
            fsdep.Close();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }
    }

    }


   


