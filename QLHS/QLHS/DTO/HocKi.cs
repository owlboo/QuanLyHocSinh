using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class HocKi
    {
        private int maHocKi;
        private string tenHocKi;

        public int MaHocKi { get => maHocKi; set => maHocKi = value; }
        public string TenHocKi { get => tenHocKi; set => tenHocKi = value; }

        public HocKi(int mahocki,string tenhocki)
        {
            this.MaHocKi = mahocki;
            this.TenHocKi = tenhocki;
        }
        public HocKi(DataRow row)
        {
            this.MaHocKi = (int)row["MaHocKi"];
            this.TenHocKi = row["TenHocKi"].ToString();
        }
    }
}
