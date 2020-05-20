using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class sort_dep_form : Form
    {
        public string sort;
        public bool typesort = true;
        public bool flag = false;
        public sort_dep_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void acceptbut_Click(object sender, EventArgs e) // кнопка принятия
        {
            foreach (RadioButton rad in groupBox1.Controls) // поиск выбранного элемента
            {
                if (rad.Checked) // выбранный элемент становится фильтром
                {
                    sort = rad.Text;
                    break;
                }
            }
            if (Descradiobut.Checked) // определение режима сортировки
            {
                typesort = false;
            }
            flag = true;
            Hide();
        }

        private void sort_dep_form_Load(object sender, EventArgs e)
        {
            Descradiobut.Checked = true;
        }

        private void canselbut_Click(object sender, EventArgs e) // кнопка отмены
        {
            Hide();
        }

    }
}
