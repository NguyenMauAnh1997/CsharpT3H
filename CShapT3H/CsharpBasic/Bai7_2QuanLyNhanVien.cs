using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    class Bai7_2QuanLyNhanVien
    {
    }
    public class QuanLyNhanVienToanThoiGian : NhanVien
    {
        public override void NhapNhanVien()
        {
            Console.WriteLine("Hay nhap so luong nhan vien Toan Thoi Gian muon them");


            
        }

        public override void TinhLuong()
        {

        }
    }
    public abstract class NhanVien {
        public string TenNhanVien { get; set; }
        public long Luong { get; set; }
        public abstract void NhapNhanVien();
        public abstract void TinhLuong();


    }

}
