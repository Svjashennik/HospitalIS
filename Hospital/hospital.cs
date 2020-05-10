﻿using System;
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
        public List<Department> departments { get; set; }
        public List<Pacient> lst_people = new List<Pacient>(); 
        public List<Pacient> lst_onscreen = new List<Pacient>();
        public List<string> filter = new List<string>();
        public filter_form filt_form = new filter_form();
        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Отделениия.xml"))
            {
                fsdep = new FileStream("Отделения.xml", FileMode.Open);
                xsdep = new XmlSerializer(typeof(List<Department>));
                departments = (List<Department>)xsdep.Deserialize(fsdep);
                foreach (Department dep in departments)
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
                Department dep1 = new Department("Кожевно-венерологическое", 20, "Купитман", "8-800-555-35-35");
                Department dep2 = new Department("Гастрологическое", 15, "Степанов", "8-900-555-35-35");
                Department dep3 = new Department("Психиатрическое", 40, "Колганова", "8-228-555-35-35");
                departments = new List<Department>();
                departments.Add(dep1);
                departments.Add(dep2);
                departments.Add(dep3);
                lst_people.Add(new Pacient("Кириллкин В.Л.", new DateTime(2000,2,3), "Ветрянка", "Кожевно-венерологическое", new DateTime(2020,1,20),new DateTime(2020,2,20),"783-212",departments));
                lst_people.Add(new Pacient("Райбекас А.Я.", new DateTime(2000, 10, 12), "Сыпь", "Кожевно-венерологическое", new DateTime(2020, 5, 2), new DateTime(2020, 7, 25), "784-818", departments));
                lst_people.Add(new Pacient("Никитин Р.Б.", new DateTime(2000, 6, 8), "Герпис", "Кожевно-венерологическое", new DateTime(2020, 1, 10), new DateTime(2020, 1, 20), "233-252", departments));
                lst_people.Add(new Pacient("Калашникова С.Д.", new DateTime(2001, 9, 25), "Гастрит", "Гастрологическое", new DateTime(2020, 2, 15), new DateTime(2020, 6, 8), "983-000", departments));
                lst_people.Add(new Pacient("Лебедь Д.О.", new DateTime(2000, 12, 14), "Гастрит", "Гастрологическое", new DateTime(2020, 4, 20), new DateTime(2020, 8, 26), "753-900", departments));
                lst_people.Add(new Pacient("Федоренков В.В.", new DateTime(2000, 6, 19), "Ожирение", "Гастрологическое", new DateTime(2020, 5, 10), new DateTime(2020, 6, 10), "408-123", departments));
                lst_people.Add(new Pacient("Рогозникова С.Л.", new DateTime(2000, 11, 15), "Обследование", "Гастрологическое", new DateTime(2020, 2, 10), new DateTime(2020, 5, 14), "645-802", departments));
                lst_people.Add(new Pacient("Акаев И.С.", new DateTime(2000, 7, 21), "Неврит", "Психиатрическое", new DateTime(2020, 3, 15), new DateTime(2020, 3, 16), "123-987", departments));
                lst_people.Add(new Pacient("Комарницкий В.Г.", new DateTime(1999, 4, 28), "Биполярное расстройство", "Психиатрическое", new DateTime(2020, 4, 30), new DateTime(2020, 6, 1), "626-228", departments));
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
                Pacient newpac = new Pacient(add_dialog.namebox.Text, add_dialog.datebox.Value, add_dialog.syndrombox.Text, ((Department)add_dialog.depbox.SelectedItem).name, add_dialog.dateadd.Value, add_dialog.dateclose.Value,add_dialog.medbox.Text ,departments);
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
            add_dialog.sel = lst_onscreen[pacientDataGridView.CurrentCell.RowIndex];
            add_dialog.depbox.DataSource = departmentBindingSource;
            add_dialog.ShowDialog();
            int i = pacientDataGridView.CurrentRow.Index;
            if (add_dialog.flag)
            {
                lst_onscreen[i].name = add_dialog.namebox.Text;
                lst_onscreen[i].ChangeDepart((Department)add_dialog.depbox.SelectedItem, add_dialog.syndrombox.Text, departments);
                lst_onscreen[i].ChangeDate(add_dialog.datebox.Value);
                lst_onscreen[i].ChangeCloseDate(add_dialog.dateadd.Value, add_dialog.dateclose.Value);
                lst_onscreen[i].medicinecard = add_dialog.medbox.Text;
                pacientBindingSource.ResetBindings(false);
                departmentBindingSource.ResetBindings(false);
                _ = MessageBox.Show("Информация о пациенте успешна обновлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void resetfilterbut_Click(object sender, EventArgs e)
        {
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
            filt_form.checkBox1.Checked = false;
            filt_form.checkBox2.Checked = false;
            filt_form.checkBox3.Checked = false;
            filtbut.BackColor = change_but.BackColor;
            filter.Clear();
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            int i = pacientDataGridView.CurrentCell.RowIndex;
            if (lst_onscreen == lst_people)
            {
                lst_onscreen[i].Out(departments);
                lst_onscreen.RemoveAt(i);
            }
            else
            {
                lst_people.Remove(lst_onscreen[i]);
                lst_onscreen[i].Out(departments);
                lst_onscreen.RemoveAt(i);
            }
            pacientBindingSource.ResetBindings(false);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsdep = new FileStream("Отделения.xml", FileMode.Create);
            xsdep = new XmlSerializer(typeof(List<Department>));
            xsdep.Serialize(fsdep, departments);
            fsdep.Close();
        }

        private void sortbut_Click(object sender, EventArgs e)
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
                        case "По дате приема":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.date_add).ToList();
                            break;
                        case "По дате выписки":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.date_close).ToList();
                            break;
                        case "По факту пребывания":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.hear).ToList();
                            break;
                        case "По кол-ву дней":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.dayhear).ToList();
                            break;
                        case "По мед.карте":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.medicinecard).ToList();
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
                        case "По дате приема":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.date_add).ToList();
                            break;
                        case "По дате выписки":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.date_close).ToList();
                            break;
                        case "По факту пребывания":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.hear).ToList();
                            break;
                        case "По кол-ву дней":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.dayhear).ToList();
                            break;
                        case "По мед.карте":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.medicinecard).ToList();
                            break;
                    }

                }
                pacientBindingSource.DataSource = lst_onscreen;
                pacientBindingSource.ResetBindings(false);
            }
        }

        private void filt_Click(object sender, EventArgs e)
        {
            filt_form.Owner = this;
            lst_onscreen = lst_people;
            filt_form.flag = false;
            filt_form.departmentBindingSource.DataSource = departments;
            filt_form.ShowDialog();
            if (!filt_form.flag) return;

            if (filt_form.checkBox1.Checked)
            {
                if (filt_form.nameCheck.Checked)
                {
                    lst_onscreen = lst_onscreen.FindAll(pac => pac.name.Contains(filt_form.namesub.Text));
                }
                if (filt_form.departsub.Checked)
                {
                    lst_onscreen = lst_onscreen.FindAll(pac => pac.depart_name.Contains(filt_form.departsubtext.Text));
                }
                if (filt_form.syndromsub.Checked)
                { 
                    lst_onscreen = lst_onscreen.FindAll(pac => pac.syndrom.Contains(filt_form.syndromsubtext.Text));
                }
                if (filt_form.medicinesub.Checked)
                {
                    lst_onscreen = lst_onscreen.FindAll(pac => pac.medicinecard.Contains(filt_form.medicinesubtext.Text));
                }
            }

            if (filt_form.checkBox2.Checked)
            {
                if (filt_form.datecheck.Checked)
                {
                    lst_onscreen = lst_onscreen.FindAll(pac => (filt_form.date1.Value <= pac.date && pac.date <= filt_form.date2.Value));
                }

                if (filt_form.dateaddcheck.Checked)
                {
                    lst_onscreen = lst_onscreen.FindAll(pac => (filt_form.dateadd1.Value <= pac.date_add && pac.date_add <= filt_form.dateadd2.Value));
                }

                if (filt_form.datecloseCheck.Checked)
                {
                    lst_onscreen = lst_onscreen.FindAll(pac => (filt_form.dateclose1.Value <= pac.date_close && pac.date_close <= filt_form.dateclose2.Value));
                }
            }
            if (filt_form.checkBox3.Checked)
            {
                if (filt_form.departcheck.Checked)
                {
                        lst_onscreen = lst_onscreen.FindAll(pac => pac.depart_name == filt_form.departbox.Text);
                }
                        
                if (filt_form.dayhearcheck.Checked)
                {
                        lst_onscreen = lst_onscreen.FindAll(pac => (int.Parse(filt_form.day1.Text) <= pac.dayhear && int.Parse(filt_form.day2.Text) >= pac.dayhear));
                }

                if (filt_form.agecheck.Checked)
                {
                        lst_onscreen = lst_onscreen.FindAll(pac => (int.Parse(filt_form.age1.Text) <= pac.age && int.Parse(filt_form.age2.Text) >= pac.age));
                }
                if (filt_form.hearcheck.Checked)
                {
                    if (filt_form.factcheck.Checked) lst_onscreen = lst_onscreen.FindAll(pac => pac.hear);
                    else lst_onscreen = lst_onscreen.FindAll(pac => !pac.hear);
                }
            }
            if (filt_form.checkBox1.Checked || filt_form.checkBox2.Checked || filt_form.checkBox3.Checked) filtbut.BackColor = System.Drawing.Color.Aqua;  
            else filtbut.BackColor = change_but.BackColor;
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _=MessageBox.Show("Данная программа разработана студентом \n Финансового Университета второго года обучения группы ПИ18-2 Асташкина Никиты. \n Научный руководитель - Чистов Д.В.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pacientDataGridView_SelectionChanged(object sender, EventArgs e)
        {   if (pacientDataGridView.CurrentRow is null) return;
            Pacient pac = lst_onscreen[pacientDataGridView.CurrentRow.Index];
            namelab.Text = pac.name;
            medicinelab.Text = pac.medicinecard;
            depart_lab.Text = pac.depart_name;
            syndromlab.Text = pac.syndrom;
            agelab.Text = pac.age.ToString();
            datelab.Text = pac.date.ToString("d");
            dateaddlab.Text = pac.date_add.ToString("d");
            datecloselab.Text = pac.date_close.ToString("d");
            daylab.Text = pac.dayhear.ToString();
            if (pac.hear) hearlab.Text = "Числится";
            else hearlab.Text = "Не числится";
        }

        private void pacientDataGridView_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = pacientDataGridView.CurrentCell.RowIndex;
            lst_onscreen = lst_people.FindAll(pac => pac.depart_name == pacientDataGridView.Rows[i].Cells["depart_name"].Value.ToString());
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
        }
    }
}


   


