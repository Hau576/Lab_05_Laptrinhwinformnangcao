using System;
using System.Linq;
using System.Windows.Forms;

namespace BTVN_Tuan6
{
    public partial class btvn_frmMainCoMenustrip : Form
    {
        public btvn_frmMainCoMenustrip()
        {
            InitializeComponent();
        }

        private void btvn_frmMainCoMenustrip_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void mnuBai1_Click(object sender, EventArgs e)
        {
            OpenChildFormByName("btvn_frmMainCoMenustrip");
        }

        private void mnuBai2_Click(object sender, EventArgs e)
        {
            OpenChildFormByName("btvn_frmMainCoMenustrip");
        }

        // Hàm hỗ trợ tự động tìm kiếm form theo tên lớp để mở an toàn
        private void OpenChildFormByName(params string[] possibleNames)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (possibleNames.Contains(frm.GetType().Name, StringComparer.OrdinalIgnoreCase))
                {
                    frm.Activate();
                    return;
                }
            }

            Type formType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .FirstOrDefault(t => possibleNames.Contains(t.Name, StringComparer.OrdinalIgnoreCase) && typeof(Form).IsAssignableFrom(t));

            if (formType != null)
            {
                Form childForm = (Form)Activator.CreateInstance(formType);
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy form tương ứng với bài tập này trong dự án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btvn_frmMainCoMenustrip_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}