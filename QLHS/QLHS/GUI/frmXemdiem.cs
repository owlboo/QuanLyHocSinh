
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
    public partial class frmXemdiem : Form
    {
        #region Constructor
        BindingSource bs = new BindingSource();
        #endregion
        public frmXemdiem()
        {
            InitializeComponent();
            dGVXemdiem.DataSource = bs;
        }
        #region Func
        public void LoadHS(string malop,string mamon,int hocki)
        {
            string query = "SELECT bd.MaHS,h.HoTen,m.TenMon,cd.TenCotDiem,bd.Diem FROM BangDiem bd,CTBD c,HocSinh h,MonHoc m,CotDiem cd"
                            +" WHERE bd.ID=c.IDBangDiem"
                            +" AND h.MaHS=bd.MaHS"
                            +" AND m.MaMH=c.MaMH"
                            +" AND cd.MaCotDiem=bd.MaCotDiem"
                            +" AND bd.MaLop = '"+malop+"'"
                            +" AND m.MaMH= '"+mamon+"'"
                            +" AND bd.HocKi = "+hocki;
            bs.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void LoadHS(string malop, string mamon,int hocki,string mahs)
        {
            string query = "SELECT bd.MaHS,h.HoTen,m.TenMon,cd.TenCotDiem,bd.Diem FROM BangDiem bd,CTBD c,HocSinh h,MonHoc m,CotDiem cd"
                            + " WHERE bd.ID=c.IDBangDiem"
                            + " AND h.MaHS=bd.MaHS"
                            + " AND m.MaMH=c.MaMH"
                            + " AND cd.MaCotDiem=bd.MaCotDiem"
                            + " AND bd.MaLop = '" + malop + "'"
                            + " AND m.MaMH= '" + mamon + "'"
                            +" AND h.MaHS= '"+mahs+"'"
                            + " AND bd.HocKi = " + hocki;
            bs.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVXemdiem.CurrentRow == null) return true;
                dGVXemdiem.CurrentCell = dGVXemdiem.CurrentRow.Cells["colMahocsinh"];
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
        public void LoadIncbHocSinh(string malop,ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocSinh,XepLop WHERE XepLop.MaHS=HocSinh.MaHS AND MaLop = '"+malop+"'");
            cb.DisplayMember = "HoTen";
            cb.ValueMember = "MaHS";
        }
        #endregion

        #region Event
        private void cmbNamhoc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoc1.SelectedValue != null)
            {
                cmbLop1.DataSource = null;
                LoadIncbClass(cmbNamhoc1.SelectedValue.ToString(), cmbLop1);

            }
        }
        private void cmbNamhoc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoc2.SelectedValue != null)
            {
                cmbLop2.DataSource = null;
                LoadIncbClass(cmbNamhoc2.SelectedValue.ToString(), cmbLop2);

            }
        }
        private void frmXemdiem_Load(object sender, EventArgs e)
        {
            LoadIncbNamHocClass(cmbNamhoc1);
            LoadIncbNamHocClass(cmbNamhoc2);
            LoadIncbHocKiClass(cmbHocky1);
            LoadIncbHocKiClass(cmbHocky2);
        }

        private void cmbLop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop1.SelectedValue != null)
                LoadIncbMonHoc(cmbMonhoc1);
        }

        private void cmbLop2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop2.SelectedValue != null)
            {
                LoadIncbMonHoc(cmbMonhoc2);
                LoadIncbHocSinh(cmbLop2.SelectedValue.ToString(), cmbHocsinh2);
            }
        }
        private void btnXemdiem1_Click(object sender, EventArgs e)
        {
            int hocki = Int32.Parse(cmbHocky1.SelectedValue.ToString());
            LoadHS(cmbLop1.SelectedValue.ToString(), cmbMonhoc1.SelectedValue.ToString(), hocki);
        }

        private void btnXemdiem2_Click(object sender, EventArgs e)
        {
            int hocki = Int32.Parse(cmbHocky2.SelectedValue.ToString());
            LoadHS(cmbLop2.SelectedValue.ToString(), cmbMonhoc2.SelectedValue.ToString(), hocki, cmbHocsinh2.SelectedValue.ToString());
        }

        private void navigationPage1_Click(object sender, EventArgs e)
        {
            int hocki = Int32.Parse(cmbHocky1.SelectedValue.ToString());
            LoadHS(cmbLop1.SelectedValue.ToString(), cmbMonhoc1.SelectedValue.ToString(), hocki);
        }
        #endregion


    }
}
