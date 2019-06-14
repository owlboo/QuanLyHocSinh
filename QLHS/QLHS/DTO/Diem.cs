using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class Diem
    {
        private int maHS;
        private int maLop;
        private string hoTen;
        private string maMon;
        private string namHoc;
        private int hocKi;
        private float diemMieng;
        private float diem15P;
        private float diem1T;
        private float diemGK;
        private float diemCK;

        public int MaHS { get => maHS; set => maHS = value; }
        public int MaLop { get => maLop; set => maLop = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
        public int HocKi { get => hocKi; set => hocKi = value; }
        public float DiemMieng { get => diemMieng; set => diemMieng = value; }
        public float Diem15P { get => diem15P; set => diem15P = value; }
        public float Diem1T { get => diem1T; set => diem1T = value; }
        public float DiemGK { get => diemGK; set => diemGK = value; }
        public float DiemCK { get => diemCK; set => diemCK = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        public Diem(int mahs, string hoten, int malop, int hocki, string namhoc, float diemmieng, float diem15p, float diemgk, float diem1t, float diemck)
        {
            this.MaHS = maHS;
            this.HoTen = hoten;
            this.MaLop = malop;
            this.HocKi = hocki;
            this.NamHoc = namhoc;
            this.Diem15P = diem15p;
            this.DiemMieng = diemmieng;
            this.DiemGK = diemgk;
            this.Diem1T = diem1t;
            this.DiemCK = diemck;
        }
        //public Diem(DataRow row)
        //{
        //    this.MaHS = (int)row["MaHS"];
        //    this.MaLop = (int)row["MaLop"];
        //    this.HocKi = (int)row["HocKi"];
        //    this.NamHoc = row["NamHoc"].ToString();
        //    this.Diem15P = (float)row["diem15p"];
        //    this.DiemMieng = (float)row[""]
        //    this.DiemGK = diemgk;
        //    this.Diem1T = diem1t;
        //    this.DiemCK = diemck;
        //}
    }
}

