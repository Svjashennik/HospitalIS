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

        private void Cansel_but_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Accept_but_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rad in groupBox3.Controls)
            {
                if (rad.Checked)
                {
                    sort = rad.Text;
                }
            }
            if (DescradioButton.Checked)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
