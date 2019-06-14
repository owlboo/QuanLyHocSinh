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
    public partial class frmNamhoc : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        //private string User = "";
        #endregion
        public frmNamhoc()
        {
            InitializeComponent();
            dGVNamhoc.DataSource = bd;
        }
        #region Event
        private void frmNamhoc_Load(object sender, EventArgs e)
        {
            bd.DataSource = NamHocDAO.Instance.LoadNamHoc();
            bindingNavigatorNamHoc.BindingSource = bd;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dGVNamhoc.Rows.Count; i++)
            {
                string manammhoc = dGVNamhoc.Rows[i].Cells["colManamhoc"].Value.ToString();
                if (manammhoc == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }
                
                if (dGVNamhoc.Rows[i].Cells["colManamhoc"].Selected || dGVNamhoc.Rows[i].Cells["colTennamhoc"].Selected)
                    NamHocDAO.Instance.XoaNamHoc(manammhoc);
            }
            MessageBox.Show("Xóa thành công", "Thông báo");
            LoadNamHoc();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData==Keys.Enter)
            {
                if (dGVNamhoc.CurrentRow == null) return true;
                dGVNamhoc.CurrentCell = dGVNamhoc.CurrentRow.Cells["colManamhoc"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Func
        //public void SaveU(string u)
        //{
        //    User = u;
        //    string type = AccountDAO.Instance.GetType(User);
        //    if (!type.Equals("admin"))
        //    {
        //        bindingNavigatorNamHoc.Enabled = false;
        //    }
        //}
        public void LoadNamHoc()
        {
            bd.DataSource = NamHocDAO.Instance.LoadNamHoc();
        }
        public void SaveItem()
        {
            for (int i = 0; i < dGVNamhoc.Rows.Count; i++)
            {
                {
                    string manamhoc = dGVNamhoc.Rows[i].Cells["colManamhoc"].Value.ToString();
                    string tennamhoc = dGVNamhoc.Rows[i].Cells["colTennamhoc"].Value.ToString();

                    if (manamhoc == "")
                    {
                        MessageBox.Show("Mã năm học trống", "Thông báo");
                        return;
                    }
                    if (tennamhoc == "")
                    {
                        MessageBox.Show("Tên năm học trống", "Thông báo");
                        return;
                    }
                    {
                        if (!NamHocDAO.Instance.CheckNamHocExist(manamhoc))
                            NamHocDAO.Instance.ThemNamHoc(manamhoc, tennamhoc);
                        if (NamHocDAO.Instance.CheckNamHocExist(manamhoc)&&NamHocDAO.Instance.CheckNamHocInGridView(manamhoc,dGVNamhoc)==false)
                            NamHocDAO.Instance.SuaNamHoc(manamhoc, tennamhoc);
                        }
                    }
                }
            MessageBox.Show("Đã lưu thành công", "Thông báo");
            
            LoadNamHoc();
        }
        #endregion


    }
}
