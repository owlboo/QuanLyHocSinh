using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using xls = Microsoft.Office.Interop.Excel;

namespace QLHS
{
    public partial class frmHocsinh : Form
    {
        #region Constructor
        private string User = "";
        string[] temp = new string[5];
        private string filePath;
        #endregion
        public frmHocsinh()
        {
            InitializeComponent();
            loadStu();
            Reset.ResetAllControls(navigationPageAddHocSinh);
            lvNS.Hide();
            lvDC.Hide();
            lblCheckTen.Text = "";
            lblCheckSDT.Text = "";
            lblCheckDC.Text = "";
            lblCheckNS.Text = "";
            lblCheckEmail.Text = "";
        }
        #region Event
        private void txtMahocsinh_Enter(object sender, EventArgs e)
        {
            lblCheckMHS.ForeColor = SystemColors.GrayText;
            lblCheckMHS.Text = "Mã học sinh có dạng: HSxxxx";
        }

        private void txtMahocsinh_Leave(object sender, EventArgs e)
        {
            if (txtMahocsinh.TextLength == 0)
            {
                lblCheckMHS.ForeColor = Color.Red;
                lblCheckMHS.Text = "Bạn chưa mã tên học sinh";
            }
        }

        private void txtTenhocsinh_Enter(object sender, EventArgs e)
        {
            lblCheckTen.Text = "";
        }

        private void txtTenhocsinh_Leave(object sender, EventArgs e)
        {
            if (txtTenhocsinh.TextLength == 0)
            {
                lblCheckTen.ForeColor = Color.Red;
                lblCheckTen.Text = "Bạn chưa nhập tên học sinh";
            }
        }

        private void txbSoDienThoai_Enter(object sender, EventArgs e)
        {
            lblCheckSDT.Text = "";
        }

