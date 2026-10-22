using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TuDienApp
{
    public partial class btvn_tudienAV_VA : Form
    {
        // Từ điển Anh - Việt mẫu
        private Dictionary<string, string> dictAnhViet = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "student", "Sinh viên, học sinh" },
            { "teacher", "Giáo viên, giảng viên" },
            { "worker", "Công nhân, người lao động" },
            { "hat", "Cái mũ, nón" },
            { "head", "Đầu, người đứng đầu" },
            { "mouse", "Con chuột" },
            { "cat", "Con mèo" },
            { "dog", "Con chó" },
            { "snake", "Con rắn" },
            { "lamb", "Con cừu non" },
            { "loan", "Khoản vay, cho vay" },
            { "frog", "Con ếch" },
            { "sheep", "Con cừu" }
        };

        // Từ điển Việt - Anh mẫu
        private Dictionary<string, string> dictVietAnh = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "sinh viên", "Student" },
            { "giáo viên", "Teacher" },
            { "công nhân", "Worker" },
            { "mũ", "Hat" },
            { "đầu", "Head" },
            { "chuột", "Mouse" },
            { "mèo", "Cat" },
            { "chó", "Dog" },
            { "rắn", "Snake" },
            { "cừu", "Sheep" }
        };

        public btvn_tudienAV_VA()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load: Nạp dữ liệu sẵn vào danh sách[cite: 23]
        private void btvn_tudienAV_VA_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Nạp dữ liệu tab Anh - Việt
            lstAnh.Items.Clear();
            foreach (var key in dictAnhViet.Keys)
            {
                lstAnh.Items.Add(key);
            }

            // Nạp dữ liệu tab Việt - Anh
            lstViet.Items.Clear();
            foreach (var key in dictVietAnh.Keys)
            {
                lstViet.Items.Add(key);
            }
        }

        // Khi chọn từ trong danh sách Anh - Việt, hiển thị nghĩa tương ứng[cite: 23]
        private void lstAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAnh.SelectedItem != null)
            {
                string word = lstAnh.SelectedItem.ToString();
                if (dictAnhViet.ContainsKey(word))
                {
                    txtNghiaAnh.Text = dictAnhViet[word];
                }
            }
        }

        // Khi chọn từ trong danh sách Việt - Anh, hiển thị nghĩa tương ứng[cite: 23]
        private void lstViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViet.SelectedItem != null)
            {
                string word = lstViet.SelectedItem.ToString();
                if (dictVietAnh.ContainsKey(word))
                {
                    txtNghiaViet.Text = dictVietAnh[word];
                }
            }
        }

        // Nút Thoát[cite: 23]
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi đóng Form
        private void btvn_tudienAV_VA_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình từ điển?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}