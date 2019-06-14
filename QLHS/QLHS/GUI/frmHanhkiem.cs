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
    public partial class frmHanhkiem : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmHanhkiem()
        {
            InitializeComponent();

        }
        #region Event
        private void frmHanhkiem_Load(object sender, EventArgs e)
        {
            LoadHanhKiem();
            dGVHanhkiem.DataSource = bd;
            bindingNavigatorHanhKiem.BindingSource = bd;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Func
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVHanhkiem.CurrentRow == null) return true;
                dGVHanhkiem.CurrentCell = dGVHanhkiem.CurrentRow.Cells["colMahanhkiem"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void LoadHanhKiem()
        {
            bd.DataSource = HanhKiemDAO.Instance.LoadHanhKiem();
        }
        public void SaveItem()
        {

            for (int i = 0; i < dGVHanhkiem.Rows.Count; i++)
            {
                {
                    string mahk = dGVHanhkiem.Rows[i].Cells["colMahanhkiem"].Value.ToString();
                    string tenhk = dGVHanhkiem.Rows[i].Cells["colTenhanhkiem"].Value.ToString();
                    if (mahk == "")
                    {
                        MessageBox.Show("Mã hạnh kiểm trống", "Thông báo");
                        return;
                    }
                    if (tenhk == "")
                    {
                        MessageBox.Show("Tên hạnh kiểm trống", "Thông báo");
                        return;
                    }
                  
                    {
                        if (!HanhKiemDAO.Instance.CheckHanhKiemExist(mahk))

                            HanhKiemDAO.Instance.ThemHanhKiem(mahk, tenhk);
                        if (HanhKiemDAO.Instance.CheckHanhKiemExist(mahk)&&HanhKiemDAO.Instance.CheckHanhKiemInGridView(mahk,dGVHanhkiem)==false)
                        {

                            HanhKiemDAO.Instance.SuaHanhKiem(mahk, tenhk);
                        }
                    }
                }
            }
            MessageBox.Show("Đã lưu thành công", "Thông báo");
            LoadHanhKiem();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVHanhkiem.Rows.Count; i++)
            {
                string mahk = dGVHanhkiem.Rows[i].Cells["colMahanhkiem"].Value.ToString();
                if (mahk == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }

                if (dGVHanhkiem.Rows[i].Cells["colMahanhkiem"].Selected || dGVHanhkiem.Rows[i].Cells["colTenhanhkiem"].Selected)
                    HanhKiemDAO.Instance.XoaHanhKiem(mahk);
            }
            MessageBox.Show("Xóa thành công", "Thông báo");
            LoadHanhKiem();
        }
    }
}
