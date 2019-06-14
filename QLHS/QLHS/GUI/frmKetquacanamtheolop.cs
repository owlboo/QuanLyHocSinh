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
    public partial class frmKetquacanamtheolop : Form
    {
        BindingSource bd = new BindingSource();
        public frmKetquacanamtheolop()
        {
            InitializeComponent();
        }
        #region Events
        private void frmKetquacanamtheolop_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bd;
            LoadLopToCB(cmbLop);
            LoadNHtoCB(cmbNamhoc);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string manamhoc = cmbNamhoc.SelectedValue.ToString();
            string malop = cmbLop.SelectedValue.ToString();
            bd.DataSource = KQTongHopDAO.Instance.LoadKQCNByNamHocAndMaLop(manamhoc, malop);
            dGVKetquacanamtheolop.DataSource = bd;
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            KQCN_Lop kq = new KQCN_Lop();
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
        #region Function
        void LoadNHtoCB(ComboBox cb)
        {
            cb.DataSource = NamHocDAO.Instance.LoadNamHoc();
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";
        }

        void LoadLopToCB(ComboBox cb)
        {
            cb.DataSource = ClassDAO.Instance.loadClass();
            cb.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
        }
        //public void HienThi()
        //{
        //    if (cmbNamhoc.SelectedValue != null && cmbLop.SelectedValue != null)
        //        bd.DataSource = KQTongHopDAO.Instance.LoadKQCNByNamHocAndMaLop(cmbNamhoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());
        //    string manamhoc = cmbNamhoc.SelectedValue.ToString();
        //    string malop = cmbLop.SelectedValue.ToString();
        //    dGVKetquacanamtheolop.DataSource = KQTongHopDAO.Instance.LoadKQCNByNamHocAndMaLop(cmbNamhoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());
        //    foreach (DataGridViewRow rowHocSinh in dGVKetquacanamtheolop.Rows)
        //    {
        //        string DiemHK1 = "";
        //        string DiemHK2 = "";
        //        DataTable m_data = KQTongHopDAO.Instance.GetKQHK(rowHocSinh.Cells["colMahocsinh"].Value.ToString(), manamhoc, malop);
        //        foreach (DataRow rowDiem in m_data.Rows)
        //        {
        //            if (Int32.Parse(rowDiem["MaHocKi"].ToString()) == 1)
        //            {
        //                DiemHK1 = rowDiem["DiemTBHocKi"].ToString();
        //            }
        //            else if (Int32.Parse(rowDiem["MaHocKi"].ToString()) == 2)
        //            {
        //                DiemHK2 = rowDiem["DiemTBHocKi"].ToString();
        //            }
        //        }
        //        rowHocSinh.Cells["colDTBHK1"].Value = DiemHK1;
        //        rowHocSinh.Cells["colDTBHK2"].Value = DiemHK2;
        //    }
        //}
    
        #endregion
   }
}
