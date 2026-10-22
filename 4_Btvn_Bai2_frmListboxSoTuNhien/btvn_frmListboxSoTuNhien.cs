using System;
using System.Linq;
using System.Windows.Forms;

namespace ListBoxSoTuNhienApp
{
    public partial class btvn_frmListboxSoTuNhien : Form
    {
        public btvn_frmListboxSoTuNhien()
        {
            InitializeComponent();
        }

        // 1. Nhập số nguyên N vào ListBox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapSo.Text.Trim(), out int n))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                txtNhapSo.SelectAll();
                return;
            }

            lstSoTuNhien.Items.Add(n);
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // 2. Tính tổng các phần tử trong ListBox
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (lstSoTuNhien.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tong = lstSoTuNhien.Items.Cast<int>().Sum();
            MessageBox.Show($"Tổng các phần tử trong ListBox là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Xóa phần tử đầu và cuối của ListBox
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstSoTuNhien.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstSoTuNhien.Items.RemoveAt(0); // Xóa phần tử đầu
            if (lstSoTuNhien.Items.Count > 0)
            {
                lstSoTuNhien.Items.RemoveAt(lstSoTuNhien.Items.Count - 1); // Xóa phần tử cuối
            }
        }

        // 4. Xóa các phần tử đang chọn trong ListBox
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstSoTuNhien.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phần tử cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa ngược từ dưới lên để tránh lệch chỉ số (Index)
            for (int i = lstSoTuNhien.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstSoTuNhien.Items.RemoveAt(lstSoTuNhien.SelectedIndices[i]);
            }
        }

        // 5. Tăng giá trị mỗi phần tử lên 2
        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            if (lstSoTuNhien.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < lstSoTuNhien.Items.Count; i++)
            {
                int val = (int)lstSoTuNhien.Items[i];
                lstSoTuNhien.Items[i] = val + 2;
            }
        }

        // 6. Thay mỗi giá trị bằng bình phương của chính nó
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            if (lstSoTuNhien.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < lstSoTuNhien.Items.Count; i++)
            {
                int val = (int)lstSoTuNhien.Items[i];
                lstSoTuNhien.Items[i] = val * val;
            }
        }

        // 7. Chọn các phần tử là số chẵn trong ListBox
        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            lstSoTuNhien.ClearSelected(); // Bỏ chọn hiện tại
            for (int i = 0; i < lstSoTuNhien.Items.Count; i++)
            {
                int val = (int)lstSoTuNhien.Items[i];
                if (val % 2 == 0)
                {
                    lstSoTuNhien.SetSelected(i, true);
                }
            }
        }

        // 8. Chọn các phần tử là số lẻ trong ListBox
        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            lstSoTuNhien.ClearSelected(); // Bỏ chọn hiện tại
            for (int i = 0; i < lstSoTuNhien.Items.Count; i++)
            {
                int val = (int)lstSoTuNhien.Items[i];
                if (val % 2 != 0)
                {
                    lstSoTuNhien.SetSelected(i, true);
                }
            }
        }

        // 9. Nút Kết Thúc (Thoát ứng dụng có xác nhận)
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi đóng Form
        private void btvn_frmListboxSoTuNhien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}