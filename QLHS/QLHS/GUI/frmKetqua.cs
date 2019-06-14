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
    public partial class frmKetqua : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmKetqua()
        {
            InitializeComponent();
            dGVKetqua.DataSource = bd;
        }
        #region Event
        #endregion
        #region Func
        public void LoadKetQua()
        {
            bd.DataSource = KetQuaDAO.Instance.LoadKetQua();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVKetqua.CurrentRow == null) return true;
                dGVKetqua.CurrentCell = dGVKetqua.CurrentRow.Cells["colMaketqua"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void SaveItem()
        {
            for (int i = 0; i < dGVKetqua.Rows.Count; i++)
            {
                {
                    string maketqua = dGVKetqua.Rows[i].Cells["colMaketqua"].Value.ToString();
                    string tenketqua = dGVKetqua.Rows[i].Cells["colTenketqua"].Value.ToString();
                    if (maketqua == "")
                    {
                        MessageBox.Show("Mã kết quả trống", "Thông báo");
                        return;
                    }
                    if (tenketqua == "")
                    {
                        MessageBox.Show("Tên kết quả trống", "Thông báo");
                        return;
                    }
                   
                    {
                        if (!KetQuaDAO.Instance.CheckKetQuaExist(maketqua))
                            
                            KetQuaDAO.Instance.ThemKetQua(maketqua, tenketqua);
                        if (KetQuaDAO.Instance.CheckKetQuaExist(maketqua)&&KetQuaDAO.Instance.CheckKetQuaInGridView(maketqua,dGVKetqua)==false)
                        {
                            
                            KetQuaDAO.Instance.SuaKetQua(maketqua, tenketqua);
                        }
                    }
                }
            }
            MessageBox.Show("Đã lưu thành công", "Thông báo");
            LoadKetQua();
        }
        #endregion

        private void frmKetqua_Load(object sender, EventArgs e)
        {
            LoadKetQua();
            bindingNavigatorKetQua.BindingSource = bd;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVKetqua.Rows.Count; i++)
            {
                string makq = dGVKetqua.Rows[i].Cells["colMaketqua"].Value.ToString();
                if (makq == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }

                if (dGVKetqua.Rows[i].Cells["colMaketqua"].Selected || dGVKetqua.Rows[i].Cells["colTenketqua"].Selected)
                    KetQuaDAO.Instance.XoaKetQua(makq);
            }
            MessageBox.Show("Xóa thành công", "Thông báo");
            LoadKetQua();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
