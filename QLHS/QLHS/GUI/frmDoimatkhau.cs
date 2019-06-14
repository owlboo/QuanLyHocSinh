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
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string old_pass = txtMatkhaucu.Text;
            string new_pass = txtMatkhaumoi.Text;
            string confirm = txtNhaplaimatkhaumoi.Text;
            string username = Properties.Settings.Default.user;
            if (confirm == new_pass && old_pass != new_pass)
            {
                AccountDAO.Instance.PasswordChange(username, new_pass);
                MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK);
                Reset.ResetAllControls(grDoimatkhau);
            }
            else if (old_pass == new_pass)
                MessageBox.Show("Mật khẩu cũ và mật khẩu mới không được trùng nhau !", "Thông báo", MessageBoxButtons.OK);
            else if (confirm != new_pass)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

        }
    }
}