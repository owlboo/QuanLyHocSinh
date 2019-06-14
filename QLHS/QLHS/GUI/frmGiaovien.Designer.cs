namespace QLHS
{
    partial class frmGiaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaovien));
            this.navigationPaneAddGV = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lblCheckDC = new System.Windows.Forms.Label();
            this.lblCheckTenGV = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.picOk = new System.Windows.Forms.PictureBox();
            this.picFalse = new System.Windows.Forms.PictureBox();
            this.lblCheckSDT = new System.Windows.Forms.Label();
            this.picMGVOk = new System.Windows.Forms.PictureBox();
            this.picMGVFalse = new System.Windows.Forms.PictureBox();
            this.lblCheckmaGV = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.btnThemvaodanhsach = new System.Windows.Forms.Button();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblMamonhoc = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.cmbMamonhoc = new System.Windows.Forms.ComboBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtTengiaovien = new System.Windows.Forms.TextBox();
            this.txtMagiaovien = new System.Windows.Forms.TextBox();
            this.lblTengiaovien = new System.Windows.Forms.Label();
            this.lblMagiaovien = new System.Windows.Forms.Label();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtNhapthongtincantimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.radTimtheotengiaovien = new System.Windows.Forms.RadioButton();
            this.radTimtheomagiaovien = new System.Windows.Forms.RadioButton();
            this.lblNhapthongtincantimkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVGiaovien = new System.Windows.Forms.DataGridView();
            this.colMagiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTengiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorGiaoVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExite = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneAddGV)).BeginInit();
            this.navigationPaneAddGV.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMGVOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMGVFalse)).BeginInit();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiaovien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGiaoVien)).BeginInit();
            this.bindingNavigatorGiaoVien.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPaneAddGV
            // 
            this.navigationPaneAddGV.Controls.Add(this.navigationPage1);
            this.navigationPaneAddGV.Controls.Add(this.navigationPage2);
            this.navigationPaneAddGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPaneAddGV.Location = new System.Drawing.Point(0, 0);
            this.navigationPaneAddGV.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPaneAddGV.Name = "navigationPaneAddGV";
            this.navigationPaneAddGV.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPaneAddGV.RegularSize = new System.Drawing.Size(261, 366);
            this.navigationPaneAddGV.SelectedPage = this.navigationPage1;
            this.navigationPaneAddGV.Size = new System.Drawing.Size(261, 366);
            this.navigationPaneAddGV.TabIndex = 0;
            this.navigationPaneAddGV.Text = "navigationPane1";
            this.navigationPaneAddGV.Click += new System.EventHandler(this.navigationPaneAddGV_Click);
            // 
            // navigationPage1
            // 
            this.navigationPage1.AllowTouchScroll = true;
            this.navigationPage1.Caption = "Thêm dữ liệu";
            this.navigationPage1.Controls.Add(this.lblCheckDC);
            this.navigationPage1.Controls.Add(this.lblCheckTenGV);
            this.navigationPage1.Controls.Add(this.listView1);
            this.navigationPage1.Controls.Add(this.picOk);
            this.navigationPage1.Controls.Add(this.picFalse);
            this.navigationPage1.Controls.Add(this.lblCheckSDT);
            this.navigationPage1.Controls.Add(this.picMGVOk);
            this.navigationPage1.Controls.Add(this.picMGVFalse);
            this.navigationPage1.Controls.Add(this.lblCheckmaGV);
            this.navigationPage1.Controls.Add(this.lbDiaChi);
            this.navigationPage1.Controls.Add(this.btnThemvaodanhsach);
            this.navigationPage1.Controls.Add(this.lblDienthoai);
            this.navigationPage1.Controls.Add(this.lblMamonhoc);
            this.navigationPage1.Controls.Add(this.txbDiaChi);
            this.navigationPage1.Controls.Add(this.cmbMamonhoc);
            this.navigationPage1.Controls.Add(this.txtDienthoai);
            this.navigationPage1.Controls.Add(this.txtTengiaovien);
            this.navigationPage1.Controls.Add(this.txtMagiaovien);
            this.navigationPage1.Controls.Add(this.lblTengiaovien);
            this.navigationPage1.Controls.Add(this.lblMagiaovien);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(166, 306);
            // 
            // lblCheckDC
            // 
            this.lblCheckDC.AutoSize = true;
            this.lblCheckDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckDC.Location = new System.Drawing.Point(3, 253);
            this.lblCheckDC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckDC.Name = "lblCheckDC";
            this.lblCheckDC.Size = new System.Drawing.Size(35, 13);
            this.lblCheckDC.TabIndex = 18;
            this.lblCheckDC.Text = "label1";
            // 
            // lblCheckTenGV
            // 
            this.lblCheckTenGV.AutoSize = true;
            this.lblCheckTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckTenGV.Location = new System.Drawing.Point(3, 98);
            this.lblCheckTenGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckTenGV.Name = "lblCheckTenGV";
            this.lblCheckTenGV.Size = new System.Drawing.Size(35, 13);
            this.lblCheckTenGV.TabIndex = 17;
            this.lblCheckTenGV.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(0, 253);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(137, 0);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // picOk
            // 
            this.picOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picOk.BackColor = System.Drawing.Color.White;
            this.picOk.Image = global::QLHS.Properties.Resources.hanhkiem;
            this.picOk.Location = new System.Drawing.Point(119, 176);
            this.picOk.Margin = new System.Windows.Forms.Padding(2);
            this.picOk.Name = "picOk";
            this.picOk.Size = new System.Drawing.Size(16, 16);
            this.picOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOk.TabIndex = 15;
            this.picOk.TabStop = false;
            // 
            // picFalse
            // 
            this.picFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFalse.BackColor = System.Drawing.Color.White;
            this.picFalse.Image = global::QLHS.Properties.Resources.delete;
            this.picFalse.Location = new System.Drawing.Point(119, 176);
            this.picFalse.Margin = new System.Windows.Forms.Padding(2);
            this.picFalse.Name = "picFalse";
            this.picFalse.Size = new System.Drawing.Size(16, 16);
            this.picFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFalse.TabIndex = 15;
            this.picFalse.TabStop = false;
            // 
            // lblCheckSDT
            // 
            this.lblCheckSDT.AutoSize = true;
            this.lblCheckSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckSDT.Location = new System.Drawing.Point(3, 198);
            this.lblCheckSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckSDT.Name = "lblCheckSDT";
            this.lblCheckSDT.Size = new System.Drawing.Size(35, 13);
            this.lblCheckSDT.TabIndex = 14;
            this.lblCheckSDT.Text = "label1";
            // 
            // picMGVOk
            // 
            this.picMGVOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMGVOk.BackColor = System.Drawing.Color.White;
            this.picMGVOk.Image = global::QLHS.Properties.Resources.hanhkiem;
            this.picMGVOk.Location = new System.Drawing.Point(119, 20);
            this.picMGVOk.Margin = new System.Windows.Forms.Padding(2);
            this.picMGVOk.Name = "picMGVOk";
            this.picMGVOk.Size = new System.Drawing.Size(16, 16);
            this.picMGVOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMGVOk.TabIndex = 13;
            this.picMGVOk.TabStop = false;
            // 
            // picMGVFalse
            // 
            this.picMGVFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMGVFalse.BackColor = System.Drawing.Color.White;
            this.picMGVFalse.Image = global::QLHS.Properties.Resources.delete;
            this.picMGVFalse.Location = new System.Drawing.Point(119, 22);
            this.picMGVFalse.Margin = new System.Windows.Forms.Padding(2);
            this.picMGVFalse.Name = "picMGVFalse";
            this.picMGVFalse.Size = new System.Drawing.Size(16, 16);
            this.picMGVFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMGVFalse.TabIndex = 12;
            this.picMGVFalse.TabStop = false;
            // 
            // lblCheckmaGV
            // 
            this.lblCheckmaGV.AutoSize = true;
            this.lblCheckmaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckmaGV.Location = new System.Drawing.Point(5, 41);
            this.lblCheckmaGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckmaGV.Name = "lblCheckmaGV";
            this.lblCheckmaGV.Size = new System.Drawing.Size(35, 13);
            this.lblCheckmaGV.TabIndex = 11;
            this.lblCheckmaGV.Text = "label1";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(0, 214);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbDiaChi.TabIndex = 8;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // btnThemvaodanhsach
            // 
            this.btnThemvaodanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemvaodanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemvaodanhsach.Image = global::QLHS.Properties.Resources.add;
            this.btnThemvaodanhsach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemvaodanhsach.Location = new System.Drawing.Point(0, 271);
            this.btnThemvaodanhsach.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemvaodanhsach.Name = "btnThemvaodanhsach";
            this.btnThemvaodanhsach.Size = new System.Drawing.Size(166, 35);
            this.btnThemvaodanhsach.TabIndex = 10;
            this.btnThemvaodanhsach.Text = "Thêm";
            this.btnThemvaodanhsach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemvaodanhsach.UseVisualStyleBackColor = true;
            this.btnThemvaodanhsach.Click += new System.EventHandler(this.btnThemvaodanhsach_Click);
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(0, 158);
            this.lblDienthoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(55, 13);
            this.lblDienthoai.TabIndex = 6;
            this.lblDienthoai.Text = "Điện thoại";
            // 
            // lblMamonhoc
            // 
            this.lblMamonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMamonhoc.AutoSize = true;
            this.lblMamonhoc.Location = new System.Drawing.Point(0, 113);
            this.lblMamonhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMamonhoc.Name = "lblMamonhoc";
            this.lblMamonhoc.Size = new System.Drawing.Size(49, 13);
            this.lblMamonhoc.TabIndex = 4;
            this.lblMamonhoc.Text = "Môn học";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDiaChi.Location = new System.Drawing.Point(0, 230);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(137, 20);
            this.txbDiaChi.TabIndex = 9;
            this.txbDiaChi.TextChanged += new System.EventHandler(this.txbDiaChi_TextChanged);
            this.txbDiaChi.Enter += new System.EventHandler(this.txbDiaChi_Enter);
            this.txbDiaChi.Leave += new System.EventHandler(this.txbDiaChi_Leave);
            // 
            // cmbMamonhoc
            // 
            this.cmbMamonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMamonhoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMamonhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMamonhoc.FormattingEnabled = true;
            this.cmbMamonhoc.Location = new System.Drawing.Point(0, 129);
            this.cmbMamonhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMamonhoc.Name = "cmbMamonhoc";
            this.cmbMamonhoc.Size = new System.Drawing.Size(137, 21);
            this.cmbMamonhoc.TabIndex = 5;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienthoai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDienthoai.Location = new System.Drawing.Point(0, 175);
            this.txtDienthoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(137, 20);
            this.txtDienthoai.TabIndex = 7;
            this.txtDienthoai.TextChanged += new System.EventHandler(this.txtDienthoai_TextChanged);
            this.txtDienthoai.Enter += new System.EventHandler(this.txtDienthoai_Enter);
            this.txtDienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienthoai_KeyPress_1);
            this.txtDienthoai.Leave += new System.EventHandler(this.txtDienthoai_Leave);
            // 
            // txtTengiaovien
            // 
            this.txtTengiaovien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTengiaovien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTengiaovien.Location = new System.Drawing.Point(0, 77);
            this.txtTengiaovien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTengiaovien.Name = "txtTengiaovien";
            this.txtTengiaovien.Size = new System.Drawing.Size(137, 20);
            this.txtTengiaovien.TabIndex = 3;
            this.txtTengiaovien.Enter += new System.EventHandler(this.txtTengiaovien_Enter);
            this.txtTengiaovien.Leave += new System.EventHandler(this.txtTengiaovien_Leave);
            // 
            // txtMagiaovien
            // 
            this.txtMagiaovien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMagiaovien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMagiaovien.Location = new System.Drawing.Point(0, 20);
            this.txtMagiaovien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMagiaovien.Name = "txtMagiaovien";
            this.txtMagiaovien.Size = new System.Drawing.Size(137, 20);
            this.txtMagiaovien.TabIndex = 1;
            this.txtMagiaovien.TextChanged += new System.EventHandler(this.txtMagiaovien_TextChanged);
            this.txtMagiaovien.Enter += new System.EventHandler(this.txtMagiaovien_Enter);
            this.txtMagiaovien.Leave += new System.EventHandler(this.txtMagiaovien_Leave);
            // 
            // lblTengiaovien
            // 
            this.lblTengiaovien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTengiaovien.AutoSize = true;
            this.lblTengiaovien.Location = new System.Drawing.Point(0, 61);
            this.lblTengiaovien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTengiaovien.Name = "lblTengiaovien";
            this.lblTengiaovien.Size = new System.Drawing.Size(72, 13);
            this.lblTengiaovien.TabIndex = 2;
            this.lblTengiaovien.Text = "Tên giáo viên";
            // 
            // lblMagiaovien
            // 
            this.lblMagiaovien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMagiaovien.AutoSize = true;
            this.lblMagiaovien.Location = new System.Drawing.Point(0, 3);
            this.lblMagiaovien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagiaovien.Name = "lblMagiaovien";
            this.lblMagiaovien.Size = new System.Drawing.Size(68, 13);
            this.lblMagiaovien.TabIndex = 0;
            this.lblMagiaovien.Text = "Mã giáo viên";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotengiaovien);
            this.navigationPage2.Controls.Add(this.radTimtheomagiaovien);
            this.navigationPage2.Controls.Add(this.lblNhapthongtincantimkiem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(165, 309);
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapthongtincantimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtNhapthongtincantimkiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(0, 37);
            this.txtNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(166, 20);
            this.txtNhapthongtincantimkiem.TabIndex = 0;
            this.txtNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            this.txtNhapthongtincantimkiem.Enter += new System.EventHandler(this.txtNhapthongtincantimkiem_Enter);
            this.txtNhapthongtincantimkiem.Leave += new System.EventHandler(this.txtNhapthongtincantimkiem_Leave);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = global::QLHS.Properties.Resources.tracuugiaovien;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(0, 201);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(165, 43);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radTimtheotengiaovien
            // 
            this.radTimtheotengiaovien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTimtheotengiaovien.AutoSize = true;
            this.radTimtheotengiaovien.Location = new System.Drawing.Point(4, 128);
            this.radTimtheotengiaovien.Margin = new System.Windows.Forms.Padding(2);
            this.radTimtheotengiaovien.Name = "radTimtheotengiaovien";
            this.radTimtheotengiaovien.Size = new System.Drawing.Size(130, 17);
            this.radTimtheotengiaovien.TabIndex = 2;
            this.radTimtheotengiaovien.TabStop = true;
            this.radTimtheotengiaovien.Text = "Tìm theo tên giáo viên";
            this.radTimtheotengiaovien.UseVisualStyleBackColor = true;
            // 
            // radTimtheomagiaovien
            // 
            this.radTimtheomagiaovien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTimtheomagiaovien.AutoSize = true;
            this.radTimtheomagiaovien.Location = new System.Drawing.Point(4, 90);
            this.radTimtheomagiaovien.Margin = new System.Windows.Forms.Padding(2);
            this.radTimtheomagiaovien.Name = "radTimtheomagiaovien";
            this.radTimtheomagiaovien.Size = new System.Drawing.Size(129, 17);
            this.radTimtheomagiaovien.TabIndex = 1;
            this.radTimtheomagiaovien.TabStop = true;
            this.radTimtheomagiaovien.Text = "Tìm theo mã giáo viên";
            this.radTimtheomagiaovien.UseVisualStyleBackColor = true;
            // 
            // lblNhapthongtincantimkiem
            // 
            this.lblNhapthongtincantimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhapthongtincantimkiem.AutoSize = true;
            this.lblNhapthongtincantimkiem.Location = new System.Drawing.Point(2, 7);
            this.lblNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapthongtincantimkiem.Name = "lblNhapthongtincantimkiem";
            this.lblNhapthongtincantimkiem.Size = new System.Drawing.Size(139, 13);
            this.lblNhapthongtincantimkiem.TabIndex = 0;
            this.lblNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVGiaovien);
            this.groupBox1.Controls.Add(this.bindingNavigatorGiaoVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(261, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(419, 366);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // dGVGiaovien
            // 
            this.dGVGiaovien.AllowUserToAddRows = false;
            this.dGVGiaovien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVGiaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGiaovien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMagiaovien,
            this.colTengiaovien,
            this.colTenmonhoc,
            this.colDienthoai,
            this.colDiachi});
            this.dGVGiaovien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVGiaovien.Location = new System.Drawing.Point(2, 42);
            this.dGVGiaovien.Margin = new System.Windows.Forms.Padding(2);
            this.dGVGiaovien.Name = "dGVGiaovien";
            this.dGVGiaovien.RowTemplate.Height = 24;
            this.dGVGiaovien.Size = new System.Drawing.Size(415, 322);
            this.dGVGiaovien.TabIndex = 1;
            // 
            // colMagiaovien
            // 
            this.colMagiaovien.DataPropertyName = "MaGV";
            this.colMagiaovien.HeaderText = "Mã giáo viên";
            this.colMagiaovien.Name = "colMagiaovien";
            this.colMagiaovien.ReadOnly = true;
            // 
            // colTengiaovien
            // 
            this.colTengiaovien.DataPropertyName = "TenGV";
            this.colTengiaovien.HeaderText = "Tên giáo viên";
            this.colTengiaovien.Name = "colTengiaovien";
            // 
            // colTenmonhoc
            // 
            this.colTenmonhoc.DataPropertyName = "TenMon";
            this.colTenmonhoc.HeaderText = "Tên môn học";
            this.colTenmonhoc.Name = "colTenmonhoc";
            // 
            // colDienthoai
            // 
            this.colDienthoai.DataPropertyName = "SDT";
            this.colDienthoai.HeaderText = "Điện thoại";
            this.colDienthoai.Name = "colDienthoai";
            // 
            // colDiachi
            // 
            this.colDiachi.DataPropertyName = "DiaChi";
            this.colDiachi.HeaderText = "Địa Chỉ";
            this.colDiachi.Name = "colDiachi";
            // 
            // bindingNavigatorGiaoVien
            // 
            this.bindingNavigatorGiaoVien.AddNewItem = null;
            this.bindingNavigatorGiaoVien.CountItem = null;
            this.bindingNavigatorGiaoVien.DeleteItem = null;
            this.bindingNavigatorGiaoVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorGiaoVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator4,
            this.btnSave,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.btnExite});
            this.bindingNavigatorGiaoVien.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigatorGiaoVien.MoveFirstItem = null;
            this.bindingNavigatorGiaoVien.MoveLastItem = null;
            this.bindingNavigatorGiaoVien.MoveNextItem = null;
            this.bindingNavigatorGiaoVien.MovePreviousItem = null;
            this.bindingNavigatorGiaoVien.Name = "bindingNavigatorGiaoVien";
            this.bindingNavigatorGiaoVien.PositionItem = null;
            this.bindingNavigatorGiaoVien.Size = new System.Drawing.Size(415, 27);
            this.bindingNavigatorGiaoVien.TabIndex = 0;
            this.bindingNavigatorGiaoVien.Text = "bindingNavigator1";
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
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(24, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::QLHS.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.Text = "toolStripButton1";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // btnExite
            // 
            this.btnExite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExite.Image = global::QLHS.Properties.Resources.exit1;
            this.btnExite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(24, 24);
            this.btnExite.Text = "toolStripButton1";
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(261, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(419, 22);
            this.statusStrip1.TabIndex = 4;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPaneAddGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGiaovien";
            this.Text = "Giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneAddGV)).EndInit();
            this.navigationPaneAddGV.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMGVOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMGVFalse)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiaovien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGiaoVien)).EndInit();
            this.bindingNavigatorGiaoVien.ResumeLayout(false);
            this.bindingNavigatorGiaoVien.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPaneAddGV;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Button btnThemvaodanhsach;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblMamonhoc;
        private System.Windows.Forms.TextBox txtTengiaovien;
        private System.Windows.Forms.TextBox txtMagiaovien;
        private System.Windows.Forms.ComboBox cmbMamonhoc;
        private System.Windows.Forms.Label lblTengiaovien;
        private System.Windows.Forms.Label lblMagiaovien;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.TextBox txtNhapthongtincantimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton radTimtheotengiaovien;
        private System.Windows.Forms.RadioButton radTimtheomagiaovien;
        private System.Windows.Forms.Label lblNhapthongtincantimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVGiaovien;
        private System.Windows.Forms.BindingNavigator bindingNavigatorGiaoVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnExite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMagiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTengiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.Label lblCheckmaGV;
        private System.Windows.Forms.PictureBox picMGVOk;
        private System.Windows.Forms.PictureBox picMGVFalse;
        private System.Windows.Forms.Label lblCheckSDT;
        private System.Windows.Forms.PictureBox picOk;
        private System.Windows.Forms.PictureBox picFalse;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblCheckTenGV;
        private System.Windows.Forms.Label lblCheckDC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}