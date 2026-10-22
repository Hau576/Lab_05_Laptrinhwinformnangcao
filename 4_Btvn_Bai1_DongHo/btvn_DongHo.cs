using System;
using System.Windows.Forms;

namespace DongHoDemNguocApp
{
    public partial class btvn_DongHo : Form
    {
        private int tongSoGiay = 30 * 60; // Mặc định đếm ngược từ 30 phút = 1800 giây

        public btvn_DongHo()
        {
            InitializeComponent();
        }

        private void btvn_DongHo_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 giây = 1000 mili giây
            CapNhatHienThi(tongSoGiay);
        }

        // Hàm định dạng và hiển thị thời gian lên Label (phút:giây)
        private void CapNhatHienThi(int giayConLai)
        {
            int phut = giayConLai / 60;
            int giay = giayConLai % 60;
            lblThoiGian.Text = $"{phut:D2}:{giay:D2}";
        }

        // Nút Bắt đầu / Tạm dừng
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                btnBatDau.Text = "Tạm dừng";
            }
            else
            {
                timer1.Stop();
                btnBatDau.Text = "Bắt đầu";
            }
        }

        // Sự kiện Tick của Timer chạy mỗi giây
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tongSoGiay > 0)
            {
                tongSoGiay--;
                CapNhatHienThi(tongSoGiay);
            }
            else
            {
                timer1.Stop();
                btnBatDau.Text = "Bắt đầu";
                MessageBox.Show("Đã hết thời gian đếm ngược!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset lại thời gian về 30 phút nếu muốn
                tongSoGiay = 30 * 60;
                CapNhatHienThi(tongSoGiay);
            }
        }

        // Xác nhận khi đóng Form
        private void btvn_DongHo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}