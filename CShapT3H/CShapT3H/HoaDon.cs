using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapT3H
{
    public struct HoaDon
    {
        public string MaHoaDon { set; get; }
        public string NgayPhatHanhHD { set; get; }
        public int TongSoTien { set; get; }
        public int TongSoTienNo { set; get; }
        public int TrangThaiNo { set; get; } // 0 het no     1 con no
        public string TenKhachHang { set; get; }
    }
}
