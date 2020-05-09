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
    public partial class filter_form : Form
    {
        public bool flag;
        public filter_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
            comboBox2.SelectedItem = comboBox2.Items[0];
        }

        private void dateadd1_ValueChanged(object sender, EventArgs e)
        {
            dateadd2.Value = dateadd1.Value;
        }

        private void dateclose1_ValueChanged(object sender, EventArgs e)
        {
            dateclose2.Value = dateclose1.Value;
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            date2.Value = date1.Value;
        }

        private void age1_TextChanged(object sender, EventArgs e)
        {
            age2.Text = age1.Text;
        }

        private void day1_TextChanged(object sender, EventArgs e)
        {
            day2.Text = day1.Text;
        }

        private void AcceptBut_Click(object sender, EventArgs e)
        {
            flag = true;
            Hide();
        }

        private void CanselBut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                groupBox4.Enabled = true;
            else
                groupBox4.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Числится") factcheck.Checked = true;
            else factcheck.Checked = false;
        }

        private void filter_form_Load(object sender, EventArgs e)
        {

        }
    }
}
