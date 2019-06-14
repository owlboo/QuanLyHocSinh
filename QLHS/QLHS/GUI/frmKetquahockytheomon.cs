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

namespace QLHS
{
    public partial class frmKetquahockytheomon : Form
    {
        BindingSource bd = new BindingSource();
        public frmKetquahockytheomon()
        {
            InitializeComponent();
        }
        #region Func
        void LoadNHToCB(ComboBox cb)
        {
            cb.DataSource = NamHocDAO.Instance.LoadNamHoc();
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";
        }
        void LoadHocKiToCB(ComboBox cb)
        {
            cb.DataSource = HocKiDAO.Instance.LoadHocKi();
            cb.DisplayMember = "TenHocKi";
            cb.ValueMember = "MaHocKi";
        }
        void LoadMonHocToCB(ComboBox cb)
        {
            cb.DataSource = MonHocDAO.Instance.LoadMonHoc();
            cb.DisplayMember = "TenMon";
            cb.ValueMember = "MaMH";
        }

        #endregion

        #region Events

        #endregion

        private void frmKetquahockytheomon_Load(object sender, EventArgs e)
        {
            LoadNHToCB(cmbNamhoc);
            LoadHocKiToCB(cmbHocky);
            LoadMonHocToCB(cmbMonhoc);
            dGVKetquahockytheomon.DataSource = KQMonHocHocKiDAO.Instance.LoadKQHKMonHocToReport();
            bindingNavigator1.BindingSource = bd;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string manamhoc = cmbNamhoc.SelectedValue.ToString();
            string mahocki = cmbHocky.SelectedValue.ToString();
            string mamon = cmbMonhoc.SelectedValue.ToString();
            bd.DataSource = KQMonHocHocKiDAO.Instance.LoadKQHKMonHocByNamHocAndHocKyAndMonHoc(manamhoc, mahocki, mamon);
            dGVKetquahockytheomon.DataSource = bd;
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            KQHK_Mon kq = new KQHK_Mon();
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            DataTable da = bd.DataSource as DataTable;
            if (da != null)
            {
                ds.Tables.Add(da);
                kq.DataSource = ds;
                kq.DataMember = ds.Tables[0].TableName;
                kq.ShowPreviewDialog();
            }
        }
    }
}
