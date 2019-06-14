using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmNhapdiemrieng : Form
    {
        #region Constructor
        BindingSource bs = new BindingSource();
        #endregion
        public frmNhapdiemrieng()
        {
            InitializeComponent();
            dGVNhapdiemrieng.DataSource = bs;
        }
        #region Func
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVNhapdiemrieng.CurrentRow == null) return true;
                dGVNhapdiemrieng.CurrentCell = dGVNhapdiemrieng.CurrentRow.Cells["colMahocsinh"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void LoadIncbNamHocClass(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NamHoc");
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";

        }
        public void LoadIncbHocKiClass(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HocKi");
            cb.DisplayMember = "TenHocKi";
            cb.ValueMember = "MaHocKi";

        }
        public void LoadIncbClass(string namhoc, ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE NamHoc = N'" + namhoc + "'");
            cb.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
        }
        public void LoadIncbMonHoc(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM MonHoc");
            cb.DisplayMember = "TenMon";
            cb.ValueMember = "MaMH";
        }
        public void LoadIncbHocSinh(string malop, ComboBox cb)
        {
            string query = "SELECT HocSinh.MaHS,HoTen FROM dbo.HocSinh,dbo.XepLop WHERE dbo.XepLop.MaHS=dbo.HocSinh.MaHS AND MaLop= N'" + malop + "'";
            cb.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cb.DisplayMember = "HoTen";
            cb.ValueMember = "MaHS";
        }
        public void LoadIncbLoaiDiem(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM CotDiem");
            cb.DisplayMember = "TenCotDiem";
            cb.ValueMember = "MaCotDiem";
        }
        public void LoadDiem()
        {
            bs.DataSource = DiemDAO.Instance.LoadSTInBangDiem(cmbLop.SelectedValue.ToString());
        }
        #endregion

        #region Event
        private void frmNhapdiemrieng_Load(object sender, EventArgs e)
        {
            LoadIncbNamHocClass(cmbNamhoc);
            LoadIncbHocKiClass(cmbHocky);
            LoadIncbLoaiDiem(cmbLoaidiem);
            LoadIncbMonHoc(cmbMonhoc);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbNamhoc.SelectedValue != null &&
               cmbHocky.SelectedValue != null &&
               cmbLop.SelectedValue != null &&
               cmbHocsinh.SelectedValue != null &&
                cmbLoaidiem.SelectedValue != null &&
                cmbMonhoc.SelectedValue != null)
            {
                DiemDAO.Instance.LuuDiem(cmbHocsinh.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(),
                                         cmbLoaidiem.SelectedValue.ToString(), (float)Convert.ToDouble(txtDiem.Text), Int32.Parse(cmbHocky.SelectedValue.ToString()),
                                         cmbNamhoc.SelectedValue.ToString(), cmbMonhoc.SelectedValue.ToString());
                dGVNhapdiemrieng.DataSource = DiemDAO.Instance.LoadSTInBangDiem(cmbLop.SelectedValue.ToString());
                //MessageBox.Show("It's OK", "Notice");
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = 110;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Step = 10;
                timer1.Start();
            }
            else MessageBox.Show("Thông tin trống !!!", "Thông báo");
        }

        private void cmbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoc.SelectedValue != null)
            {
                cmbLop.DataSource = null;
                LoadIncbClass(cmbNamhoc.SelectedValue.ToString(), cmbLop);
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop.SelectedValue != null)
            {
                cmbHocsinh.DataSource = null;
                LoadIncbHocSinh(cmbLop.SelectedValue.ToString(), cmbHocsinh);
                LoadDiem();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVNhapdiemrieng.Rows.Count; i++)
            {
                string mahs = dGVNhapdiemrieng.Rows[i].Cells["colMahocsinh"].Value.ToString();
                float diem = (float)Convert.ToDouble(dGVNhapdiemrieng.Rows[i].Cells["colDiem"].Value.ToString());
                if (DiemDAO.Instance.UpdateDiem(mahs, diem))
                {
                    //MessageBox.Show("Sửa điểm thành công", "Thông báo");
                    toolStripProgressBar1.Minimum = 0;
                    toolStripProgressBar1.Maximum = 110;
                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Step = 10;
                    timer1.Start();
                }
            }
            LoadDiem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVNhapdiemrieng.Rows.Count; i++)
            {
                string mahs = dGVNhapdiemrieng.Rows[i].Cells["colMahocsinh"].Value.ToString();
                string tencotdiem = dGVNhapdiemrieng.Rows[i].Cells["colLoaidiem"].Value.ToString();
                int id = int.Parse(dGVNhapdiemrieng.Rows[i].Cells["colID"].Value.ToString());
                if (dGVNhapdiemrieng.Rows[i].Cells["colMahocsinh"].Selected ||
                    dGVNhapdiemrieng.Rows[i].Cells["colTenhocsinh"].Selected ||
                    dGVNhapdiemrieng.Rows[i].Cells["colHocky"].Selected ||
                    dGVNhapdiemrieng.Rows[i].Cells["colLoaidiem"].Selected ||
                    dGVNhapdiemrieng.Rows[i].Cells["colNamhoc"].Selected ||
                    dGVNhapdiemrieng.Rows[i].Cells["colDiem"].Selected ||
                    dGVNhapdiemrieng.Rows[i].Selected ||
                    dGVNhapdiemrieng.Rows[i].Cells["colTenmon"].Selected||
                    dGVNhapdiemrieng.Rows[i].Cells["colID"].Selected)
                {
                    DiemDAO.Instance.XoaDIem(mahs, tencotdiem,id);

                }
            }
            //MessageBox.Show("Xóa điểm thành công", "Thông báo");
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 110;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Step = 10;
            timer1.Start();
            LoadDiem();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value > 0 && toolStripProgressBar1.Value < 100)
            {
                toolStripStatusLabel1.Text = "Saving.....";
            }
            else if (toolStripProgressBar1.Value == 100)
            {
                toolStripStatusLabel1.Text = "Saved!!!";
            }
        }
        #endregion




    }
}
