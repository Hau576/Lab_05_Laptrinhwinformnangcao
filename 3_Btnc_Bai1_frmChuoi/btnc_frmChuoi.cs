using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Yêu cầu Reference: Microsoft.VisualBasic cho InputBox

namespace BaiTapChuoi
{
    public partial class btnc_frmChuoi : Form
    {
        private readonly string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        private readonly string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
        private readonly string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

        public btnc_frmChuoi()
        {
            InitializeComponent();
        }

        // Tự động tạo 50 tên ngẫu nhiên
        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rand.Next(HO.Length)];
                string tenLot = TENLOT[rand.Next(TENLOT.Length)];
                string ten = TEN[rand.Next(TEN.Length)];

                string hoTen = $"{ho} {tenLot} {ten}";
                lstDanhSach.Items.Add(hoTen);
            }
        }

        // Xóa phần tử đang chọn
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phần tử để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = lstDanhSach.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndices[i]);
            }
        }

        // Xóa các phần tử có tên là "Sơn"
        private void btnXoaTenSon_Click(object sender, EventArgs e)
        {
            for (int i = lstDanhSach.Items.Count - 1; i >= 0; i--)
            {
                string hoTen = lstDanhSach.Items[i].ToString().Trim();
                string[] parts = hoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0)
                {
                    string ten = parts[parts.Length - 1];
                    if (string.Compare(ten, "Sơn", true) == 0)
                    {
                        lstDanhSach.Items.RemoveAt(i);
                    }
                }
            }
        }

        // Xóa các phần tử có họ là "Lê"
        private void btnXoaHoLe_Click(object sender, EventArgs e)
        {
            for (int i = lstDanhSach.Items.Count - 1; i >= 0; i--)
            {
                string hoTen = lstDanhSach.Items[i].ToString().Trim();
                string[] parts = hoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0)
                {
                    string ho = parts[0];
                    if (string.Compare(ho, "Lê", true) == 0)
                    {
                        lstDanhSach.Items.RemoveAt(i);
                    }
                }
            }
        }

        // Chuyển phần tử đang chọn thành chữ IN HOA
        private void btnInHoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count == 0) return;

            List<int> selectedIndices = lstDanhSach.SelectedIndices.Cast<int>().ToList();
            foreach (int index in selectedIndices)
            {
                lstDanhSach.Items[index] = lstDanhSach.Items[index].ToString().ToUpper();
            }
        }

        // Chuyển phần tử đang chọn thành chữ in thường
        private void btnInThuong_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count == 0) return;

            List<int> selectedIndices = lstDanhSach.SelectedIndices.Cast<int>().ToList();
            foreach (int index in selectedIndices)
            {
                lstDanhSach.Items[index] = lstDanhSach.Items[index].ToString().ToLower();
            }
        }

        // Chuyển phần tử đang chọn thành Viết Hoa Đầu Mỗi Từ
        private void btnHoaDauTu_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count == 0) return;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            List<int> selectedIndices = lstDanhSach.SelectedIndices.Cast<int>().ToList();

            foreach (int index in selectedIndices)
            {
                string str = lstDanhSach.Items[index].ToString().ToLower();
                lstDanhSach.Items[index] = textInfo.ToTitleCase(str);
            }
        }

        // Xóa tất cả các phần tử
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ danh sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstDanhSach.Items.Clear();
                }
            }
        }

        // Double click vào tên đang chọn để thay đổi bằng InputBox
        private void lstDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                int index = lstDanhSach.SelectedIndex;
                string currentValue = lstDanhSach.Items[index].ToString();

                string newValue = Interaction.InputBox("Nhập tên mới:", "Sửa Tên", currentValue);

                if (!string.IsNullOrWhiteSpace(newValue))
                {
                    lstDanhSach.Items[index] = newValue.Trim();
                }
            }
        }

        // Xác nhận khi đóng Form
        private void btnc_frmChuoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}