using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyHocVienApp
{
    public partial class btnc_QLHocVien : Form
    {
        public btnc_QLHocVien()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load: Nạp dữ liệu mẫu và ẩn panel nhập học viên ban đầu
        private void btnc_QLHocVien_Load(object sender, EventArgs e)
        {
            lstLopA.Items.Add("Trần Hùng");
            lstLopA.Items.Add("Nguyễn Hưng");
            lstLopA.Items.Add("Lâm Tú");

            lstLopB.Items.Add("Tuấn Hưng");
            lstLopB.Items.Add("Hồng Ngọc");
            lstLopB.Items.Add("Anh Minh");
            lstLopB.Items.Add("Bảo Lâm");

            // Nạp dữ liệu cho ComboBox chọn lớp trên panel phụ
            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");
            cboLop.SelectedIndex = 0;

            // Ẩn panel nhập học viên lúc mới mở form
            pnlNhapHocVien.Visible = false;
        }

        // --- CÁC CHỨC NĂNG TRÊN MENU ---

        // 1. Menu: Nhập học viên mới (Hiển thị panel nhập liệu)
        private void mnuNhapHocVienMới_Click(object sender, EventArgs e)
        {
            pnlNhapHocVien.Visible = true;
            txtHoVaTen.Clear();
            cboLop.SelectedIndex = 0;
            txtHoVaTen.Focus();
        }

        // 2. Menu: Chuyển sang lớp B
        private void mnuChuyenSangLopB_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên trong danh sách Lớp A trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> selectedItems = lstLopA.SelectedItems.Cast<string>().ToList();
            foreach (string item in selectedItems)
            {
                lstLopB.Items.Add(item);
                lstLopA.Items.Remove(item);
            }
        }

        // 3. Menu: Chuyển sang lớp A
        private void mnuChuyenSangLopA_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên trong danh sách Lớp B trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> selectedItems = lstLopB.SelectedItems.Cast<string>().ToList();
            foreach (string item in selectedItems)
            {
                lstLopA.Items.Add(item);
                lstLopB.Items.Remove(item);
            }
        }

        // 4. Menu: Xóa học viên
        private void mnuXoaHocVien_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0 && lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa ở Lớp A hoặc Lớp B trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa các học viên đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
                }
                for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstLopB.Items.Remove(lstLopB.SelectedItems[i]);
                }
            }
        }

        // 5. Menu: Kết thúc
        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- CÁC CHỨC NĂNG CỦA PANEL NHẬP HỌC VIÊN MỚI ---

        // Nút Cập nhật trên panel nhập học viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtHoVaTen.Text.Trim();

            if (string.IsNullOrEmpty(hoVaTen))
            {
                MessageBox.Show("Họ và Tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                return;
            }

            string lopChon = cboLop.SelectedItem.ToString();
            if (lopChon == "Lớp A")
            {
                lstLopA.Items.Add(hoVaTen);
            }
            else
            {
                lstLopB.Items.Add(hoVaTen);
            }

            MessageBox.Show($"Thêm học viên {hoVaTen} vào {lopChon} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtHoVaTen.Clear();
            txtHoVaTen.Focus();
        }

        // Nút Trở về trên panel nhập học viên (Ẩn panel đi)
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            pnlNhapHocVien.Visible = false;
        }

        // Xác nhận khi đóng Form
        private void btnc_QLHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}