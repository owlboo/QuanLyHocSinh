namespace QLHS
{
    partial class frmMonhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonhoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVMonhoc = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorMonHoc = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.colMamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMonHoc)).BeginInit();
            this.bindingNavigatorMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVMonhoc);
            this.groupBox1.Controls.Add(this.bindingNavigatorMonHoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(600, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            // 
            // dGVMonhoc
            // 
            this.dGVMonhoc.AllowUserToAddRows = false;
            this.dGVMonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMamonhoc,
            this.colTenmonhoc,
            this.colHeso});
            this.dGVMonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVMonhoc.Location = new System.Drawing.Point(2, 42);
            this.dGVMonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVMonhoc.Name = "dGVMonhoc";
            this.dGVMonhoc.RowTemplate.Height = 24;
            this.dGVMonhoc.Size = new System.Drawing.Size(596, 322);
            this.dGVMonhoc.TabIndex = 1;
            // 
            // bindingNavigatorMonHoc
            // 
            this.bindingNavigatorMonHoc.AddNewItem = this.btnAdd;
            this.bindingNavigatorMonHoc.CountItem = null;
            this.bindingNavigatorMonHoc.DeleteItem = null;
            this.bindingNavigatorMonHoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.btnAdd,
            this.toolStripSeparator3,
            this.bindingNavigatorSeparator2,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.btnExit});
            this.bindingNavigatorMonHoc.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigatorMonHoc.MoveFirstItem = null;
            this.bindingNavigatorMonHoc.MoveLastItem = null;
            this.bindingNavigatorMonHoc.MoveNextItem = null;
            this.bindingNavigatorMonHoc.MovePreviousItem = null;
            this.bindingNavigatorMonHoc.Name = "bindingNavigatorMonHoc";
            this.bindingNavigatorMonHoc.PositionItem = null;
            this.bindingNavigatorMonHoc.Size = new System.Drawing.Size(596, 27);
            this.bindingNavigatorMonHoc.TabIndex = 0;
            this.bindingNavigatorMonHoc.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(78, 24);
            this.btnAdd.Text = "Add new";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // colMamonhoc
            // 
            this.colMamonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMamonhoc.DataPropertyName = "MaMH";
            this.colMamonhoc.HeaderText = "Mã môn học";
            this.colMamonhoc.Name = "colMamonhoc";
            this.colMamonhoc.Width = 91;
            // 
            // colTenmonhoc
            // 
            this.colTenmonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenmonhoc.DataPropertyName = "TenMon";
            this.colTenmonhoc.HeaderText = "Tên môn học";
            this.colTenmonhoc.Name = "colTenmonhoc";
            // 
            // colHeso
            // 
            this.colHeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colHeso.DataPropertyName = "HeSoMon";
            this.colHeso.HeaderText = "Hệ số";
            this.colHeso.Name = "colHeso";
            this.colHeso.Width = 60;
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMonhoc";
            this.Text = "Môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMonHoc)).EndInit();
            this.bindingNavigatorMonHoc.ResumeLayout(false);
            this.bindingNavigatorMonHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorMonHoc;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dGVMonhoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeso;
    }
}