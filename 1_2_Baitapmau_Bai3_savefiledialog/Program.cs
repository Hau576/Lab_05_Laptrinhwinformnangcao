using _1_2_Baitapmau_Bai2_saveFileDialog;
using System;
using System.Windows.Forms;

namespace _1_2_Baitapmau_Bai3_savefiledialog
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new savefiledialog());
        }
    }
}