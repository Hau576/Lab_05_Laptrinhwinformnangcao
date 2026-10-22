using System;
using System.Windows.Forms;

namespace DanhBaApp
{
    public partial class btvn_frmBTVN2 : Form
    {
        public btvn_frmBTVN2()
        {
            InitializeComponent();
        }

        // Khi form được load lên, treeView chứa tất cả các ký tự từ A -> Z[cite: 28]
        private void btvn_frmBTVN2_Load(object sender, EventArgs e)
        {
            trvDanhBa.Nodes.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                trvDanhBa.Nodes.Add(c.ToString());
            }
        }

        // Nút Add: Thêm người mới vào treeView ở vị trí node tương ứng với chữ cái đầu của Last Name[cite: 28]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ First Name và Last Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ký tự đầu của Last Name để phân nhóm (ví dụ: "Bình" -> 'B')
            char firstChar = char.ToUpper(lastName[0]);

            if (firstChar < 'A' || firstChar > 'Z')
            {
                MessageBox.Show("Chữ cái đầu của Last Name phải từ A đến Z!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Định dạng tên hiển thị: "LastName, FirstName" (ví dụ: "Bình, Ngô Thanh")[cite: 28]
            string fullNameFormatted = $"{lastName}, {firstName}";

            // Tìm node chữ cái tương ứng trong TreeView từ A -> Z
            foreach (TreeNode node in trvDanhBa.Nodes)
            {
                if (node.Text == firstChar.ToString())
                {
                    node.Nodes.Add(fullNameFormatted);
                    node.Expand(); // Mở rộng node chữ cái để hiển thị danh bạ vừa thêm
                    break;
                }
            }

            // Xóa trắng các ô nhập liệu và đưa con trỏ về First Name
            txtFirstName.Clear();
            txtLastName.Clear();
            txtFirstName.Focus();
        }

        // Nút Exit: Đóng ứng dụng có xác nhận
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xác nhận khi đóng Form
        private void btvn_frmBTVN2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}