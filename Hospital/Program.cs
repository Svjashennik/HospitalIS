﻿using System;
using System.Windows.Forms;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() // главный запуск формы.
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new hospital());
        }
    }
}


