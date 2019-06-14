using DevExpress.XtraReports.UI;
using QLHS.DAO;
using QLHS.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.GUI
{
    public partial class frmDanhsachlop : Form
    {
        BindingSource bd = new BindingSource();
        public frmDanhsachlop()
        {
            InitializeComponent();
        }
        #region Events

        #endregion
        #region Func
        void LoadNHtoCB (ComboBox cb)
        {
            cb.DataSource = NamHocDAO.Instance.LoadNamHoc();
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";
        }
        void LoadKLtoCB(ComboBox cb)
        {
            cb.DataSource = KhoiLopDAO.Instance.LoadKhoiLop();
            cb.DisplayMember = "TenKhoiLop";
            cb.ValueMember = "MaKhoiLop";
        }
        #endregion

        private void frmDanhsachlop_Load(object sender, EventArgs e)
        {
           
            bindingNavigator1.BindingSource = bd;
            LoadKLtoCB(cmbKhoilop);
            LoadNHtoCB(cmbNamhoc);
            dgvLop.DataSource = ClassDAO.Instance.loadClassToReport();

        }

        private void btnHienthi1_Click(object sender, EventArgs e)
        {
            string namhoc = cmbNamhoc.SelectedValue.ToString();
            dgvLop.DataSource = ClassDAO.Instance.loadClassByNH(namhoc);
            bd.DataSource= ClassDAO.Instance.loadClassByNH(namhoc);
        }

        private void btnHienthi2_Click(object sender, EventArgs e)
        {
            string khoilop = cmbKhoilop.SelectedValue.ToString();
            dgvLop.DataSource = ClassDAO.Instance.loadClassByKL(khoilop);
            bd.DataSource= ClassDAO.Instance.loadClassByKL(khoilop);
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            DSLop dSHS = new DSLop();
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            DataTable da = bd.DataSource as DataTable;
            if (da != null)
            {
                ds.Tables.Add(da);
                dSHS.DataSource = ds;
                dSHS.DataMember = ds.Tables[0].TableName;
                dSHS.ShowPreviewDialog();
            }
        }
    }
}
