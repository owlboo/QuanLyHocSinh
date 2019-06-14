namespace QLHS
{
    partial class frmHanhkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHanhkiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVHanhkiem = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorHanhKiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnAđ = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.colMahanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHanhkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHanhKiem)).BeginInit();
            this.bindingNavigatorHanhKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVHanhkiem);
            this.groupBox1.Controls.Add(this.bindingNavigatorHanhKiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hạnh kiểm";
            // 
            // dGVHanhkiem
            // 
            this.dGVHanhkiem.AllowUserToAddRows = false;
            this.dGVHanhkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVHanhkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHanhkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahanhkiem,
            this.colTenhanhkiem});
            this.dGVHanhkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHanhkiem.Location = new System.Drawing.Point(3, 45);
            this.dGVHanhkiem.Name = "dGVHanhkiem";
            this.dGVHanhkiem.RowTemplate.Height = 24;
            this.dGVHanhkiem.Size = new System.Drawing.Size(794, 402);
            this.dGVHanhkiem.TabIndex = 3;
            // 
            // bindingNavigatorHanhKiem
            // 
            this.bindingNavigatorHanhKiem.AddNewItem = this.btnAđ;
            this.bindingNavigatorHanhKiem.CountItem = null;
            this.bindingNavigatorHanhKiem.DeleteItem = null;
            this.bindingNavigatorHanhKiem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorHanhKiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.btnAđ,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorSeparator1,
            this.btnDelete,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnExit});
            this.bindingNavigatorHanhKiem.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigatorHanhKiem.MoveFirstItem = null;
            this.bindingNavigatorHanhKiem.MoveLastItem = null;
            this.bindingNavigatorHanhKiem.MoveNextItem = null;
            this.bindingNavigatorHanhKiem.MovePreviousItem = null;
            this.bindingNavigatorHanhKiem.Name = "bindingNavigatorHanhKiem";
            this.bindingNavigatorHanhKiem.PositionItem = null;
            this.bindingNavigatorHanhKiem.Size = new System.Drawing.Size(794, 27);
            this.bindingNavigatorHanhKiem.TabIndex = 2;
            this.bindingNavigatorHanhKiem.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAđ
            // 
            this.btnAđ.Image = ((System.Drawing.Image)(resources.GetObject("btnAđ.Image")));
            this.btnAđ.Name = "btnAđ";
            this.btnAđ.RightToLeftAutoMirrorImage = true;
            this.btnAđ.Size = new System.Drawing.Size(92, 24);
            this.btnAđ.Text = "Add new";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(77, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLHS.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 24);
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
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // colMahanhkiem
            // 
            this.colMahanhkiem.DataPropertyName = "MaHK";
            this.colMahanhkiem.HeaderText = "Mã hạnh kiểm";
            this.colMahanhkiem.Name = "colMahanhkiem";
            // 
            // colTenhanhkiem
            // 
            this.colTenhanhkiem.DataPropertyName = "LoaiHK";
            this.colTenhanhkiem.HeaderText = "Tên hạnh kiểm";
            this.colTenhanhkiem.Name = "colTenhanhkiem";
            // 
            // frmHanhkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHanhkiem";
            this.Text = "Hanhkiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHanhkiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHanhkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHanhKiem)).EndInit();
            this.bindingNavigatorHanhKiem.ResumeLayout(false);
            this.bindingNavigatorHanhKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHanhKiem;
        private System.Windows.Forms.ToolStripButton btnAđ;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView dGVHanhkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahanhkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhanhkiem;
    }
}