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
    public partial class frmKetquahockytheolop : Form
    {
        BindingSource bd = new BindingSource();
        public frmKetquahockytheolop()
        {
            InitializeComponent();
        }
        #region Func
        void LoadNHtoCB(ComboBox cb)
        {
            cb.DataSource = NamHocDAO.Instance.LoadNamHoc();
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";
        }
        void LoadLoptoCB(ComboBox cb)
        {
            cb.DataSource = ClassDAO.Instance.loadClass();
            cb.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
        }
        void LoadHKtoCB(ComboBox cb)
        {
            cb.DataSource = HocKiDAO.Instance.LoadHocKi();
            cb.DisplayMember = "TenHocKi";
            cb.ValueMember = "MaHocKi";
        }
        #endregion

        #region Events
        private void btnXem_Click(object sender, EventArgs e)
        {
            string malop = cmbLop.SelectedValue.ToString();
            string namhoc = cmbNamhoc.SelectedValue.ToString();
            string hocki = cmbHocky.SelectedValue.ToString();
            bd.DataSource = KQTongHopHocKiDAO.Instance.LoadKQHocKiByMaLopAndNamHocAndHocKi(namhoc, malop, hocki);
            dGVKetquacanamtheolop.DataSource = bd;
        }
        private void frmKetquahockytheolop_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bd;
            LoadNHtoCB(cmbNamhoc);
            LoadLoptoCB(cmbLop);
            LoadHKtoCB(cmbHocky);
            dGVKetquacanamtheolop.DataSource = KQTongHopHocKiDAO.Instance.LoadKQHocKiToReport();

        }



        #endregion

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            KQHK_Lop kq = new KQHK_Lop();
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
