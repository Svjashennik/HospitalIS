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
        public List<Pacient> lst_onscreen = new List<Pacient>();
        public List<string> filter = new List<string>();
        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Отделени.xml"))
            {
                fsdep = new FileStream("Отделеyия.xml", FileMode.Open);
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
                lst_people.Add(new Pacient("Кириллкин", new DateTime(2000,2,3), "Модник", "Венерическое", new DateTime(2020,1,20),new DateTime(2020,2,20),departments));
                lst_people.Add(new Pacient("Райбекас", new DateTime(2000, 10, 12), "Котики", "Венерическое", new DateTime(2020, 5, 2), new DateTime(2020, 7, 25), departments));
                lst_people.Add(new Pacient("Никитин", new DateTime(2000, 6, 8), "Соболев", "Венерическое", new DateTime(2020, 1, 10), new DateTime(2020, 1, 20), departments));
                lst_people.Add(new Pacient("Калашникова", new DateTime(2001, 9, 25), "Мразь", "Гастрологическое", new DateTime(2020, 2, 15), new DateTime(2020, 6, 8), departments));
                lst_people.Add(new Pacient("Лебедь", new DateTime(2000, 12, 14), "Тряпка", "Гастрологическое", new DateTime(2020, 4, 20), new DateTime(2020, 8, 26), departments));
                lst_people.Add(new Pacient("Федоренков", new DateTime(2000, 6, 19), "Робот", "Гастрологическое", new DateTime(2020, 5, 10), new DateTime(2020, 6, 10), departments));
                lst_people.Add(new Pacient("Рогозникова", new DateTime(2000, 11, 15), "Словпок", "Гастрологическое", new DateTime(2020, 2, 10), new DateTime(2020, 5, 14), departments));
                lst_people.Add(new Pacient("Акаев", new DateTime(2000, 7, 21), "Лентяево", "Психиатрическое", new DateTime(2020, 3, 15), new DateTime(2020, 3, 16), departments));
                lst_people.Add(new Pacient("Комарницкий", new DateTime(1999, 4, 28), "ЦСВ", "Психиатрическое", new DateTime(2020, 4, 30), new DateTime(2020, 6, 1), departments));
            }
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
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
                Pacient newpac = new Pacient(add_dialog.namebox.Text, add_dialog.datebox.Value, add_dialog.syndrombox.Text, ((Department)add_dialog.depbox.SelectedItem).name, add_dialog.dateadd.Value, add_dialog.dateclose.Value, departments);
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
                lst_people[pacientDataGridView.CurrentRow.Index].ChangeDate(add_dialog.datebox.Value);
                lst_people[pacientDataGridView.CurrentRow.Index].ChangeCloseDate(add_dialog.dateadd.Value, add_dialog.dateclose.Value);
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
            lst_onscreen = lst_people.FindAll(pac => pac.depart_name == filter[0]);
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
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
            lst_onscreen = lst_people.FindAll(pac => pac.depart_name == pacientDataGridView.Rows[i].Cells["depart_name"].Value.ToString());
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
        }

        private void resetfilterbut_Click(object sender, EventArgs e)
        {
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
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

        private void pacientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortPac_form sort_form = new SortPac_form();
            sort_form.Owner = this;
            sort_form.ShowDialog();
            if (sort_form.flag)
            {
                if (!sort_form.typesort)
                {
                    switch (sort_form.sort)
                    {
                        case "По фамилии":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.name).ToList();
                            break;
                        case "По отделению":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.depart_name).ToList();
                            break;
                        case "По возрасту":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.age).ToList();
                            break;
                        case "По диагнозу":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.syndrom).ToList();
                            break;
                    }
                }
                else
                {
                    switch (sort_form.sort)
                    {
                        case "По фамилии":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.name).ToList();
                            break;
                        case "По отделению":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.depart_name).ToList();
                            break;
                        case "По возрасту":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.age).ToList();
                            break;
                        case "По диагнозу":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.syndrom).ToList();
                            break;
                    }

                }
                sort_form.Close();
                pacientBindingSource.DataSource = lst_onscreen;
                pacientBindingSource.ResetBindings(false);
            }
        }

        private void pacientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pacientDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    }


   


