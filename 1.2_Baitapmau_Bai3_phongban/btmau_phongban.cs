using System;
using System.Windows.Forms;

namespace BaiTapTreeView
{
    public partial class btmau_phongban : Form
    {
        public btmau_phongban()
        {
            InitializeComponent();
        }

        // Khi Form hiển thị, nạp dữ liệu ban đầu cho TreeView và ComboBox
        private void btmau_phongban_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };

            foreach (string s in pb)
            {
                trv_DS.Nodes.Add(s); // Thêm node vào TreeView
                cbo_phongban.Items.Add(s); // Thêm item vào ComboBox
            }

            if (cbo_phongban.Items.Count > 0)
            {
                cbo_phongban.SelectedIndex = 0; // Chọn mặc định phòng ban đầu tiên
            }
        }

        // Hàm kiểm tra trùng tên phòng ban (so sánh không phân biệt chữ hoa/thường)
        private bool kiemtra(string s)
        {
            foreach (TreeNode node in trv_DS.Nodes)
            {
                if (string.Compare(node.Text.Trim(), s.Trim(), true) == 0)
                {
                    return false; // Đã tồn tại phòng ban
                }
            }
            return true; // Chưa tồn tại
        }

        // Thêm phòng ban mới
        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            string tenPB = txt_phongban.Text.Trim();

            if (string.IsNullOrEmpty(tenPB))
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phongban.Focus();
                return;
            }

            if (kiemtra(tenPB))
            {
                trv_DS.Nodes.Add(tenPB);
                cbo_phongban.Items.Add(tenPB);
                txt_phongban.Clear();
                txt_phongban.Focus();
            }
            else
            {
                MessageBox.Show("Phòng ban đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phongban.Text = "";
                txt_phongban.Focus();
            }
        }

        // Xóa phòng ban đang được chọn trên TreeView
        private void btn_XoaPB_Click(object sender, EventArgs e)
        {
            if (trv_DS.SelectedNode == null)
            {
                MessageBox.Show("Vui lòng chọn phòng ban cần xóa trên TreeView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu node đang chọn là node gốc (Phòng ban)
            if (trv_DS.SelectedNode.Parent == null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string tenPB = trv_DS.SelectedNode.Text;
                    cbo_phongban.Items.Remove(tenPB);
                    trv_DS.Nodes.Remove(trv_DS.SelectedNode);

                    if (cbo_phongban.Items.Count > 0)
                    {
                        cbo_phongban.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn node phòng ban gốc để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Thêm mới nhân viên vào phòng ban được chọn
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            string maSo = txt_maso.Text.Trim();
            string hoTen = txt_hoten.Text.Trim();
            string diaChi = txt_diachi.Text.Trim();

            if (string.IsNullOrEmpty(maSo) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã số và Họ tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbo_phongban.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenPBChon = cbo_phongban.SelectedItem.ToString();

            // Tìm node phòng ban tương ứng trong TreeView để thêm con
            foreach (TreeNode node in trv_DS.Nodes)
            {
                if (string.Compare(node.Text, tenPBChon, true) == 0)
                {
                    string thongTinNV = $"{hoTen} ({maSo})";
                    TreeNode nvNode = new TreeNode(thongTinNV);
                    node.Nodes.Add(nvNode);
                    node.Expand(); // Mở rộng node phòng ban để hiển thị nhân viên mới

                    // Xóa trắng các ô nhập liệu nhân viên
                    txt_maso.Clear();
                    txt_hoten.Clear();
                    txt_diachi.Clear();
                    txt_maso.Focus();
                    break;
                }
            }
        }

        // Nút Thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi đóng Form
        private void btmau_phongban_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}