        private void txbSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txbSoDienThoai.TextLength == 0)
            {
                lblCheckSDT.ForeColor = Color.Red;
                lblCheckSDT.Text = "Bạn chưa nhập số điện thoại";
            }
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.TextLength == 0)
            {
                lblCheckEmail.ForeColor = Color.Red;
                lblCheckEmail.Text = "Bạn chưa nhập email";
            }
        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {
            lblCheckEmail.Text = "";
        }

        private void txtNoisinh_TextChanged(object sender, EventArgs e)
        {
            CheckType.GooglePlace(txtNoisinh, lvNS);
        }

        private void lvDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDC.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDC.SelectedItems[0];
                txbDiaChi.Text = itm.SubItems[0].Text;
                lvDC.Hide();
            }
        }

        private void txbDiaChi_Leave(object sender, EventArgs e)
        {
            lvDC.Hide();
            if (txbDiaChi.TextLength == 0)
            {
                lblCheckDC.ForeColor = Color.Red;
                lblCheckDC.Text = "Bạn chưa nhập địa chỉ";
            }
        }

        private void lvNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNS.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvNS.SelectedItems[0];
                txtNoisinh.Text = itm.SubItems[0].Text;
                lvNS.Hide();
            }
        }

        private void txtNoisinh_Leave(object sender, EventArgs e)
        {
            lvNS.Hide();
            if (txtNoisinh.TextLength == 0)
            {
                lblCheckNS.ForeColor = Color.Red;
                lblCheckNS.Text = "Bạn chưa nơi sinh";
            }
        }

        private void txbDiaChi_Enter(object sender, EventArgs e)
        {
            lblCheckDC.Text = "";
        }

        private void txtNoisinh_Enter(object sender, EventArgs e)
        {
            lblCheckNS.Text = "";
        }
        private void navigationPane1_Click(object sender, EventArgs e)
        {
            loadStu();
            Reset.ResetAllControls(navigationPageAddHocSinh);
            Reset.ResetFocus(txtMahocsinh, txtNhapthongtincantimkiem);
        }

        private void txtMahocsinh_TextChanged(object sender, EventArgs e)
        {
            if (txtMahocsinh.Text == "")
            {
                lblCheckMHS.Text = "Mã học sinh có dạng: HSxxxxx";
                lblCheckMHS.ForeColor = SystemColors.GrayText;
                picMHSOk.Hide();
                picMHSSai.Hide();
            }
            else
            {
                lblCheckMHS.Text = "";
                picMHSOk.Hide();
                picMHSSai.Hide();
            }
            if (HocSinhDAO.Instance.checkExistedStuByMaHS(CheckType.chuanHoaMa(txtMahocsinh.Text)))
            {
                lblCheckMHS.Text = "Mã học sinh đã tồn tại";
                lblCheckMHS.ForeColor = Color.Red;
                picMHSSai.Show();
                picMHSOk.Hide();
                //txtMagiaovien.Focus();
            }
            else
            {
                if (CheckType.Instance.CheckMaHS(CheckType.chuanHoaMa(txtMahocsinh.Text)))
                {
                    picMHSOk.Show();
                    picMHSSai.Hide();
                }
                else if (txtMahocsinh.Text != "")
                {
                    lblCheckMHS.Text = "Sai định dạng mã học sinh";
                    lblCheckMHS.ForeColor = Color.Red;
                    picMHSSai.Show();
                    picMHSOk.Hide();
                }
            }
        }

        private void txbSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (!CheckType.Instance.CheckIsPhone(txbSoDienThoai.Text) && txbSoDienThoai.Text != ""
           && txbSoDienThoai.Text != "Nhập số điện thoại")
            {
                lblCheckSDT.Text = "Sai định dạng số điện thoại ";
                lblCheckSDT.ForeColor = Color.Red;
                picFalse.Show();
                picOk.Hide();
            }

            else
            {
                lblCheckSDT.Text = "";
                picOk.Hide();
                picFalse.Hide();
            }
            if (CheckType.Instance.CheckIsPhone(txbSoDienThoai.Text))
            {
                lblCheckSDT.Text = "";
                picOk.Show();
                picFalse.Hide();
            }

        }


        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            if (!CheckType.Instance.CheckIsMail(txbEmail.Text) && txbEmail.Text != ""
                    && txbEmail.Text != "Nhập địa chỉ Email")
            {
                lblCheckEmail.Text = "Sai định dạng Email";
                lblCheckEmail.ForeColor = Color.Red;
                picEmailFalse.Show();
                picEmailOk.Hide();
            }

            else
            {
                lblCheckEmail.Text = "";
                picEmailOk.Hide();
                picEmailFalse.Hide();
            }
            if (CheckType.Instance.CheckIsMail(txbEmail.Text))
            {
                lblCheckEmail.Text = "";
                picEmailOk.Show();
                picEmailFalse.Hide();
            }
        }

        private void txtNhapthongtincantimkiem_Enter(object sender, EventArgs e)
        {
            if (txtNhapthongtincantimkiem.Text == "" || txtNhapthongtincantimkiem.Text == "Nhập thông tin cần tìm kiếm")
            {
                txtNhapthongtincantimkiem.Text = "";
                txtNhapthongtincantimkiem.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtNhapthongtincantimkiem_Leave(object sender, EventArgs e)
        {
            if (txtNhapthongtincantimkiem.Text.Length == 0)
            {
                txtNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
                txtNhapthongtincantimkiem.ForeColor = SystemColors.GrayText;
            }
        }

        private void txbDiaChi_TextChanged(object sender, EventArgs e)
        {         
           CheckType.GooglePlace(txbDiaChi,lvDC);
        }
        private void btnThemvaodanhsach_Click(object sender, EventArgs e)
        {

            if (Reset.CheckTextControl(navigationPageAddHocSinh)== true)
            {
                MessageBox.Show("Thông tin trống kìa !!!", "Thông báo");
                Reset.ChangeFocus(navigationPageAddHocSinh);
                return;
            }
            string maHS = CheckType.chuanHoaMa(txtMahocsinh.Text);
            string hoTen = CheckType.chuanHoaTen(txtTenhocsinh.Text);
            string gioiTinh = "";
            if (radNam.Checked)
            {
                gioiTinh = radNam.Text;
            }
            else if (radNu.Checked)
            {
                gioiTinh = radNu.Text;
            }
            
            DateTime ngaySinh = dtpNgaysinh.Value;
            string noiSinh = txtNoisinh.Text;
            string dienThoai = txbSoDienThoai.Text;
            string emaiL = txbEmail.Text;
            string diaChi = txbDiaChi.Text;
            if(!CheckType.Instance.CheckMaHS(maHS))
            {
                MessageBox.Show("Mã học sinh dạng HSXXXX (XXXX là số thứ tự) !!!", "Thông báo", MessageBoxButtons.OK);
                txtMahocsinh.ResetText();
                txtMahocsinh.Focus();
                return;
            }
            if (!CheckType.Instance.CheckIsPhone(dienThoai))
            {
                MessageBox.Show("Số điện thoại định dạng sai rồi !!!", "Thông báo", MessageBoxButtons.OK);
                txbSoDienThoai.Focus();
                return;
            }
            if (!CheckType.Instance.CheckIsMail(emaiL))
                {
                    MessageBox.Show("Email dạng email rồi !!!", "Thông báo", MessageBoxButtons.OK);
                    txbEmail.Focus();
                    return;
                }
                try
                {
                    if (!HocSinhDAO.Instance.checkExistedStuByMaHS(maHS))
                    {
                        HocSinhDAO.Instance.ThemHocSinh(maHS, hoTen, gioiTinh, ngaySinh, noiSinh, dienThoai, emaiL, diaChi);
                    //MessageBox.Show("Thêm thành công", "Thông báo");
                    toolStripProgressBar1.Minimum = 0;
                    toolStripProgressBar1.Maximum = 110;
                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Step = 10;
                    timer1.Start();
                    Reset.ResetAllControls(navigationPageAddHocSinh);
                        txtMahocsinh.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mã học sinh đã tồn tại! Vui lòng nhập vào một mã học sinh mới!", "Thông báo", MessageBoxButtons.OK);
                        txtMahocsinh.ResetText();
                    }
                    loadStu();
                }
                catch
                {
                    MessageBox.Show("Tuổi nhập vào phải lớn hơn "+QuidinhtuoiDAO.Instance.GetAgeMinByMaTruong()+" và nhỏ hơn "+QuidinhtuoiDAO.Instance.GetAgeMaxByMaTruong()+" tuổi quy định !", "Thông báo", MessageBoxButtons.OK);
                    dtpNgaysinh.Focus();
                }

        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
                string inputData = txtNhapthongtincantimkiem.Text;
            if (inputData == "" || inputData == "Nhập thông tin cần tìm kiếm")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK);
                txtNhapthongtincantimkiem.Focus();
                return;
            }

            if (!radTimtheomahocsinh.Checked && !radTimtheotenhocsinh.Checked)
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm", "Thông báo", MessageBoxButtons.OK);
            }
            else if (radTimtheomahocsinh.Checked)
            {


                        string mahs = CheckType.chuanHoaMa(inputData);
                        if (HocSinhDAO.Instance.checkExistedStuByMaHS(mahs))
                            picMHSFalse.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaHS,HoTen,GioiTinh,NgSinh,NoiSinh,DienThoai,Email,DiaChi FROM HocSinh WHERE MaHS = '" + mahs+"'");
                        else
                        {
                            MessageBox.Show("Học sinh không tồn tại !", "Thông báo");
                            Reset.ResetAllControls(navigationPage2);
                            txtNhapthongtincantimkiem.Focus();                           
                        }
            }
            else if (radTimtheotenhocsinh.Checked)
                {
                    if (HocSinhDAO.Instance.checkExistedStuByName(CheckType.chuanHoaTen(inputData)))
                        picMHSFalse.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaHS,HoTen,GioiTinh,NgSinh,NoiSinh,DienThoai,Email,DiaChi FROM HocSinh WHERE HoTen =N'" + inputData + "'");
                    else
                {
                    MessageBox.Show("Học sinh không tồn tại !", "Thông báo");
                    Reset.ResetAllControls(navigationPage2);
                    txtNhapthongtincantimkiem.Focus();
                }
                }
 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string mahs = CheckType.chuanHoaMa(picMHSFalse.CurrentRow.Cells["MaHS"].Value.ToString());
                string hoten = CheckType.chuanHoaTen(picMHSFalse.CurrentRow.Cells["HoTen"].Value.ToString());
                string gioitinh = picMHSFalse.CurrentRow.Cells["GioiTinh"].Value.ToString();
                DateTime ngaysinh = (DateTime)picMHSFalse.CurrentRow.Cells["NgSinh"].Value;
                string noisinh = picMHSFalse.CurrentRow.Cells["NoiSinh"].Value.ToString();
                string dienthoai = picMHSFalse.CurrentRow.Cells["DienThoai"].Value.ToString();
                string email = picMHSFalse.CurrentRow.Cells["Email"].Value.ToString();
                string diachi = picMHSFalse.CurrentRow.Cells["DiaChi"].Value.ToString();
                if (!CheckType.Instance.CheckMaHS(mahs))
                {
                    MessageBox.Show("Mã học sinh dạng HSXXXX (XXXX là số thứ tự) !!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (!CheckType.Instance.CheckIsMail(email))
                {
                    MessageBox.Show("Email dạng email rồi !!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (!CheckType.Instance.CheckIsPhone(dienthoai))
                {
                    MessageBox.Show("Số điện thoại định dạng sai rồi !!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (HocSinhDAO.Instance.updateHocSinh(mahs, hoten, gioitinh, ngaysinh, noisinh, dienthoai, email, diachi))
                {
                    MessageBox.Show("Đã thay đổi học sinh có mã " + mahs + " thành công !", "Thông báo", MessageBoxButtons.OK);
                    loadStu();
                    Reset.ResetFocus(txtMahocsinh, txtNhapthongtincantimkiem);
                }
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = 110;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Step = 10;
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Tuổi phải từ "+QuidinhtuoiDAO.Instance.GetAgeMinByMaTruong()+" đến "+QuidinhtuoiDAO.Instance.GetAgeMaxByMaTruong()+" tuổi !", "Thông báo", MessageBoxButtons.OK);
            }

}
        private void btnDelete_Click(object sender, EventArgs e)
        {

            string mshs = picMHSFalse.CurrentRow.Cells["MaHS"].Value.ToString();
            if (XepLopDAO.Instance.CheckExist(mshs) == false)
            {
                if (HocSinhDAO.Instance.deleteHocSinh(mshs))
                {
                    toolStripProgressBar1.Minimum = 0;
                    toolStripProgressBar1.Maximum = 110;
                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Step = 10;
                    timer1.Start();
                    //MessageBox.Show("Xóa thành công học sinh có mã " + mshs + " !", "Thông báo", MessageBoxButtons.OK);
                    loadStu();
                    Reset.ResetAllControls(navigationPage2);
                    Reset.ResetAllControls(navigationPageAddHocSinh);
                    Reset.ResetFocus(txtMahocsinh, txtNhapthongtincantimkiem);
                }
            }
            else
                MessageBox.Show("Học sinh đã có lớp, không thể xóa được!!", "Thông báo", MessageBoxButtons.OK);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Filter = "excel file |*.xls;*.xlsx";
            fDialog.FilterIndex = 1;
            fDialog.RestoreDirectory = true;
            fDialog.Title = "chon file excel import";
            fDialog.Multiselect = false;
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fDialog.FileName;
                readerxcel();
                loadStu();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value > 0 && toolStripProgressBar1.Value < 100)
            {
                toolStripStatusLabel1.Text = "Saving.....";
            }
            else if (toolStripProgressBar1.Value == 100)
            {
                toolStripStatusLabel1.Text = "Saved!!!";
            }
        }

        #endregion

        #region Func
        public void SaveU(string u)
        {
            this.User = u;
            string type = AccountDAO.Instance.GetType(User);
            if (!type.Equals("admin"))
            {
                navigationPageAddHocSinh.PageVisible = false;
                navigationPane1.SelectedPageIndex++;
                bindingNavigatorAddHS.Visible = false;
                picMHSFalse.ReadOnly = true;
            }
        }
        void loadStu()
        {
            picMHSFalse.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetHocSinh");
        }
        bool isNumber(string value)
        {
            foreach (Char item in value)
            {
                if (!Char.IsDigit(item))
                    return false;
            }
            return true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if Enter is pressed
            if (keyData == Keys.Enter)
            {
                // If there isn't any selected row, do nothing
                if (picMHSFalse.CurrentRow == null)
                {
                    return true;
                }

                // Display first cell's value
                picMHSFalse.CurrentCell = picMHSFalse.CurrentRow.Cells["MaHS"];
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void readerxcel()
        {
            if (filePath == null)
            {
                MessageBox.Show("chua chon file");
            }
            else
            {

                xls.Application excelapp;
                xls.Workbook wbook;
                excelapp = new xls.Application();
                try
                {
                    wbook = excelapp.Workbooks.Open(filePath);
                }
                catch
                {
                    MessageBox.Show("khong the mo file");
                    return;
                }

                //doc du lieu vao bang tam
                foreach (xls.Worksheet wsheet in excelapp.Worksheets)
                {
                    if (wsheet.Name == "Danh sách học sinh")
                        try
                        {
                            long i = 2;
                            do
                            {
                                //kiem tra xem co phai la dong cuoi cung
                                if (wsheet.Range["A" + i].Value == null && wsheet.Range["B" + i].Value == null)
                                {
                                    break;
                                }
                                else
                                {
                                    try
                                    {
                                        string mahs = CheckType.chuanHoaMa(wsheet.Range["A" + i].Text);
                                        string hoten = CheckType.chuanHoaTen(wsheet.Range["B" + i].Text);
                                        string gioitinh = wsheet.Range["C" + i].Text;
                                        DateTime ngaysinh = Convert.ToDateTime(wsheet.Range["D" + i].Text);
                                        string noisinh = wsheet.Range["H" + i].Text;
                                        string dienthoai = wsheet.Range["E" + i].Text;
                                        string email = wsheet.Range["F" + i].Text;
                                        string diachi = wsheet.Range["G" + i].Text;
                                        if (mahs == "" || hoten == "" || gioitinh == "" || ngaysinh == null || noisinh == "" || dienthoai == "" || email == "" || diachi == "")
                                        {
                                            MessageBox.Show("Có thông tin trống", "THÔNG BÁO");
                                            return;
                                        }
                                        else if (!CheckType.Instance.CheckMaHS(mahs))
                                        {
                                            MessageBox.Show("Định dạng mã học sinh dạng HSxxxxx với x là chữ số từ 0-9", "THÔNG BÁO");
                                            return;
                                        }
                                        else if (!CheckType.Instance.CheckIsPhone(dienthoai))
                                        {
                                            MessageBox.Show("Sai định dạng số điện thoại", "THÔNG BÁO");
                                            return;
                                        }
                                        else if (!CheckType.Instance.CheckIsMail(email))
                                        {
                                            MessageBox.Show("Sai định dạng email", "THÔNG BÁO");
                                            return;
                                        }
                                        else if (HocSinhDAO.Instance.checkExistedStuByMaHS(mahs))
                                        {
                                            MessageBox.Show("Học sinh này đã tồn tại", "THÔNG BÁO");
                                            return;
                                        }
                                        HocSinhDAO.Instance.ThemHocSinh(mahs, hoten, gioitinh, ngaysinh, noisinh, dienthoai, email, diachi);
                                        i = i + 1;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Tuổi nhập vào phải lớn hơn " + QuidinhtuoiDAO.Instance.GetAgeMinByMaTruong() + " và nhỏ hơn " + QuidinhtuoiDAO.Instance.GetAgeMaxByMaTruong() + " tuổi quy định !", "Thông báo", MessageBoxButtons.OK);
                                        break;
                                    }
                                }
                            }
                            while (true);
                        }
                        catch
                        {
                            MessageBox.Show("co loi khi thuc hien");
                        }
                }
                excelapp.Quit();
            }
        }
        #endregion



        
    }
}
