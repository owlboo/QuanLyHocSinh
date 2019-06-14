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
    public partial class frmHocluc : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmHocluc()
        {
            InitializeComponent();
            dGVHocluc.DataSource = bd;
        }
        #region Event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVHocluc.Rows.Count; i++)
            {
                string mahocluc = dGVHocluc.Rows[i].Cells["colMahocluc"].Value.ToString();
                if (mahocluc == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }

                if (dGVHocluc.Rows[i].Cells["colMahocluc"].Selected || 
                    dGVHocluc.Rows[i].Cells["colTenhocluc"].Selected || 
                    dGVHocluc.Rows[i].Cells["colDiemtoithieu"].Selected||
                    dGVHocluc.Rows[i].Cells["colDiemtoida"].Selected)
                    HocLucDAO.Instance.XoaHocLuc(mahocluc);
            }
            MessageBox.Show("Xóa thành công", "Thông báo");
            LoadHocLuc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }
        private void frmHocluc_Load(object sender, EventArgs e)
        {
            bindingNavigatorHocLuc.BindingSource = bd;
            
            LoadHocLuc();
            
        }
        #endregion
        #region Func
        public void LoadHocLuc()
        {
            bd.DataSource = HocLucDAO.Instance.LoadHocLuc();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVHocluc.CurrentRow == null) return true;
                dGVHocluc.CurrentCell = dGVHocluc.CurrentRow.Cells["colMahocluc"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void SaveItem()
        {
            for (int i = 0; i < dGVHocluc.Rows.Count; i++)
            {
                {
                    string mahocluc = dGVHocluc.Rows[i].Cells["colMahocluc"].Value.ToString();
                    string tenhocluc = dGVHocluc.Rows[i].Cells["colTenhocluc"].Value.ToString();
                    float diemtoida,diemtoithieu;
                    if (mahocluc == "")
                    {
                        MessageBox.Show("Mã học lực trống", "Thông báo");
                        return;
                    }
                    if (tenhocluc == "")
                    {
                        MessageBox.Show("Tên học lực trống", "Thông báo");
                        return;
                    }
                    if (!float.TryParse(dGVHocluc.Rows[i].Cells["colDiemtoida"].Value.ToString(), out diemtoida))
                    {
                        MessageBox.Show("Điểm tối đa sai định dạng !!!", "Thông báo");
                        return;
                    }
                    if (!float.TryParse(dGVHocluc.Rows[i].Cells["colDiemtoithieu"].Value.ToString(), out diemtoithieu))
                    {
                        MessageBox.Show("Điểm tối đa sai định dạng !!!", "Thông báo");
                        return;
                    }
                    {
                        if (!QuyDInhDiemDAO.Instance.KiemTraDiem(diemtoithieu.ToString()))
                        {
                            MessageBox.Show("Điểm tối thiểu từ 0 - 10", "Thông báo");
                            return;
                        }
                        if (!QuyDInhDiemDAO.Instance.KiemTraDiem(diemtoida.ToString()))
                        {
                            MessageBox.Show("Điểm tối đa từ 0 - 10", "Thông báo");
                            return;
                        }
                        if (!HocLucDAO.Instance.CheckHocLucExist(mahocluc))

                            HocLucDAO.Instance.ThemHocLuc(mahocluc, tenhocluc, diemtoithieu,diemtoida);
                        if (HocLucDAO.Instance.CheckHocLucExist(mahocluc)&&HocLucDAO.Instance.CheckHocLucInGridView(mahocluc,dGVHocluc))
                        {

                            HocLucDAO.Instance.SuaHocLuc(mahocluc, tenhocluc, diemtoithieu,diemtoida);
                        }
                    }
                }
            }
            MessageBox.Show("Đã lưu thành công", "Thông báo");
            LoadHocLuc();
        }
        #endregion


    }
}
