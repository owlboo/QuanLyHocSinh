namespace QLHS.GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetquacanamtheolop));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lblMonhoc = new System.Windows.Forms.Label();
            this.cmbNamhoc = new System.Windows.Forms.ComboBox();
            this.lblNamhoc = new System.Windows.Forms.Label();
            this.lblNhapthongtin = new System.Windows.Forms.Label();
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
            this.dGVKetquacanamtheolop = new System.Windows.Forms.DataGridView();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemtrungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquacanamtheolop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.cmbLop);
            this.panelControl1.Controls.Add(this.lblMonhoc);
            this.panelControl1.Controls.Add(this.cmbNamhoc);
            this.panelControl1.Controls.Add(this.lblNamhoc);
            this.panelControl1.Controls.Add(this.lblNhapthongtin);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(150, 366);
            this.panelControl1.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Image = global::QLHS.Properties.Resources.xemdiem;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXem.Location = new System.Drawing.Point(0, 250);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(148, 32);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(0, 167);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(149, 21);
            this.cmbLop.TabIndex = 4;
            // 
            // lblMonhoc
            // 
            this.lblMonhoc.AutoSize = true;
            this.lblMonhoc.Location = new System.Drawing.Point(0, 150);
            this.lblMonhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonhoc.Name = "lblMonhoc";
            this.lblMonhoc.Size = new System.Drawing.Size(24, 13);
            this.lblMonhoc.TabIndex = 3;
            this.lblMonhoc.Text = "Lớp";
            // 
            // cmbNamhoc
            // 
            this.cmbNamhoc.FormattingEnabled = true;
            this.cmbNamhoc.Location = new System.Drawing.Point(0, 93);
            this.cmbNamhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNamhoc.Name = "cmbNamhoc";
            this.cmbNamhoc.Size = new System.Drawing.Size(149, 21);
            this.cmbNamhoc.TabIndex = 2;
            // 
            // lblNamhoc
            // 
            this.lblNamhoc.AutoSize = true;
            this.lblNamhoc.Location = new System.Drawing.Point(0, 76);
            this.lblNamhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamhoc.Name = "lblNamhoc";
            this.lblNamhoc.Size = new System.Drawing.Size(48, 13);
            this.lblNamhoc.TabIndex = 1;
            this.lblNamhoc.Text = "Năm học";
            // 
            // lblNhapthongtin
            // 
            this.lblNhapthongtin.AutoSize = true;
            this.lblNhapthongtin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNhapthongtin.Location = new System.Drawing.Point(4, 2);
            this.lblNhapthongtin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapthongtin.Name = "lblNhapthongtin";
            this.lblNhapthongtin.Size = new System.Drawing.Size(155, 19);
            this.lblNhapthongtin.TabIndex = 0;
            this.lblNhapthongtin.Text = "NHẬP THÔNG TIN";
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
            this.bindingNavigator1.Location = new System.Drawing.Point(150, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(450, 27);
            this.bindingNavigator1.TabIndex = 3;
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
            this.btnPrinter.Text = "Print";
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // dGVKetquacanamtheolop
            // 
            this.dGVKetquacanamtheolop.AllowUserToAddRows = false;
            this.dGVKetquacanamtheolop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVKetquacanamtheolop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKetquacanamtheolop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colLop,
            this.colDiemtrungbinh,
            this.colKetqua});
            this.dGVKetquacanamtheolop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVKetquacanamtheolop.Location = new System.Drawing.Point(150, 27);
            this.dGVKetquacanamtheolop.Margin = new System.Windows.Forms.Padding(2);
            this.dGVKetquacanamtheolop.Name = "dGVKetquacanamtheolop";
            this.dGVKetquacanamtheolop.RowTemplate.Height = 24;
            this.dGVKetquacanamtheolop.Size = new System.Drawing.Size(450, 339);
            this.dGVKetquacanamtheolop.TabIndex = 4;
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
            // colLop
            // 
            this.colLop.DataPropertyName = "TenLop";
            this.colLop.HeaderText = "Lớp";
            this.colLop.Name = "colLop";
            // 
            // colDiemtrungbinh
            // 
            this.colDiemtrungbinh.DataPropertyName = "DiemTBNam";
            this.colDiemtrungbinh.HeaderText = "Điểm TB cả năm";
            this.colDiemtrungbinh.Name = "colDiemtrungbinh";
            // 
            // colKetqua
            // 
            this.colKetqua.DataPropertyName = "TenKQ";
            this.colKetqua.HeaderText = "Kết quả";
            this.colKetqua.Name = "colKetqua";
            // 
            // frmKetquacanamtheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dGVKetquacanamtheolop);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKetquacanamtheolop";
            this.Load += new System.EventHandler(this.frmKetquacanamtheolop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquacanamtheolop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lblMonhoc;
        private System.Windows.Forms.ComboBox cmbNamhoc;
        private System.Windows.Forms.Label lblNamhoc;
        private System.Windows.Forms.Label lblNhapthongtin;
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
        private System.Windows.Forms.ToolStripButton btnPrinter;
        private System.Windows.Forms.DataGridView dGVKetquacanamtheolop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemtrungbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetqua;
    }
}