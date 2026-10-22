using System;
using System.Windows.Forms;

namespace QuanLySinhVienListViewApp
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
            Application.Run(new bttl_frmBaitap1());
        }
    }
}