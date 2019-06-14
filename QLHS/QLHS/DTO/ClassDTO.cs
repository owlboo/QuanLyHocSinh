using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DTO
{
    class ClassDTO
    {
        public ClassDTO(string malop, string tenlop, string makhoilop, int siso, int loailop, string namhoc, string gvcn)
        {
            this.MaLop = malop;
            this.TenLop = tenlop;
            this.MaKhoiLop = makhoilop;
            this.SiSo = siso;
            this.LoaiLop = loailop;
            this.NamHoc = namhoc;
            this.GVCN = gvcn;
        }

        public ClassDTO(DataRow row)
        {
            this.MaLop = row["MaLop"].ToString();
            this.TenLop = row["TenLop"].ToString();
            this.MaKhoiLop = row["MaKhoiLop"].ToString();
            this.SiSo = (int)row["SiSo"];
            this.LoaiLop = (int)row["LoaiLop"];
            this.NamHoc = row["NamHoc"].ToString();
            this.GVCN = row["GVCN"].ToString();

        }

        private string maLop;

        private string tenLop;

        private string maKhoiLop;

        private int siSo;

        private int loaiLop;

        private string namHoc;

        private string gVCN;

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoiLop { get => maKhoiLop; set => maKhoiLop = value; }
        public int SiSo { get => siSo; set => siSo = value; }
        public int LoaiLop { get => loaiLop; set => loaiLop = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
        public string GVCN { get => gVCN; set => gVCN = value; }
    }
}
