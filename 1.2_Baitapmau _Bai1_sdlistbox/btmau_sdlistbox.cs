using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapListBox
{
    public partial class btmau_sdlistbox : Form
    {
        public btmau_sdlistbox()
        {
            InitializeComponent();
        }

        // Khởi tạo dữ liệu mẫu cho ListBox Trái khi Form tải lên
        private void btmau_sdlistbox_Load(object sender, EventArgs e)
        {
            lst_Trai.Items.Add("Cốc");
            lst_Trai.Items.Add("Ổi");
            lst_Trai.Items.Add("Xoài");
            lst_Trai.Items.Add("Mần");
            lst_Trai.Items.Add("Bưởi");
            lst_Trai.Items.Add("Cam");
        }

        // Button > : Chuyển các phần tử đang chọn từ Trái sang Phải
        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if (lst_Trai.SelectedIndex == -1) return;

            // Lấy danh sách các item đang chọn
            List<object> selectedItems = lst_Trai.SelectedItems.Cast<object>().ToList();

            foreach (var item in selectedItems)
            {
                lst_Phai.Items.Add(item);
                lst_Trai.Items.Remove(item);
            }
        }

        // Button >> : Chuyển tất cả phần tử từ Trái sang Phải
        private void btnQuaPhaiAll_Click(object sender, EventArgs e)
        {
            lst_Phai.Items.AddRange(lst_Trai.Items);
            lst_Trai.Items.Clear();
        }

        // Button < : Chuyển các phần tử đang chọn từ Phải sang Trái
        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (lst_Phai.SelectedIndex == -1) return;

            List<object> selectedItems = lst_Phai.SelectedItems.Cast<object>().ToList();

            foreach (var item in selectedItems)
            {
                lst_Trai.Items.Add(item);
                lst_Phai.Items.Remove(item);
            }
        }

        // Button << : Chuyển tất cả phần tử từ Phải sang Trái
        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
            lst_Trai.Items.AddRange(lst_Phai.Items);
            lst_Phai.Items.Clear();
        }

        // Xác nhận từ người dùng khi đóng Form
        private void btmau_sdlistbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}