namespace QLHS
{
    partial class frmQuydinhvesiso
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
            this.lblSiso1 = new System.Windows.Forms.Label();
            this.lblSisotoithieu = new System.Windows.Forms.Label();
            this.lblSiso2 = new System.Windows.Forms.Label();
            this.lblSisotoida = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSiso1
            // 
            this.lblSiso1.AutoSize = true;
            this.lblSiso1.Location = new System.Drawing.Point(27, 29);
            this.lblSiso1.Name = "lblSiso1";
            this.lblSiso1.Size = new System.Drawing.Size(101, 17);
            this.lblSiso1.TabIndex = 0;
            this.lblSiso1.Text = "Sĩ số tối thiểu :";
            // 
            // lblSisotoithieu
            // 
            this.lblSisotoithieu.AutoSize = true;
            this.lblSisotoithieu.Location = new System.Drawing.Point(202, 29);
            this.lblSisotoithieu.Name = "lblSisotoithieu";
            this.lblSisotoithieu.Size = new System.Drawing.Size(63, 17);
            this.lblSisotoithieu.TabIndex = 0;
            this.lblSisotoithieu.Text = "Tối thiểu";
            // 
            // lblSiso2
            // 
            this.lblSiso2.AutoSize = true;
            this.lblSiso2.Location = new System.Drawing.Point(27, 102);
            this.lblSiso2.Name = "lblSiso2";
            this.lblSiso2.Size = new System.Drawing.Size(86, 17);
            this.lblSiso2.TabIndex = 0;
            this.lblSiso2.Text = "Sĩ số tối đa :";
            // 
            // lblSisotoida
            // 
            this.lblSisotoida.AutoSize = true;
            this.lblSisotoida.Location = new System.Drawing.Point(202, 102);
            this.lblSisotoida.Name = "lblSisotoida";
            this.lblSisotoida.Size = new System.Drawing.Size(48, 17);
            this.lblSisotoida.TabIndex = 0;
            this.lblSisotoida.Text = "Tối đa";
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QLHS.Properties.Resources.exit1;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(205, 146);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 42);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmQuydinhvesiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 214);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblSisotoida);
            this.Controls.Add(this.lblSiso2);
            this.Controls.Add(this.lblSisotoithieu);
            this.Controls.Add(this.lblSiso1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuydinhvesiso";
            this.Text = "Quy định về sĩ số";
            this.Load += new System.EventHandler(this.frmQuydinhvesiso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiso1;
        private System.Windows.Forms.Label lblSisotoithieu;
        private System.Windows.Forms.Label lblSiso2;
        private System.Windows.Forms.Label lblSisotoida;
        private System.Windows.Forms.Button btnDong;
    }
}