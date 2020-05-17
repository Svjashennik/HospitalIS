using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            if (newfile.Checked)
            {
                flag = true;
                Hide();
                return;
            }
            if (ownfile.Checked)
            {
                filename = textBox1.Text;
            }
            if (sample.Checked) filename = "samples/Отделения.xml";
            if (!File.Exists(filename) && !newfile.Checked)
            {
                _ = MessageBox.Show("Не удается найти путь к файлу. Проверьте правильность ввода.", "Ошибка поиска.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FileStream fsdep = new FileStream(filename, FileMode.Open);
            XmlSerializer xsdep = new XmlSerializer(typeof(List<Department>));
            try
            {
                List<Department> l = (List<Department>)xsdep.Deserialize(fsdep);
                fsdep.Close();
            }
            catch
            {
                _ = MessageBox.Show("Не удается считать данный файл, возможно он поврежден или не содержит необходимой информации.", "Ошибка поиска.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fsdep.Close();
                return;
            }
            flag = true;
            Hide();
        }

        private void startform_Load(object sender, EventArgs e)
        {
            newfile.Checked = true;
        }
    }
}
