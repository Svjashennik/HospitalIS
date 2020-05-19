﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class add_dialog_formpac : Form
    {
        public bool flag = false; //Флаг проверки, выполнена операция или нет.
        public bool chanfl = false;//флаг проверки по какому пути должна идти функция, добавления или изменения.
        public bool again;// флаг проверки повторять ли запуск формы или нет.
        public Pacient sel; //выбранный пациент для изменения
        public List<Department> departments; // список для заполнения комбобокса
        public List<Pacient> lst_people; // список для проверки уникальности
        public add_dialog_formpac()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_dialog_form_Load(object sender, EventArgs e)
        {
            depbox.DataSource = departments; // передача в источники данных
            depbox.SelectedItem = departments[0];
            roombox.DataSource = ((Department)depbox.SelectedItem).rooms; // выбора набора палат, конкретного департамента.
            roombox.SelectedItem = ((Department)depbox.SelectedItem).rooms[0];
            dateadd.Value = DateTime.Now;
            dateclose.Value = DateTime.Now;
            if (chanfl) // заполнение данных выбранного пациента
            {
                namebox.Text = sel.name;
                datebox.Value = sel.date;
                syndrombox.Text = sel.syndrom;
                depbox.SelectedItem = (sel.FindDep(departments)).name;
                depbox.Text = sel.depart_name;
                dateadd.Value = sel.date_add;
                dateclose.Value = sel.date_close;
                medbox.Text = sel.medicinecard;
                roombox.SelectedItem = sel.room;
                roombox.Text = roombox.SelectedItem.ToString();
            }
        }


        private void Accept_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text)) // проверка на пустые строки
            {
                MessageBox.Show("Вы должны ввести фамилию.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namebox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(syndrombox.Text))
            {
                MessageBox.Show("Вы должны ввести диагноз.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                syndrombox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(medbox.Text))
            {
                MessageBox.Show("Вы должны ввести номер мед карты.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                syndrombox.Focus();
                return;
            }


            if (dateadd.Value > dateclose.Value) // проверка на правильный порядок дат
            {
                MessageBox.Show("Дата принятия не может быть позже даты выписки.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateadd.Focus();
                return;
            }

            if (checkpac()) //проверка на уникальность записи
            {
                MessageBox.Show("Аналогичный пациент уже существует.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namebox.Focus();
                return;
            }

            if (!chanfl && MessageBox.Show("Пациент с фамилией " + namebox.Text + " добавлен. \n\nПовторить ввод?", "Вопросы ввода", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                again = true; // уточнение на повторение операции
            }

            flag = true;
            this.Hide();
        }

        public bool checkpac() // функция на проверку уникальности
        {
            foreach (Pacient pac in lst_people)
            {
                if (pac.date_add != dateadd.Value) continue;
                if (pac.date_close != dateclose.Value) continue;
                if (pac.date != datebox.Value) continue;
                if (pac.name != namebox.Text) continue;
                if (pac.depart_name != depbox.Text) continue;
                if (pac.syndrom != syndrombox.Text) continue;
                if (pac.medicinecard != medbox.Text) continue;
                if (pac.room.ToString() != roombox.Text) continue;
                return true;
            }
            return false;
        }

        private void cansel_but_Click(object sender, EventArgs e) // кнопка отмены
        {
            this.Hide();
        }

        private void depbox_SelectedIndexChanged(object sender, EventArgs e) // изменение списка палат
        {
            roombox.DataSource = ((Department)depbox.SelectedItem).rooms;
            roombox.SelectedItem = ((Department)depbox.SelectedItem).rooms[0];
        }
    }
}
