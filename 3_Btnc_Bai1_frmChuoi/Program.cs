using System;
using System.Windows.Forms;

namespace BaiTapChuoi
{
    internal static class Program
    {
        /// <summary>
        .
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new btnc_frmChuoi());
        }
    }
}