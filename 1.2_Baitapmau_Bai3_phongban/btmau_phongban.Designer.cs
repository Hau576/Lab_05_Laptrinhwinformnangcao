namespace BaiTapTreeView
{
    partial class btmau_phongban
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_PhongbanTree = new System.Windows.Forms.Label();
            this.trv_DS = new System.Windows.Forms.TreeView();
            this.lbl_Phongban = new System.Windows.Forms.Label();
            this.txt_phongban = new System.Windows.Forms.TextBox();
            this.btn_ThemPB = new System.Windows.Forms.Button();
            this.btn_XoaPB = new System.Windows.Forms.Button();
            this.lbl_Maso = new System.Windows.Forms.Label();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.lbl_Hoten = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lbl_Diachi = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_CboPB = new System.Windows.Forms.Label();
            this.cbo_phongban = new System.Windows.Forms.ComboBox();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Title.Location = new System.Drawing.Point(400, 15);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(220, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // lbl_PhongbanTree
            // 
            this.lbl_PhongbanTree.AutoSize = true;
            this.lbl_PhongbanTree.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhongbanTree.Location = new System.Drawing.Point(15, 15);
            this.lbl_PhongbanTree.Name = "lbl_PhongbanTree";
            this.lbl_PhongbanTree.Size = new System.Drawing.Size(78, 17);
            this.lbl_PhongbanTree.TabIndex = 1;
            this.lbl_PhongbanTree.Text = "Phòng ban";
            // 
            // trv_DS
            // 
            this.trv_DS.Location = new System.Drawing.Point(15, 38);
            this.trv_DS.Name = "trv_DS";
            this.trv_DS.Size = new System.Drawing.Size(260, 310);
            this.trv_DS.TabIndex = 2;
            // 
            // lbl_Phongban
            // 
            this.lbl_Phongban.AutoSize = true;
            this.lbl_Phongban.Location = new System.Drawing.Point(15, 363);
            this.lbl_Phongban.Name = "lbl_Phongban";
            this.lbl_Phongban.Size = new System.Drawing.Size(71, 17);
            this.lbl_Phongban.TabIndex = 3;
            this.lbl_Phongban.Text = "Phòng ban";
            // 
            // txt_phongban
            // 
            this.txt_phongban.Location = new System.Drawing.Point(95, 360);
            this.txt_phongban.Name = "txt_phongban";
            this.txt_phongban.Size = new System.Drawing.Size(180, 24);
            this.txt_phongban.TabIndex = 4;
            // 
            // btn_ThemPB
            // 
            this.btn_ThemPB.Location = new System.Drawing.Point(95, 395);
            this.btn_ThemPB.Name = "btn_ThemPB";
            this.btn_ThemPB.Size = new System.Drawing.Size(180, 30);
            this.btn_ThemPB.TabIndex = 5;
            this.btn_ThemPB.Text = "Thêm phòng ban";
            this.btn_ThemPB.UseVisualStyleBackColor = true;
            this.btn_ThemPB.Click += new System.EventHandler(this.btn_ThemPB_Click);
            // 
            // btn_XoaPB
            // 
            this.btn_XoaPB.Location = new System.Drawing.Point(95, 435);
            this.btn_XoaPB.Name = "btn_XoaPB";
            this.btn_XoaPB.Size = new System.Drawing.Size(180, 30);
            this.btn_XoaPB.TabIndex = 6;
            this.btn_XoaPB.Text = "Xóa phòng ban";
            this.btn_XoaPB.UseVisualStyleBackColor = true;
            this.btn_XoaPB.Click += new System.EventHandler(this.btn_XoaPB_Click);
            // 
            // lbl_Maso
            // 
            this.lbl_Maso.AutoSize = true;
            this.lbl_Maso.Location = new System.Drawing.Point(310, 60);
            this.lbl_Maso.Name = "lbl_Maso";
            this.lbl_Maso.Size = new System.Drawing.Size(44, 17);
            this.lbl_Maso.TabIndex = 7;
            this.lbl_Maso.Text = "Mã số";
            // 
            // txt_maso
            // 
            this.txt_maso.Location = new System.Drawing.Point(390, 57);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(100, 24);
            this.txt_maso.TabIndex = 8;
            // 
            // lbl_Hoten
            // 
            this.lbl_Hoten.AutoSize = true;
            this.lbl_Hoten.Location = new System.Drawing.Point(515, 60);
            this.lbl_Hoten.Name = "lbl_Hoten";
            this.lbl_Hoten.Size = new System.Drawing.Size(48, 17);
            this.lbl_Hoten.TabIndex = 9;
            this.lbl_Hoten.Text = "Họ tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(575, 57);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(180, 24);
            this.txt_hoten.TabIndex = 10;
            // 
            // lbl_Diachi
            // 
            this.lbl_Diachi.AutoSize = true;
            this.lbl_Diachi.Location = new System.Drawing.Point(310, 105);
            this.lbl_Diachi.Name = "lbl_Diachi";
            this.lbl_Diachi.Size = new System.Drawing.Size(50, 17);
            this.lbl_Diachi.TabIndex = 11;
            this.lbl_Diachi.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(390, 102);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(365, 24);
            this.txt_diachi.TabIndex = 12;
            // 
            // lbl_CboPB
            // 
            this.lbl_CboPB.AutoSize = true;
            this.lbl_CboPB.Location = new System.Drawing.Point(310, 150);
            this.lbl_CboPB.Name = "lbl_CboPB";
            this.lbl_CboPB.Size = new System.Drawing.Size(71, 17);
            this.lbl_CboPB.TabIndex = 13;
            this.lbl_CboPB.Text = "Phòng ban";
            // 
            // cbo_phongban
            // 
            this.cbo_phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phongban.FormattingEnabled = true;
            this.cbo_phongban.Location = new System.Drawing.Point(390, 147);
            this.cbo_phongban.Name = "cbo_phongban";
            this.cbo_phongban.Size = new System.Drawing.Size(365, 25);
            this.cbo_phongban.TabIndex = 14;
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(420, 195);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(90, 32);
            this.btn_ThemNV.TabIndex = 15;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(530, 195);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(90, 32);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btmau_phongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 485);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.cbo_phongban);
            this.Controls.Add(this.lbl_CboPB);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.lbl_Diachi);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.lbl_Hoten);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.lbl_Maso);
            this.Controls.Add(this.btn_XoaPB);
            this.Controls.Add(this.btn_ThemPB);
            this.Controls.Add(this.txt_phongban);
            this.Controls.Add(this.lbl_Phongban);
            this.Controls.Add(this.trv_DS);
            this.Controls.Add(this.lbl_PhongbanTree);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "btmau_phongban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng ban -Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btmau_phongban_FormClosing);
            this.Load += new System.EventHandler(this.btmau_phongban_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_PhongbanTree;
        private System.Windows.Forms.TreeView trv_DS;
        private System.Windows.Forms.Label lbl_Phongban;
        private System.Windows.Forms.TextBox txt_phongban;
        private System.Windows.Forms.Button btn_ThemPB;
        private System.Windows.Forms.Button btn_XoaPB;
        private System.Windows.Forms.Label lbl_Maso;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.Label lbl_Hoten;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lbl_Diachi;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_CboPB;
        private System.Windows.Forms.ComboBox cbo_phongban;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_Thoat;
    }
}