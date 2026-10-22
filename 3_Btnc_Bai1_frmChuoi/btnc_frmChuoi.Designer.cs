namespace BaiTapChuoi
{
    partial class btnc_frmChuoi
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
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaTenSon = new System.Windows.Forms.Button();
            this.btnXoaHoLe = new System.Windows.Forms.Button();
            this.btnInHoa = new System.Windows.Forms.Button();
            this.btnInThuong = new System.Windows.Forms.Button();
            this.btnHoaDauTu = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Location = new System.Drawing.Point(20, 15);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(220, 35);
            this.btnNgauNhien.TabIndex = 0;
            this.btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 18;
            this.lstDanhSach.Location = new System.Drawing.Point(20, 60);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSach.Size = new System.Drawing.Size(220, 328);
            this.lstDanhSach.TabIndex = 1;
            this.lstDanhSach.DoubleClick += new System.EventHandler(this.lstDanhSach_DoubleClick);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(260, 60);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(260, 35);
            this.btnXoaDangChon.TabIndex = 2;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaTenSon
            // 
            this.btnXoaTenSon.Location = new System.Drawing.Point(260, 105);
            this.btnXoaTenSon.Name = "btnXoaTenSon";
            this.btnXoaTenSon.Size = new System.Drawing.Size(260, 35);
            this.btnXoaTenSon.TabIndex = 3;
            this.btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaTenSon.UseVisualStyleBackColor = true;
            this.btnXoaTenSon.Click += new System.EventHandler(this.btnXoaTenSon_Click);
            // 
            // btnXoaHoLe
            // 
            this.btnXoaHoLe.Location = new System.Drawing.Point(260, 150);
            this.btnXoaHoLe.Name = "btnXoaHoLe";
            this.btnXoaHoLe.Size = new System.Drawing.Size(260, 35);
            this.btnXoaHoLe.TabIndex = 4;
            this.btnXoaHoLe.Text = "Xóa Phần tử có họ là Lê";
            this.btnXoaHoLe.UseVisualStyleBackColor = true;
            this.btnXoaHoLe.Click += new System.EventHandler(this.btnXoaHoLe_Click);
            // 
            // btnInHoa
            // 
            this.btnInHoa.Location = new System.Drawing.Point(260, 200);
            this.btnInHoa.Name = "btnInHoa";
            this.btnInHoa.Size = new System.Drawing.Size(260, 35);
            this.btnInHoa.TabIndex = 5;
            this.btnInHoa.Text = "Chuyển PT đang chọn thành chữ HOA";
            this.btnInHoa.UseVisualStyleBackColor = true;
            this.btnInHoa.Click += new System.EventHandler(this.btnInHoa_Click);
            // 
            // btnInThuong
            // 
            this.btnInThuong.Location = new System.Drawing.Point(260, 245);
            this.btnInThuong.Name = "btnInThuong";
            this.btnInThuong.Size = new System.Drawing.Size(260, 35);
            this.btnInThuong.TabIndex = 6;
            this.btnInThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            this.btnInThuong.UseVisualStyleBackColor = true;
            this.btnInThuong.Click += new System.EventHandler(this.btnInThuong_Click);
            // 
            // btnHoaDauTu
            // 
            this.btnHoaDauTu.Location = new System.Drawing.Point(260, 290);
            this.btnHoaDauTu.Name = "btnHoaDauTu";
            this.btnHoaDauTu.Size = new System.Drawing.Size(260, 45);
            this.btnHoaDauTu.TabIndex = 7;
            this.btnHoaDauTu.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ";
            this.btnHoaDauTu.UseVisualStyleBackColor = true;
            this.btnHoaDauTu.Click += new System.EventHandler(this.btnHoaDauTu_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(260, 345);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(260, 35);
            this.btnXoaTatCa.TabIndex = 8;
            this.btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnc_frmChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 410);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnHoaDauTu);
            this.Controls.Add(this.btnInThuong);
            this.Controls.Add(this.btnInHoa);
            this.Controls.Add(this.btnXoaHoLe);
            this.Controls.Add(this.btnXoaTenSon);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.btnNgauNhien);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "btnc_frmChuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuoi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btnc_frmChuoi_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaTenSon;
        private System.Windows.Forms.Button btnXoaHoLe;
        private System.Windows.Forms.Button btnInHoa;
        private System.Windows.Forms.Button btnInThuong;
        private System.Windows.Forms.Button btnHoaDauTu;
        private System.Windows.Forms.Button btnXoaTatCa;
    }
}