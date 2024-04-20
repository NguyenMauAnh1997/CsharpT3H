using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    class Bill
    {
        public string MaSanPham { set; get; }
        public string TenSanPham { set; get; }
        public int SoLuong { set; get; }
        public int DonGia { set; get; }
        public int ThanhTien { set; get; }

    }
}
