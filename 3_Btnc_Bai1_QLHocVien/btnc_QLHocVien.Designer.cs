namespace QuanLyHocVienApp
{
    partial class btnc_QLHocVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHocVienMới = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLopA = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.grpLopB = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.pnlNhapHocVien = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpLopA.SuspendLayout();
            this.grpLopB.SuspendLayout();
            this.pnlNhapHocVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapNhat,
            this.mnuKetThuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapHocVienMới,
            this.mnuChuyenSangLopB,
            this.mnuChuyenSangLopA,
            this.mnuXoaHocVien});
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(84, 24);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuNhapHocVienMới
            // 
            this.mnuNhapHocVienMới.Name = "mnuNhapHocVienMới";
            this.mnuNhapHocVienMới.Size = new System.Drawing.Size(222, 26);
            this.mnuNhapHocVienMới.Text = "Nhập học viên mới";
            this.mnuNhapHocVienMới.Click += new System.EventHandler(this.mnuNhapHocVienMới_Click);
            // 
            // mnuChuyenSangLopB
            // 
            this.mnuChuyenSangLopB.Name = "mnuChuyenSangLopB";
            this.mnuChuyenSangLopB.Size = new System.Drawing.Size(222, 26);
            this.mnuChuyenSangLopB.Text = "Chuyển sang lớp B";
            this.mnuChuyenSangLopB.Click += new System.EventHandler(this.mnuChuyenSangLopB_Click);
            // 
            // mnuChuyenSangLopA
            // 
            this.mnuChuyenSangLopA.Name = "mnuChuyenSangLopA";
            this.mnuChuyenSangLopA.Size = new System.Drawing.Size(222, 26);
            this.mnuChuyenSangLopA.Text = "Chuyển sang lớp A";
            this.mnuChuyenSangLopA.Click += new System.EventHandler(this.mnuChuyenSangLopA_Click);
            // 
            // mnuXoaHocVien
            // 
            this.mnuXoaHocVien.Name = "mnuXoaHocVien";
            this.mnuXoaHocVien.Size = new System.Drawing.Size(222, 26);
            this.mnuXoaHocVien.Text = "Xóa học viên";
            this.mnuXoaHocVien.Click += new System.EventHandler(this.mnuXoaHocVien_Click);
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(82, 24);
            this.mnuKetThuc.Text = "Kết thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // grpLopA
            // 
            this.grpLopA.Controls.Add(this.lstLopA);
            this.grpLopA.Location = new System.Drawing.Point(30, 50);
            this.grpLopA.Name = "grpLopA";
            this.grpLopA.Size = new System.Drawing.Size(240, 260);
            this.grpLopA.TabIndex = 1;
            this.grpLopA.TabStop = false;
            this.grpLopA.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 18;
            this.lstLopA.Location = new System.Drawing.Point(15, 25);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(210, 220);
            this.lstLopA.TabIndex = 0;
            // 
            // grpLopB
            // 
            this.grpLopB.Controls.Add(this.lstLopB);
            this.grpLopB.Location = new System.Drawing.Point(310, 50);
            this.grpLopB.Name = "grpLopB";
            this.grpLopB.Size = new System.Drawing.Size(240, 260);
            this.grpLopB.TabIndex = 2;
            this.grpLopB.TabStop = false;
            this.grpLopB.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 18;
            this.lstLopB.Location = new System.Drawing.Point(15, 25);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(210, 220);
            this.lstLopB.TabIndex = 0;
            // 
            // pnlNhapHocVien
            // 
            this.pnlNhapHocVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNhapHocVien.Controls.Add(this.btnTroVe);
            this.pnlNhapHocVien.Controls.Add(this.btnCapNhat);
            this.pnlNhapHocVien.Controls.Add(this.cboLop);
            this.pnlNhapHocVien.Controls.Add(this.lblLop);
            this.pnlNhapHocVien.Controls.Add(this.txtHoVaTen);
            this.pnlNhapHocVien.Controls.Add(this.lblHoVaTen);
            this.pnlNhapHocVien.Location = new System.Drawing.Point(70, 70);
            this.pnlNhapHocVien.Name = "pnlNhapHocVien";
            this.pnlNhapHocVien.Size = new System.Drawing.Size(440, 195);
            this.pnlNhapHocVien.TabIndex = 3;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(300, 135);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(100, 32);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(180, 135);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 32);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(140, 80);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(260, 26);
            this.cboLop.TabIndex = 3;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(35, 83);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 18);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(140, 35);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(260, 26);
            this.txtHoVaTen.TabIndex = 1;
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Location = new System.Drawing.Point(35, 38);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(73, 18);
            this.lblHoVaTen.TabIndex = 0;
            this.lblHoVaTen.Text = "Họ và Tên";
            // 
            // btnc_QLHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 340);
            this.Controls.Add(this.pnlNhapHocVien);
            this.Controls.Add(this.grpLopB);
            this.Controls.Add(this.grpLopA);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "btnc_QLHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btnc_QLHocVien_FormClosing);
            this.Load += new System.EventHandler(this.btnc_QLHocVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLopA.ResumeLayout(false);
            this.grpLopB.ResumeLayout(false);
            this.pnlNhapHocVien.ResumeLayout(false);
            this.pnlNhapHocVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHocVienMới;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopA;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.GroupBox grpLopA;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox grpLopB;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Panel pnlNhapHocVien;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label lblHoVaTen;
    }
}