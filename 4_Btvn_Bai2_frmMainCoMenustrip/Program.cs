using System;
using System.Windows.Forms;

namespace BTVN_Tuan6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy form chính chứa MenuStrip
            Application.Run(new btvn_frmMainCoMenustrip());
        }
    }
}