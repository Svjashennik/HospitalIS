using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class add_dialog_formpac : Form
    {
        public bool flag = false;
        public bool chanfl = false;
        public bool again;
        public Pacient sel;
        public List<Department> departments;
        public add_dialog_formpac()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_dialog_form_Load(object sender, EventArgs e)
        {
            depbox.DataSource = departments;
            depbox.SelectedItem = departments[0];
            roombox.DataSource = ((Department)depbox.SelectedItem).rooms;
            roombox.SelectedItem = ((Department)depbox.SelectedItem).rooms[0];
            if (chanfl)
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
            if (string.IsNullOrEmpty(namebox.Text))
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

            if (dateadd.Value > dateclose.Value)
            {
                MessageBox.Show("Дата принятия не может быть позже даты выписки.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateadd.Focus();
                return;
            }

            if (!chanfl && MessageBox.Show("Пациент с фамилией " + namebox.Text + " добавлен. \n\nПовторить ввод?", "Вопросы ввода", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

        private void depbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roombox.DataSource = ((Department)depbox.SelectedItem).rooms;
            roombox.SelectedItem = ((Department)depbox.SelectedItem).rooms[0];
        }
    }
}
