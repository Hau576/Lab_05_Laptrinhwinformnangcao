namespace ListBoxSoTuNhienApp
{
    partial class btvn_frmListboxSoTuNhien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpListbox = new System.Windows.Forms.GroupBox();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lstSoTuNhien = new System.Windows.Forms.ListBox();
            this.grpXuLy = new System.Windows.Forms.GroupBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grpListbox.SuspendLayout();
            this.grpXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(230, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LISTBOX";
            // 
            // grpListbox
            // 
            this.grpListbox.Controls.Add(this.lstSoTuNhien);
            this.grpListbox.Controls.Add(this.btnNhap);
            this.grpListbox.Controls.Add(this.txtNhapSo);
            this.grpListbox.Location = new System.Drawing.Point(20, 70);
            this.grpListbox.Name = "grpListbox";
            this.grpListbox.Size = new System.Drawing.Size(240, 360);
            this.grpListbox.TabIndex = 1;
            this.grpListbox.TabStop = false;
            this.grpListbox.Text = "Listbox";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(15, 30);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(210, 26);
            this.txtNhapSo.TabIndex = 0;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(15, 70);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(210, 35);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lstSoTuNhien
            // 
            this.lstSoTuNhien.FormattingEnabled = true;
            this.lstSoTuNhien.ItemHeight = 18;
            this.lstSoTuNhien.Location = new System.Drawing.Point(15, 120);
            this.lstSoTuNhien.Name = "lstSoTuNhien";
            this.lstSoTuNhien.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSoTuNhien.Size = new System.Drawing.Size(210, 220);
            this.lstSoTuNhien.TabIndex = 2;
            // 
            // grpXuLy
            // 
            this.grpXuLy.Controls.Add(this.btnChonSoLe);
            this.grpXuLy.Controls.Add(this.btnChonSoChan);
            this.grpXuLy.Controls.Add(this.btnBinhPhuong);
            this.grpXuLy.Controls.Add(this.btnTangLen2);
            this.grpXuLy.Controls.Add(this.btnXoaDangChon);
            this.grpXuLy.Controls.Add(this.btnXoaDauCuoi);
            this.grpXuLy.Controls.Add(this.btnTinhTong);
            this.grpXuLy.Location = new System.Drawing.Point(280, 70);
            this.grpXuLy.Name = "grpXuLy";
            this.grpXuLy.Size = new System.Drawing.Size(300, 360);
            this.grpXuLy.TabIndex = 2;
            this.grpXuLy.TabStop = false;
            this.grpXuLy.Text = "Xử lý Listbox";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(20, 30);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(260, 35);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tổng các phần tử trong List";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(20, 75);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(260, 35);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(20, 120);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(260, 35);
            this.btnXoaDangChon.TabIndex = 2;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Location = new System.Drawing.Point(20, 165);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(260, 35);
            this.btnTangLen2.TabIndex = 3;
            this.btnTangLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(20, 210);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(260, 35);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.Location = new System.Drawing.Point(20, 255);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(260, 35);
            this.btnChonSoChan.TabIndex = 5;
            this.btnChonSoChan.Text = "Chọn số chẵn";
            this.btnChonSoChan.UseVisualStyleBackColor = true;
            this.btnChonSoChan.Click += new System.EventHandler(this.btnChonSoChan_Click);
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.Location = new System.Drawing.Point(20, 300);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(260, 35);
            this.btnChonSoLe.TabIndex = 6;
            this.btnChonSoLe.Text = "Chọn số lẻ";
            this.btnChonSoLe.UseVisualStyleBackColor = true;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(20, 445);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(560, 38);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btvn_frmListboxSoTuNhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 500);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grpXuLy);
            this.Controls.Add(this.grpListbox);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "btvn_frmListboxSoTuNhien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btvn_frmListboxSoTuNhien_FormClosing);
            this.grpListbox.ResumeLayout(false);
            this.grpListbox.PerformLayout();
            this.grpXuLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpListbox;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstSoTuNhien;
        private System.Windows.Forms.GroupBox grpXuLy;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnKetThuc;
    }
}