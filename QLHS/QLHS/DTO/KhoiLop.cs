using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class KhoiLop
    {
        private string maKhoiLop;
        private string tenKhoiLop;

        public string MaKhoiLop { get => maKhoiLop; set => maKhoiLop = value; }
        public string TenKhoiLop { get => tenKhoiLop; set => tenKhoiLop = value; }

        public KhoiLop(string makhoilop,string tenkhoilop)
        {
            this.MaKhoiLop = maKhoiLop;
            this.TenKhoiLop = tenkhoilop;
        }
        public KhoiLop(DataRow row)
        {
            this.MaKhoiLop = row["MaKhoiLop"].ToString();
            this.TenKhoiLop = row["TenKhoiLop"].ToString();
        }
    }
}
