using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    public class NamHoc
    {
        private string maNamHoc;
        private string tenNamHoc;

        public string MaNamHoc { get => maNamHoc; set => maNamHoc = value; }
        public string TenNamHoc { get => tenNamHoc; set => tenNamHoc = value; }

        public NamHoc(string manamhoc,string tennamhoc)
        {
            this.MaNamHoc = manamhoc;
            this.TenNamHoc = tennamhoc;
        }
        public NamHoc(DataRow row)
        {
            this.MaNamHoc = row["MaNamHoc"].ToString();
            this.TenNamHoc = row["TenNamHoc"].ToString();
        }
    }
}
