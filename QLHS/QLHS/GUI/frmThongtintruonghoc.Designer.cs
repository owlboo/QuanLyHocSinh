namespace QLHS
{
    partial class frmThongtintruonghoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTruong = new System.Windows.Forms.Label();
            this.lblTentruong = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTruong
            // 
            this.lblTruong.AutoSize = true;
            this.lblTruong.Location = new System.Drawing.Point(76, 13);
            this.lblTruong.Name = "lblTruong";
            this.lblTruong.Size = new System.Drawing.Size(62, 17);
            this.lblTruong.TabIndex = 0;
            this.lblTruong.Text = "Trường :";
            // 
            // lblTentruong
            // 
            this.lblTentruong.AutoSize = true;
            this.lblTentruong.Location = new System.Drawing.Point(162, 13);
            this.lblTentruong.Name = "lblTentruong";
            this.lblTentruong.Size = new System.Drawing.Size(28, 17);
            this.lblTentruong.TabIndex = 0;
            this.lblTentruong.Text = "tên";
            this.lblTentruong.Click += new System.EventHandler(this.lblTentruong_Click);
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(76, 75);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(59, 17);
            this.lblDC.TabIndex = 0;
            this.lblDC.Text = "Địa chỉ :";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(162, 75);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(51, 17);
            this.lblDiachi.TabIndex = 0;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QLHS.Properties.Resources.exit1;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(309, 129);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(83, 42);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmThongtintruonghoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 183);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblTentruong);
            this.Controls.Add(this.lblTruong);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongtintruonghoc";
            this.Text = "Thông tin trường học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTruong;
        private System.Windows.Forms.Label lblTentruong;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Button btnDong;
    }
}