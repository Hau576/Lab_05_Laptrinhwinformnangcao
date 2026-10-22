namespace BTVN_Tuan6
{
    partial class btvn_frmMainCoMenustrip
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
            this.mnuBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBai1,
            this.mnuBai2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBai1
            // 
            this.mnuBai1.Name = "mnuBai1";
            this.mnuBai1.Size = new System.Drawing.Size(53, 24);
            this.mnuBai1.Text = "Bài 1";
            this.mnuBai1.Click += new System.EventHandler(this.mnuBai1_Click);
            // 
            // mnuBai2
            // 
            this.mnuBai2.Name = "mnuBai2";
            this.mnuBai2.Size = new System.Drawing.Size(53, 24);
            this.mnuBai2.Text = "Bài 2";
            this.mnuBai2.Click += new System.EventHandler(this.mnuBai2_Click);
            // 
            // btvn_frmMainCoMenustrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "btvn_frmMainCoMenustrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTVN_Tuan6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btvn_frmMainCoMenustrip_FormClosing);
            this.Load += new System.EventHandler(this.btvn_frmMainCoMenustrip_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBai1;
        private System.Windows.Forms.ToolStripMenuItem mnuBai2;
    }
}