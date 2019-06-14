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
    public partial class frmQuydinhchung : Form
    {
        #region Constructor
        #endregion
        public frmQuydinhchung()
        {
            InitializeComponent();
        }

        #region Event
        private void btnCapNhatSiSo_Click(object sender, EventArgs e)
        {
            if (txtSisotoida.Text.ToString() != "" && txtSisotoithieu.Text.ToString() != "")
                if (isNumber(txtSisotoida.Text.ToString()) && isNumber(txtSisotoithieu.Text.ToString()))
                {
                    int SiSoMax = Convert.ToInt32(txtSisotoida.Text.ToString());
                    int SiSoMin = Convert.ToInt32(txtSisotoithieu.Text.ToString());
                    if (QuyDinhSiSoDAO.Instance.ChangeSiSoMaxMin(SiSoMax, SiSoMin)&&QuyDinhSiSoDAO.Instance.UpdateLimitSiSo(SiSoMax, SiSoMin))
                    {
                        MessageBox.Show("Thay đổi giới hạn sỉ số thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else MessageBox.Show("Thay đổi giới hạn sỉ số thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Không phải kiểu số nha cưng!!", "Thông báo",MessageBoxButtons.OK);
            else MessageBox.Show("Có chỗ nào trống kìa!!", "Thông báo", MessageBoxButtons.OK);
        }
        private void btEditAge_Click(object sender, EventArgs e)
        {
            if(txtDotuoitoida.Text.ToString()!=""&&txtDotuoitoithieu.Text.ToString()!="")
            {
                if(QuidinhtuoiDAO.Instance.QuiDinhTuoiHS(txtDotuoitoida.Text,txtDotuoitoithieu.Text)&&QuidinhtuoiDAO.Instance.UpdateLimitAge(txtDotuoitoida.Text, txtDotuoitoithieu.Text))
                {
                    MessageBox.Show("Thay đổi giới hạn độ tuổi thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Thay đổi giới hạn độ tuổi thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Có chỗ nào trống kìa!!", "Thông báo");
        }
        #endregion

        #region Func
        bool isNumber(string value)
        {
            foreach (Char item in value)
            {
                if (!Char.IsDigit(item))
                    return false;
            }
            return true;
        }

        #endregion


    }
}
