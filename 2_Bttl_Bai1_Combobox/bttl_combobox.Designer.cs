namespace BaiTapTạiLop
{
    partial class bttl_combobox
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cboDanhSachSo = new System.Windows.Forms.ComboBox();
            this.lblDanhSachUoc = new System.Windows.Forms.Label();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnTongUocSo = new System.Windows.Forms.Button();
            this.btnSoLuongUocChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(110, 25);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(63, 18);
            this.lblNhapSo.TabIndex = 0;
            this.lblNhapSo.Text = "Nhập Số";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(110, 50);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(120, 25);
            this.txtNhapSo.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(240, 48);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cboDanhSachSo
            // 
            this.cboDanhSachSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhSachSo.FormattingEnabled = true;
            this.cboDanhSachSo.Location = new System.Drawing.Point(110, 95);
            this.cboDanhSachSo.Name = "cboDanhSachSo";
            this.cboDanhSachSo.Size = new System.Drawing.Size(220, 26);
            this.cboDanhSachSo.TabIndex = 3;
            this.cboDanhSachSo.SelectedIndexChanged += new System.EventHandler(this.cboDanhSachSo_SelectedIndexChanged);
            // 
            // lblDanhSachUoc
            // 
            this.lblDanhSachUoc.AutoSize = true;
            this.lblDanhSachUoc.Location = new System.Drawing.Point(365, 25);
            this.lblDanhSachUoc.Name = "lblDanhSachUoc";
            this.lblDanhSachUoc.Size = new System.Drawing.Size(155, 18);
            this.lblDanhSachUoc.TabIndex = 4;
            this.lblDanhSachUoc.Text = "Danh sách các ước số";
            // 
            // lstUocSo
            // 
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 18;
            this.lstUocSo.Location = new System.Drawing.Point(368, 50);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(210, 130);
            this.lstUocSo.TabIndex = 5;
            // 
            // btnTongUocSo
            // 
            this.btnTongUocSo.Location = new System.Drawing.Point(368, 195);
            this.btnTongUocSo.Name = "btnTongUocSo";
            this.btnTongUocSo.Size = new System.Drawing.Size(210, 32);
            this.btnTongUocSo.TabIndex = 6;
            this.btnTongUocSo.Text = "&Tổng các ước số";
            this.btnTongUocSo.UseVisualStyleBackColor = true;
            this.btnTongUocSo.Click += new System.EventHandler(this.btnTongUocSo_Click);
            // 
            // btnSoLuongUocChan
            // 
            this.btnSoLuongUocChan.Location = new System.Drawing.Point(368, 235);
            this.btnSoLuongUocChan.Name = "btnSoLuongUocChan";
            this.btnSoLuongUocChan.Size = new System.Drawing.Size(210, 32);
            this.btnSoLuongUocChan.TabIndex = 7;
            this.btnSoLuongUocChan.Text = "Số lượng các ước số &chẵn";
            this.btnSoLuongUocChan.UseVisualStyleBackColor = true;
            this.btnSoLuongUocChan.Click += new System.EventHandler(this.btnSoLuongUocChan_Click);
            // 
            // btnSoLuongUocNguyenTo
            // 
            this.btnSoLuongUocNguyenTo.Location = new System.Drawing.Point(368, 275);
            this.btnSoLuongUocNguyenTo.Name = "btnSoLuongUocNguyenTo";
            this.btnSoLuongUocNguyenTo.Size = new System.Drawing.Size(210, 32);
            this.btnSoLuongUocNguyenTo.TabIndex = 8;
            this.btnSoLuongUocNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            this.btnSoLuongUocNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoLuongUocNguyenTo.Click += new System.EventHandler(this.btnSoLuongUocNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(240, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bttl_combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 330);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoLuongUocNguyenTo);
            this.Controls.Add(this.btnSoLuongUocChan);
            this.Controls.Add(this.btnTongUocSo);
            this.Controls.Add(this.lstUocSo);
            this.Controls.Add(this.lblDanhSachUoc);
            this.Controls.Add(this.cboDanhSachSo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhapSo);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "bttl_combobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bttl_combobox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboDanhSachSo;
        private System.Windows.Forms.Label lblDanhSachUoc;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTongUocSo;
        private System.Windows.Forms.Button btnSoLuongUocChan;
        private System.Windows.Forms.Button btnSoLuongUocNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}