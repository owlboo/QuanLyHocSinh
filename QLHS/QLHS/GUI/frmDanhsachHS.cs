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
    public partial class frmDanhsachHS : Form
    {
        BindingSource bd = new BindingSource();
        DataSet ds = new DataSet();
        public frmDanhsachHS()
        {
            InitializeComponent();
        }
        #region Events
        private void frmDanhsachHS_Load(object sender, EventArgs e)
        {
            //bd.DataSource = HocSinhDAO.Instance.LoadHS();
            bindingNavigator1.BindingSource = bd;
            LoadClassInCB(cmbLop);
            LoadNHInCB(cmbNamhoc1);
            LoadNHInCB(cmbNamhoc2);
            LoadKLinCB(cmbKhoilop);
            dgvHS.DataSource = HocSinhDAO.Instance.LoadHS();
        }


        #endregion

        #region Func

        void LoadClassInCB(ComboBox cb)
        {
            cb.DataSource = ClassDAO.Instance.loadClass();
            cb.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
        }
        void LoadNHInCB(ComboBox cb)
        {
            cb.DataSource = NamHocDAO.Instance.LoadNamHoc();
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";

        }
        void LoadKLinCB(ComboBox cb)
        {
            cb.DataSource = KhoiLopDAO.Instance.LoadKhoiLop();
            cb.DisplayMember = "TenKhoiLop";
            cb.ValueMember = "MaKhoiLop";
        }
        #endregion

        #region Other
        private void cmbKhoilop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNamhoc1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNamhoc2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            //XtraReport2 report = new XtraReport2();
            //report.GridControl = dgvHS;
            //ReportPrintTool printTool = new ReportPrintTool(report);
            //printTool.ShowPreviewDialog();
        }

        private void btnHienthi2_Click(object sender, EventArgs e)
        {
            string khoilop = cmbKhoilop.SelectedValue.ToString();
            string namhoc = cmbNamhoc1.SelectedValue.ToString();
            dgvHS.DataSource = HocSinhDAO.Instance.LoadHSByMaKhoiNH(khoilop, namhoc);
        }

        private void btnHienthi1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //XtraReport2 report = new XtraReport2();
            //ReportDesignTool designTool = new ReportDesignTool(report);
            //designTool.ShowDesignerDialog();

        }

        private void btnPrinter_Click_1(object sender, EventArgs e)
        {
            //DSHS dSHS = new DSHS();
            //string malop = cmbLop.SelectedValue.ToString();
            //string namhoc = cmbNamhoc1.SelectedValue.ToString();
            //ds.Tables.Add(HocSinhDAO.Instance.LoadHSByMaLopNH(malop, namhoc));
            //dSHS.DataSource = ds;
            //dSHS.DataMember = ds.Tables[0].TableName;
            //dSHS.ShowPreviewDialog();

            DSHS dSHS = new DSHS();
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

        private void btnHienthi1_Click_1(object sender, EventArgs e)
        {
            string malop = cmbLop.SelectedValue.ToString();
            string namhoc = cmbNamhoc1.SelectedValue.ToString();
            bd.DataSource = HocSinhDAO.Instance.LoadHSByMaLopNH(malop, namhoc);
            //dgvHS.DataSource = HocSinhDAO.Instance.LoadHSByMaLopNH(malop, namhoc);
            dgvHS.DataSource = HocSinhDAO.Instance.LoadHSByMaLopNH(malop, namhoc);
        }

        private void btnHienthi2_Click_1(object sender, EventArgs e)
        {
            string makhoi = cmbKhoilop.SelectedValue.ToString();
            string namhoc = cmbNamhoc2.SelectedValue.ToString();
            bd.DataSource = HocSinhDAO.Instance.LoadHSByMaKhoiNH(makhoi, namhoc);
            dgvHS.DataSource = bd;
        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }

        private void navigationPage1_Click(object sender, EventArgs e)
        {

        }

        private void navigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
