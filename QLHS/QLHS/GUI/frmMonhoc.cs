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
    public partial class frmMonhoc : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmMonhoc()
        {
            InitializeComponent();
            
        }
        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMonhoc_Load(object sender, EventArgs e)
        {

            LoadMonHoc();
            dGVMonhoc.DataSource = bd;
            bindingNavigatorMonHoc.BindingSource = bd;
        }

        #endregion

        #region Func
        public void LoadMonHoc()
        {
            bd.DataSource = MonHocDAO.Instance.LoadMonHoc();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVMonhoc.CurrentRow == null) return true;
                dGVMonhoc.CurrentCell = dGVMonhoc.CurrentRow.Cells["colMamonhoc"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void SaveItem()
        {
            for (int i = 0; i < dGVMonhoc.Rows.Count; i++)
            {
                {
                    string mamonhoc = dGVMonhoc.Rows[i].Cells["colMamonhoc"].Value.ToString();
                    string tenmonhoc = dGVMonhoc.Rows[i].Cells["colTenmonhoc"].Value.ToString();
                    int heso;
                    if (mamonhoc == "")
                    {
                        MessageBox.Show("Mã môn học trống", "Thông báo");
                        return;
                    }
                    if (tenmonhoc == "")
                    {
                        MessageBox.Show("Tên môn học trống", "Thông báo");
                        return;
                    }
                    if (!Int32.TryParse(dGVMonhoc.Rows[i].Cells["colHeso"].Value.ToString(), out heso))
                    {
                        MessageBox.Show("Hệ số sai định dạng !!!", "Thông báo");
                        return;
                    }
                    {
                        if (!MonHocDAO.Instance.CheckMonHocExist(mamonhoc))
                            MonHocDAO.Instance.ThemMonHoc(mamonhoc, tenmonhoc, heso);
                        if (MonHocDAO.Instance.CheckMonHocExist(mamonhoc)&&MonHocDAO.Instance.CheckMonHocInGridView(mamonhoc,dGVMonhoc)==false)
                        {
                            
                            MonHocDAO.Instance.SuaMonHoc(mamonhoc, tenmonhoc, heso);
                        }
                    }
                }
            }
            MessageBox.Show("Đã lưu thành công", "Thông báo");
            LoadMonHoc();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVMonhoc.Rows.Count; i++)
            {
                string mamonhoc = dGVMonhoc.Rows[i].Cells["colMamonhoc"].Value.ToString();
                if (mamonhoc == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }
                if (dGVMonhoc.Rows[i].Cells["colMamonhoc"].Selected || dGVMonhoc.Rows[i].Cells["colTenmonhoc"].Selected ||
                    dGVMonhoc.Rows[i].Cells["colHeso"].Selected || dGVMonhoc.Rows[i].Selected)
                    MonHocDAO.Instance.XoaMonHoc(mamonhoc);
            }
            MessageBox.Show("Xóa thành công", "Thông báo");
            LoadMonHoc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }
    }
}
