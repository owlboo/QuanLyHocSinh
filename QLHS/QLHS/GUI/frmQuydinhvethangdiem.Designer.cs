namespace QLHS
{
    partial class frmQuydinhvethangdiem
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
            this.lblThangdiemsudung = new System.Windows.Forms.Label();
            this.lblThangdiem = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThangdiemsudung
            // 
            this.lblThangdiemsudung.AutoSize = true;
            this.lblThangdiemsudung.Location = new System.Drawing.Point(41, 68);
            this.lblThangdiemsudung.Name = "lblThangdiemsudung";
            this.lblThangdiemsudung.Size = new System.Drawing.Size(138, 17);
            this.lblThangdiemsudung.TabIndex = 0;
            this.lblThangdiemsudung.Text = "Thang điểm sử dụng";
            // 
            // lblThangdiem
            // 
            this.lblThangdiem.AutoSize = true;
            this.lblThangdiem.Location = new System.Drawing.Point(223, 68);
            this.lblThangdiem.Name = "lblThangdiem";
            this.lblThangdiem.Size = new System.Drawing.Size(83, 17);
            this.lblThangdiem.TabIndex = 0;
            this.lblThangdiem.Text = "Thang điểm";
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QLHS.Properties.Resources.exit1;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(226, 117);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 41);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmQuydinhvethangdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 190);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblThangdiem);
            this.Controls.Add(this.lblThangdiemsudung);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuydinhvethangdiem";
            this.Text = "Quy định về thang điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThangdiemsudung;
        private System.Windows.Forms.Label lblThangdiem;
        private System.Windows.Forms.Button btnDong;
    }
}