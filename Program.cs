﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayo_Laurence_Act7_EDP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Add this to your program startup (Program.cs)
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // For free use

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplashScreen());

            
        }
    }
}
