namespace QLHS
{
    partial class frmHocluc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocluc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVHocluc = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorHocLuc = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.colMahocluc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocluc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemtoithieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemtoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocluc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).BeginInit();
            this.bindingNavigatorHocLuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVHocluc);
            this.groupBox1.Controls.Add(this.bindingNavigatorHocLuc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học lực";
            // 
            // dGVHocluc
            // 
            this.dGVHocluc.AllowUserToAddRows = false;
            this.dGVHocluc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVHocluc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHocluc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocluc,
            this.colTenhocluc,
            this.colDiemtoithieu,
            this.colDiemtoida});
            this.dGVHocluc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHocluc.Location = new System.Drawing.Point(3, 45);
            this.dGVHocluc.Name = "dGVHocluc";
            this.dGVHocluc.RowTemplate.Height = 24;
            this.dGVHocluc.Size = new System.Drawing.Size(794, 402);
            this.dGVHocluc.TabIndex = 1;
            // 
            // bindingNavigatorHocLuc
            // 
            this.bindingNavigatorHocLuc.AddNewItem = this.btnAdd;
            this.bindingNavigatorHocLuc.CountItem = null;
            this.bindingNavigatorHocLuc.DeleteItem = null;
            this.bindingNavigatorHocLuc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorHocLuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.btnAdd,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.btnExit});
            this.bindingNavigatorHocLuc.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigatorHocLuc.MoveFirstItem = null;
            this.bindingNavigatorHocLuc.MoveLastItem = null;
            this.bindingNavigatorHocLuc.MoveNextItem = null;
            this.bindingNavigatorHocLuc.MovePreviousItem = null;
            this.bindingNavigatorHocLuc.Name = "bindingNavigatorHocLuc";
            this.bindingNavigatorHocLuc.PositionItem = null;
            this.bindingNavigatorHocLuc.Size = new System.Drawing.Size(794, 27);
            this.bindingNavigatorHocLuc.TabIndex = 0;
            this.bindingNavigatorHocLuc.Text = "bindingNavigator1";
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
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(92, 24);
            this.btnAdd.Text = "Add new";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.btnSave.Size = new System.Drawing.Size(64, 24);
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
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.Text = "Exit";
            // 
            // colMahocluc
            // 
            this.colMahocluc.DataPropertyName = "MaHocLuc";
            this.colMahocluc.HeaderText = "Mã học lực";
            this.colMahocluc.Name = "colMahocluc";
            // 
            // colTenhocluc
            // 
            this.colTenhocluc.DataPropertyName = "TenHocLuc";
            this.colTenhocluc.HeaderText = "Tên học lực";
            this.colTenhocluc.Name = "colTenhocluc";
            // 
            // colDiemtoithieu
            // 
            this.colDiemtoithieu.DataPropertyName = "DiemToiThieu";
            this.colDiemtoithieu.HeaderText = "Điểm tối thiểu";
            this.colDiemtoithieu.Name = "colDiemtoithieu";
            // 
            // colDiemtoida
            // 
            this.colDiemtoida.DataPropertyName = "DiemToiDa";
            this.colDiemtoida.HeaderText = "Điểm tối đa";
            this.colDiemtoida.Name = "colDiemtoida";
            // 
            // frmHocluc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHocluc";
            this.Text = "Học lực";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocluc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocluc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).EndInit();
            this.bindingNavigatorHocLuc.ResumeLayout(false);
            this.bindingNavigatorHocLuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocLuc;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dGVHocluc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocluc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocluc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemtoithieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemtoida;
    }
}