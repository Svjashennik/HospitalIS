using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        public bool newfile = false; // флаг работы с новым файлом
        public string filename { get; set; } // имя рабочего файла
        public List<Department> departments = new List<Department>(); // список отделений
        public List<Pacient> lst_people = new List<Pacient>(); // основной список пациентов
        public List<Pacient> lst_onscreen = new List<Pacient>(); // список пациентов для отображения
        public List<string> filter = new List<string>(); // фильтр от отделения
        public filter_form filt_form = new filter_form(); // форма фильтрации
        public bool flagfile = false; 
        public bool changecheck { get; set; } //флаг изменения файла
        public bool rights { get; set; } // флаг уровня доступа
        public void Form1_Load(object sender, EventArgs e)
        {
            userform usform = new userform();
            usform.Owner = this; // создание и запуск формы определения уровня доступа
            usform.ShowDialog();
            if (!usform.flag) // закрытие программы при закрытии формы
            {
                Close();
                return;
            }
            rights = usform.rights;
            usform.Close();
            if (!rights) // выключение действий с пациентами
            {
                groupBox1.Enabled = false;
            }
            startform fileform = new startform(); // создание и запуск формы выбора файлов
            fileform.Owner = this;
            fileform.ShowDialog();
            if (!fileform.flag) // закрытие программы при закрытии формы
            {
                Close();
                return;
            }
            if (fileform.newfile.Checked) // операция создания нового файла.
            {
                newfile = true;
                newfileoperation(sender, e);
                return;
            }
            filename = fileform.filename; // имя рабочего файла
            openfileoperation(sender, e); // операция открытия нового файла
            if (departments.Count == 0) // если файл пустой. Работаем в формате нового файла.
            {
                newfileoperation(sender, e);
            }
            fileform.Close();
            changecheck = false; // задаем параметр изменения
            lst_onscreen = lst_people; // передаем ссылки в источники данных
            pacientBindingSource.DataSource = lst_onscreen;
            departmentBindingSource.DataSource = departments;
            changecount();
        }



        private void Add_pole_Click(object sender, EventArgs e) // функция добавления пациента
        {
            add_dialog_formpac add_dialog = new add_dialog_formpac(); //Создание формы, указания владельца, передача ссылки на список.
            add_dialog.Owner = this;
            add_dialog.departments = departments;
            add_dialog.lst_people = lst_people;
        Add:
            add_dialog.ShowDialog();
            if (add_dialog.flag) // если флаг выполнения операции истененен, то добавляем нового пациента.
            {
                // Добавляем в список нового пациента через конструктор
                Pacient newpac = new Pacient(add_dialog.namebox.Text, add_dialog.datebox.Value, add_dialog.syndrombox.Text, ((Department)add_dialog.depbox.SelectedItem).name, (int)add_dialog.roombox.SelectedItem, add_dialog.dateadd.Value, add_dialog.dateclose.Value, add_dialog.medbox.Text, departments);
                lst_people.Add(newpac); 
                pacientBindingSource.ResetBindings(false);
                departmentBindingSource.ResetBindings(false);
                if (add_dialog.again) // проверка на повторный запуск.
                {
                    add_dialog.flag = false;
                    add_dialog.again = false;
                    goto Add;
                }
                changecheck = true; // флаг изменений в файле
            }
            add_dialog.Close();
            changecount(); // функция обновления количества.
        }

        private void change_but_Click(object sender, EventArgs e) // функция изменение пациента
        {
            if (pacientDataGridView.CurrentRow is null) return; // проверка на пустоту
            add_dialog_formpac add_dialog = new add_dialog_formpac(); // создание формы и передача необходимых параметров.
            add_dialog.Owner = this;
            add_dialog.chanfl = true; // флаг операции изменения
            add_dialog.sel = lst_onscreen[pacientDataGridView.CurrentCell.RowIndex]; // пациент для изменения
            add_dialog.departments = departments;
            add_dialog.lst_people = lst_people;
            add_dialog.ShowDialog();
            int i = pacientDataGridView.CurrentRow.Index;
            if (add_dialog.flag) // изменение параметров пациента
            {
                lst_onscreen[i].name = add_dialog.namebox.Text;
                lst_onscreen[i].ChangeDepart((Department)add_dialog.depbox.SelectedItem, add_dialog.syndrombox.Text, (int)add_dialog.roombox.SelectedItem, departments);
                lst_onscreen[i].ChangeDate(add_dialog.datebox.Value);
                lst_onscreen[i].ChangeCloseDate(add_dialog.dateadd.Value, add_dialog.dateclose.Value); // используя функции класса
                lst_onscreen[i].medicinecard = add_dialog.medbox.Text;
                pacientBindingSource.ResetBindings(false);
                departmentBindingSource.ResetBindings(false);
                _ = MessageBox.Show("Информация о пациенте успешна обновлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changecheck = true;
            }
            add_dialog.chanfl = false;
            add_dialog.Close();
            changecount();
        }



        private void Shrift_button_Click(object sender, EventArgs e) // кнопка изменения шрифта
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

        private void Color_but_Click(object sender, EventArgs e) // кнопка изменения цвета
        {
            colorDialog1.Color = this.BackColor; // Текущий цвет в рамке
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                toolStrip1.BackColor = colorDialog1.Color;
            }
        }


        private void ДепартаментыToolStripMenuItem_Click(object sender, EventArgs e) // переключение на форму отделений
        {
            departments_list depart_lst = new departments_list(); // создание формы и передача всех необходимых параметров
            depart_lst.Owner = this;
            depart_lst.departments = departments;
            depart_lst.filter = filter;
            depart_lst.lst_people = lst_people;
            depart_lst.Font = Font;
            depart_lst.rights = rights;
            depart_lst.BackColor = BackColor;
            this.Hide();
            depart_lst.ShowDialog();
            this.Show();
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            changecount();
            changecheck = true;
            if (!filter.Any()) // проверка на фильтры отделений
            {
                return;
            }
            lst_onscreen = lst_people.FindAll(pac => pac.depart_name == filter[0]); // фильтрация списка
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            filtbut.BackColor = System.Drawing.Color.Aqua; // изменение цвета кнопки
            changecount();
        }

        private void ПациентыToolStripMenuItem_Click(object sender, EventArgs e) // обновление списка пациента
        {
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            changecount();
        }

        private void Quite_save_Click(object sender, EventArgs e) // кнопка выхода и сохранения
        {
            сохранитьToolStripMenuItem_Click(sender, e);
            Close();
        }

        private void Resetfilterbut_Click(object sender, EventArgs e) // сброс фильтров
        {  
            lst_onscreen = lst_people; // обновление ссылки
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
            filt_form.checkBox1.Checked = false; // выключение галочек сохранения
            filt_form.checkBox2.Checked = false;
            filt_form.checkBox3.Checked = false;
            filtbut.BackColor = change_but.BackColor;
            filter.Clear();
            changecount();
        }

        private void deletebut_Click(object sender, EventArgs e) // функция удаления
        {
            if (pacientDataGridView.CurrentRow is null) return; // проверка на пустоту
            int i = pacientDataGridView.CurrentCell.RowIndex;
            if (lst_onscreen == lst_people) // если список пациентов и список вывода на экран исползуют одну ссылку, то удаляем только из одного
            {
                lst_onscreen[i].Out(departments);
                lst_onscreen.RemoveAt(i);
            }
            else // удаляем из обоих
            {
                lst_people.Remove(lst_onscreen[i]);
                lst_onscreen[i].Out(departments);
                lst_onscreen.RemoveAt(i);
            }
            pacientBindingSource.ResetBindings(false);
            changecount();
            changecheck = true; 
        }

        public void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newfile) // другой режим сохранения при работе с новым файлом
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
                return;
            }
            savefileoperation();
            changecheck = false;
        }

        private void sortbut_Click(object sender, EventArgs e) // кнопка сортировки
        {
            SortPac_form sort_form = new SortPac_form(); // создание формы сортировки
            sort_form.Owner = this;
            sort_form.ShowDialog();
            if (sort_form.flag) // если флаг выполнения истин, то выполняем сортировку
            {
                if (!sort_form.typesort) // выбор вида сортировки
                {
                    switch (sort_form.sort) // сравниваем выбор с типом сортировки
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
                        case "По палатам":
                            lst_onscreen = lst_onscreen.OrderBy(pac => pac.room).ToList();
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
                        case "По палатам":
                            lst_onscreen = lst_onscreen.OrderByDescending(pac => pac.room).ToList();
                            break;
                    }

                }
                pacientBindingSource.DataSource = lst_onscreen;
                pacientBindingSource.ResetBindings(false);
                changecount();
            }
        }

        private void filt_Click(object sender, EventArgs e) // кнопка фильтрации
        {
            filt_form.Owner = this; // создание формы и передача необходимых параметров
            lst_onscreen = lst_people;
            filt_form.flag = false;
            filt_form.departmentBindingSource.DataSource = departments;
            filt_form.ShowDialog();
            if (!filt_form.flag) return; 

            if (filt_form.checkBox1.Checked) // проверка фильтров из списка
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
                if (filt_form.roomcheck.Checked)
                {
                    lst_onscreen = lst_onscreen.FindAll(pac => pac.room == int.Parse(filt_form.roombox.Text));
                }
            }
            if (filt_form.checkBox1.Checked || filt_form.checkBox2.Checked || filt_form.checkBox3.Checked) filtbut.BackColor = System.Drawing.Color.Aqua;
            else filtbut.BackColor = change_but.BackColor; // изменение цвета кнопки
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
            changecount();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) // вызов формы информации
        {
            infoform inf = new infoform();
            inf.ShowDialog();
            inf.Close();
        }

        private void pacientDataGridView_SelectionChanged(object sender, EventArgs e) // отображение доп.информации
        {
            if (pacientDataGridView.CurrentRow is null) return;
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
            roomlab.Text = pac.room.ToString();
            if (pac.hear) hearlab.Text = "Числится";
            else hearlab.Text = "Не числится";
        }

        private void pacientDataGridView_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e) // фильтрация по отделениям
        {
            int i = pacientDataGridView.CurrentCell.RowIndex;
            lst_onscreen = lst_people.FindAll(pac => pac.depart_name == pacientDataGridView.Rows[i].Cells["depart_name"].Value.ToString());
            pacientBindingSource.DataSource = lst_onscreen;
            pacientBindingSource.ResetBindings(false);
            filtbut.BackColor = System.Drawing.Color.Aqua;
            changecount();
        }

        public void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e) // кнопка сохранения
        {
            saveFileDialog1.Filter = "Xml файлы (*.xml)|*.xml"; // создание формы сохранения и передача ей необходимых параметров
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel || saveFileDialog1.FileName == "")
                return;
            filename = saveFileDialog1.FileName; // название файла
            savefileoperation();
            changecheck = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Xml файлы (*.xml)|*.xml"; // откр
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            openfileoperation(sender, e);
            if (!flagfile) { return; }
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
            departmentBindingSource.DataSource = departments;
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            changecount();
            flagfile = false;
        }

        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newfile = true;
            lst_onscreen.Clear();
            lst_people.Clear();
            departments.Clear();
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            newfileoperation(sender, e);
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
        }

        public void newfileoperation(object sender, EventArgs e)
        {
            if (!rights) return;
            departments_list depart_lst = new departments_list();
            depart_lst.Owner = this;
            depart_lst.departments = departments;
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
            departmentBindingSource.DataSource = departments;
            depart_lst.rights = rights;
            while (departments.Count == 0)
            {
                _ = MessageBox.Show("Перед работой с новым файлом необходимо создать одно отделение.", "Новый файл", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                depart_lst.add_button_Click(sender, e);
            }
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            changecount();
            changecheck = true;
        }
        public void savefileoperation()
        {
            fsdep = new FileStream(filename, FileMode.Create);
            xsdep = new XmlSerializer(typeof(List<Department>));
            xsdep.Serialize(fsdep, departments);
            fsdep.Close();
        }
        public void openfileoperation(object sender, EventArgs e)
        {
            try
            {
                fsdep = new FileStream(filename, FileMode.Open);
                xsdep = new XmlSerializer(typeof(List<Department>));
                departments = (List<Department>)xsdep.Deserialize(fsdep);
                lst_people.Clear();
                foreach (Department dep in departments)
                {
                    foreach (Pacient pac in dep.people)
                    {
                        lst_people.Add(pac);
                    }
                }
                if (departments.Count == 0)
                {
                    newfileoperation(sender, e);
                }
                flagfile = true;
                fsdep.Close();
            }
            catch
            {
                _ = MessageBox.Show("Не удается считать данный файл, возможно он поврежден или не содержит необходимой информации.", "Ошибка поиска.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fsdep.Close();
            }

        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            filename = "samples/Отделения.xml";
            newfile = false;
            openfileoperation(sender, e);
            if (!flagfile) { return; }
            lst_onscreen = lst_people;
            pacientBindingSource.DataSource = lst_onscreen;
            departmentBindingSource.DataSource = departments;
            pacientBindingSource.ResetBindings(false);
            departmentBindingSource.ResetBindings(false);
            changecount();
            flagfile = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        private void visbut_Click(object sender, EventArgs e)
        {
            if (departments.Count == 0)
            {
                _ = MessageBox.Show("Визуализация не доступна для работы с пустым файлом.", "Пустой файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            visualform visform = new visualform();
            visform.Owner = this;
            visform.departments = departments;
            visform.lst_people = lst_people;
            visform.depbox.DataSource = departmentBindingSource.DataSource;
            visform.ShowDialog();
            visform.Close();
        }

        public void changecount()
        {
            if (lst_people is null || lst_onscreen is null) return;
            countrow.Text = lst_people.Count.ToString();
            herecount.Text = lst_onscreen.Count.ToString();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad.exe", "files/Info.txt");
        }

        private void hospital_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changecheck)
            {
                if (DialogResult.Cancel == MessageBox.Show("Вы уверены,что хотите выйти без сохранения?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) e.Cancel = true;
            }
        }
    }
}





