using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel;

namespace QLHS
{
    public partial class frmNhapdiemchung : Form
    {
        #region Constructor
        private BindingSource bd = new BindingSource();
        int[,] STT;
        private DataTable oTbl = new DataTable();
        private string filePath = "";
        #endregion
        public frmNhapdiemchung()
        {
            InitializeComponent();
            dGVNhapdiemchung.DataSource = bd;
        }
        #region Event
        private void frmNhapdiemchung_Load(object sender, EventArgs e)
        {
            //bd.DataSource = DiemDAO.Instance.GetMaHSFromBangDiem();
            LoadIncbNamHocClass(cmbNamhoc1);
            LoadIncbHocKiClass(cmbHocky1);
            bindingNavigatorBangDiem.BindingSource = bd;
            STT = null;
            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.Name = "cbxUpdate";
            //checkBoxColumn.HeaderText = "Cập nhật";
            //dGVNhapdiemchung.Columns.Add(checkBoxColumn);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 110;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Step = 10;
            timer1.Start();
            if (cmbLop1.SelectedValue != null)
            {
                if (DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiemmieng") == true &&
                    DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiem15phut") == true &&
                    DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiem45phut") == true &&
                    DiemDAO.Instance.KiemTraDiem(dGVNhapdiemchung, "colDiemthi") == true
                    )
                {

                    int rowcount = 0;
                    foreach (DataGridViewRow row in dGVNhapdiemchung.Rows)
                    {
                        //    if (Convert.ToBoolean(row.Cells["cbxUpdate"].Value) == false && STT == null)
                        //    {

                        //        #region DiemMieng
                        //        if (row.Cells["colDiemmieng"].Value != null)
                        //                {
                        //                    string ChuoiChuaXuLy = row.Cells["colDiemmieng"].Value.ToString();
                        //                    string ChuoiDaXuLy = "";

                        //                    int count = 0;
                        //                    for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                        //                    {
                        //                        if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                        //                            count++;
                        //                        else
                        //                        {
                        //                            if (i == ChuoiChuaXuLy.Length - 1)
                        //                            {
                        //                                i++;
                        //                                count++;
                        //                            }
                        //                            ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                        //                            if (ChuoiDaXuLy != "")
                        //                            {
                        //                                DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                        //                                                           cmbLop1.SelectedValue.ToString(), "M", float.Parse(ChuoiDaXuLy.ToString()),
                        //                                                           Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                        //                            }
                        //                            ChuoiDaXuLy = null;
                        //                            count = 0;
                        //                        }
                        //                    }
                        //                }
                        //                #endregion

                        //        #region Diem15P

                        //                if (row.Cells["colDiem15phut"].Value != null)
                        //                {
                        //                    string ChuoiChuaXuLy = row.Cells["colDiem15phut"].Value.ToString();
                        //                    string ChuoiDaXuLy = "";

                        //                    int count = 0;
                        //                    for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                        //                    {
                        //                        if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                        //                            count++;
                        //                        else
                        //                        {
                        //                            if (i == ChuoiChuaXuLy.Length - 1)
                        //                            {
                        //                                i++;
                        //                                count++;
                        //                            }
                        //                            ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                        //                            if (ChuoiDaXuLy != "")
                        //                            {
                        //                                DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                        //                                                           cmbLop1.SelectedValue.ToString(), "15P", float.Parse(ChuoiDaXuLy.ToString()),
                        //                                                           Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                        //                            }
                        //                            ChuoiDaXuLy = null;
                        //                            count = 0;
                        //                        }
                        //                    }
                        //                }

                        //                #endregion

                        //        #region Diem45p

                        //                if (row.Cells["colDiem45phut"].Value != null)
                        //                {
                        //                    string ChuoiChuaXuLy = row.Cells["colDiem45phut"].Value.ToString();
                        //                    string ChuoiDaXuLy = "";

                        //                    int count = 0;
                        //                    for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                        //                    {
                        //                        if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                        //                            count++;
                        //                        else
                        //                        {
                        //                            if (i == ChuoiChuaXuLy.Length - 1)
                        //                            {
                        //                                i++;
                        //                                count++;
                        //                            }
                        //                            ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                        //                            if (ChuoiDaXuLy != "")
                        //                            {
                        //                                DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                        //                                                           cmbLop1.SelectedValue.ToString(), "45P", float.Parse(ChuoiDaXuLy.ToString()),
                        //                                                           Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                        //                            }
                        //                            ChuoiDaXuLy = null;
                        //                            count = 0;
                        //                        }
                        //                    }
                        //                }

                        //                #endregion

                        //        #region DiemThi
                        //                if (row.Cells["colDiemthi"].Value != null)
                        //                {
                        //                    string ChuoiChuaXuLy = row.Cells["colDiemthi"].Value.ToString();
                        //                    string ChuoiDaXuLy = "";

                        //                    int count = 0;
                        //                    for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                        //                    {
                        //                        if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                        //                            count++;
                        //                        else
                        //                        {
                        //                            if (i == ChuoiChuaXuLy.Length - 1)
                        //                            {
                        //                                i++;
                        //                                count++;
                        //                            }
                        //                            ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                        //                            if (ChuoiDaXuLy != "")
                        //                            {
                        //                                DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                        //                                                           cmbLop1.SelectedValue.ToString(), "THI", float.Parse(ChuoiDaXuLy.ToString()),
                        //                                                           Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                        //                            }
                        //                            ChuoiDaXuLy = null;
                        //                            count = 0;
                        //                        }
                        //                    }
                        //                }
                        //                #endregion

                        //        #region LuuKQ
                        //                //if (!DiemDAO.Instance.CheckHSInBangDiemMon(row.Cells["colMahocsinh"].Value.ToString(), cmbMonHoc1.SelectedValue.ToString()))
                        //                //{
                        //                KQMonHocHocKiDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString(), Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString());

                        //                KQMonHocCaNamDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString());

                        //                KQTongHopHocKiDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), "T", cmbNamhoc1.SelectedValue.ToString());

                        //                KQTongHopDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString(), "T");
                        //                //}
                        //                #endregion
                        //    }
                        if (STT != null)
                        {
                            //DiemDAO.Instance.XoaDIem(row.Cells["colMahocsinh"].Value.ToString());

                            #region DiemMieng
                            if (row.Cells["colDiemmieng"].Value != null)
                            {
                                string ChuoiChuaXuLy = row.Cells["colDiemmieng"].Value.ToString();
                                string ChuoiDaXuLy = "";

                                int count = 0;
                                for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                {
                                    if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                        count++;
                                    else
                                    {
                                        if (i == ChuoiChuaXuLy.Length - 1)
                                        {
                                            i++;
                                            count++;
                                        }
                                        ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                        if (ChuoiDaXuLy != "")
                                        {
                                            DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                       cmbLop1.SelectedValue.ToString(), "M", float.Parse(ChuoiDaXuLy.ToString()),
                                                                       Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                        }
                                        ChuoiDaXuLy = null;
                                        count = 0;
                                    }
                                }
                            }
                            #endregion

                            #region Diem15P

                            if (row.Cells["colDiem15phut"].Value != null)
                            {
                                string ChuoiChuaXuLy = row.Cells["colDiem15phut"].Value.ToString();
                                string ChuoiDaXuLy = "";

                                int count = 0;
                                for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                {
                                    if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                        count++;
                                    else
                                    {
                                        if (i == ChuoiChuaXuLy.Length - 1)
                                        {
                                            i++;
                                            count++;
                                        }
                                        ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                        if (ChuoiDaXuLy != "")
                                        {
                                            DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                       cmbLop1.SelectedValue.ToString(), "15P", float.Parse(ChuoiDaXuLy.ToString()),
                                                                       Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                        }
                                        ChuoiDaXuLy = null;
                                        count = 0;
                                    }
                                }
                            }

                            #endregion

                            #region Diem45p

                            if (row.Cells["colDiem45phut"].Value != null)
                            {
                                string ChuoiChuaXuLy = row.Cells["colDiem45phut"].Value.ToString();
                                string ChuoiDaXuLy = "";

                                int count = 0;
                                for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                {
                                    if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                        count++;
                                    else
                                    {
                                        if (i == ChuoiChuaXuLy.Length - 1)
                                        {
                                            i++;
                                            count++;
                                        }
                                        ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                        if (ChuoiDaXuLy != "")
                                        {
                                            DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                       cmbLop1.SelectedValue.ToString(), "45P", float.Parse(ChuoiDaXuLy.ToString()),
                                                                       Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                        }
                                        ChuoiDaXuLy = null;
                                        count = 0;
                                    }
                                }
                            }

                            #endregion

                            #region DiemThi
                            if (row.Cells["colDiemthi"].Value != null)
                            {
                                string ChuoiChuaXuLy = row.Cells["colDiemthi"].Value.ToString();
                                string ChuoiDaXuLy = "";

                                int count = 0;
                                for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                                {
                                    if (ChuoiChuaXuLy[i] != ';' && ChuoiChuaXuLy[i] != ' ' && i != ChuoiChuaXuLy.Length - 1)
                                        count++;
                                    else
                                    {
                                        if (i == ChuoiChuaXuLy.Length - 1)
                                        {
                                            i++;
                                            count++;
                                        }
                                        ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                                        if (ChuoiDaXuLy != "")
                                        {
                                            DiemDAO.Instance.LuuDiem(row.Cells["colMahocsinh"].Value.ToString(),
                                                                       cmbLop1.SelectedValue.ToString(), "THI", float.Parse(ChuoiDaXuLy.ToString()),
                                                                       Int32.Parse(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                        }
                                        ChuoiDaXuLy = null;
                                        count = 0;
                                    }
                                }
                            }
                            #endregion

                            #region LuuKQ
                            //if (!DiemDAO.Instance.CheckHSInBangDiemMon(row.Cells["colMahocsinh"].Value.ToString(), cmbMonHoc1.SelectedValue.ToString()))
                            //{
                            KQMonHocHocKiDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString(), Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString());

                            KQMonHocCaNamDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString());

                            KQTongHopHocKiDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), "T", cmbNamhoc1.SelectedValue.ToString());

                            KQTongHopDAO.Instance.LuuKetQua(row.Cells["colMahocsinh"].Value.ToString(), cmbLop1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString(), "T");
                            //}
                            #endregion

                            #region Xóa các kết quả cũ
                            if (STT != null)
                            {
                                for (int i = 1; i < QuyDinhSiSoDAO.Instance.GetSiSoMax(); i++)
                                    for (int j = 1; j < 20; j++)
                                    {
                                        int id = STT[i, j];
                                        if (id > 0)
                                            DiemDAO.Instance.XoaDIem(id);
                                        else
                                            break;
                                    }
                            }
                            #endregion
                        }
                    }
                }
                else MessageBox.Show("Sai định dạng điểm !!!", "Thông báo");
                //MessageBox.Show("Đã Lưu Thành Công", "Thông báo");
            }
            else MessageBox.Show("Chưa chọn lớp kìa !!!!");
            HienThiDanhSachBangDiemHocSinh();
        }
        private void cmbNamhoc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoc1.SelectedValue != null)
            {
                cmbLop1.DataSource = null;
                LoadIncbClass(cmbNamhoc1.SelectedValue.ToString(), cmbLop1);

            }

        }

        private void cmbLop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop1.SelectedValue != null)
                LoadIncbMonHoc(cmbMonHoc1);
        }

        private void cmbHocky1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMonHoc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop1.SelectedValue != null && cmbMonHoc1.SelectedValue != null && cmbNamhoc1.SelectedValue != null)
                bd.DataSource = HocSinhDAO.Instance.GetHocSinhByMaLopAndNamHoc(cmbLop1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString());
        }
        private void btnHiemthidanhsach1_Click(object sender, EventArgs e)
        {
            HienThiDanhSachBangDiemHocSinh();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 110;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Step = 10;
            timer1.Start();

            for (int i = 0; i < dGVNhapdiemchung.Rows.Count; i++)
            {
                string mahs = dGVNhapdiemchung.Rows[i].Cells["colMahocsinh"].Value.ToString();
                if (mahs == "")
                {
                    MessageBox.Show("Trống rồi không thể xóa", "Thông báo");
                    return;
                }
                if (dGVNhapdiemchung.Rows[i].Cells["colMahocsinh"].Selected ||
                    dGVNhapdiemchung.Rows[i].Cells["colTenhocsinh"].Selected ||
                    dGVNhapdiemchung.Rows[i].Cells["colDiem15phut"].Selected ||
                    dGVNhapdiemchung.Rows[i].Cells["colDiemmieng"].Selected ||
                    dGVNhapdiemchung.Rows[i].Cells["colDiem45phut"].Selected ||
                    dGVNhapdiemchung.Rows[i].Cells["colDiemthi"].Selected ||
                    dGVNhapdiemchung.Rows[i].Selected)
                    DiemDAO.Instance.XoaDIem(mahs);
            }
            //MessageBox.Show("Xóa thành công", "Thông báo");
            HienThiDanhSachBangDiemHocSinh();
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

        public void HienThiDanhSachBangDiemHocSinh()
        {
            STT = new int[QuyDinhSiSoDAO.Instance.GetSiSoMax(), 20];
            if (cmbLop1.SelectedValue != null && cmbNamhoc1.SelectedValue != null && cmbMonHoc1.SelectedValue != null)
                bd.DataSource = HocSinhDAO.Instance.GetHocSinhByMaLopAndNamHoc(cmbLop1.SelectedValue.ToString(), cmbNamhoc1.SelectedValue.ToString());
            int countRowHocSinh = 0;
            foreach (DataGridViewRow rowHocSinh in dGVNhapdiemchung.Rows)
            {
                countRowHocSinh++;
                String[] diemMieng = new String[10];
                String[] diem15Phut = new String[10];
                String[] diem45Phut = new String[10];
                String diemThi = "";

                int soDiemMieng = 0;
                int soDiem15Phut = 0;
                int soDiem45Phut = 0;

                DataTable m_data = DiemDAO.Instance.LayDanhSachDiem(rowHocSinh.Cells["colMahocsinh"].Value.ToString(),
                                                                    cmbLop1.SelectedValue.ToString(),
                                                                    cmbNamhoc1.SelectedValue.ToString(),
                                                                    Int32.Parse(cmbHocky1.SelectedValue.ToString()),
                                                                    cmbMonHoc1.SelectedValue.ToString());
                int countRowDiem = 0;
                foreach (DataRow rowDiem in m_data.Rows)
                {
                    countRowDiem++;
                    STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["ID"].ToString());
                    if (rowDiem["MaCotDiem"].ToString() == "M")
                        diemMieng[soDiemMieng++] = rowDiem["Diem"].ToString();
                    else if (rowDiem["MaCotDiem"].ToString() == "15P")
                        diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();
                    else if (rowDiem["MaCotDiem"].ToString() == "45P")
                        diem45Phut[soDiem45Phut++] = rowDiem["Diem"].ToString();
                    else if (rowDiem["MaCotDiem"].ToString() == "THI")
                        diemThi = rowDiem["Diem"].ToString();
                }
                rowHocSinh.Cells["colDiemMieng"].Value = CheckType.Instance.ArrayToString(diemMieng, soDiemMieng);
                rowHocSinh.Cells["colDiem15Phut"].Value = CheckType.Instance.ArrayToString(diem15Phut, soDiem15Phut);
                rowHocSinh.Cells["colDiem45Phut"].Value = CheckType.Instance.ArrayToString(diem45Phut, soDiem45Phut);
                rowHocSinh.Cells["colDiemThi"].Value = diemThi;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dGVNhapdiemchung.CurrentRow == null) return true;
                dGVNhapdiemchung.CurrentCell = dGVNhapdiemchung.CurrentRow.Cells["colMahocsinh"];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void LoadIncbNamHocClass(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NamHoc");
            cb.DisplayMember = "TenNamHoc";
            cb.ValueMember = "MaNamHoc";

        }
        public void LoadIncbHocKiClass(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HocKi");
            cb.DisplayMember = "TenHocKi";
            cb.ValueMember = "MaHocKi";

        }
        public void LoadIncbClass(string namhoc, ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE NamHoc = N'" + namhoc + "'");
            cb.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
        }
        public void LoadIncbMonHoc(ComboBox cb)
        {
            cb.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM MonHoc");
            cb.DisplayMember = "TenMon";
            cb.ValueMember = "MaMH";
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

                //tao bao tam de input
                //oTbl = new DataTable();
                //oTbl.Columns.Add("Mã học sinh", typeof(String));
                //oTbl.Columns.Add("Tên học sinh", typeof(String));
                //oTbl.Columns.Add("Điểm miệng", typeof(String));
                //oTbl.Columns.Add("Điểm 15 phút", typeof(String));
                //oTbl.Columns.Add("Điểm 45 phút", typeof(String));
                //oTbl.Columns.Add("Điểm thi", typeof(String));

                //doc du lieu vao bang tam
                foreach (xls.Worksheet wsheet in excelapp.Worksheets)
                {
                    if (wsheet.Name == "Bảng điểm học sinh")
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
                                if (!DiemDAO.Instance.CheckHSInBangDiemMon(wsheet.Range["A" + i].Text, cmbMonHoc1.SelectedValue.ToString()))
                                {
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "M", (float)Convert.ToDouble(wsheet.Range["C" + i].Text)
                                    , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "M", (float)Convert.ToDouble(wsheet.Range["D" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "M", (float)Convert.ToDouble(wsheet.Range["E" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "15P", (float)Convert.ToDouble(wsheet.Range["F" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "15P", (float)Convert.ToDouble(wsheet.Range["G" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "15P", (float)Convert.ToDouble(wsheet.Range["H" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "45P", (float)Convert.ToDouble(wsheet.Range["I" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "45P", (float)Convert.ToDouble(wsheet.Range["J" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "THI", (float)Convert.ToDouble(wsheet.Range["K" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    i = i + 1;
                                }
                                else
                                {
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "M", (float)Convert.ToDouble(wsheet.Range["C" + i].Text)
                                    , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "M", (float)Convert.ToDouble(wsheet.Range["D" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "M", (float)Convert.ToDouble(wsheet.Range["E" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "15P", (float)Convert.ToDouble(wsheet.Range["F" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "15P", (float)Convert.ToDouble(wsheet.Range["G" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "15P", (float)Convert.ToDouble(wsheet.Range["H" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "45P", (float)Convert.ToDouble(wsheet.Range["I" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "45P", (float)Convert.ToDouble(wsheet.Range["J" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());
                                    DiemDAO.Instance.LuuDiem(wsheet.Range["A" + i].Text, cmbLop1.SelectedValue.ToString(), "THI", (float)Convert.ToDouble(wsheet.Range["K" + i].Text)
                                       , Convert.ToInt32(cmbHocky1.SelectedValue.ToString()), cmbNamhoc1.SelectedValue.ToString(), cmbMonHoc1.SelectedValue.ToString());

                                    #region Xóa các kết quả cũ
                                    if (STT != null)
                                    {
                                        for (int h = 1; h < QuyDinhSiSoDAO.Instance.GetSiSoMax(); h++)
                                            for (int j = 1; j < 20; j++)
                                            {
                                                int id = STT[h, j];
                                                if (id > 0)
                                                    DiemDAO.Instance.XoaDIem(id);
                                                else
                                                    break;
                                            }
                                    }
                                    #endregion
                                    i++;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
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
                HienThiDanhSachBangDiemHocSinh();
            }
        }


    }
}
