using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class MonHoc
    {
        private string maMH;
        private string tenMon;

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public MonHoc(string mamh,string tenmh)
        {
            this.MaMH = mamh;
            this.TenMon = tenmh;
        }
        public MonHoc(DataRow r)
        {
            this.maMH = r["MaMH"].ToString();
            this.TenMon = r["TenMon"].ToString();
        }
    }
}
