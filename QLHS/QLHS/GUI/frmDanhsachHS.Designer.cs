namespace QLHS.GUI
{
    partial class frmDanhsachHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhsachHS));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnHienthi1 = new System.Windows.Forms.Button();
            this.cmbNamhoc1 = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnHienthi2 = new System.Windows.Forms.Button();
            this.cmbNamhoc2 = new System.Windows.Forms.ComboBox();
            this.cmbKhoilop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrinter = new System.Windows.Forms.ToolStripButton();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.colMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(236, 366);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(236, 366);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            this.navigationPane1.Click += new System.EventHandler(this.navigationPane1_Click);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Danh sách lớp";
            this.navigationPage1.Controls.Add(this.btnHienthi1);
            this.navigationPage1.Controls.Add(this.cmbNamhoc1);
            this.navigationPage1.Controls.Add(this.cmbLop);
            this.navigationPage1.Controls.Add(this.label2);
            this.navigationPage1.Controls.Add(this.label1);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(125, 306);
            this.navigationPage1.Click += new System.EventHandler(this.navigationPage1_Click);
            // 
            // btnHienthi1
            // 
            this.btnHienthi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHienthi1.Image = global::QLHS.Properties.Resources.kqcnamtheomon;
            this.btnHienthi1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHienthi1.Location = new System.Drawing.Point(4, 185);
            this.btnHienthi1.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienthi1.Name = "btnHienthi1";
            this.btnHienthi1.Size = new System.Drawing.Size(118, 32);
            this.btnHienthi1.TabIndex = 2;
            this.btnHienthi1.Text = "Hiển thị";
            this.btnHienthi1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHienthi1.UseVisualStyleBackColor = true;
            this.btnHienthi1.Click += new System.EventHandler(this.btnHienthi1_Click_1);
            // 
            // cmbNamhoc1
            // 
            this.cmbNamhoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNamhoc1.FormattingEnabled = true;
            this.cmbNamhoc1.Location = new System.Drawing.Point(4, 105);
            this.cmbNamhoc1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNamhoc1.Name = "cmbNamhoc1";
            this.cmbNamhoc1.Size = new System.Drawing.Size(119, 21);
            this.cmbNamhoc1.TabIndex = 1;
            // 
            // cmbLop
            // 
            this.cmbLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(4, 42);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(119, 21);
            this.cmbLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Danh sách khối";
            this.navigationPage2.Controls.Add(this.btnHienthi2);
            this.navigationPage2.Controls.Add(this.cmbNamhoc2);
            this.navigationPage2.Controls.Add(this.cmbKhoilop);
            this.navigationPage2.Controls.Add(this.label3);
            this.navigationPage2.Controls.Add(this.label4);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(125, 306);
            this.navigationPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPage2_Paint);
            // 
            // btnHienthi2
            // 
            this.btnHienthi2.Image = global::QLHS.Properties.Resources.kqcnamtheomon;
            this.btnHienthi2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHienthi2.Location = new System.Drawing.Point(4, 137);
            this.btnHienthi2.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienthi2.Name = "btnHienthi2";
            this.btnHienthi2.Size = new System.Drawing.Size(110, 35);
            this.btnHienthi2.TabIndex = 6;
            this.btnHienthi2.Text = "Hiển thị";
            this.btnHienthi2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHienthi2.UseVisualStyleBackColor = true;
            this.btnHienthi2.Click += new System.EventHandler(this.btnHienthi2_Click_1);
            // 
            // cmbNamhoc2
            // 
            this.cmbNamhoc2.FormattingEnabled = true;
            this.cmbNamhoc2.Location = new System.Drawing.Point(4, 98);
            this.cmbNamhoc2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNamhoc2.Name = "cmbNamhoc2";
            this.cmbNamhoc2.Size = new System.Drawing.Size(111, 21);
            this.cmbNamhoc2.TabIndex = 4;
            // 
            // cmbKhoilop
            // 
            this.cmbKhoilop.FormattingEnabled = true;
            this.cmbKhoilop.Location = new System.Drawing.Point(4, 35);
            this.cmbKhoilop.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhoilop.Name = "cmbKhoilop";
            this.cmbKhoilop.Size = new System.Drawing.Size(111, 21);
            this.cmbKhoilop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khối lớp";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btnPrinter});
            this.bindingNavigator1.Location = new System.Drawing.Point(236, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(560, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnPrinter
            // 
            this.btnPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrinter.Image = global::QLHS.Properties.Resources.printer;
            this.btnPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(24, 24);
            this.btnPrinter.Text = "toolStripButton1";
            this.btnPrinter.ToolTipText = "Print";
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click_1);
            // 
            // dgvHS
            // 
            this.dgvHS.AllowUserToAddRows = false;
            this.dgvHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHS,
            this.colTenHS,
            this.colNgaysinh,
            this.colNoisinh,
            this.colDiachi,
            this.colLop,
            this.colNamhoc});
            this.dgvHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHS.Location = new System.Drawing.Point(236, 27);
            this.dgvHS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.RowTemplate.Height = 24;
            this.dgvHS.Size = new System.Drawing.Size(560, 339);
            this.dgvHS.TabIndex = 2;
            // 
            // colMaHS
            // 
            this.colMaHS.DataPropertyName = "MaHS";
            this.colMaHS.HeaderText = "Mã học sinh";
            this.colMaHS.Name = "colMaHS";
            // 
            // colTenHS
            // 
            this.colTenHS.DataPropertyName = "HoTen";
            this.colTenHS.HeaderText = "Tên học sinh";
            this.colTenHS.Name = "colTenHS";
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.DataPropertyName = "NgSinh";
            this.colNgaysinh.HeaderText = "Ngày sinh";
            this.colNgaysinh.Name = "colNgaysinh";
            // 
            // colNoisinh
            // 
            this.colNoisinh.DataPropertyName = "NoiSinh";
            this.colNoisinh.HeaderText = "Nơi sinh";
            this.colNoisinh.Name = "colNoisinh";
            // 
            // colDiachi
            // 
            this.colDiachi.DataPropertyName = "DiaChi";
            this.colDiachi.HeaderText = "Địa chỉ";
            this.colDiachi.Name = "colDiachi";
            // 
            // colLop
            // 
            this.colLop.DataPropertyName = "TenLop";
            this.colLop.HeaderText = "Lớp";
            this.colLop.Name = "colLop";
            // 
            // colNamhoc
            // 
            this.colNamhoc.DataPropertyName = "TenNamHoc";
            this.colNamhoc.HeaderText = "Năm học";
            this.colNamhoc.Name = "colNamhoc";
            // 
            // frmDanhsachHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 366);
            this.Controls.Add(this.dgvHS);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.navigationPane1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhsachHS";
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.frmDanhsachHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.Button btnHienthi1;
        private System.Windows.Forms.ComboBox cmbNamhoc1;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Button btnHienthi2;
        private System.Windows.Forms.ComboBox cmbNamhoc2;
        private System.Windows.Forms.ComboBox cmbKhoilop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvHS;
        private System.Windows.Forms.ToolStripButton btnPrinter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamhoc;
    }
}