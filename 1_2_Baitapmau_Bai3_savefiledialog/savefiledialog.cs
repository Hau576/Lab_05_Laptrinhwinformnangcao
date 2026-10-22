#pragma warning disable CS8981
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1_2_Baitapmau_Bai2_saveFileDialog
{
    public partial class savefiledialog : Form
    {
        public savefiledialog()
        {
            InitializeComponent();
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.Filter = "Text files | *.txt";
            if (svg.ShowDialog() == DialogResult.OK)
            {
                string filename = svg.FileName;
                textBox1.Text = filename;

                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Text File (*.txt)|*.txt|All Document (*.pdf)|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;

                using (StreamReader f = new StreamReader(openFileDialog1.FileName))
                {
                    richTextBox1.Text = f.ReadToEnd();
                }
            }
        }

        private void savefiledialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}