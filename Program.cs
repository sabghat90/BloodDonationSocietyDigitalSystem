﻿using System;
using System.Windows.Forms;
using BloodDonationSocietyDigitalSystem.WinForms;

namespace BloodDonationSocietyDigitalSystem
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        /// something added
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
