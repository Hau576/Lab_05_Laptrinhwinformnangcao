using System;
using System.Windows.Forms;

namespace QuanLySinhVienApp
{
    public partial class bttl_quanlisv : Form
    {
        public bttl_quanlisv()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load
        private void bttl_quanlisv_Load(object sender, EventArgs e)
        {
            // Nạp các lớp ban đầu vào TreeView và ComboBox
            string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };

            TreeNode rootNode = trvDanhSachLop.Nodes.Add("Danh sách lớp");

            foreach (string lop in dsLop)
            {
                rootNode.Nodes.Add(lop);
                cboChonLop.Items.Add(lop);
            }

            rootNode.Expand();

            if (cboChonLop.Items.Count > 0)
            {
                cboChonLop.SelectedIndex = 0;
            }

            // Trạng thái ban đầu của CheckBox và GroupBox Thêm lớp
            chkThemLop.Checked = false;
            grpThongTinLop.Visible = false;
        }

        // Ẩn / Hiện GroupBox Thêm lớp theo CheckBox
        private void chkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grpThongTinLop.Visible = chkThemLop.Checked;
        }

        // Kiểm tra xem tên lớp đã tồn tại chưa
        private bool KiemTraTrungLop(string tenLop)
        {
            if (trvDanhSachLop.Nodes.Count > 0)
            {
                TreeNode rootNode = trvDanhSachLop.Nodes[0];
                foreach (TreeNode node in rootNode.Nodes)
                {
                    if (string.Compare(node.Text.Trim(), tenLop.Trim(), true) == 0)
                    {
                        return true; // Đã trùng
                    }
                }
            }
            return false;
        }

        // Button Thêm lớp
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();

            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            if (KiemTraTrungLop(tenLop))
            {
                MessageBox.Show("Tên lớp đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.SelectAll();
                txtTenLop.Focus();
                return;
            }

            // Thêm vào TreeView
            if (trvDanhSachLop.Nodes.Count > 0)
            {
                trvDanhSachLop.Nodes[0].Nodes.Add(tenLop);
                trvDanhSachLop.Nodes[0].Expand();
            }

            // Thêm vào ComboBox
            cboChonLop.Items.Add(tenLop);
            cboChonLop.SelectedItem = tenLop;

            txtTenLop.Clear();
            MessageBox.Show("Thêm lớp mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Kiểm tra xem Mã sinh viên đã tồn tại chưa
        private bool KiemTraTrungMaSV(string maSV)
        {
            if (trvDanhSachLop.Nodes.Count > 0)
            {
                TreeNode rootNode = trvDanhSachLop.Nodes[0];
                foreach (TreeNode lopNode in rootNode.Nodes)
                {
                    foreach (TreeNode svNode in lopNode.Nodes)
                    {
                        // Text node dạng: "200115, Nguyễn Văn Bình"
                        string[] parts = svNode.Text.Split(',');
                        if (parts.Length > 0 && string.Compare(parts[0].Trim(), maSV.Trim(), true) == 0)
                        {
                            return true; // Trùng mã SV
                        }
                    }
                }
            }
            return false;
        }

        // Button Cập Nhật (Thêm SV vào lớp đang chọn)
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV, Họ Tên và Địa Chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboChonLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.SelectAll();
                txtMaSV.Focus();
                return;
            }

            string lopChon = cboChonLop.SelectedItem.ToString();

            // Tìm node lớp trong TreeView
            if (trvDanhSachLop.Nodes.Count > 0)
            {
                TreeNode rootNode = trvDanhSachLop.Nodes[0];
                foreach (TreeNode lopNode in rootNode.Nodes)
                {
                    if (string.Compare(lopNode.Text.Trim(), lopChon.Trim(), true) == 0)
                    {
                        // Thêm node Sinh viên dạng: "MaSV, HoTen"
                        TreeNode svNode = new TreeNode($"{maSV}, {hoTen}");
                        // Thêm node Địa chỉ dưới dạng node con của Sinh viên
                        svNode.Nodes.Add(diaChi);

                        lopNode.Nodes.Add(svNode);
                        lopNode.Expand();
                        svNode.Expand();

                        // Clear ô nhập
                        txtMaSV.Clear();
                        txtHoTen.Clear();
                        txtDiaChi.Clear();
                        txtMaSV.Focus();
                        break;
                    }
                }
            }
        }

        // Khi click chọn một node trên TreeView
        private void trvDanhSachLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode == null) return;

            // Trường hợp 1: Chọn đúng node Sinh viên (Cấp 2)
            if (selectedNode.Parent != null && selectedNode.Parent.Parent != null)
            {
                string[] parts = selectedNode.Text.Split(',');
                if (parts.Length >= 2)
                {
                    txtMaSV.Text = parts[0].Trim();
                    txtHoTen.Text = parts[1].Trim();
                }

                if (selectedNode.Nodes.Count > 0)
                {
                    txtDiaChi.Text = selectedNode.Nodes[0].Text.Trim();
                }

                // Cập nhật ComboBox ứng với lớp của SV này
                cboChonLop.SelectedItem = selectedNode.Parent.Text;
            }
            // Trường hợp 2: Chọn node Địa chỉ (Cấp 3)
            else if (selectedNode.Parent != null && selectedNode.Parent.Parent != null && selectedNode.Parent.Parent.Parent != null)
            {
                TreeNode svNode = selectedNode.Parent;
                string[] parts = svNode.Text.Split(',');
                if (parts.Length >= 2)
                {
                    txtMaSV.Text = parts[0].Trim();
                    txtHoTen.Text = parts[1].Trim();
                }
                txtDiaChi.Text = selectedNode.Text.Trim();
                cboChonLop.SelectedItem = svNode.Parent.Text;
            }
        }

        // Button Xóa (Chỉ cho phép xóa node là sinh viên)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = trvDanhSachLop.SelectedNode;

            if (selectedNode == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trên TreeView!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra node đang chọn có phải là Sinh viên không (có Parent là node Lớp)
            if (selectedNode.Parent != null && selectedNode.Parent.Parent != null && selectedNode.Parent.Parent.Parent == null)
            {
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {selectedNode.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    trvDanhSachLop.Nodes.Remove(selectedNode);
                    txtMaSV.Clear();
                    txtHoTen.Clear();
                    txtDiaChi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng node Sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xác nhận khi đóng Form
        private void bttl_quanlisv_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}