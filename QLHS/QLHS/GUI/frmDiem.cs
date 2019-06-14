
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
    public partial class frmDiem : Form
    {
        #region Constructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmDiem()
        {
            InitializeComponent();
            dGVDiem.DataSource = bd;
        }
        #region Func
        public void LoadCotDiem()
        {
            string query = "SELECT * FROM CotDiem";
            bd.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVDiem.CurrentRow == null) return true;
                dGVDiem.CurrentCell = dGVDiem.CurrentRow.Cells["colMacotdiem"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void SaveItem()
        {
            for (int i = 0; i < dGVDiem.Rows.Count; i++)
            {
                {
                    string macotdiem = dGVDiem.Rows[i].Cells["colMacotdiem"].Value.ToString();
                    string tencotdiem = dGVDiem.Rows[i].Cells["colTencotdiem"].Value.ToString();
                    int heso;
                    if (macotdiem == "")
                    {
                        MessageBox.Show("Mã cột điểm trống", "Thông báo");
                        return;
                    }
                    if (tencotdiem == "")
                    {
                        MessageBox.Show("Tên cột điểm trống", "Thông báo");
                        return;
                    }
                    if (!Int32.TryParse(dGVDiem.Rows[i].Cells["colHeso"].Value.ToString(), out heso))
                    {
                        MessageBox.Show("Hệ số sai định dạng !!!", "Thông báo");
                        return;
                    }
                    {
                        if (!CotDiemDAO.Instance.CheckCotDiemExist(macotdiem))
                            
                            CotDiemDAO.Instance.ThemCotDiem(macotdiem, tencotdiem, heso);
                        if (CotDiemDAO.Instance.CheckCotDiemExist(macotdiem)&&CotDiemDAO.Instance.CheckCotDiemInGridView(macotdiem,dGVDiem)==false)
                        {
                            
                            CotDiemDAO.Instance.SuaCotDiem(macotdiem, tencotdiem, heso);
                        }
                    }
                }
            }
            MessageBox.Show("Đã lưu thành công", "Thông báo");
            LoadCotDiem();
        }
        #endregion

        #region Event
        private void frmDiem_Load(object sender, EventArgs e)
        {
            LoadCotDiem();
            bindingNavigatorCotDiem.BindingSource = bd;
        }


        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVDiem.Rows.Count; i++)
            {
                string macotdiem = dGVDiem.Rows[i].Cells["colMacotdiem"].Value.ToString();
                if (macotdiem == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }

                if (dGVDiem.Rows[i].Cells["colMacotdiem"].Selected || dGVDiem.Rows[i].Cells["colTencotdiem"].Selected || dGVDiem.Rows[i].Cells["colHeso"].Selected)
                    CotDiemDAO.Instance.XoaCotDiem(macotdiem);
            }
            MessageBox.Show("Xóa thành công", "Thông báo");
            LoadCotDiem();
        }
    }
}
