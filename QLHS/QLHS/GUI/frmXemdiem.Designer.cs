namespace QLHS
{
    partial class frmXemdiem
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnXemdiem1 = new System.Windows.Forms.Button();
            this.lblMonhoc1 = new System.Windows.Forms.Label();
            this.lblLop1 = new System.Windows.Forms.Label();
            this.lblHocky1 = new System.Windows.Forms.Label();
            this.lblNamhoc1 = new System.Windows.Forms.Label();
            this.cmbMonhoc1 = new System.Windows.Forms.ComboBox();
            this.cmbLop1 = new System.Windows.Forms.ComboBox();
            this.cmbHocky1 = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc1 = new System.Windows.Forms.ComboBox();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lblLop2 = new System.Windows.Forms.Label();
            this.btnXemdiem2 = new System.Windows.Forms.Button();
            this.lblHocsinh2 = new System.Windows.Forms.Label();
            this.lblMonhoc2 = new System.Windows.Forms.Label();
            this.lblHocky2 = new System.Windows.Forms.Label();
            this.lblNamhoc2 = new System.Windows.Forms.Label();
            this.cmbHocsinh2 = new System.Windows.Forms.ComboBox();
            this.cmbMonhoc2 = new System.Windows.Forms.ComboBox();
            this.cmbLop2 = new System.Windows.Forms.ComboBox();
            this.cmbHocky2 = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVXemdiem = new System.Windows.Forms.DataGridView();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVXemdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(412, 540);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(412, 540);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Xem điểm lớp";
            this.navigationPage1.Controls.Add(this.btnXemdiem1);
            this.navigationPage1.Controls.Add(this.lblMonhoc1);
            this.navigationPage1.Controls.Add(this.lblLop1);
            this.navigationPage1.Controls.Add(this.lblHocky1);
            this.navigationPage1.Controls.Add(this.lblNamhoc1);
            this.navigationPage1.Controls.Add(this.cmbMonhoc1);
            this.navigationPage1.Controls.Add(this.cmbLop1);
            this.navigationPage1.Controls.Add(this.cmbHocky1);
            this.navigationPage1.Controls.Add(this.cmbNamhoc1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(227, 467);
            this.navigationPage1.Click += new System.EventHandler(this.navigationPage1_Click);
            // 
            // btnXemdiem1
            // 
            this.btnXemdiem1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemdiem1.Image = global::QLHS.Properties.Resources.xemdiem;
            this.btnXemdiem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXemdiem1.Location = new System.Drawing.Point(6, 306);
            this.btnXemdiem1.Name = "btnXemdiem1";
            this.btnXemdiem1.Size = new System.Drawing.Size(224, 41);
            this.btnXemdiem1.TabIndex = 2;
            this.btnXemdiem1.Text = "Xem điểm";
            this.btnXemdiem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXemdiem1.UseVisualStyleBackColor = true;
            this.btnXemdiem1.Click += new System.EventHandler(this.btnXemdiem1_Click);
            // 
            // lblMonhoc1
            // 
            this.lblMonhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonhoc1.AutoSize = true;
            this.lblMonhoc1.Location = new System.Drawing.Point(3, 213);
            this.lblMonhoc1.Name = "lblMonhoc1";
            this.lblMonhoc1.Size = new System.Drawing.Size(62, 17);
            this.lblMonhoc1.TabIndex = 1;
            this.lblMonhoc1.Text = "Môn học";
            // 
            // lblLop1
            // 
            this.lblLop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLop1.AutoSize = true;
            this.lblLop1.Location = new System.Drawing.Point(3, 150);
            this.lblLop1.Name = "lblLop1";
            this.lblLop1.Size = new System.Drawing.Size(32, 17);
            this.lblLop1.TabIndex = 1;
            this.lblLop1.Text = "Lớp";
            // 
            // lblHocky1
            // 
            this.lblHocky1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHocky1.AutoSize = true;
            this.lblHocky1.Location = new System.Drawing.Point(3, 84);
            this.lblHocky1.Name = "lblHocky1";
            this.lblHocky1.Size = new System.Drawing.Size(51, 17);
            this.lblHocky1.TabIndex = 1;
            this.lblHocky1.Text = "Học kỳ";
            // 
            // lblNamhoc1
            // 
            this.lblNamhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamhoc1.AutoSize = true;
            this.lblNamhoc1.Location = new System.Drawing.Point(3, 12);
            this.lblNamhoc1.Name = "lblNamhoc1";
            this.lblNamhoc1.Size = new System.Drawing.Size(64, 17);
            this.lblNamhoc1.TabIndex = 1;
            this.lblNamhoc1.Text = "Năm học";
            // 
            // cmbMonhoc1
            // 
            this.cmbMonhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonhoc1.FormattingEnabled = true;
            this.cmbMonhoc1.Location = new System.Drawing.Point(3, 236);
            this.cmbMonhoc1.Name = "cmbMonhoc1";
            this.cmbMonhoc1.Size = new System.Drawing.Size(227, 24);
            this.cmbMonhoc1.TabIndex = 0;
            // 
            // cmbLop1
            // 
            this.cmbLop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLop1.FormattingEnabled = true;
            this.cmbLop1.Location = new System.Drawing.Point(3, 170);
            this.cmbLop1.Name = "cmbLop1";
            this.cmbLop1.Size = new System.Drawing.Size(227, 24);
            this.cmbLop1.TabIndex = 0;
            this.cmbLop1.SelectedIndexChanged += new System.EventHandler(this.cmbLop1_SelectedIndexChanged);
            // 
            // cmbHocky1
            // 
            this.cmbHocky1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHocky1.FormattingEnabled = true;
            this.cmbHocky1.Location = new System.Drawing.Point(3, 104);
            this.cmbHocky1.Name = "cmbHocky1";
            this.cmbHocky1.Size = new System.Drawing.Size(227, 24);
            this.cmbHocky1.TabIndex = 0;
            // 
            // cmbNamhoc1
            // 
            this.cmbNamhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNamhoc1.FormattingEnabled = true;
            this.cmbNamhoc1.Location = new System.Drawing.Point(3, 32);
            this.cmbNamhoc1.Name = "cmbNamhoc1";
            this.cmbNamhoc1.Size = new System.Drawing.Size(227, 24);
            this.cmbNamhoc1.TabIndex = 0;
            this.cmbNamhoc1.SelectedIndexChanged += new System.EventHandler(this.cmbNamhoc1_SelectedIndexChanged);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Xem điểm từng học sinh";
            this.navigationPage2.Controls.Add(this.lblLop2);
            this.navigationPage2.Controls.Add(this.btnXemdiem2);
            this.navigationPage2.Controls.Add(this.lblHocsinh2);
            this.navigationPage2.Controls.Add(this.lblMonhoc2);
            this.navigationPage2.Controls.Add(this.lblHocky2);
            this.navigationPage2.Controls.Add(this.lblNamhoc2);
            this.navigationPage2.Controls.Add(this.cmbHocsinh2);
            this.navigationPage2.Controls.Add(this.cmbMonhoc2);
            this.navigationPage2.Controls.Add(this.cmbLop2);
            this.navigationPage2.Controls.Add(this.cmbHocky2);
            this.navigationPage2.Controls.Add(this.cmbNamhoc2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(227, 467);
            // 
            // lblLop2
            // 
            this.lblLop2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLop2.AutoSize = true;
            this.lblLop2.Location = new System.Drawing.Point(3, 152);
            this.lblLop2.Name = "lblLop2";
            this.lblLop2.Size = new System.Drawing.Size(32, 17);
            this.lblLop2.TabIndex = 13;
            this.lblLop2.Text = "Lớp";
            // 
            // btnXemdiem2
            // 
            this.btnXemdiem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemdiem2.Image = global::QLHS.Properties.Resources.xemdiem;
            this.btnXemdiem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXemdiem2.Location = new System.Drawing.Point(0, 346);
            this.btnXemdiem2.Name = "btnXemdiem2";
            this.btnXemdiem2.Size = new System.Drawing.Size(224, 41);
            this.btnXemdiem2.TabIndex = 12;
            this.btnXemdiem2.Text = "Xem điểm";
            this.btnXemdiem2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXemdiem2.UseVisualStyleBackColor = true;
            this.btnXemdiem2.Click += new System.EventHandler(this.btnXemdiem2_Click);
            // 
            // lblHocsinh2
            // 
            this.lblHocsinh2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHocsinh2.AutoSize = true;
            this.lblHocsinh2.Location = new System.Drawing.Point(3, 283);
            this.lblHocsinh2.Name = "lblHocsinh2";
            this.lblHocsinh2.Size = new System.Drawing.Size(63, 17);
            this.lblHocsinh2.TabIndex = 8;
            this.lblHocsinh2.Text = "Học sinh";
            // 
            // lblMonhoc2
            // 
            this.lblMonhoc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonhoc2.AutoSize = true;
            this.lblMonhoc2.Location = new System.Drawing.Point(3, 215);
            this.lblMonhoc2.Name = "lblMonhoc2";
            this.lblMonhoc2.Size = new System.Drawing.Size(62, 17);
            this.lblMonhoc2.TabIndex = 9;
            this.lblMonhoc2.Text = "Môn học";
            // 
            // lblHocky2
            // 
            this.lblHocky2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHocky2.AutoSize = true;
            this.lblHocky2.Location = new System.Drawing.Point(3, 86);
            this.lblHocky2.Name = "lblHocky2";
            this.lblHocky2.Size = new System.Drawing.Size(51, 17);
            this.lblHocky2.TabIndex = 10;
            this.lblHocky2.Text = "Học kỳ";
            // 
            // lblNamhoc2
            // 
            this.lblNamhoc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamhoc2.AutoSize = true;
            this.lblNamhoc2.Location = new System.Drawing.Point(3, 14);
            this.lblNamhoc2.Name = "lblNamhoc2";
            this.lblNamhoc2.Size = new System.Drawing.Size(64, 17);
            this.lblNamhoc2.TabIndex = 11;
            this.lblNamhoc2.Text = "Năm học";
            // 
            // cmbHocsinh2
            // 
            this.cmbHocsinh2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHocsinh2.FormattingEnabled = true;
            this.cmbHocsinh2.Location = new System.Drawing.Point(3, 306);
            this.cmbHocsinh2.Name = "cmbHocsinh2";
            this.cmbHocsinh2.Size = new System.Drawing.Size(221, 24);
            this.cmbHocsinh2.TabIndex = 3;
            // 
            // cmbMonhoc2
            // 
            this.cmbMonhoc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonhoc2.FormattingEnabled = true;
            this.cmbMonhoc2.Location = new System.Drawing.Point(3, 238);
            this.cmbMonhoc2.Name = "cmbMonhoc2";
            this.cmbMonhoc2.Size = new System.Drawing.Size(221, 24);
            this.cmbMonhoc2.TabIndex = 4;
            // 
            // cmbLop2
            // 
            this.cmbLop2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLop2.FormattingEnabled = true;
            this.cmbLop2.Location = new System.Drawing.Point(3, 172);
            this.cmbLop2.Name = "cmbLop2";
            this.cmbLop2.Size = new System.Drawing.Size(221, 24);
            this.cmbLop2.TabIndex = 5;
            this.cmbLop2.SelectedIndexChanged += new System.EventHandler(this.cmbLop2_SelectedIndexChanged);
            // 
            // cmbHocky2
            // 
            this.cmbHocky2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHocky2.FormattingEnabled = true;
            this.cmbHocky2.Location = new System.Drawing.Point(3, 106);
            this.cmbHocky2.Name = "cmbHocky2";
            this.cmbHocky2.Size = new System.Drawing.Size(221, 24);
            this.cmbHocky2.TabIndex = 6;
            // 
            // cmbNamhoc2
            // 
            this.cmbNamhoc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNamhoc2.FormattingEnabled = true;
            this.cmbNamhoc2.Location = new System.Drawing.Point(3, 34);
            this.cmbNamhoc2.Name = "cmbNamhoc2";
            this.cmbNamhoc2.Size = new System.Drawing.Size(221, 24);
            this.cmbNamhoc2.TabIndex = 7;
            this.cmbNamhoc2.SelectedIndexChanged += new System.EventHandler(this.cmbNamhoc2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVXemdiem);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(412, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dGVXemdiem
            // 
            this.dGVXemdiem.AllowUserToAddRows = false;
            this.dGVXemdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVXemdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVXemdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colMon,
            this.colLoaidiem,
            this.colDiem});
            this.dGVXemdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVXemdiem.Location = new System.Drawing.Point(3, 45);
            this.dGVXemdiem.Name = "dGVXemdiem";
            this.dGVXemdiem.RowTemplate.Height = 24;
            this.dGVXemdiem.Size = new System.Drawing.Size(743, 492);
            this.dGVXemdiem.TabIndex = 1;
            // 
            // colMahocsinh
            // 
            this.colMahocsinh.DataPropertyName = "MaHS";
            this.colMahocsinh.HeaderText = "Mã học sinh";
            this.colMahocsinh.Name = "colMahocsinh";
            this.colMahocsinh.ReadOnly = true;
            // 
            // colTenhocsinh
            // 
            this.colTenhocsinh.DataPropertyName = "HoTen";
            this.colTenhocsinh.HeaderText = "Tên học sinh";
            this.colTenhocsinh.Name = "colTenhocsinh";
            this.colTenhocsinh.ReadOnly = true;
            // 
            // colMon
            // 
            this.colMon.DataPropertyName = "TenMon";
            this.colMon.HeaderText = "Môn";
            this.colMon.Name = "colMon";
            this.colMon.ReadOnly = true;
            // 
            // colLoaidiem
            // 
            this.colLoaidiem.DataPropertyName = "TenCotDiem";
            this.colLoaidiem.HeaderText = "Loại điểm";
            this.colLoaidiem.Name = "colLoaidiem";
            this.colLoaidiem.ReadOnly = true;
            // 
            // colDiem
            // 
            this.colDiem.DataPropertyName = "Diem";
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.btnExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(743, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLHS.Properties.Resources.thoat;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.Text = "Exit";
            // 
            // frmXemdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmXemdiem";
            this.Text = "Xem điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVXemdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Button btnXemdiem1;
        private System.Windows.Forms.Label lblMonhoc1;
        private System.Windows.Forms.Label lblLop1;
        private System.Windows.Forms.Label lblHocky1;
        private System.Windows.Forms.Label lblNamhoc1;
        private System.Windows.Forms.ComboBox cmbMonhoc1;
        private System.Windows.Forms.ComboBox cmbLop1;
        private System.Windows.Forms.ComboBox cmbHocky1;
        private System.Windows.Forms.ComboBox cmbNamhoc1;
        private System.Windows.Forms.Label lblLop2;
        private System.Windows.Forms.Button btnXemdiem2;
        private System.Windows.Forms.Label lblHocsinh2;
        private System.Windows.Forms.Label lblMonhoc2;
        private System.Windows.Forms.Label lblHocky2;
        private System.Windows.Forms.Label lblNamhoc2;
        private System.Windows.Forms.ComboBox cmbHocsinh2;
        private System.Windows.Forms.ComboBox cmbMonhoc2;
        private System.Windows.Forms.ComboBox cmbLop2;
        private System.Windows.Forms.ComboBox cmbHocky2;
        private System.Windows.Forms.ComboBox cmbNamhoc2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVXemdiem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
    }
}