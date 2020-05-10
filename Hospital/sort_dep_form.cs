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

        private void acceptbut_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rad in groupBox1.Controls)
            {
                if (rad.Checked)
                {
                    sort = rad.Text;
                }
            }
            if (Descradiobut.Checked)
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

        private void canselbut_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
