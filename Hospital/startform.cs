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
    public partial class startform : Form
    {
        public string filename;
        public bool flag = false;
        public startform()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ownfile.Checked = true;
            openFileDialog1.Filter = "Xml файлы (*.xml)|*.xml";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBox1.Text = openFileDialog1.FileName;
        }

        private void acceptbut_Click(object sender, EventArgs e)
        {
            if (ownfile.Checked)
            {
                filename = textBox1.Text;
            }
            if (sample.Checked) filename = "Отделения.xml";
            flag = true;
            Hide();
        }

        private void startform_Load(object sender, EventArgs e)
        {
            newfile.Checked = true;
        }
    }
}
