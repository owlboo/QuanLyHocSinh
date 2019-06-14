namespace QLHS
{
    partial class frmHocky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocky));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVHocky = new System.Windows.Forms.DataGridView();
            this.colMahocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorHocKy = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocKy)).BeginInit();
            this.bindingNavigatorHocKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVHocky);
            this.groupBox1.Controls.Add(this.bindingNavigatorHocKy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học kỳ";
            // 
            // dGVHocky
            // 
            this.dGVHocky.AllowUserToAddRows = false;
            this.dGVHocky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVHocky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHocky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocky,
            this.colTenhocky,
            this.colHeso});
            this.dGVHocky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHocky.Location = new System.Drawing.Point(3, 45);
            this.dGVHocky.Name = "dGVHocky";
            this.dGVHocky.RowTemplate.Height = 24;
            this.dGVHocky.Size = new System.Drawing.Size(515, 273);
            this.dGVHocky.TabIndex = 1;
            // 
            // colMahocky
            // 
            this.colMahocky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMahocky.DataPropertyName = "MaHocKi";
            this.colMahocky.HeaderText = "Mã học kỳ";
            this.colMahocky.Name = "colMahocky";
            // 
            // colTenhocky
            // 
            this.colTenhocky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenhocky.DataPropertyName = "TenHocKi";
            this.colTenhocky.HeaderText = "Tên học kỳ";
            this.colTenhocky.Name = "colTenhocky";
            // 
            // colHeso
            // 
            this.colHeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHeso.DataPropertyName = "HeSo";
            this.colHeso.HeaderText = "Hệ số";
            this.colHeso.Name = "colHeso";
            // 
            // bindingNavigatorHocKy
            // 
            this.bindingNavigatorHocKy.AddNewItem = this.btnAdd;
            this.bindingNavigatorHocKy.CountItem = null;
            this.bindingNavigatorHocKy.DeleteItem = null;
            this.bindingNavigatorHocKy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorHocKy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.btnAdd,
            this.toolStripSeparator1,
            this.bindingNavigatorSeparator2,
            this.btnDelete,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.btnExit});
            this.bindingNavigatorHocKy.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigatorHocKy.MoveFirstItem = null;
            this.bindingNavigatorHocKy.MoveLastItem = null;
            this.bindingNavigatorHocKy.MoveNextItem = null;
            this.bindingNavigatorHocKy.MovePreviousItem = null;
            this.bindingNavigatorHocKy.Name = "bindingNavigatorHocKy";
            this.bindingNavigatorHocKy.PositionItem = null;
            this.bindingNavigatorHocKy.Size = new System.Drawing.Size(515, 27);
            this.bindingNavigatorHocKy.TabIndex = 0;
            this.bindingNavigatorHocKy.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(92, 24);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.btnDelete.Size = new System.Drawing.Size(77, 24);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHocky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 321);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHocky";
            this.Text = "Học kỳ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocky_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocKy)).EndInit();
            this.bindingNavigatorHocKy.ResumeLayout(false);
            this.bindingNavigatorHocKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocKy;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dGVHocky;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeso;
    }
}