using System;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    public partial class filt_dep_form : Form
    {
        public bool flag; // флаг выполнения операции
        public filt_dep_form() 
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.Enabled = false; // выключение блоков при запуске формы
            groupBox2.Enabled = false;
        }

        private void filt_dep_form_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // при изменении изменяется и доступ к ячейке
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;
        }

        private void count1_TextChanged(object sender, EventArgs e)
        {
            count2.Text = count1.Text; // подстраивание второго показателя под первый
        }

        private void max1_TextChanged(object sender, EventArgs e)
        {
            room2.Text = room1.Text; // подстаивание второго показателя под первый
        }

        private void acceptbut_Click(object sender, EventArgs e) // проверка ввода и кнопка принятия
        {
            if (room1.Text.All(ch => !char.IsDigit(ch)) && roomcheck.Checked) // проверка на числа
            {
                _ = MessageBox.Show("Кол-во палат должно выражаться числами.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                room1.Focus();
                return;
            }
            if (room2.Text.All(ch => !char.IsDigit(ch)) && roomcheck.Checked)
            {
                _ = MessageBox.Show("Кол-во палат должно выражаться числами.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                room2.Focus();
                return;
            }
            if (count2.Text.All(ch => !char.IsDigit(ch)) && countcheck.Checked)
            {
                MessageBox.Show("Кол-во пациентов должно выражаться числами.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count2.Focus();
                return;
            }
            if (count1.Text.All(ch => !char.IsDigit(ch)) && countcheck.Checked)
            {
                MessageBox.Show("Кол-во пациентов должно выражаться числами.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count1.Focus();
                return;
            }
            flag = true; // изменение флага проведения операции
            Hide();
        }

        private void canselbut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) 
        {
            if (checkBox2.Checked) //при изменении изменяется и доступ к ячейке
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;
        }
    }
}
