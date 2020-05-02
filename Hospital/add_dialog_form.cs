using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class add_dialog_formpac : Form
    {
        public bool flag = false;
        public bool chanfl = false;
        public bool again;
        public DataGridViewRow sel;
        public add_dialog_formpac()
        {
            InitializeComponent();
        }

        private void add_dialog_form_Load(object sender, EventArgs e)
        {
            if (chanfl)
            {
                namebox.Text = sel.Cells["name"].Value.ToString();
                datebox.Value = (DateTime)sel.Cells["date"].Value;
                syndrombox.Text = sel.Cells["syndrom"].Value.ToString();
                depbox.Text = sel.Cells["depart_name"].Value.ToString();
            }
        }

       
        private void Accept_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text))
            {
                MessageBox.Show("Вы должны ввести фамилию.","Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namebox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(syndrombox.Text))
            {
                MessageBox.Show("Вы должны ввести диагноз.","Ошибка ввода",MessageBoxButtons.OK,MessageBoxIcon.Error);
                syndrombox.Focus();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
