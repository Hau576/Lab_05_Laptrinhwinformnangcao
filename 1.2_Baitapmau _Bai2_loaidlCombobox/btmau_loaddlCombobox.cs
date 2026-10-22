using System;
using System.Windows.Forms;

namespace BaiTapComboBox
{
    public partial class btmau_loaddlCombobox : Form
    {
        public btmau_loaddlCombobox()
        {
            InitializeComponent();
        }

        // Sự kiện click của button "Load dữ liệu Combobox"
        private void btn_loadDL_Click(object sender, EventArgs e)
        {
            // Tạm thời hủy đăng ký sự kiện SelectedIndexChanged để tránh bắn MessageBox khi đang nạp dữ liệu
            cbo_dt.SelectedIndexChanged -= cbo_dt_SelectedIndexChanged;

            cbo_dt.Items.Clear();
            string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khác" };

            foreach (string s in dt)
            {
                cbo_dt.Items.Add(s);
            }

            if (cbo_dt.Items.Count > 0)
            {
                cbo_dt.SelectedIndex = 0; // Chọn mặc định phần tử đầu tiên
            }

            // Đăng ký lại sự kiện sau khi đã nạp xong dữ liệu
            cbo_dt.SelectedIndexChanged += cbo_dt_SelectedIndexChanged;
        }

        // Cách 1: Click button "Hiển thị", dân tộc được chọn xuất hiện trong Label
        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (cbo_dt.SelectedIndex >= 0)
            {
                lbl_kq.Text = s + cbo_dt.SelectedItem.ToString();
            }
            else
            {
                lbl_kq.Text = "Bạn chưa chọn dân tộc";
            }
        }

        // Cách 2: Dân tộc được chọn xuất hiện trên MessageBox ngay khi chọn từ ComboBox
        private void cbo_dt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_dt.SelectedIndex >= 0)
            {
                MessageBox.Show(
                    "Dân tộc được chọn: " + cbo_dt.SelectedItem.ToString(),
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}