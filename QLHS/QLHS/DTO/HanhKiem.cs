using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class HanhKiem
    {
        private string maHK;
        private string loaiHK;

        public string MaHK { get => maHK; set => maHK = value; }
        public string LoaiHK { get => loaiHK; set => loaiHK = value; }
        public HanhKiem(string mahk,string loaihk)
        {
            this.MaHK = mahk;
            this.loaiHK = loaihk;
        }
        public HanhKiem(DataRow r)
        {
            this.MaHK = r["MaHK"].ToString();
            this.LoaiHK = r["LoaiHK"].ToString();
        }
    }
}
