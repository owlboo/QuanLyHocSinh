namespace QLHS
{
    partial class frmQuydinhdotuoi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblDotuoitoithieu = new System.Windows.Forms.Label();
            this.lblDuoitoida = new System.Windows.Forms.Label();
            this.lblToithieu = new System.Windows.Forms.Label();
            this.lblToida = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.lblDotuoitoithieu);
            this.panel1.Controls.Add(this.lblDuoitoida);
            this.panel1.Controls.Add(this.lblToithieu);
            this.panel1.Controls.Add(this.lblToida);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 236);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QLHS.Properties.Resources.exit1;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(232, 157);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(82, 39);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // lblDotuoitoithieu
            // 
            this.lblDotuoitoithieu.AutoSize = true;
            this.lblDotuoitoithieu.Location = new System.Drawing.Point(199, 42);
            this.lblDotuoitoithieu.Name = "lblDotuoitoithieu";
            this.lblDotuoitoithieu.Size = new System.Drawing.Size(90, 17);
            this.lblDotuoitoithieu.TabIndex = 0;
            this.lblDotuoitoithieu.Text = "Tuổi tối thiểu";
            this.lblDotuoitoithieu.Click += new System.EventHandler(this.lblDotuoitoithieu_Click);
            // 
            // lblDuoitoida
            // 
            this.lblDuoitoida.AutoSize = true;
            this.lblDuoitoida.Location = new System.Drawing.Point(199, 114);
            this.lblDuoitoida.Name = "lblDuoitoida";
            this.lblDuoitoida.Size = new System.Drawing.Size(75, 17);
            this.lblDuoitoida.TabIndex = 0;
            this.lblDuoitoida.Text = "Tuổi tối đa";
            // 
            // lblToithieu
            // 
            this.lblToithieu.AutoSize = true;
            this.lblToithieu.Location = new System.Drawing.Point(65, 42);
            this.lblToithieu.Name = "lblToithieu";
            this.lblToithieu.Size = new System.Drawing.Size(115, 17);
            this.lblToithieu.TabIndex = 0;
            this.lblToithieu.Text = "Độ tuổi tối thiểu :";
            // 
            // lblToida
            // 
            this.lblToida.AutoSize = true;
            this.lblToida.Location = new System.Drawing.Point(65, 114);
            this.lblToida.Name = "lblToida";
            this.lblToida.Size = new System.Drawing.Size(100, 17);
            this.lblToida.TabIndex = 0;
            this.lblToida.Text = "Độ tuổi tối đa :";
            // 
            // frmQuydinhdotuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 256);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuydinhdotuoi";
            this.Text = "Quy định độ tuổi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDotuoitoithieu;
        private System.Windows.Forms.Label lblDuoitoida;
        private System.Windows.Forms.Label lblToithieu;
        private System.Windows.Forms.Label lblToida;
        private System.Windows.Forms.Button btnDong;
    }
}