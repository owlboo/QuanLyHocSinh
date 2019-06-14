namespace QLHS
{
    partial class frmKetquahockytheolop
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
            this.cmbHocky = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblHocky = new System.Windows.Forms.Label();
            this.lblNamhoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVKetquahockytheolop = new System.Windows.Forms.DataGridView();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemtrungbinhhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocluc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquahockytheolop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.cmbLop);
            this.panelControl1.Controls.Add(this.cmbHocky);
            this.panelControl1.Controls.Add(this.cmbNamhoc);
            this.panelControl1.Controls.Add(this.lblLop);
            this.panelControl1.Controls.Add(this.lblHocky);
            this.panelControl1.Controls.Add(this.lblNamhoc);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 425);
            this.panelControl1.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(46, 319);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(93, 37);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(6, 239);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(154, 24);
            this.cmbLop.TabIndex = 2;
            // 
            // cmbHocky
            // 
            this.cmbHocky.FormattingEnabled = true;
            this.cmbHocky.Location = new System.Drawing.Point(6, 164);
            this.cmbHocky.Name = "cmbHocky";
            this.cmbHocky.Size = new System.Drawing.Size(154, 24);
            this.cmbHocky.TabIndex = 2;
            // 
            // cmbNamhoc
            // 
            this.cmbNamhoc.FormattingEnabled = true;
            this.cmbNamhoc.Location = new System.Drawing.Point(6, 81);
            this.cmbNamhoc.Name = "cmbNamhoc";
            this.cmbNamhoc.Size = new System.Drawing.Size(154, 24);
            this.cmbNamhoc.TabIndex = 2;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(6, 219);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(31, 17);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "Lớp";
            // 
            // lblHocky
            // 
            this.lblHocky.AutoSize = true;
            this.lblHocky.Location = new System.Drawing.Point(6, 144);
            this.lblHocky.Name = "lblHocky";
            this.lblHocky.Size = new System.Drawing.Size(51, 17);
            this.lblHocky.TabIndex = 1;
            this.lblHocky.Text = "Học kỳ";
            // 
            // lblNamhoc
            // 
            this.lblNamhoc.AutoSize = true;
            this.lblNamhoc.Location = new System.Drawing.Point(6, 61);
            this.lblNamhoc.Name = "lblNamhoc";
            this.lblNamhoc.Size = new System.Drawing.Size(63, 17);
            this.lblNamhoc.TabIndex = 1;
            this.lblNamhoc.Text = "Năm học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP THÔNG TIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVKetquahockytheolop);
            this.groupBox1.Location = new System.Drawing.Point(219, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 425);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dGVKetquahockytheolop
            // 
            this.dGVKetquahockytheolop.AllowUserToAddRows = false;
            this.dGVKetquahockytheolop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKetquahockytheolop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colDiemtrungbinhhocky,
            this.colHocluc,
            this.colHanhkiem});
            this.dGVKetquahockytheolop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVKetquahockytheolop.Location = new System.Drawing.Point(3, 18);
            this.dGVKetquahockytheolop.Name = "dGVKetquahockytheolop";
            this.dGVKetquahockytheolop.RowTemplate.Height = 24;
            this.dGVKetquahockytheolop.Size = new System.Drawing.Size(563, 404);
            this.dGVKetquahockytheolop.TabIndex = 0;
            // 
            // colMahocsinh
            // 
            this.colMahocsinh.HeaderText = "Mã học sinh";
            this.colMahocsinh.Name = "colMahocsinh";
            // 
            // colTenhocsinh
            // 
            this.colTenhocsinh.HeaderText = "Tên học sinh";
            this.colTenhocsinh.Name = "colTenhocsinh";
            // 
            // colDiemtrungbinhhocky
            // 
            this.colDiemtrungbinhhocky.HeaderText = "Điểm trung bình học kỳ";
            this.colDiemtrungbinhhocky.Name = "colDiemtrungbinhhocky";
            // 
            // colHocluc
            // 
            this.colHocluc.HeaderText = "Học lực";
            this.colHocluc.Name = "colHocluc";
            // 
            // colHanhkiem
            // 
            this.colHanhkiem.HeaderText = "Hạnh kiểm";
            this.colHanhkiem.Name = "colHanhkiem";
            // 
            // frmKetquahockytheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKetquahockytheolop";
            this.Text = "Kết quả học kỳ theo lớp";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquahockytheolop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbHocky;
        private System.Windows.Forms.ComboBox cmbNamhoc;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblHocky;
        private System.Windows.Forms.Label lblNamhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVKetquahockytheolop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemtrungbinhhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocluc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanhkiem;
    }
}