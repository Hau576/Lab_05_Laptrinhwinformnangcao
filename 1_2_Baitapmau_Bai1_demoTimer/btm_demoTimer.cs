using System;
using System.Windows.Forms;

namespace DemoTimerApp
{
    public partial class btm_demoTimer : Form
    {
        public btm_demoTimer()
        {
            InitializeComponent();
        }

        // Khởi động Timer khi Form được tải
        private void btm_demoTimer_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Đặt khoảng thời gian chờ giữa 2 lần gọi Tick là 1 giây (1000 mili giây)
            timer1.Start();         // Kích hoạt Timer
        }

        // Sự kiện Tick phát sinh mỗi giây[cite: 29]
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hệ thống và hiển thị lên label1[cite: 29]
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        // Xác nhận khi đóng Form
        private void btm_demoTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}