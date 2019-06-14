namespace QLHS
{
    partial class frmKetqua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetqua));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVKetqua = new System.Windows.Forms.DataGridView();
            this.colMaketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorKetQua = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetQua)).BeginInit();
            this.bindingNavigatorKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVKetqua);
            this.groupBox1.Controls.Add(this.bindingNavigatorKetQua);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(600, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách kết quả";
            // 
            // dGVKetqua
            // 
            this.dGVKetqua.AllowUserToAddRows = false;
            this.dGVKetqua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKetqua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaketqua,
            this.colTenketqua});
            this.dGVKetqua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVKetqua.Location = new System.Drawing.Point(2, 42);
            this.dGVKetqua.Margin = new System.Windows.Forms.Padding(2);
            this.dGVKetqua.Name = "dGVKetqua";
            this.dGVKetqua.RowTemplate.Height = 24;
            this.dGVKetqua.Size = new System.Drawing.Size(596, 322);
            this.dGVKetqua.TabIndex = 1;
            // 
            // colMaketqua
            // 
            this.colMaketqua.DataPropertyName = "MaKQ";
            this.colMaketqua.HeaderText = "Mã kết quả";
            this.colMaketqua.Name = "colMaketqua";
            // 
            // colTenketqua
            // 
            this.colTenketqua.DataPropertyName = "TenKQ";
            this.colTenketqua.HeaderText = "Tên kết quả";
            this.colTenketqua.Name = "colTenketqua";
            // 
            // bindingNavigatorKetQua
            // 
            this.bindingNavigatorKetQua.AddNewItem = this.btnAdd;
            this.bindingNavigatorKetQua.CountItem = null;
            this.bindingNavigatorKetQua.DeleteItem = null;
            this.bindingNavigatorKetQua.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorKetQua.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.btnAdd,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator3,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.btnExit});
            this.bindingNavigatorKetQua.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigatorKetQua.MoveFirstItem = null;
            this.bindingNavigatorKetQua.MoveLastItem = null;
            this.bindingNavigatorKetQua.MoveNextItem = null;
            this.bindingNavigatorKetQua.MovePreviousItem = null;
            this.bindingNavigatorKetQua.Name = "bindingNavigatorKetQua";
            this.bindingNavigatorKetQua.PositionItem = null;
            this.bindingNavigatorKetQua.Size = new System.Drawing.Size(596, 27);
            this.bindingNavigatorKetQua.TabIndex = 0;
            this.bindingNavigatorKetQua.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
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
            // frmKetqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKetqua";
            this.Text = "Kết quả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKetqua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetQua)).EndInit();
            this.bindingNavigatorKetQua.ResumeLayout(false);
            this.bindingNavigatorKetQua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKetQua;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dGVKetqua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaketqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenketqua;
    }
}