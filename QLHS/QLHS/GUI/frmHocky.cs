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
    public partial class frmHocky : Form
    {
        #region Contructor
        BindingSource bd = new BindingSource();
        #endregion
        public frmHocky()
        {
            InitializeComponent();
            dGVHocky.DataSource = bd;
        }
        #region Event
        private void frmHocky_Load(object sender, EventArgs e)
        {
            LoadHocKy();
            bindingNavigatorHocKy.BindingSource = bd;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dGVHocky.Rows.Count; i++)
            {
                string mahk = dGVHocky.Rows[i].Cells["colMahocky"].Value.ToString();
                if (mahk == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }
                
                if(dGVHocky.Rows[i].Cells["colMahocky"].Selected|| dGVHocky.Rows[i].Cells["colTenhocky"].Selected||dGVHocky.Rows[i].Cells["colHeso"].Selected)
                    HocKiDAO.Instance.XoaHocKi(mahk);
            }
            MessageBox.Show("Xóa thành công", "Thông báo");
            LoadHocKy();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }
        #endregion

        #region Func
        public void LoadHocKy()
        {
            bd.DataSource = HocKiDAO.Instance.LoadHocKi();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVHocky.CurrentRow == null) return true;
                dGVHocky.CurrentCell = dGVHocky.CurrentRow.Cells["colMahocky"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void SaveItem()
        {
            for (int i = 0; i < dGVHocky.Rows.Count; i++)
            {
                {
                    string mahk = dGVHocky.Rows[i].Cells["colMahocky"].Value.ToString();
                    string tenhk = dGVHocky.Rows[i].Cells["colTenhocky"].Value.ToString();
                    int heso;
                    if (mahk == "")
                    {
                        MessageBox.Show("Mã học kì trống", "Thông báo");
                        return;
                    }
                    if (tenhk == "")
                    {
                        MessageBox.Show("Tên học kì trống", "Thông báo");
                        return;
                    }
                    if(!Int32.TryParse(dGVHocky.Rows[i].Cells["colHeso"].Value.ToString(), out heso))
                    {
                        MessageBox.Show("Hệ số sai định dạng !!!", "Thông báo");
                        return;
                    }
                    {
                        if (!HocKiDAO.Instance.CheckHocKiExist(mahk))
                            
                            HocKiDAO.Instance.ThemHocKi(mahk, tenhk,heso);
                        if(HocKiDAO.Instance.CheckHocKiExist(mahk)&&HocKiDAO.Instance.CheckHocKiInGridView(mahk,dGVHocky)==false)
                        {
                            
                            HocKiDAO.Instance.SuaHocKi(mahk, tenhk,heso);
                        }
                    }
                }
            }
            MessageBox.Show("Đã lưu thành công", "Thông báo");
            LoadHocKy();
        }


        #endregion

    }
}
