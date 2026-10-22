namespace QuanLySinhVienApp
{
    partial class bttl_quanlisv
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
            this.trvDanhSachLop = new System.Windows.Forms.TreeView();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.grpThongTinSV = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.chkThemLop = new System.Windows.Forms.CheckBox();
            this.grpThongTinLop = new System.Windows.Forms.GroupBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.grpThongTinSV.SuspendLayout();
            this.grpThongTinLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDanhSachLop
            // 
            this.trvDanhSachLop.Location = new System.Drawing.Point(12, 12);
            this.trvDanhSachLop.Name = "trvDanhSachLop";
            this.trvDanhSachLop.Size = new System.Drawing.Size(260, 480);
            this.trvDanhSachLop.TabIndex = 0;
            this.trvDanhSachLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDanhSachLop_AfterSelect);
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(300, 20);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(60, 17);
            this.lblChonLop.TabIndex = 1;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // cboChonLop
            // 
            this.cboChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(380, 17);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(260, 24);
            this.cboChonLop.TabIndex = 2;
            // 
            // grpThongTinSV
            // 
            this.grpThongTinSV.Controls.Add(this.btnXoa);
            this.grpThongTinSV.Controls.Add(this.btnCapNhat);
            this.grpThongTinSV.Controls.Add(this.txtDiaChi);
            this.grpThongTinSV.Controls.Add(this.lblDiaChi);
            this.grpThongTinSV.Controls.Add(this.txtHoTen);
            this.grpThongTinSV.Controls.Add(this.lblHoTen);
            this.grpThongTinSV.Controls.Add(this.txtMaSV);
            this.grpThongTinSV.Controls.Add(this.lblMaSV);
            this.grpThongTinSV.Location = new System.Drawing.Point(290, 55);
            this.grpThongTinSV.Name = "grpThongTinSV";
            this.grpThongTinSV.Size = new System.Drawing.Size(370, 220);
            this.grpThongTinSV.TabIndex = 3;
            this.grpThongTinSV.TabStop = false;
            this.grpThongTinSV.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(230, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(100, 170);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 32);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(90, 120);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 24);
            this.txtDiaChi.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 123);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(48, 17);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 75);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 24);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 78);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(51, 17);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(90, 30);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(250, 24);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(20, 33);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(46, 17);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV";
            // 
            // chkThemLop
            // 
            this.chkThemLop.AutoSize = true;
            this.chkThemLop.Location = new System.Drawing.Point(290, 290);
            this.chkThemLop.Name = "chkThemLop";
            this.chkThemLop.Size = new System.Drawing.Size(83, 21);
            this.chkThemLop.TabIndex = 4;
            this.chkThemLop.Text = "Thêm lớp";
            this.chkThemLop.UseVisualStyleBackColor = true;
            this.chkThemLop.CheckedChanged += new System.EventHandler(this.chkThemLop_CheckedChanged);
            // 
            // grpThongTinLop
            // 
            this.grpThongTinLop.Controls.Add(this.btnThemLop);
            this.grpThongTinLop.Controls.Add(this.txtTenLop);
            this.grpThongTinLop.Controls.Add(this.lblTenLop);
            this.grpThongTinLop.Location = new System.Drawing.Point(290, 320);
            this.grpThongTinLop.Name = "grpThongTinLop";
            this.grpThongTinLop.Size = new System.Drawing.Size(370, 90);
            this.grpThongTinLop.TabIndex = 5;
            this.grpThongTinLop.TabStop = false;
            this.grpThongTinLop.Text = "Thông tin lớp";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(240, 35);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(100, 30);
            this.btnThemLop.TabIndex = 2;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(80, 38);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(140, 24);
            this.txtTenLop.TabIndex = 1;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(15, 41);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(56, 17);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên lớp";
            // 
            // bttl_quanlisv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 505);
            this.Controls.Add(this.grpThongTinLop);
            this.Controls.Add(this.chkThemLop);
            this.Controls.Add(this.grpThongTinSV);
            this.Controls.Add(this.cboChonLop);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.trvDanhSachLop);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "bttl_quanlisv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bttl_quanlisv_FormClosing);
            this.Load += new System.EventHandler(this.bttl_quanlisv_Load);
            this.grpThongTinSV.ResumeLayout(false);
            this.grpThongTinSV.PerformLayout();
            this.grpThongTinLop.ResumeLayout(false);
            this.grpThongTinLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvDanhSachLop;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.GroupBox grpThongTinSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.CheckBox chkThemLop;
        private System.Windows.Forms.GroupBox grpThongTinLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThemLop;
    }
}