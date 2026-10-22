namespace TuDienApp
{
    partial class btvn_tudienAV_VA
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnhViet = new System.Windows.Forms.TabPage();
            this.txtNghiaAnh = new System.Windows.Forms.TextBox();
            this.lstAnh = new System.Windows.Forms.ListBox();
            this.lblTiengVietAnh = new System.Windows.Forms.Label();
            this.lblTiengAnh = new System.Windows.Forms.Label();
            this.tabVietAnh = new System.Windows.Forms.TabPage();
            this.txtNghiaViet = new System.Windows.Forms.TextBox();
            this.lstViet = new System.Windows.Forms.ListBox();
            this.lblTiengAnhViet = new System.Windows.Forms.Label();
            this.lblTiengViet = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAnhViet.SuspendLayout();
            this.tabVietAnh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnhViet);
            this.tabControl1.Controls.Add(this.tabVietAnh);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAnhViet
            // 
            this.tabAnhViet.Controls.Add(this.txtNghiaAnh);
            this.tabAnhViet.Controls.Add(this.lstAnh);
            this.tabAnhViet.Controls.Add(this.lblTiengVietAnh);
            this.tabAnhViet.Controls.Add(this.lblTiengAnh);
            this.tabAnhViet.Location = new System.Drawing.Point(4, 27);
            this.tabAnhViet.Name = "tabAnhViet";
            this.tabAnhViet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnhViet.Size = new System.Drawing.Size(592, 329);
            this.tabAnhViet.TabIndex = 0;
            this.tabAnhViet.Text = "ANH - VIỆT";
            this.tabAnhViet.UseVisualStyleBackColor = true;
            // 
            // txtNghiaAnh
            // 
            this.txtNghiaAnh.Location = new System.Drawing.Point(233, 40);
            this.txtNghiaAnh.Multiline = true;
            this.txtNghiaAnh.Name = "txtNghiaAnh";
            this.txtNghiaAnh.ReadOnly = true;
            this.txtNghiaAnh.Size = new System.Drawing.Size(335, 256);
            this.txtNghiaAnh.TabIndex = 3;
            // 
            // lstAnh
            // 
            this.lstAnh.FormattingEnabled = true;
            this.lstAnh.ItemHeight = 18;
            this.lstAnh.Location = new System.Drawing.Point(23, 40);
            this.lstAnh.Name = "lstAnh";
            this.lstAnh.Size = new System.Drawing.Size(180, 256);
            this.lstAnh.TabIndex = 2;
            this.lstAnh.SelectedIndexChanged += new System.EventHandler(this.lstAnh_SelectedIndexChanged);
            // 
            // lblTiengVietAnh
            // 
            this.lblTiengVietAnh.AutoSize = true;
            this.lblTiengVietAnh.Location = new System.Drawing.Point(230, 15);
            this.lblTiengVietAnh.Name = "lblTiengVietAnh";
            this.lblTiengVietAnh.Size = new System.Drawing.Size(75, 18);
            this.lblTiengVietAnh.TabIndex = 1;
            this.lblTiengVietAnh.Text = "Tiếng Việt";
            // 
            // lblTiengAnh
            // 
            this.lblTiengAnh.AutoSize = true;
            this.lblTiengAnh.Location = new System.Drawing.Point(20, 15);
            this.lblTiengAnh.Name = "lblTiengAnh";
            this.lblTiengAnh.Size = new System.Drawing.Size(73, 18);
            this.lblTiengAnh.TabIndex = 0;
            this.lblTiengAnh.Text = "Tiếng Anh";
            // 
            // tabVietAnh
            // 
            this.tabVietAnh.Controls.Add(this.txtNghiaViet);
            this.tabVietAnh.Controls.Add(this.lstViet);
            this.tabVietAnh.Controls.Add(this.lblTiengAnhViet);
            this.tabVietAnh.Controls.Add(this.lblTiengViet);
            this.tabVietAnh.Location = new System.Drawing.Point(4, 27);
            this.tabVietAnh.Name = "tabVietAnh";
            this.tabVietAnh.Padding = new System.Windows.Forms.Padding(3);
            this.tabVietAnh.Size = new System.Drawing.Size(592, 329);
            this.tabVietAnh.TabIndex = 1;
            this.tabVietAnh.Text = "VIỆT - ANH";
            this.tabVietAnh.UseVisualStyleBackColor = true;
            // 
            // txtNghiaViet
            // 
            this.txtNghiaViet.Location = new System.Drawing.Point(233, 40);
            this.txtNghiaViet.Multiline = true;
            this.txtNghiaViet.Name = "txtNghiaViet";
            this.txtNghiaViet.ReadOnly = true;
            this.txtNghiaViet.Size = new System.Drawing.Size(335, 256);
            this.txtNghiaViet.TabIndex = 3;
            // 
            // lstViet
            // 
            this.lstViet.FormattingEnabled = true;
            this.lstViet.ItemHeight = 18;
            this.lstViet.Location = new System.Drawing.Point(23, 40);
            this.lstViet.Name = "lstViet";
            this.lstViet.Size = new System.Drawing.Size(180, 256);
            this.lstViet.TabIndex = 2;
            this.lstViet.SelectedIndexChanged += new System.EventHandler(this.lstViet_SelectedIndexChanged);
            // 
            // lblTiengAnhViet
            // 
            this.lblTiengAnhViet.AutoSize = true;
            this.lblTiengAnhViet.Location = new System.Drawing.Point(230, 15);
            this.lblTiengAnhViet.Name = "lblTiengAnhViet";
            this.lblTiengAnhViet.Size = new System.Drawing.Size(73, 18);
            this.lblTiengAnhViet.TabIndex = 1;
            this.lblTiengAnhViet.Text = "Tiếng Anh";
            // 
            // lblTiengViet
            // 
            this.lblTiengViet.AutoSize = true;
            this.lblTiengViet.Location = new System.Drawing.Point(20, 15);
            this.lblTiengViet.Name = "lblTiengViet";
            this.lblTiengViet.Size = new System.Drawing.Size(75, 18);
            this.lblTiengViet.TabIndex = 0;
            this.lblTiengViet.Text = "Tiếng Việt";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(520, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btvn_tudienAV_VA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 425);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "btvn_tudienAV_VA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btvn_tudienAV_VA_FormClosing);
            this.Load += new System.EventHandler(this.btvn_tudienAV_VA_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAnhViet.ResumeLayout(false);
            this.tabAnhViet.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabVietAnh.ResumeLayout(false);
            this.tabVietAnh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnhViet;
        private System.Windows.Forms.TabPage tabVietAnh;
        private System.Windows.Forms.Label lblTiengAnh;
        private System.Windows.Forms.Label lblTiengVietAnh;
        private System.Windows.Forms.ListBox lstAnh;
        private System.Windows.Forms.TextBox txtNghiaAnh;
        private System.Windows.Forms.Label lblTiengViet;
        private System.Windows.Forms.Label lblTiengAnhViet;
        private System.Windows.Forms.ListBox lstViet;
        private System.Windows.Forms.TextBox txtNghiaViet;
        private System.Windows.Forms.Button btnThoat;
    }
}