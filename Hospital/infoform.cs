﻿using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class infoform : Form
    {
        public infoform()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void infoform_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
