using QLHS.DAO;
using QLHS.DTO;
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
    public partial class frmPhanlop : Form
    {
        #region Constructor
        BindingSource bs = new BindingSource();
        //private string User = "";
        #endregion
        public frmPhanlop()
        {
            InitializeComponent();
            dGvLopcu.AutoGenerateColumns = false;
            dGvLopmoi.AutoGenerateColumns = false;
        }
        #region Func
        public void LoadListHS()
        {
            if (cmbNamhoccu.SelectedValue != null && cmbKhoilopcu.SelectedValue != null && cmbLopcu.SelectedValue != null)
                dGvLopcu.DataSource = XepLopDAO.Instance.GetHSHaveClass(cmbLopcu.SelectedValue.ToString(), cmbNamhoccu.SelectedValue.ToString());
            else dGvLopcu.DataSource = XepLopDAO.Instance.GetHSNotInClass();
        }
        public void LoadListHSNew()
        {
            dGvLopmoi.DataSource = XepLopDAO.Instance.GetHSHaveClass(cmbLopmoi.SelectedValue.ToString(), cmbNamhocmoi.SelectedValue.ToString());
        }
        public void LoadIncbNamHoc()
        {
            cmbNamhoccu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc");
            cmbNamhoccu.DisplayMember = "TenNamHoc";
            cmbNamhoccu.ValueMember = "MaNamHoc";

            cmbNamhocmoi.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc");
            cmbNamhocmoi.DisplayMember = "TenNamHoc";
            cmbNamhocmoi.ValueMember = "MaNamHoc";
        }
        public void LoadIncbKhoiLop()
        {
            cmbKhoilopcu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhoiLop");
            cmbKhoilopcu.DisplayMember = "TenKhoiLop";
            cmbKhoilopcu.ValueMember = "MaKhoiLop";

            cmbKhoilopmoi.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhoiLop");
            cmbKhoilopmoi.DisplayMember = "TenKhoiLop";
            cmbKhoilopmoi.ValueMember = "MaKhoiLop";
        }
        public void LoadIncbLopByMaKhoiLopAndNamHoc(string manamhoc, string makhoilop)
        {
            cmbLopcu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE NamHoc =N'" + manamhoc + "' AND MaKhoiLop =N'" + makhoilop + "'");
            cmbLopcu.DisplayMember = "TenLop";
            cmbLopcu.ValueMember = "MaLop";
        }
        public void LoadIncbLopMoiByMaKhoiLopAndNamHoc(string manamhoc, string makhoilop)
        {
            cmbLopmoi.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE NamHoc =N'" + manamhoc + "' AND MaKhoiLop =N'" + makhoilop + "'");
            cmbLopmoi.DisplayMember = "TenLop";
            cmbLopmoi.ValueMember = "MaLop";
        }
        #endregion
        #region Event
        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGvLopmoi.Rows.Count; i++)
            {
                if (dGvLopmoi.Rows[i].Cells[0].Value != null && (dGvLopmoi.Rows[i].Cells[0].Selected || dGvLopmoi.Rows[i].Cells[1].Selected))
                {
                    XepLopDAO.Instance.XoaXepLop(dGvLopmoi.Rows[i].Cells[0].Value.ToString());
                }
            }
            MessageBox.Show("Xóa thành công");
            LoadListHS();
            LoadListHSNew();
        }
        private void btnChuyentatca_Click(object sender, EventArgs e)
        {
            if (cmbLopmoi.SelectedValue != null)
            {
                for (int i = 0; i < dGvLopcu.Rows.Count; i++)
                {
                    if (dGvLopcu.Rows[i].Cells[0].Value != null)
                    {
                        if (XepLopDAO.Instance.CheckExist(dGvLopcu.Rows[i].Cells[0].Value.ToString(), cmbLopmoi.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Học sinh đã có trong lớp này rồi !!!!", "Thông báo");
                            return;
                        }
                        XepLopDAO.Instance.XepLop(dGvLopcu.Rows[i].Cells[0].Value.ToString(), cmbLopmoi.SelectedValue.ToString());
                    }
                }

                MessageBox.Show("Thêm thành công");
                LoadListHS();
                LoadListHSNew();
            }
            else MessageBox.Show("Chọn chon lớp cần xếp", "Thông báo");
        }
        private void btnChuyentungnguoimot_Click(object sender, EventArgs e)
        {
            if (cmbLopmoi.SelectedValue != null)
            {
                for (int i = 0; i < dGvLopcu.Rows.Count; i++)
                {
                    if (dGvLopcu.Rows[i].Cells[0].Value != null && (dGvLopcu.Rows[i].Cells[0].Selected || dGvLopcu.Rows[i].Cells[1].Selected))
                    {
                        if (XepLopDAO.Instance.CheckExist(dGvLopcu.Rows[i].Cells[0].Value.ToString(), cmbLopmoi.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Học sinh đã có trong lớp này rồi !!!!", "Thông báo");
                            return;
                        }
                        if (XepLopDAO.Instance.CheckHSHaveClass(dGvLopcu.Rows[i].Cells[0].Value.ToString()))
                        { XepLopDAO.Instance.XepLop(dGvLopcu.Rows[i].Cells[0].Value.ToString(), cmbLopmoi.SelectedValue.ToString()); }
                        else XepLopDAO.Instance.UpdateXepLop(dGvLopcu.Rows[i].Cells[0].Value.ToString(), cmbLopmoi.SelectedValue.ToString());
                    }
                }

                MessageBox.Show("Thêm thành công");
                LoadListHS();
                LoadListHSNew();
            }
        }
        private void frmPhanlop_Load(object sender, EventArgs e)
        {
            LoadIncbNamHoc();
            LoadIncbKhoiLop();
        }
        private void cmbNamhoccu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLopcu.DataBindings.Clear();
            cmbLopcu.DataSource = null;
        }
        private void cmbNamhocmoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLopmoi.DataBindings.Clear();
            cmbLopmoi.DataSource = null;
        }
        private void cmbKhoilopcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLopcu.DataSource = null;
            if (cmbNamhoccu.SelectedValue != null && cmbKhoilopcu.SelectedValue != null)
                LoadIncbLopByMaKhoiLopAndNamHoc(cmbNamhoccu.SelectedValue.ToString(), cmbKhoilopcu.SelectedValue.ToString());
            cmbLopcu.DataBindings.Clear();

        }
        private void cmbKhoilopmoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLopmoi.DataSource = null;
            if (cmbNamhocmoi.SelectedValue != null && cmbKhoilopmoi.SelectedValue != null)
                LoadIncbLopMoiByMaKhoiLopAndNamHoc(cmbNamhocmoi.SelectedValue.ToString(), cmbKhoilopmoi.SelectedValue.ToString());
            cmbLopmoi.DataBindings.Clear();
        }
        private void cmbLopcu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbNamhoccu.SelectedValue != null && cmbKhoilopcu.SelectedValue != null && cmbLopcu.SelectedValue != null)
                LoadListHS();

        }
        private void cmbLopmoi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbNamhocmoi.SelectedValue != null && cmbKhoilopmoi.SelectedValue != null && cmbLopmoi.SelectedValue != null)
                LoadListHSNew();
        }
        private void cbNewStudent_CheckedChanged(object sender, EventArgs e)
        {
            dGvLopcu.AutoGenerateColumns = false;
            if (cbNewStudent.Checked == true)
            {
                dGvLopcu.DataSource = XepLopDAO.Instance.GetHSNotInClass();
            }
            else dGvLopcu.DataSource = null;
        }

        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
