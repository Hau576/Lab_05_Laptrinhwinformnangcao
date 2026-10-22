using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapTạiLop
{
    public partial class bttl_combobox : Form
    {
        public bttl_combobox()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra số nguyên tố
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Nút Cập nhật (&Cập nhật)
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtNhapSo.Text.Trim(), out int so) || so <= 0)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }

            // Kiểm tra trùng số trong ComboBox
            if (cboDanhSachSo.Items.Contains(so))
            {
                MessageBox.Show($"Số {so} đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
                return;
            }

            // Thêm vào ComboBox
            cboDanhSachSo.Items.Add(so);
            cboDanhSachSo.SelectedItem = so; // Tự động chọn số vừa thêm

            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // Sự kiện khi người dùng chọn một số trong ComboBox
        private void cboDanhSachSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUocSo.Items.Clear();

            if (cboDanhSachSo.SelectedItem != null && int.TryParse(cboDanhSachSo.SelectedItem.ToString(), out int n))
            {
                // Tìm tất cả ước số của n và đưa vào ListBox
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        lstUocSo.Items.Add(i);
                    }
                }
            }
        }

        // Nút Tổng các ước số (&Tổng các ước số)
        private void btnTongUocSo_Click(object sender, EventArgs e)
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách ước số đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tong = lstUocSo.Items.Cast<int>().Sum();
            MessageBox.Show($"Tổng các ước số là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Số lượng các ước số chẵn (Số lượng các ước số &chẵn)
        private void btnSoLuongUocChan_Click(object sender, EventArgs e)
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách ước số đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int countChan = lstUocSo.Items.Cast<int>().Count(x => x % 2 == 0);
            MessageBox.Show($"Số lượng các ước số chẵn là: {countChan}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Số lượng các ước số nguyên tố (Số lượng các ước số &nguyên tố)
        private void btnSoLuongUocNguyenTo_Click(object sender, EventArgs e)
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách ước số đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int countNT = lstUocSo.Items.Cast<int>().Count(x => IsPrime(x));
            MessageBox.Show($"Số lượng các ước số nguyên tố là: {countNT}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Thoát (&Thoát)
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận từ người dùng khi đóng Form
        private void bttl_combobox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}