using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    public partial class departments_list : Form
    {
        public List<Department> departments; // Основной список отделений
        public List<Department> dep_onscreen; // Список отделений, который выводится на экран
        public List<string> filter; // список фильтров для основной формы.
        public filt_dep_form filt_form = new filt_dep_form(); // форма фильтрации
        public List<Pacient> lst_people; // список пациентов
        public bool rights { get; set; } // Переменная прав доступа
        public departments_list()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void add_button_Click(object sender, EventArgs e) // кнопка добавления отделения
        {
            add_dep_form add_dialog = new add_dep_form(); // Создание формы, указания владельца, передача ссылки на список.
            add_dialog.Owner = this;
            add_dialog.departments = departments;
        Add: // метка повтора.
            add_dialog.ShowDialog();
            if (add_dialog.flag) // если флаг выполнения операции истененен, то добавляем новое отделение.
            {
                // Добавляем в список новое отделение через конструктор
                departments.Add(new Department(add_dialog.namebox.Text, add_dialog.managerbox.Text, add_dialog.phonebox.Text, Department.roomslst((int)add_dialog.roombox.Value, departments.Count + 1)));
                departmentBindingSource.ResetBindings(false);
                if (add_dialog.again) // проверка на повторный запуск.
                {
                    add_dialog.flag = false;
                    add_dialog.again = false;
                    goto Add;
                }
            }
            add_dialog.Close();
            changecount(); // функция обновления количества.
        }

        private void chan_button_Click(object sender, EventArgs e) // кнопка изменения отделения
        {
            add_dep_form add_dialog = new add_dep_form(); // создание формы и передача необходимых параметров.
            add_dialog.Owner = this;
            add_dialog.departments = departments;
            add_dialog.chanfl = true; // измененния флага
            add_dialog.sel = dep_onscreen[departmentDataGridView.CurrentRow.Index]; // передача выбранного отделения
            add_dialog.ShowDialog();
            int i = departmentDataGridView.CurrentRow.Index;

            if (add_dialog.flag) // изменение выбранного отделения
            {
                dep_onscreen[i].phone = add_dialog.phonebox.Text;
                dep_onscreen[i].manager = add_dialog.managerbox.Text;
                dep_onscreen[i].rooms = Department.roomslst((int)add_dialog.roombox.Value, departments.FindIndex(dep => dep.name == dep_onscreen[i].name) + 1);
                dep_onscreen[i].countroom = dep_onscreen[i].rooms.Count; 
                if (dep_onscreen[i].name != add_dialog.namebox.Text)
                {
                    dep_onscreen[i].ChangeName(add_dialog.namebox.Text); // при изменении имени отделения оно изменяется у всех пациентов
                }
                _ = MessageBox.Show("Информация об отделении успешна обновлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            departmentBindingSource.ResetBindings(false);
            add_dialog.chanfl = false;
            add_dialog.Close();
            changecount(); 
        }

        private void departments_list_Load(object sender, EventArgs e) // загрузка формы
        {
            dep_onscreen = departments; // передача ссылки в список отображения
            departmentBindingSource.DataSource = dep_onscreen;
            if (!rights) groupBox1.Enabled = false; // закрытие доступа не администратору
            changecount();
        }


        private void настройкаЦветаToolStripMenuItem_Click(object sender, EventArgs e) // создание формы изменения цвета
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


        private void deletebut_Click(object sender, EventArgs e) // операция удаления отделения
        {
            if (MessageBox.Show("Вы уверены? Данная операция удалит всех пациентов данного отделения.", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int i = departmentDataGridView.CurrentCell.RowIndex;
                foreach (Pacient pac in dep_onscreen[i].people) // удаление всеx пациентов главного списка из выбранного отделения
                {
                    lst_people.Remove(pac);
                }
                if (dep_onscreen == departments) // если список отделений и список вывода на экран исползуют одну ссылку, то удаляем только из одного
                {
                    dep_onscreen.RemoveAt(i);
                }
                else // удаляем из обоих
                {
                    departments.Remove(dep_onscreen[i]);
                    dep_onscreen.RemoveAt(i);
                }
                departmentBindingSource.ResetBindings(false);
                changecount();
            }
        }

        private void настройкаШрифтаToolStripMenuItem_Click(object sender, EventArgs e) // создание и запуск формы настройки шрифта
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = this.Font;
            fontDialog1.Color = this.ForeColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font; // передаем его в материнскую и дочернюю форму.
                this.ForeColor = fontDialog1.Color;
                Owner.Font = fontDialog1.Font;
                Owner.ForeColor = fontDialog1.Color;
            }
        }

        private void отделенияToolStripMenuItem_Click(object sender, EventArgs e) // при нажатии на кнопку отделений база данных просто обновится
        {
            departmentBindingSource.ResetBindings(false);
            changecount();
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); // переключение на список пациентов
        }

        private void exitbut_Click(object sender, EventArgs e)
        {
            Hide(); // переключение на список пациентов
        }

        private void sortbut_Click(object sender, EventArgs e) // кнопка сортировки
        {
            sort_dep_form sort_form = new sort_dep_form(); // создание формы и передача необходимых параметов
            sort_form.Owner = this;
            sort_form.ShowDialog();
            if (sort_form.flag)
            {
                if (!sort_form.typesort) // определяем тип сортировки по возрастанию или убыванию
                {
                    switch (sort_form.sort) // сравниваем выбор с типом сортировки
                    {
                        case "По названию":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.name).ToList();
                            break;
                        case "По заведующему":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.manager).ToList();
                            break;
                        case "По кол-ву палат":
                            dep_onscreen = dep_onscreen.OrderBy(pac => pac.countroom).ToList();
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
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.countroom).ToList();
                            break;
                        case "По кол-ву пациентов":
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.countpac).ToList();
                            break;
                        case "По номеру телефона":
                            dep_onscreen = dep_onscreen.OrderByDescending(pac => pac.phone).ToList();
                            break;
                    }
                }
                departmentBindingSource.DataSource = dep_onscreen; // обновляем источник данных
                departmentBindingSource.ResetBindings(false);
                changecount();
            }
        }

        private void clearfiltbut_Click(object sender, EventArgs e) // очистка фильтров
        {
            dep_onscreen = departments; // передаем ссылку на главный список отделений
            departmentBindingSource.DataSource = dep_onscreen;
            departmentBindingSource.ResetBindings(false); // обновляем источник данных
            filt_form.checkBox1.Checked = false; // убираем галочки из формы фильтрации
            filt_form.checkBox2.Checked = false;
            filtbut.BackColor = chan_button.BackColor; // изменяем цвет
            changecount(); 
        }

        private void filtbut_Click(object sender, EventArgs e) // кнопка фильтрации 
        {
            filt_form.Owner = this; //передаем форме параметры
            dep_onscreen = departments; // обновляем ссылку
            filt_form.flag = false;
            filt_form.ShowDialog();
            if (!filt_form.flag) return;

            if (filt_form.checkBox1.Checked) // если условие фильтрации было проставлено, то список экрана фильтруется, и проверяется по следующему параметру
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

                if (filt_form.roomcheck.Checked)
                {
                    dep_onscreen = dep_onscreen.FindAll(dep => int.Parse(filt_form.room1.Text) <= dep.countroom && int.Parse(filt_form.room2.Text) >= dep.countroom);
                }
            }
            if (filt_form.checkBox1.Checked || filt_form.checkBox2.Checked) filtbut.BackColor = System.Drawing.Color.Aqua;  // изменение цвета кнопки фильтрации
            else filtbut.BackColor = chan_button.BackColor;
            departmentBindingSource.DataSource = dep_onscreen; // обновление источника данных
            departmentBindingSource.ResetBindings(false);
            changecount();
        }

        private void departmentDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) // фильтрация главной формы по двойному щелчку
        {
            int i = departmentDataGridView.CurrentCell.RowIndex;
            filter.Add(departmentDataGridView.Rows[i].Cells["name"].Value.ToString()); // передаем фильтр в нужну форму
            Hide();
        }
        public void changecount() // функция подсчета отображаемых строк и строк всего
        {
            if (departments is null || dep_onscreen is null) return;
            countrow.Text = departments.Count.ToString();
            herecount.Text = dep_onscreen.Count.ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}
