using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class SortPac_form : Form
    {
        public string sort;
        public bool typesort = true;
        public bool flag = false;
        public SortPac_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Cansel_but_Click(object sender, EventArgs e) // кнопка выхода из формы
        {
            Hide();
        }

        private void Accept_but_Click(object sender, EventArgs e) // кнопка принятия
        {
            foreach (RadioButton rad in groupBox3.Controls) // поиск выбранного параметра
            {
                if (rad.Checked)
                {
                    sort = rad.Text;
                    break;
                }
            }
            if (DescradioButton.Checked) // определение типа сортировки
            {
                typesort = false;
            }
            flag = true;
            Hide();
        }

        private void SortPac_form_Load(object sender, EventArgs e)
        {
            DescradioButton.Checked = true;
        }
    }
}
