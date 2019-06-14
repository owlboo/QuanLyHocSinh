using QLHS.DAO;
using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLHS
{
    public partial class frmGiaovien : Form
    {
        #region Constructor
        private string User = "";
        BindingSource bd = new BindingSource();
        BindingSource temp = new BindingSource();
        #endregion
        public frmGiaovien()
        {
            InitializeComponent();
            dGVGiaovien.DataSource = bd;
            Reset.ResetAllControls(navigationPage1);
            listView1.Hide();
            lblCheckTenGV.Text = "";
            lblCheckSDT.Text = "";
            lblCheckDC.Text = "";
        }
        #region Event
        private void txtTengiaovien_Enter(object sender, EventArgs e)
        {
            if (txtTengiaovien.Text == "")
            {
                txtTengiaovien.ForeColor = SystemColors.WindowText;
                lblCheckTenGV.Text = "";
            }
        }

        private void txtTengiaovien_Leave(object sender, EventArgs e)
        {
            if (txtTengiaovien.TextLength == 0)
            {
                lblCheckTenGV.ForeColor = Color.Red;
                lblCheckTenGV.Text = "Bạn chưa nhập tên giáo viên";
            }
            else
            {
                lblCheckTenGV.Text = "";
            }
        }

        private void txbDiaChi_Leave(object sender, EventArgs e)
        {
            if (txbDiaChi.TextLength == 0)
            {
                lblCheckDC.Show();
                lblCheckDC.ForeColor = Color.Red;
                lblCheckDC.Text = "Bạn chưa nhập địa chỉ";
            }
            listView1.Hide();
        }

        private void txbDiaChi_Enter(object sender, EventArgs e)
        {
            lblCheckDC.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                txbDiaChi.Text = itm.SubItems[0].Text;
                listView1.Hide();
            }
        }

        private void txtMagiaovien_Leave(object sender, EventArgs e)
        {
            if (txtMagiaovien.TextLength == 0)
            {
                lblCheckmaGV.ForeColor = Color.Red;
                lblCheckmaGV.Text = "Bạn chưa nhập mã giáo viên";
            }
        }

        private void txtMagiaovien_Enter(object sender, EventArgs e)
        {
            if (txtMagiaovien.Text == "")
            {
                lblCheckmaGV.ForeColor = SystemColors.GrayText;
                lblCheckmaGV.Text = "Mã giáo viên có dạng: GVxxx";
            }
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDienthoai_Enter(object sender, EventArgs e)
        {
            if (txtDienthoai.TextLength == 0)
            {
                lblCheckSDT.Text = "";
            }
        }

        private void txtDienthoai_Leave(object sender, EventArgs e)
        {
            if (txtDienthoai.TextLength == 0)
            {
                lblCheckSDT.ForeColor = Color.Red;
                lblCheckSDT.Text = "Bạn chưa nhập số điện thoại";
            }
        }

        private void txtDienthoai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txbDiaChi_TextChanged(object sender, EventArgs e)
        {
            CheckType.GooglePlace(txbDiaChi,listView1);
        }
        private void txtMagiaovien_TextChanged(object sender, EventArgs e)
        {
            if (txtMagiaovien.Text == "")
            {
                lblCheckmaGV.Text = "Mã giáo viên có dạng: GVxxx";
                lblCheckmaGV.ForeColor = SystemColors.GrayText;
                picMGVOk.Hide();
                picMGVFalse.Hide();
            }
            else
            {
                lblCheckmaGV.Text = "";
                picMGVOk.Hide();
                picMGVFalse.Hide();
            }
            if (GiaoVienDAO.Instance.CheckGiaoVienExist(CheckType.chuanHoaMa(txtMagiaovien.Text)))
            {
                lblCheckmaGV.Text = "Mã giáo viên đã tồn tại";
                lblCheckmaGV.ForeColor = Color.Red;
                picMGVFalse.Show();
                picMGVOk.Hide();
                //txtMagiaovien.Focus();
            }
            else
            {
                if (CheckType.Instance.CheckMaGV(CheckType.chuanHoaMa(txtMagiaovien.Text)))
                {
                    picMGVOk.Show();
                    picMGVFalse.Hide();
                }
                else if (txtMagiaovien.Text != "")
                {
                    lblCheckmaGV.Text = "Sai định dạng mã giáo viên";
                    lblCheckmaGV.ForeColor = Color.Red;
                    picMGVFalse.Show();
                    picMGVOk.Hide();
                }
            }
        }

        private void txtDienthoai_TextChanged(object sender, EventArgs e)
        {
            if (!CheckType.Instance.CheckIsPhone(txtDienthoai.Text) && txtDienthoai.Text.Length != 0)
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
            if (CheckType.Instance.CheckIsPhone(txtDienthoai.Text))
            {
                lblCheckSDT.Text = "";
                picOk.Show();
                picFalse.Hide();
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

        private void txtNhapthongtincantimkiem_Enter(object sender, EventArgs e)
        {
            if (txtNhapthongtincantimkiem.Text == "" || txtNhapthongtincantimkiem.Text == "Nhập thông tin cần tìm kiếm")
            {
                txtNhapthongtincantimkiem.Text = "";
                txtNhapthongtincantimkiem.ForeColor = SystemColors.WindowText;
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(txtNhapthongtincantimkiem.Text =="Nhập thông tin cần tìm kiếm")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm", "Thông báo");
                return;
            }
            if (radTimtheomagiaovien.Checked == false && radTimtheotengiaovien.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm", "Thông báo");
                return;
            }
            else
            {
                if (radTimtheomagiaovien.Checked)
                {
                    //temp.DataSource = SearchGVByMaGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                    //if (temp.DataSource == null)
                    //{
                    //    MessageBox.Show("Giáo viên không tồn tại");
                    //    LoadGiaoVien();
                    //    return;
                    //}
                    //else
                        bd.DataSource = SearchGVByMaGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                }
                else if (radTimtheotengiaovien.Checked)
                {
                //    temp.DataSource = SearchGVByTenGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                //    if (dGVGiaovien.RowCount == 0)
                //    {
                //        MessageBox.Show("Giáo viên không tồn tại");
                //        LoadGiaoVien();
                //        return;
                //    }
                //    else
                        bd.DataSource = SearchGVByTenGV(CheckType.chuanHoaMa(txtNhapthongtincantimkiem.Text));
                }
            }
            dGVGiaovien.DataSource = bd;
        }
        private void frmGiaovien_Load(object sender, EventArgs e)
        {
            bd.DataSource = GiaoVienDAO.Instance.LoadGiaoVien();
            bindingNavigatorGiaoVien.BindingSource = bd;
            LoadInCbMonHoc(cmbMamonhoc);
        }
        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVGiaovien.CurrentRow == null) return true;
                dGVGiaovien.CurrentCell = dGVGiaovien.CurrentRow.Cells["colMagiaovien"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnThemvaodanhsach_Click(object sender, EventArgs e)
        {
            string magv = CheckType.chuanHoaMa(txtMagiaovien.Text);
            string tengv = CheckType.chuanHoaTen(txtTengiaovien.Text);
            string sdt = txtDienthoai.Text;
            string diachi = txbDiaChi.Text;
            string mamh = cmbMamonhoc.SelectedValue.ToString();
            if (Reset.CheckTextControl(navigationPage1) == true)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thông báo");
                Reset.ChangeFocus(navigationPage1);
                return;
            }
            if (CheckType.Instance.CheckMaGV(magv) == false)
            {
                MessageBox.Show("Mã giáo viên có dạng GVXXX", "Thông báo");
                txtMagiaovien.ResetText();
                txtMagiaovien.Focus();
                return;
            }
            if (!CheckType.Instance.CheckIsPhone(sdt))
            {
                MessageBox.Show("Sai định dạng số điện thoại rồi !!!", "Thông báo");
                txtDienthoai.ResetText();
                txtDienthoai.Focus();
                return;
            }
            if (magv != null && tengv != null && sdt != null && diachi != null && mamh != null)
            {
                if (!GiaoVienDAO.Instance.CheckGiaoVienExist(magv))
                {
                    if (GiaoVienDAO.Instance.ThemGiaoVien(magv, tengv, sdt, diachi, mamh))
                    {
                        //MessageBox.Show("Thêm thành công!!", "Thông báo");
                        toolStripProgressBar1.Minimum = 0;
                        toolStripProgressBar1.Maximum = 110;
                        toolStripProgressBar1.Value = 0;
                        toolStripProgressBar1.Step = 10;
                        timer1.Start();
                        LoadGiaoVien();
                        Reset.ResetAllControls(navigationPage1);
                        txtMagiaovien.Focus();
                    }
                    else MessageBox.Show("Thêm thất bại!!", "Thông bóa");
                }
                else
                {
                    MessageBox.Show("Mã giáo viên đã tồn tại rồi !!!", "Thông báo");
                    txtMagiaovien.ResetText();
                    txtMagiaovien.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thông báo");
                //Reset.CheckTextControl(navigationPage1);
                //Reset.ChangeFocus(navigationPage1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string magv = dGVGiaovien.CurrentRow.Cells["colMagiaovien"].Value.ToString();
            if (magv != "")
            {
                if (ClassDAO.Instance.CheckGVCNinClass(magv) == false)
                {
                    if (GiaoVienDAO.Instance.XoaGiaoVien(magv))
                    {
                        //MessageBox.Show("Xóa thành công", "Thông báo");
                        toolStripProgressBar1.Minimum = 0;
                        toolStripProgressBar1.Maximum = 110;
                        toolStripProgressBar1.Value = 0;
                        toolStripProgressBar1.Step = 10;
                        timer1.Start();
                        LoadGiaoVien();
                    }
                    else MessageBox.Show("Xóa thất bại", "Thông báo");
                }
                else MessageBox.Show("Giáo viên hiện tại đã chủ nhiệm không thể xóa", "Thông báo");
            }
            else MessageBox.Show("Trống rồi sao xóa đây !!!", "Thông báo");
            Reset.ResetFocus(txtMagiaovien, txtNhapthongtincantimkiem);
        }
        private void navigationPaneAddGV_Click(object sender, EventArgs e)
        {
            LoadGiaoVien();
            Reset.ResetAllControls(navigationPage2);
            Reset.ResetFocus(txtMagiaovien, txtNhapthongtincantimkiem);
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
            User = u;
            string type = AccountDAO.Instance.GetType(User);
            if (!type.Equals("admin"))
            {
                navigationPage1.PageVisible = false;
                navigationPaneAddGV.SelectedPageIndex++;
                dGVGiaovien.ReadOnly = true;
                bindingNavigatorGiaoVien.Visible = false;
            }
        }
        public void SaveItem()
        {
            string magv = CheckType.chuanHoaMa(dGVGiaovien.CurrentRow.Cells["colMagiaovien"].Value.ToString());
            string tengv = CheckType.chuanHoaTen(dGVGiaovien.CurrentRow.Cells["colTengiaovien"].Value.ToString());
            string sdt = dGVGiaovien.CurrentRow.Cells["colDienthoai"].Value.ToString();
            string diachi = dGVGiaovien.CurrentRow.Cells["colDiachi"].Value.ToString();
            string mamh = GiaoVienDAO.Instance.ChangeTenMontoMaMH(dGVGiaovien.CurrentRow.Cells["colTenmonhoc"].Value.ToString());

            if (CheckType.Instance.CheckMaGV(magv) == false)
            {
                MessageBox.Show("Sai r");
                return;
            }
            if (!CheckType.Instance.CheckIsPhone(sdt))
            {
                MessageBox.Show("Sai định dạng số điện thoại rồi !!!", "Thông báo");
                return;
            }
            if (magv != null && tengv != null && sdt != null && diachi != null && mamh != null)
            {
                if (!GiaoVienDAO.Instance.CheckGiaoVienExist(magv))
                {
                    if (GiaoVienDAO.Instance.ThemGiaoVien(magv, tengv, sdt, diachi, mamh))
                    {
                        MessageBox.Show("Thêm thành công!!", "Thông báo");
                        LoadGiaoVien();
                    }
                    else MessageBox.Show("Thêm thất bại!!", "Thông bóa");
                }
                else
                {
                    if(GiaoVienDAO.Instance.SuaGiaoVien(magv,tengv,sdt,diachi,mamh))
                    {
                        MessageBox.Show("Sửa thành công!!", "Thông báo");
                        LoadGiaoVien();
                    }
                    else MessageBox.Show("Sửa thất bại!!", "Thông bóa");
                }
            }
            else MessageBox.Show("Trống thông tin rồi kìa hoặc thông tin sai định dạng nè !!", "Thông báo");
            Reset.ResetFocus(txtMagiaovien, txtNhapthongtincantimkiem);
        }
        public void LoadInCbMonHoc(ComboBox cb)
        {
            cb.DataSource = MonHocDAO.Instance.LoadMonHoc();
            cb.DisplayMember = "TenMon";
            cb.ValueMember = "MaMH";
        }
        public void LoadGiaoVien()
        {
           dGVGiaovien.DataSource = GiaoVienDAO.Instance.LoadGiaoVien();
        }
        public List<GiaoVien> SearchGVByMaGV(string magv)
        {
            return GiaoVienDAO.Instance.SearchGVByMaGV(magv);
        }
        public List<GiaoVien> SearchGVByTenGV(string tengv)
        {
            return  GiaoVienDAO.Instance.SearchGVByTenGV(tengv);
        }





        #endregion


    }
}
