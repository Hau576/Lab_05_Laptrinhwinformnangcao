using System;
using System.Windows.Forms;

namespace ListViewApp
{
    public partial class btm_listView : Form
    {
        public btm_listView()
        {
            InitializeComponent();
        }

        private void btm_listView_Load(object sender, EventArgs e)
        {
            // Thiết lập thuộc tính cho ListView
            lstv1.View = View.Details;
            lstv1.GridLines = true;
            lstv1.FullRowSelect = true;
        }

        // Kiểm tra trùng mã số sinh viên
        private bool KiemTraTrungMaSV(string maSV)
        {
            foreach (ListViewItem item in lstv1.Items)
            {
                if (item.Text.Trim().Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        // Nút Thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            string maSV = txtmssv.Text.Trim();
            string hoTen = txthoten.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã số sinh viên này đã tồn tại trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmssv.Focus();
                txtmssv.SelectAll();
                return;
            }

            // Cách 2 theo hướng dẫn: Khởi tạo ListViewItem và SubItem
            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();

            item.Text = maSV;
            subitem.Text = hoTen;
            item.SubItems.Add(subitem);
            lstv1.Items.Add(item);

            // Xóa trắng ô nhập liệu
            txtmssv.Clear();
            txthoten.Clear();
            txtmssv.Focus();
        }

        // Nút Xóa[cite: 31]
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng sinh viên cần xóa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstv1.SelectedItems)
                {
                    item.Remove(); // Xóa mục đang chọn[cite: 31]
                }
            }
        }

        // Nút Sửa[cite: 31]
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lstv1.FocusedItem != null && lstv1.FocusedItem.Index >= 0)
            {
                string maSV = txtmssv.Text.Trim();
                string hoTen = txthoten.Text.Trim();

                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem item = lstv1.FocusedItem;
                item.SubItems[0].Text = maSV;
                item.SubItems[1].Text = hoTen;

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmssv.Clear();
                txthoten.Clear();
                txtmssv.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trên ListView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Khi click chọn dòng trên ListView sẽ đổ ngược dữ liệu lên TextBox để thuận tiện sửa
        private void lstv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lstv1.SelectedItems[0];
                txtmssv.Text = item.SubItems[0].Text;
                txthoten.Text = item.SubItems[1].Text;
            }
        }

        // Xác nhận khi đóng Form
        private void btm_listView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}