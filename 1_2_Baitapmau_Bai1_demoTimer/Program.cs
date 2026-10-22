using System;
using System.Windows.Forms;

namespace DemoTimerApp
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi chạy chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new btm_demoTimer());
        }
    }
}