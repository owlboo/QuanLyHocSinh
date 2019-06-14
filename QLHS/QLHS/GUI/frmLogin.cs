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
    public partial class frmLogin : Form
    {
        public delegate void User(TextBox tb);
        private string user = "";
        public frmLogin()
        {
            InitializeComponent();
            txtTen.Text = "Please Enter Your Username";
            txtTen.ForeColor = SystemColors.GrayText;
            txtMatkhau.UseSystemPasswordChar = false;
            txtMatkhau.Text = "Please Enter Your Password";
            txtMatkhau.ForeColor = SystemColors.GrayText;
            txtTen.Focus();
        }
        #region Event
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.user != String.Empty)
            {
                txtTen.ForeColor = SystemColors.WindowText;
                txtTen.Text = Properties.Settings.Default.user;
                txtMatkhau.UseSystemPasswordChar = true;
                txtMatkhau.ForeColor = SystemColors.WindowText;
                txtMatkhau.Text = Properties.Settings.Default.pass;
                chkGhinhodangnhap.Checked = Properties.Settings.Default.isCheck;

            }
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string userName = txtTen.Text;
            user = txtTen.Text;
            string passWord = txtMatkhau.Text;
            if (_login(userName, passWord))
            {
                frmMain main = new frmMain();
                this.Hide();
                User u = new User(main.SaveU);
                u(txtTen);
                main.ShowDialog();
                this.Show();
                if (chkGhinhodangnhap.Checked)
                {
                    Properties.Settings.Default.user = txtTen.Text;

                    Properties.Settings.Default.pass = txtMatkhau.Text;
                    Properties.Settings.Default.isCheck = chkGhinhodangnhap.Checked;

                    Properties.Settings.Default.Save();
                }
                else
                {
                    //Reset.ResetAllControls(grDangnhap);
                    txtTen.Text = "Please Enter Your Username";
                    txtTen.ForeColor = SystemColors.GrayText;
                    txtMatkhau.UseSystemPasswordChar = false;
                    txtMatkhau.Text = "Please Enter Your Password";
                    txtMatkhau.ForeColor = SystemColors.GrayText;
                    txtTen.Focus();
                }
            }
            else
            {
                chkGhinhodangnhap.Checked = false;
                lblThongbaodangnhap.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                lblThongbaodangnhap.BackColor = Color.Red;
                txtTen.Text = "Please Enter Your Username";
                txtTen.ForeColor = SystemColors.GrayText;
                txtMatkhau.UseSystemPasswordChar = false;
                txtMatkhau.Text = "Please Enter Your Password";
                txtMatkhau.ForeColor = SystemColors.GrayText;
                txtTen.Focus();
            }

        }
        #endregion

        #region Func
        bool _login(string userName, string passWord)
        {
            string query = "EXEC dbo.USP_User_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }
        public void SaveU(string _user)
        {
            _user = this.user;
        }
        #endregion

        private void txtTen_Enter(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtTen.Text== "Please Enter Your Username")
            {
                txtTen.Text = "";
                txtTen.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                txtTen.Text = "Please Enter Your Username";
                txtTen.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "" || txtMatkhau.Text == "Please Enter Your Password")
            {
                txtMatkhau.UseSystemPasswordChar = true;
                txtMatkhau.Text = "";
                txtMatkhau.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            if (txtMatkhau.Text.Length == 0)
            {
                txtMatkhau.UseSystemPasswordChar = false;
                txtMatkhau.Text = "Please Enter Your Password";
                txtMatkhau.ForeColor = SystemColors.GrayText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConnection frmCon = new frmConnection();
            frmCon.Show();
        }
    }
}
