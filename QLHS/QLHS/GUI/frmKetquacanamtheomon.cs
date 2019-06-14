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
    public partial class frmKetquacanamtheomon : Form
    {
        BindingSource bd = new BindingSource();
        public frmKetquacanamtheomon()
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
        void LoadMHToCB(ComboBox cb)
        {
            cb.DataSource = MonHocDAO.Instance.LoadMonHoc();
            cb.DisplayMember = "TenMon";
            cb.ValueMember = "MaMH";
        }
        //public void HienThi()
        //{
        //    if(cmbMonhoc.SelectedValue !=null && cmbNamhoc.SelectedValue !=null)
        //        bd.DataSource = KQMonHocCaNamDAO.Instance.LoadKQCaNamMHByNamHocAndMonHoc(cmbNamhoc.SelectedValue.ToString(), cmbMonhoc.SelectedValue.ToString());
        //    string manamhoc = cmbNamhoc.SelectedValue.ToString();
        //    string mamonhoc = cmbMonhoc.SelectedValue.ToString();
        //    dGVKetquacanamtheomon.DataSource = KQMonHocCaNamDAO.Instance.LoadKQCaNamMHByNamHocAndMonHoc(manamhoc, mamonhoc);
        //    foreach (DataGridViewRow rowHocSinh in dGVKetquacanamtheomon.Rows)
        //    {
        //        string DiemHK1 = "";
        //        string DiemHK2 = "";
        //        DataTable m_data = KQMonHocCaNamDAO.Instance.GetDTBHKByMaHS(rowHocSinh.Cells["colMahocsinh"].Value.ToString(),cmbNamhoc.SelectedValue.ToString(),cmbMonhoc.SelectedValue.ToString());
        //        foreach(DataRow rowDiem in m_data.Rows)
        //        {
        //            if (Int32.Parse(rowDiem["HocKi"].ToString()) == 1)
        //            {
        //                DiemHK1 = rowDiem["DTBMonHocKi"].ToString();
        //            }else if (Int32.Parse(rowDiem["HocKi"].ToString()) == 2)
        //            {
        //                DiemHK2 = rowDiem["DTBMonHocKi"].ToString();
        //            }
        //        }
        //        rowHocSinh.Cells["colDTBHK1"].Value = DiemHK1;
        //        rowHocSinh.Cells["colDTBHK2"].Value = DiemHK2;
        //    }
        //}
        #endregion
        #region Events
        private void frmKetquacanamtheomon_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bd;
            LoadMHToCB(cmbMonhoc);
            LoadNHtoCB(cmbNamhoc);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string manamhoc = cmbNamhoc.SelectedValue.ToString();
            string mamonhoc = cmbMonhoc.SelectedValue.ToString();
            bd.DataSource = KQMonHocCaNamDAO.Instance.LoadKQCaNamMHByNamHocAndMonHoc(manamhoc, mamonhoc);
            dGVKetquacanamtheomon.DataSource = bd;
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            KQCN_Mon kq = new KQCN_Mon();
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
        #endregion


    }
}
