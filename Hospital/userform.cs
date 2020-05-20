using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class userform : Form
    {
        public bool rights = false;
        public bool flag = false;
        public userform()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // доступ к вводу пароля
        {
            if (comboBox1.Text == "Администратор") textBox1.Enabled = true;
            else textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) // проверка пароля
        {
            if (comboBox1.Text == "Администратор")
            {
                if (textBox1.Text == "hospital") rights = true;
                else
                {
                    _ = MessageBox.Show("Вы ввели неправильный пароль.", "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    return;
                }
            }
            flag = true;
            Hide();
        }

        private void userform_Load(object sender, EventArgs e) // выбор пользователя в комбобоксе
        {
            comboBox1.Text = comboBox1.Items[0].ToString();
        }
    }
}
