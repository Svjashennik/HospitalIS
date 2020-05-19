using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    public partial class add_dep_form : Form
    {
        public bool flag = false; //Флаг проверки, выполнена операция или нет.
        public bool chanfl = false; //флаг проверки по какому пути должна идти функция, добавления или изменения.
        public bool again; // флаг проверки повторять ли запуск формы или нет.
        public List<Department> departments; // список отделений необходимый для проверки с одинаковыми именами.
        public Department sel; // выбранное отделение для изменения
        public add_dep_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Accept_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text)) // Проверяем значения текст боксов на пустоту.
            {
                MessageBox.Show("Вы должны ввести название.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namebox.Focus();
                return;
            }
            if (!chanfl && departments.Where(dep => dep.name == namebox.Text).Any()) // проверяем имя на уникальность.
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

            if (string.IsNullOrEmpty(phonebox.Text))
            {
                MessageBox.Show("Вы должны ввести телефон.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phonebox.Focus();
                return;
            }

            if (!chanfl && MessageBox.Show("Отделение " + namebox.Text + " добавлено. \n\nПовторить ввод?", "Вопросы ввода", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                again = true; // уточнение на повторение.
            }
            flag = true; // изменяем значение флага выполнения
            this.Hide();
        }

        private void cansel_but_Click(object sender, EventArgs e) // кнопка отмены.
        {
            this.Hide(); 
        }

        private void add_dep_form_Load(object sender, EventArgs e)
        {
            if (chanfl) // в случае флага изменения подгружаем в текстбоксы данные департамента.
            {
                namebox.Text = sel.name;
                managerbox.Text = sel.manager;
                phonebox.Text = sel.phone;
                roombox.Value = sel.rooms.Count;
            }
        }
    }
}
