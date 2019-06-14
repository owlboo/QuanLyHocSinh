namespace QLHS
{
    partial class frmNhapdiemchung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapdiemchung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVNhapdiemchung = new System.Windows.Forms.DataGridView();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemmieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem15phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem45phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorBangDiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddDiem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnHiemthidanhsach1 = new System.Windows.Forms.Button();
            this.lblLop1 = new System.Windows.Forms.Label();
            this.lblMonhoc1 = new System.Windows.Forms.Label();
            this.lblHocky1 = new System.Windows.Forms.Label();
            this.lblNamhoc1 = new System.Windows.Forms.Label();
            this.cmbMonHoc1 = new System.Windows.Forms.ComboBox();
            this.cmbHocky1 = new System.Windows.Forms.ComboBox();
            this.cmbLop1 = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc1 = new System.Windows.Forms.ComboBox();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhapdiemchung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorBangDiem)).BeginInit();
            this.bindingNavigatorBangDiem.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVNhapdiemchung);
            this.groupBox1.Controls.Add(this.bindingNavigatorBangDiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(283, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(471, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dGVNhapdiemchung
            // 
            this.dGVNhapdiemchung.AllowUserToAddRows = false;
            this.dGVNhapdiemchung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVNhapdiemchung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNhapdiemchung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colDiemmieng,
            this.colDiem15phut,
            this.colDiem45phut,
            this.colDiemthi});
            this.dGVNhapdiemchung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVNhapdiemchung.Location = new System.Drawing.Point(2, 42);
            this.dGVNhapdiemchung.Margin = new System.Windows.Forms.Padding(2);
            this.dGVNhapdiemchung.Name = "dGVNhapdiemchung";
            this.dGVNhapdiemchung.RowTemplate.Height = 24;
            this.dGVNhapdiemchung.Size = new System.Drawing.Size(467, 322);
            this.dGVNhapdiemchung.TabIndex = 1;
            // 
            // colMahocsinh
            // 
            this.colMahocsinh.DataPropertyName = "MaHS";
            this.colMahocsinh.HeaderText = "Mã học sinh";
            this.colMahocsinh.Name = "colMahocsinh";
            // 
            // colTenhocsinh
            // 
            this.colTenhocsinh.DataPropertyName = "HoTen";
            this.colTenhocsinh.HeaderText = "Tên học sinh";
            this.colTenhocsinh.Name = "colTenhocsinh";
            // 
            // colDiemmieng
            // 
            this.colDiemmieng.HeaderText = "Điểm miệng";
            this.colDiemmieng.Name = "colDiemmieng";
            // 
            // colDiem15phut
            // 
            this.colDiem15phut.HeaderText = "Điểm 15 phút";
            this.colDiem15phut.Name = "colDiem15phut";
            // 
            // colDiem45phut
            // 
            this.colDiem45phut.HeaderText = "Điểm 45 phút";
            this.colDiem45phut.Name = "colDiem45phut";
            // 
            // colDiemthi
            // 
            this.colDiemthi.HeaderText = "Điểm thi";
            this.colDiemthi.Name = "colDiemthi";
            // 
            // bindingNavigatorBangDiem
            // 
            this.bindingNavigatorBangDiem.AddNewItem = this.btnAddDiem;
            this.bindingNavigatorBangDiem.CountItem = null;
            this.bindingNavigatorBangDiem.DeleteItem = null;
            this.bindingNavigatorBangDiem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorBangDiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.btnAddDiem,
            this.bindingNavigatorSeparator2,
            this.btnDelete,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.btnExit,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator6});
            this.bindingNavigatorBangDiem.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigatorBangDiem.MoveFirstItem = null;
            this.bindingNavigatorBangDiem.MoveLastItem = null;
            this.bindingNavigatorBangDiem.MoveNextItem = null;
            this.bindingNavigatorBangDiem.MovePreviousItem = null;
            this.bindingNavigatorBangDiem.Name = "bindingNavigatorBangDiem";
            this.bindingNavigatorBangDiem.PositionItem = null;
            this.bindingNavigatorBangDiem.Size = new System.Drawing.Size(467, 27);
            this.bindingNavigatorBangDiem.TabIndex = 0;
            this.bindingNavigatorBangDiem.Text = "bindingNavigator1";
            // 
            // btnAddDiem
            // 
            this.btnAddDiem.Image = global::QLHS.Properties.Resources.add;
            this.btnAddDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDiem.Name = "btnAddDiem";
            this.btnAddDiem.Size = new System.Drawing.Size(53, 24);
            this.btnAddDiem.Text = "Add";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(64, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLHS.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLHS.Properties.Resources.thoat;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 24);
            this.btnExit.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 24);
            this.toolStripButton1.Text = "Import";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Nhập điểm";
            this.navigationPage1.Controls.Add(this.statusStrip1);
            this.navigationPage1.Controls.Add(this.btnHiemthidanhsach1);
            this.navigationPage1.Controls.Add(this.lblLop1);
            this.navigationPage1.Controls.Add(this.lblMonhoc1);
            this.navigationPage1.Controls.Add(this.lblHocky1);
            this.navigationPage1.Controls.Add(this.lblNamhoc1);
            this.navigationPage1.Controls.Add(this.cmbMonHoc1);
            this.navigationPage1.Controls.Add(this.cmbHocky1);
            this.navigationPage1.Controls.Add(this.cmbLop1);
            this.navigationPage1.Controls.Add(this.cmbNamhoc1);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(199, 306);
            // 
            // btnHiemthidanhsach1
            // 
            this.btnHiemthidanhsach1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHiemthidanhsach1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHiemthidanhsach1.Image = global::QLHS.Properties.Resources.kqcnamtheomon;
            this.btnHiemthidanhsach1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHiemthidanhsach1.Location = new System.Drawing.Point(3, 222);
            this.btnHiemthidanhsach1.Margin = new System.Windows.Forms.Padding(2);
            this.btnHiemthidanhsach1.Name = "btnHiemthidanhsach1";
            this.btnHiemthidanhsach1.Size = new System.Drawing.Size(163, 42);
            this.btnHiemthidanhsach1.TabIndex = 8;
            this.btnHiemthidanhsach1.Text = "Hiển thị";
            this.btnHiemthidanhsach1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHiemthidanhsach1.UseVisualStyleBackColor = true;
            this.btnHiemthidanhsach1.Click += new System.EventHandler(this.btnHiemthidanhsach1_Click);
            // 
            // lblLop1
            // 
            this.lblLop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLop1.AutoSize = true;
            this.lblLop1.Location = new System.Drawing.Point(3, 73);
            this.lblLop1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLop1.Name = "lblLop1";
            this.lblLop1.Size = new System.Drawing.Size(25, 13);
            this.lblLop1.TabIndex = 2;
            this.lblLop1.Text = "Lớp";
            // 
            // lblMonhoc1
            // 
            this.lblMonhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonhoc1.AutoSize = true;
            this.lblMonhoc1.Location = new System.Drawing.Point(3, 176);
            this.lblMonhoc1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonhoc1.Name = "lblMonhoc1";
            this.lblMonhoc1.Size = new System.Drawing.Size(49, 13);
            this.lblMonhoc1.TabIndex = 6;
            this.lblMonhoc1.Text = "Môn học";
            // 
            // lblHocky1
            // 
            this.lblHocky1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHocky1.AutoSize = true;
            this.lblHocky1.Location = new System.Drawing.Point(3, 128);
            this.lblHocky1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHocky1.Name = "lblHocky1";
            this.lblHocky1.Size = new System.Drawing.Size(41, 13);
            this.lblHocky1.TabIndex = 4;
            this.lblHocky1.Text = "Học kỳ";
            // 
            // lblNamhoc1
            // 
            this.lblNamhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamhoc1.AutoSize = true;
            this.lblNamhoc1.Location = new System.Drawing.Point(3, 24);
            this.lblNamhoc1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamhoc1.Name = "lblNamhoc1";
            this.lblNamhoc1.Size = new System.Drawing.Size(50, 13);
            this.lblNamhoc1.TabIndex = 0;
            this.lblNamhoc1.Text = "Năm học";
            // 
            // cmbMonHoc1
            // 
            this.cmbMonHoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonHoc1.FormattingEnabled = true;
            this.cmbMonHoc1.Location = new System.Drawing.Point(3, 193);
            this.cmbMonHoc1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonHoc1.Name = "cmbMonHoc1";
            this.cmbMonHoc1.Size = new System.Drawing.Size(163, 21);
            this.cmbMonHoc1.TabIndex = 7;
            this.cmbMonHoc1.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc1_SelectedIndexChanged);
            // 
            // cmbHocky1
            // 
            this.cmbHocky1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHocky1.FormattingEnabled = true;
            this.cmbHocky1.Location = new System.Drawing.Point(3, 145);
            this.cmbHocky1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHocky1.Name = "cmbHocky1";
            this.cmbHocky1.Size = new System.Drawing.Size(163, 21);
            this.cmbHocky1.TabIndex = 5;
            this.cmbHocky1.SelectedIndexChanged += new System.EventHandler(this.cmbHocky1_SelectedIndexChanged);
            // 
            // cmbLop1
            // 
            this.cmbLop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLop1.FormattingEnabled = true;
            this.cmbLop1.Location = new System.Drawing.Point(3, 89);
            this.cmbLop1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLop1.Name = "cmbLop1";
            this.cmbLop1.Size = new System.Drawing.Size(160, 21);
            this.cmbLop1.TabIndex = 3;
            this.cmbLop1.SelectedIndexChanged += new System.EventHandler(this.cmbLop1_SelectedIndexChanged);
            // 
            // cmbNamhoc1
            // 
            this.cmbNamhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNamhoc1.FormattingEnabled = true;
            this.cmbNamhoc1.Location = new System.Drawing.Point(3, 40);
            this.cmbNamhoc1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNamhoc1.Name = "cmbNamhoc1";
            this.cmbNamhoc1.Size = new System.Drawing.Size(160, 21);
            this.cmbNamhoc1.TabIndex = 1;
            this.cmbNamhoc1.SelectedIndexChanged += new System.EventHandler(this.cmbNamhoc1_SelectedIndexChanged);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(283, 366);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(283, 366);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(199, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmNhapdiemchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhapdiemchung";
            this.Text = "Nhập điểm lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapdiemchung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhapdiemchung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorBangDiem)).EndInit();
            this.bindingNavigatorBangDiem.ResumeLayout(false);
            this.bindingNavigatorBangDiem.PerformLayout();
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVNhapdiemchung;
        private System.Windows.Forms.BindingNavigator bindingNavigatorBangDiem;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemmieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem15phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem45phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemthi;
        private System.Windows.Forms.ToolStripButton btnAddDiem;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.Button btnHiemthidanhsach1;
        private System.Windows.Forms.Label lblLop1;
        private System.Windows.Forms.Label lblMonhoc1;
        private System.Windows.Forms.Label lblHocky1;
        private System.Windows.Forms.Label lblNamhoc1;
        private System.Windows.Forms.ComboBox cmbMonHoc1;
        private System.Windows.Forms.ComboBox cmbHocky1;
        private System.Windows.Forms.ComboBox cmbLop1;
        private System.Windows.Forms.ComboBox cmbNamhoc1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}