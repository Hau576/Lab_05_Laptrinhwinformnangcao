using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVienListViewApp
{
    public partial class bttl_frmBaitap1 : Form
    {
        public bttl_frmBaitap1()
        {
            InitializeComponent();
        }

        // Khi Load form lên thực hiện thêm dữ liệu vào ComboBox dân tộc[cite: 34]
        private void bttl_frmBaitap1_Load(object sender, EventArgs e)
        {
            // Thiết lập thuộc tính cho ListView
            lstvSinhVien.View = View.Details;
            lstvSinhVien.GridLines = true;
            lstvSinhVien.FullRowSelect = true;

            // Nạp dữ liệu vào ComboBox dân tộc
            string[] danTocList = { "Kinh", "Hoa", "Tày", "Nùng", "Mường", "Khmer", "H'Mông", "Khác" };
            cboDanToc.Items.AddRange(danTocList);
            if (cboDanToc.Items.Count > 0)
            {
                cboDanToc.SelectedIndex = 0;
            }

            // Mặc định chọn Nam
            radNam.Checked = true;
        }

        // Kiểm tra trùng mã sinh viên
        private bool KiemTraTrungMaSV(string maSV)
        {
            foreach (ListViewItem item in lstvSinhVien.Items)
            {
                if (item.SubItems[1].Text.Trim().Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        // Lấy danh sách ngoại ngữ đã chọn (Anh, Pháp, Hoa)
        private string GetNgoaiNgu()
        {
            List<string> nn = new List<string>();
            if (chkAnh.Checked) nn.Add("Anh");
            if (chkPhap.Checked) nn.Add("Pháp");
            if (chkHoa.Checked) nn.Add("Hoa");
            return string.Join(", ", nn);
        }

        // Button Thêm: Thực hiện thêm từ các control lên ListView (Không cho trùng mã sinh viên)[cite: 34]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ và tên và Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = GetNgoaiNgu();
            string danToc = cboDanToc.SelectedItem != null ? cboDanToc.SelectedItem.ToString() : "";

            // Thêm vào ListView
            ListViewItem item = new ListViewItem(hoTen); // Cột 1: Họ tên
            item.SubItems.Add(maSV);                      // Cột 2: Mã SV
            item.SubItems.Add(gioiTinh);                  // Cột 3: Giới tính
            item.SubItems.Add(ngoaiNgu);                  // Cột 4: Ngoại ngữ
            item.SubItems.Add(danToc);                    // Cột 5: Dân tộc

            lstvSinhVien.Items.Add(item);

            // Xóa trắng nhập liệu
            txtHoTen.Clear();
            txtMaSV.Clear();
            radNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            if (cboDanToc.Items.Count > 0) cboDanToc.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        // Button Xóa: Xóa dòng đang chọn trên ListView[cite: 34]
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVienSelected();
        }

        private void XoaSinhVienSelected()
        {
            if (lstvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng sinh viên cần xóa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstvSinhVien.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

        // Button Sửa: Cập nhật thông tin (Không cho sửa Mã sinh viên)[cite: 34]
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvSinhVien.SelectedItems[0];

                string hoTen = txtHoTen.Text.Trim();
                if (string.IsNullOrEmpty(hoTen))
                {
                    MessageBox.Show("Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin (Giữ nguyên mã sinh viên ở SubItems[1])
                item.SubItems[0].Text = hoTen;
                item.SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
                item.SubItems[3].Text = GetNgoaiNgu();
                item.SubItems[4].Text = cboDanToc.SelectedItem != null ? cboDanToc.SelectedItem.ToString() : "";

                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng sinh viên cần sửa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Khi click chọn dòng trên ListView, đổ ngược dữ liệu lên các control phía trên
        private void lstvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvSinhVien.SelectedItems[0];
                txtHoTen.Text = item.SubItems[0].Text;
                txtMaSV.Text = item.SubItems[1].Text;

                // Khóa ô Mã SV không cho sửa theo yêu cầu bài toán
                txtMaSV.ReadOnly = true;

                if (item.SubItems[2].Text == "Nam") radNam.Checked = true;
                else radNữ.Checked = true;

                string ngoaiNgu = item.SubItems[3].Text;
                chkAnh.Checked = ngoaiNgu.Contains("Anh");
                chkPhap.Checked = ngoaiNgu.Contains("Pháp");
                chkHoa.Checked = ngoaiNgu.Contains("Hoa");

                cboDanToc.SelectedItem = item.SubItems[4].Text;
            }
            else
            {
                txtMaSV.ReadOnly = false;
            }
        }

        // ContextMenuStrip: Thực hiện Xóa khi kích chọn phải chuột vào ListView[cite: 34]
        private void contextMenuXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVienSelected();
        }

        // Hỏi xác nhận trước khi đóng Form[cite: 34]
        private void bttl_frmBaitap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}