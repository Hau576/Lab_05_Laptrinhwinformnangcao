namespace BaiTapComboBox
{
    partial class btmau_loaddlCombobox
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
            this.btn_loadDL = new System.Windows.Forms.Button();
            this.lbl_Dantoc = new System.Windows.Forms.Label();
            this.cbo_dt = new System.Windows.Forms.ComboBox();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_loadDL
            // 
            this.btn_loadDL.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadDL.Location = new System.Drawing.Point(100, 25);
            this.btn_loadDL.Name = "btn_loadDL";
            this.btn_loadDL.Size = new System.Drawing.Size(200, 35);
            this.btn_loadDL.TabIndex = 0;
            this.btn_loadDL.Text = "Load dữ liệu Combobox";
            this.btn_loadDL.UseVisualStyleBackColor = true;
            this.btn_loadDL.Click += new System.EventHandler(this.btn_loadDL_Click);
            // 
            // lbl_Dantoc
            // 
            this.lbl_Dantoc.AutoSize = true;
            this.lbl_Dantoc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dantoc.Location = new System.Drawing.Point(50, 80);
            this.lbl_Dantoc.Name = "lbl_Dantoc";
            this.lbl_Dantoc.Size = new System.Drawing.Size(64, 18);
            this.lbl_Dantoc.TabIndex = 1;
            this.lbl_Dantoc.Text = "Dân tộc";
            // 
            // cbo_dt
            // 
            this.cbo_dt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_dt.FormattingEnabled = true;
            this.cbo_dt.Location = new System.Drawing.Point(140, 77);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new System.Drawing.Size(180, 26);
            this.cbo_dt.TabIndex = 2;
            this.cbo_dt.SelectedIndexChanged += new System.EventHandler(this.cbo_dt_SelectedIndexChanged);
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthi.Location = new System.Drawing.Point(140, 125);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(110, 35);
            this.btn_hienthi.TabIndex = 3;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kq.ForeColor = System.Drawing.Color.Red;
            this.lbl_kq.Location = new System.Drawing.Point(100, 180);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(65, 18);
            this.lbl_kq.TabIndex = 4;
            this.lbl_kq.Text = "Kết quả";
            // 
            // btmau_loaddlCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.cbo_dt);
            this.Controls.Add(this.lbl_Dantoc);
            this.Controls.Add(this.btn_loadDL);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "btmau_loaddlCombobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cbo_Dantoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadDL;
        private System.Windows.Forms.Label lbl_Dantoc;
        private System.Windows.Forms.ComboBox cbo_dt;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Label lbl_kq;
    }
}