namespace QLHS
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.navigationPaneAddClass = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navAddClass = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.picOK = new System.Windows.Forms.PictureBox();
            this.picFalse = new System.Windows.Forms.PictureBox();
            this.lblCheckTenlop = new System.Windows.Forms.Label();
            this.lblCheckML = new System.Windows.Forms.Label();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblGiaovienchunhiem = new System.Windows.Forms.Label();
            this.lblKhoilop = new System.Windows.Forms.Label();
            this.cmbGiaovienchunhiem = new System.Windows.Forms.ComboBox();
            this.cmbKhoilop = new System.Windows.Forms.ComboBox();
            this.lblSiso = new System.Windows.Forms.Label();
            this.txtSiso = new System.Windows.Forms.TextBox();
            this.lblTenlop = new System.Windows.Forms.Label();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.lblMalop = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.radTimtheotenlop = new System.Windows.Forms.RadioButton();
            this.radTimtheomalop = new System.Windows.Forms.RadioButton();
            this.txtNhapthongtincantimkiem = new System.Windows.Forms.TextBox();
            this.lblNhapthongtuncantimkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVLop = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorClass = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneAddClass)).BeginInit();
            this.navigationPaneAddClass.SuspendLayout();
            this.navAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalse)).BeginInit();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorClass)).BeginInit();
            this.bindingNavigatorClass.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPaneAddClass
            // 
            this.navigationPaneAddClass.Controls.Add(this.navAddClass);
            this.navigationPaneAddClass.Controls.Add(this.navigationPage2);
            this.navigationPaneAddClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPaneAddClass.Location = new System.Drawing.Point(0, 0);
            this.navigationPaneAddClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.navigationPaneAddClass.Name = "navigationPaneAddClass";
            this.navigationPaneAddClass.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navAddClass,
            this.navigationPage2});
            this.navigationPaneAddClass.RegularSize = new System.Drawing.Size(225, 482);
            this.navigationPaneAddClass.SelectedPage = this.navAddClass;
            this.navigationPaneAddClass.Size = new System.Drawing.Size(225, 482);
            this.navigationPaneAddClass.TabIndex = 0;
            this.navigationPaneAddClass.Text = "Tìm kiếm";
            this.navigationPaneAddClass.Click += new System.EventHandler(this.navigationPane1_Click);
            // 
            // navAddClass
            // 
            this.navAddClass.Caption = "Thêm Lớp";
            this.navAddClass.Controls.Add(this.picOK);
            this.navAddClass.Controls.Add(this.picFalse);
            this.navAddClass.Controls.Add(this.lblCheckTenlop);
            this.navAddClass.Controls.Add(this.lblCheckML);
            this.navAddClass.Controls.Add(this.cmbNamHoc);
            this.navAddClass.Controls.Add(this.lbNamHoc);
            this.navAddClass.Controls.Add(this.btnLuu);
            this.navAddClass.Controls.Add(this.lblGiaovienchunhiem);
            this.navAddClass.Controls.Add(this.lblKhoilop);
            this.navAddClass.Controls.Add(this.cmbGiaovienchunhiem);
            this.navAddClass.Controls.Add(this.cmbKhoilop);
            this.navAddClass.Controls.Add(this.lblSiso);
            this.navAddClass.Controls.Add(this.txtSiso);
            this.navAddClass.Controls.Add(this.lblTenlop);
            this.navAddClass.Controls.Add(this.txtTenlop);
            this.navAddClass.Controls.Add(this.lblMalop);
            this.navAddClass.Controls.Add(this.txtMalop);
            this.navAddClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.navAddClass.Name = "navAddClass";
            this.navAddClass.Size = new System.Drawing.Size(145, 422);
            // 
            // picOK
            // 
            this.picOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picOK.BackColor = System.Drawing.Color.White;
            this.picOK.Image = global::QLHS.Properties.Resources.hanhkiem;
            this.picOK.Location = new System.Drawing.Point(103, 31);
            this.picOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(16, 16);
            this.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOK.TabIndex = 14;
            this.picOK.TabStop = false;
            // 
            // picFalse
            // 
            this.picFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFalse.BackColor = System.Drawing.Color.White;
            this.picFalse.Image = global::QLHS.Properties.Resources.delete;
            this.picFalse.Location = new System.Drawing.Point(103, 31);
            this.picFalse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picFalse.Name = "picFalse";
            this.picFalse.Size = new System.Drawing.Size(16, 16);
            this.picFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFalse.TabIndex = 14;
            this.picFalse.TabStop = false;
            // 
            // lblCheckTenlop
            // 
            this.lblCheckTenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckTenlop.AutoSize = true;
            this.lblCheckTenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckTenlop.Location = new System.Drawing.Point(5, 103);
            this.lblCheckTenlop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckTenlop.Name = "lblCheckTenlop";
            this.lblCheckTenlop.Size = new System.Drawing.Size(35, 13);
            this.lblCheckTenlop.TabIndex = 2;
            this.lblCheckTenlop.Text = "lable1";
            // 
            // lblCheckML
            // 
            this.lblCheckML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckML.AutoSize = true;
            this.lblCheckML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckML.Location = new System.Drawing.Point(5, 51);
            this.lblCheckML.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckML.Name = "lblCheckML";
            this.lblCheckML.Size = new System.Drawing.Size(35, 13);
            this.lblCheckML.TabIndex = 2;
            this.lblCheckML.Text = "lable1";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(0, 261);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(123, 21);
            this.cmbNamHoc.TabIndex = 10;
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.Location = new System.Drawing.Point(5, 245);
            this.lbNamHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(50, 13);
            this.lbNamHoc.TabIndex = 9;
            this.lbNamHoc.Text = "Năm học";
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QLHS.Properties.Resources.add;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(0, 389);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(145, 33);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblGiaovienchunhiem
            // 
            this.lblGiaovienchunhiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiaovienchunhiem.AutoSize = true;
            this.lblGiaovienchunhiem.Location = new System.Drawing.Point(2, 314);
            this.lblGiaovienchunhiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaovienchunhiem.Name = "lblGiaovienchunhiem";
            this.lblGiaovienchunhiem.Size = new System.Drawing.Size(104, 13);
            this.lblGiaovienchunhiem.TabIndex = 11;
            this.lblGiaovienchunhiem.Text = "Giáo viên chủ nhiệm";
            // 
            // lblKhoilop
            // 
            this.lblKhoilop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhoilop.AutoSize = true;
            this.lblKhoilop.Location = new System.Drawing.Point(5, 178);
            this.lblKhoilop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoilop.Name = "lblKhoilop";
            this.lblKhoilop.Size = new System.Drawing.Size(45, 13);
            this.lblKhoilop.TabIndex = 7;
            this.lblKhoilop.Text = "Khối lớp";
            // 
            // cmbGiaovienchunhiem
            // 
            this.cmbGiaovienchunhiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGiaovienchunhiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGiaovienchunhiem.FormattingEnabled = true;
            this.cmbGiaovienchunhiem.Location = new System.Drawing.Point(0, 328);
            this.cmbGiaovienchunhiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGiaovienchunhiem.Name = "cmbGiaovienchunhiem";
            this.cmbGiaovienchunhiem.Size = new System.Drawing.Size(123, 21);
            this.cmbGiaovienchunhiem.TabIndex = 12;
            // 
            // cmbKhoilop
            // 
            this.cmbKhoilop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKhoilop.FormattingEnabled = true;
            this.cmbKhoilop.Location = new System.Drawing.Point(0, 197);
            this.cmbKhoilop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbKhoilop.Name = "cmbKhoilop";
            this.cmbKhoilop.Size = new System.Drawing.Size(123, 21);
            this.cmbKhoilop.TabIndex = 8;
            // 
            // lblSiso
            // 
            this.lblSiso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSiso.AutoSize = true;
            this.lblSiso.Location = new System.Drawing.Point(5, 121);
            this.lblSiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiso.Name = "lblSiso";
            this.lblSiso.Size = new System.Drawing.Size(33, 13);
            this.lblSiso.TabIndex = 5;
            this.lblSiso.Text = "Sĩ số";
            // 
            // txtSiso
            // 
            this.txtSiso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSiso.Location = new System.Drawing.Point(0, 137);
            this.txtSiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.ReadOnly = true;
            this.txtSiso.Size = new System.Drawing.Size(123, 20);
            this.txtSiso.TabIndex = 6;
            this.txtSiso.Text = "0";
            // 
            // lblTenlop
            // 
            this.lblTenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenlop.AutoSize = true;
            this.lblTenlop.Location = new System.Drawing.Point(3, 68);
            this.lblTenlop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenlop.Name = "lblTenlop";
            this.lblTenlop.Size = new System.Drawing.Size(43, 13);
            this.lblTenlop.TabIndex = 3;
            this.lblTenlop.Text = "Tên lớp";
            // 
            // txtTenlop
            // 
            this.txtTenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenlop.Location = new System.Drawing.Point(0, 84);
            this.txtTenlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(123, 20);
            this.txtTenlop.TabIndex = 4;
            this.txtTenlop.Enter += new System.EventHandler(this.txtTenlop_Enter);
            this.txtTenlop.Leave += new System.EventHandler(this.txtTenlop_Leave);
            // 
            // lblMalop
            // 
            this.lblMalop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMalop.AutoSize = true;
            this.lblMalop.Location = new System.Drawing.Point(3, 13);
            this.lblMalop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMalop.Name = "lblMalop";
            this.lblMalop.Size = new System.Drawing.Size(39, 13);
            this.lblMalop.TabIndex = 0;
            this.lblMalop.Text = "Mã lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalop.Location = new System.Drawing.Point(0, 29);
            this.txtMalop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(123, 20);
            this.txtMalop.TabIndex = 1;
            this.txtMalop.TextChanged += new System.EventHandler(this.txtMalop_TextChanged);
            this.txtMalop.Enter += new System.EventHandler(this.txtMalop_Enter);
            this.txtMalop.Leave += new System.EventHandler(this.txtMalop_Leave);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotenlop);
            this.navigationPage2.Controls.Add(this.radTimtheomalop);
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.lblNhapthongtuncantimkiem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(142, 425);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = global::QLHS.Properties.Resources.xemdiem;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(2, 192);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(137, 34);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radTimtheotenlop
            // 
            this.radTimtheotenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTimtheotenlop.AutoSize = true;
            this.radTimtheotenlop.Location = new System.Drawing.Point(5, 131);
            this.radTimtheotenlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radTimtheotenlop.Name = "radTimtheotenlop";
            this.radTimtheotenlop.Size = new System.Drawing.Size(101, 17);
            this.radTimtheotenlop.TabIndex = 3;
            this.radTimtheotenlop.TabStop = true;
            this.radTimtheotenlop.Text = "Tìm theo tên lớp";
            this.radTimtheotenlop.UseVisualStyleBackColor = true;
            // 
            // radTimtheomalop
            // 
            this.radTimtheomalop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTimtheomalop.AutoSize = true;
            this.radTimtheomalop.Location = new System.Drawing.Point(5, 98);
            this.radTimtheomalop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radTimtheomalop.Name = "radTimtheomalop";
            this.radTimtheomalop.Size = new System.Drawing.Size(100, 17);
            this.radTimtheomalop.TabIndex = 2;
            this.radTimtheomalop.TabStop = true;
            this.radTimtheomalop.Text = "Tìm theo mã lớp";
            this.radTimtheomalop.UseVisualStyleBackColor = true;
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(2, 52);
            this.txtNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(138, 20);
            this.txtNhapthongtincantimkiem.TabIndex = 1;
            this.txtNhapthongtincantimkiem.Enter += new System.EventHandler(this.txtNhapthongtincantimkiem_Enter);
            this.txtNhapthongtincantimkiem.Leave += new System.EventHandler(this.txtNhapthongtincantimkiem_Leave);
            // 
            // lblNhapthongtuncantimkiem
            // 
            this.lblNhapthongtuncantimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhapthongtuncantimkiem.AutoSize = true;
            this.lblNhapthongtuncantimkiem.Location = new System.Drawing.Point(3, 25);
            this.lblNhapthongtuncantimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapthongtuncantimkiem.Name = "lblNhapthongtuncantimkiem";
            this.lblNhapthongtuncantimkiem.Size = new System.Drawing.Size(139, 13);
            this.lblNhapthongtuncantimkiem.TabIndex = 0;
            this.lblNhapthongtuncantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip2);
            this.groupBox1.Controls.Add(this.dGVLop);
            this.groupBox1.Controls.Add(this.bindingNavigatorClass);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(225, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(499, 482);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dGVLop
            // 
            this.dGVLop.AllowUserToAddRows = false;
            this.dGVLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.TenKhoiLop,
            this.TenGV,
            this.TenNamHoc});
            this.dGVLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVLop.Location = new System.Drawing.Point(2, 42);
            this.dGVLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVLop.Name = "dGVLop";
            this.dGVLop.RowTemplate.Height = 24;
            this.dGVLop.Size = new System.Drawing.Size(495, 438);
            this.dGVLop.TabIndex = 1;
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // TenKhoiLop
            // 
            this.TenKhoiLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhoiLop.DataPropertyName = "TenKhoiLop";
            this.TenKhoiLop.HeaderText = "Khối Lớp";
            this.TenKhoiLop.Name = "TenKhoiLop";
            // 
            // TenGV
            // 
            this.TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.TenGV.Name = "TenGV";
            // 
            // TenNamHoc
            // 
            this.TenNamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNamHoc.DataPropertyName = "TenNamHoc";
            this.TenNamHoc.HeaderText = "Năm học";
            this.TenNamHoc.Name = "TenNamHoc";
            // 
            // bindingNavigatorClass
            // 
            this.bindingNavigatorClass.AddNewItem = null;
            this.bindingNavigatorClass.CountItem = null;
            this.bindingNavigatorClass.DeleteItem = null;
            this.bindingNavigatorClass.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.btnAdd,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnExit});
            this.bindingNavigatorClass.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigatorClass.MoveFirstItem = null;
            this.bindingNavigatorClass.MoveLastItem = null;
            this.bindingNavigatorClass.MoveNextItem = null;
            this.bindingNavigatorClass.MovePreviousItem = null;
            this.bindingNavigatorClass.Name = "bindingNavigatorClass";
            this.bindingNavigatorClass.PositionItem = null;
            this.bindingNavigatorClass.Size = new System.Drawing.Size(495, 27);
            this.bindingNavigatorClass.TabIndex = 0;
            this.bindingNavigatorClass.Text = "bindingNavigator1";
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
            // btnAdd
            // 
            this.btnAdd.Image = global::QLHS.Properties.Resources.edit;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(51, 24);
            this.btnAdd.Text = "Edit";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLHS.Properties.Resources.thoat;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 24);
            this.btnExit.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(225, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(499, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(2, 458);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(495, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPaneAddClass);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLop";
            this.Text = "Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneAddClass)).EndInit();
            this.navigationPaneAddClass.ResumeLayout(false);
            this.navAddClass.ResumeLayout(false);
            this.navAddClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalse)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorClass)).EndInit();
            this.bindingNavigatorClass.ResumeLayout(false);
            this.bindingNavigatorClass.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPaneAddClass;
        private DevExpress.XtraBars.Navigation.NavigationPage navAddClass;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Label lblGiaovienchunhiem;
        private System.Windows.Forms.Label lblKhoilop;
        private System.Windows.Forms.ComboBox cmbGiaovienchunhiem;
        private System.Windows.Forms.ComboBox cmbKhoilop;
        private System.Windows.Forms.Label lblSiso;
        private System.Windows.Forms.TextBox txtSiso;
        private System.Windows.Forms.Label lblTenlop;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.Label lblMalop;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton radTimtheotenlop;
        private System.Windows.Forms.RadioButton radTimtheomalop;
        private System.Windows.Forms.TextBox txtNhapthongtincantimkiem;
        private System.Windows.Forms.Label lblNhapthongtuncantimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVLop;
        private System.Windows.Forms.BindingNavigator bindingNavigatorClass;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.Label lblCheckML;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNamHoc;
        private System.Windows.Forms.PictureBox picFalse;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.Label lblCheckTenlop;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}