using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class HocSinh
    {
        private string maHS;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string noiSinh;
        private string dienThoai;
        private string email;
        private string diaChi;

        public string MaHS { get => maHS; set => maHS = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public HocSinh(string mahs, string hoten,string gioitinh, DateTime ngaysinh, string noisinh, string dienthoai, string email, string diachi)
        {
            this.MaHS = mahs;
            this.HoTen = hoten;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaysinh;
            this.NoiSinh = noiSinh;
            this.DienThoai = dienthoai;
            this.Email = email;
            this.DiaChi = diachi;
        }
        public HocSinh (DataRow row)
        {
            this.MaHS = row["MaHS"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.NgaySinh = Convert.ToDateTime(row["NgSinh"]);
            this.NoiSinh = row["NoiSinh"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.Email = row["Email"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }
        public HocSinh(HocSinh hs)
        {
            this.MaHS = hs.MaHS;
            this.HoTen = hs.HoTen;
            this.GioiTinh = hs.GioiTinh;
            this.NgaySinh = hs.NgaySinh;
            this.NoiSinh = hs.NoiSinh;
            this.DienThoai = hs.DienThoai;
            this.Email = hs.Email;
            this.DiaChi = hs.DiaChi;
        }
    }
}
