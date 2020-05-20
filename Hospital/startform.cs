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

        private void button1_Click(object sender, EventArgs e) // кнопка выбора файла
        {
            ownfile.Checked = true; // открытие формы и передача ей необходимых параметров
            openFileDialog1.Filter = "Xml файлы (*.xml)|*.xml";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) // проверка на отмену
                return;
            textBox1.Text = openFileDialog1.FileName; // заполнение текстбокса
        }

        private void acceptbut_Click(object sender, EventArgs e)
        {
            if (newfile.Checked) // если новый файл
            {
                flag = true;
                Hide();
                return;
            }
            if (ownfile.Checked) // если выбран свой файх
            {
                filename = textBox1.Text;
            }
            if (sample.Checked) filename = "samples/Отделения.xml"; // если образец
            if (!File.Exists(filename) && !newfile.Checked) // проверка существования файла.
            {
                _ = MessageBox.Show("Не удается найти путь к файлу. Проверьте правильность ввода.", "Ошибка поиска.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FileStream fsdep = new FileStream(filename, FileMode.Open); // предварительное открытие файла, в случае ошибки вернет в начало формы.
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
