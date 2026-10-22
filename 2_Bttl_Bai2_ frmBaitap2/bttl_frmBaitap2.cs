using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTaiKhoanBankApp
{
    public partial class bttl_frmBaitap2 : Form
    {
        private bool isAdding = false; // Trạng thái đang thêm mới

        public bttl_frmBaitap2()
        {
            InitializeComponent();
        }

        // Form Load lên thiết lập trạng thái ban đầu
        private void bttl_frmBaitap2_Load(object sender, EventArgs e)
        {
            lstvTaiKhoan.View = View.Details;
            lstvTaiKhoan.GridLines = true;
            lstvTaiKhoan.FullRowSelect = true;

            SetKhoaControl(false);
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        // Khóa / Mở khóa các textbox
        private void SetKhoaControl(bool status)
        {
            txtSoTaiKhoan.ReadOnly = !status;
            txtTenKhachHang.ReadOnly = !status;
            txtDiaChi.ReadOnly = !status;
            txtSoTien.ReadOnly = !status;
        }

        // Làm sạch dữ liệu nhập
        private void ClearControl()
        {
            txtSoTaiKhoan.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        // Tính và hiển thị tổng tiền
        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (ListViewItem item in lstvTaiKhoan.Items)
            {
                if (decimal.TryParse(item.SubItems[5].Text.Replace(",", ""), out decimal soTien))
                {
                    tongTien += soTien;
                }
            }
            txtTongTien.Text = tongTien.ToString("N0");
        }

        // Đánh lại số thứ tự (STT) tự động cho ListView
        private void CapNhatSTT()
        {
            for (int i = 0; i < lstvTaiKhoan.Items.Count; i++)
            {
                lstvTaiKhoan.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        // Button "Thêm" / "Hủy"
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                // Chuyển sang chế độ Thêm mới -> Đổi thành "Hủy" và bật nút "Lưu"[cite: 35]
                isAdding = true;
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;

                SetKhoaControl(true);
                ClearControl();
                txtSoTaiKhoan.Focus(); // Đặt con trỏ vào ô Số tài khoản[cite: 35]
            }
            else
            {
                // Hủy thêm mới
                isAdding = false;
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                SetKhoaControl(false);
                ClearControl();
            }
        }

        // Button "Lưu": Lưu dữ liệu từ các textbox vào listview[cite: 35]
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string stk = txtSoTaiKhoan.Text.Trim();
            string tenKh = txtTenKhachHang.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(stk) || string.IsNullOrEmpty(tenKh) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSoTien.Text.Trim(), out decimal soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền trong tài khoản phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Focus();
                return;
            }

            // Thêm mới mẫu tin vào ListView
            ListViewItem item = new ListViewItem(""); // Cột STT sẽ được cập nhật tự động
            item.SubItems.Add(stk);
            item.SubItems.Add(tenKh);
            item.SubItems.Add(diaChi);
            item.SubItems.Add(soTien.ToString("N0")); // Format số tiền có dấu phẩy ngăn cách

            lstvTaiKhoan.Items.Add(item);

            // Cập nhật STT và Tổng tiền
            CapNhatSTT();
            TinhTongTien();

            // Đưa form về trạng thái ban đầu
            isAdding = false;
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            SetKhoaControl(false);
            ClearControl();

            MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button "Xóa": Xóa mẫu tin hiện hành trong listview[cite: 35]
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstvTaiKhoan.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lstvTaiKhoan.Items.Remove(lstvTaiKhoan.SelectedItems[0]);
                    CapNhatSTT();
                    TinhTongTien();
                    ClearControl();
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Khi click một khách hàng trong listview, hiển thị thông tin lên textbox tương ứng[cite: 35, 36]
        private void lstvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = item.SubItems[1].Text;
                txtTenKhachHang.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoTien.Text = item.SubItems[4].Text.Replace(",", "");

                btnXoa.Enabled = true; // Bật nút Xóa khi mẫu tin được chọn[cite: 35]
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hỏi xác nhận trước khi đóng Form
        private void bttl_frmBaitap2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}