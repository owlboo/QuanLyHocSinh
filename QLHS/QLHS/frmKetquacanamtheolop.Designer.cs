namespace QLHS
{
    partial class frmKetquacanamtheolop
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNamhoc = new System.Windows.Forms.Label();
            this.lblNhapthongtin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colHanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocluc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemtrungbinhcanam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVKetquacanamtheolop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquacanamtheolop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.cmbLop);
            this.panelControl1.Controls.Add(this.cmbNamhoc);
            this.panelControl1.Controls.Add(this.lblLop);
            this.panelControl1.Controls.Add(this.lblNamhoc);
            this.panelControl1.Controls.Add(this.lblNhapthongtin);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 425);
            this.panelControl1.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(32, 258);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(98, 36);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(9, 183);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(141, 24);
            this.cmbLop.TabIndex = 3;
            // 
            // cmbNamhoc
            // 
            this.cmbNamhoc.FormattingEnabled = true;
            this.cmbNamhoc.Location = new System.Drawing.Point(9, 100);
            this.cmbNamhoc.Name = "cmbNamhoc";
            this.cmbNamhoc.Size = new System.Drawing.Size(141, 24);
            this.cmbNamhoc.TabIndex = 3;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(9, 163);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(31, 17);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "Lớp";
            // 
            // lblNamhoc
            // 
            this.lblNamhoc.AutoSize = true;
            this.lblNamhoc.Location = new System.Drawing.Point(6, 79);
            this.lblNamhoc.Name = "lblNamhoc";
            this.lblNamhoc.Size = new System.Drawing.Size(63, 17);
            this.lblNamhoc.TabIndex = 1;
            this.lblNamhoc.Text = "Năm học";
            // 
            // lblNhapthongtin
            // 
            this.lblNhapthongtin.AutoSize = true;
            this.lblNhapthongtin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNhapthongtin.Location = new System.Drawing.Point(5, 2);
            this.lblNhapthongtin.Name = "lblNhapthongtin";
            this.lblNhapthongtin.Size = new System.Drawing.Size(188, 24);
            this.lblNhapthongtin.TabIndex = 0;
            this.lblNhapthongtin.Text = "NHẬP THÔNG TIN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVKetquacanamtheolop);
            this.groupBox1.Location = new System.Drawing.Point(220, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // colHanhkiem
            // 
            this.colHanhkiem.HeaderText = "Hạnh kiểm";
            this.colHanhkiem.Name = "colHanhkiem";
            // 
            // colHocluc
            // 
            this.colHocluc.HeaderText = "Học lưc";
            this.colHocluc.Name = "colHocluc";
            // 
            // colDiemtrungbinhcanam
            // 
            this.colDiemtrungbinhcanam.HeaderText = "Điểm trung bình cả năm";
            this.colDiemtrungbinhcanam.Name = "colDiemtrungbinhcanam";
            // 
            // colTenhocsinh
            // 
            this.colTenhocsinh.HeaderText = "Tên học sinh";
            this.colTenhocsinh.Name = "colTenhocsinh";
            // 
            // colMahocsinh
            // 
            this.colMahocsinh.HeaderText = "Mã học sinh";
            this.colMahocsinh.Name = "colMahocsinh";
            // 
            // dGVKetquacanamtheolop
            // 
            this.dGVKetquacanamtheolop.AllowUserToAddRows = false;
            this.dGVKetquacanamtheolop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKetquacanamtheolop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colDiemtrungbinhcanam,
            this.colHocluc,
            this.colHanhkiem});
            this.dGVKetquacanamtheolop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVKetquacanamtheolop.Location = new System.Drawing.Point(3, 18);
            this.dGVKetquacanamtheolop.Name = "dGVKetquacanamtheolop";
            this.dGVKetquacanamtheolop.RowTemplate.Height = 24;
            this.dGVKetquacanamtheolop.Size = new System.Drawing.Size(562, 416);
            this.dGVKetquacanamtheolop.TabIndex = 0;
            // 
            // frmKetquacanamtheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKetquacanamtheolop";
            this.Text = "Kết quả cả năm theo lớp";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquacanamtheolop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbNamhoc;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNamhoc;
        private System.Windows.Forms.Label lblNhapthongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVKetquacanamtheolop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemtrungbinhcanam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocluc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanhkiem;
    }
}