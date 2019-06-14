using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class QuyDInhDiemDAO
    {
        private static QuyDInhDiemDAO instance;

        public static QuyDInhDiemDAO Instance
        {
            get { if (instance == null) instance = new QuyDInhDiemDAO(); return instance; }
            private set => instance = value;
        }
        private QuyDInhDiemDAO() { }

        public bool KiemTraDiem(string diem)
        {
            float diemso = float.Parse(diem);
            if (diemso < 0 || diemso > 10) return false;
            return true;
        }
    }
}
