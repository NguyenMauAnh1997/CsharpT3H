using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static void NhapNhanVien(List<nhanViencs> listNhanVien)
        {
            bool kiemTraDuLieuNhap = false;
            var soLuongNhanVien = "";
            do
            {
                Console.WriteLine("Hay Nhap So Luong Nhan Vien Muon Nhap");
                 soLuongNhanVien = Console.ReadLine();
                if (ChekIsNumber(soLuongNhanVien) == false)
                {
                    Console.WriteLine("Ban Da Nhap Sai Vui Long Nhap Lai");
                    kiemTraDuLieuNhap = true;
                }
            } while (kiemTraDuLieuNhap);
            Console.WriteLine("Hay Nhap Thong Tin Sau Day ");
            int soLuongNhanVienInt = Int32.Parse(soLuongNhanVien);

            for (int i = 0; i < soLuongNhanVienInt; i++)
            {
                Console.WriteLine("Hay Nhap Thong Tin Nhan Vien so 1: ");
                Console.Write("Ma Nhan Vien ");
                var maNhanVien = Console.ReadLine();
                Console.Write("Ho Dem ");
                var hoDem = Console.ReadLine();
                Console.Write("Ten Nhan Vien ");
                var ten = Console.ReadLine();
                Console.Write("Ngay Sinh ");
                var ngaySinh = Console.ReadLine();
                Console.Write("Ngay Vao Lam ");
                var ngayVaoLam = Console.ReadLine();

                var nhanVien = new nhanViencs();
                nhanVien.MaNhanVien = maNhanVien;
                nhanVien.HoDem = hoDem;
                nhanVien.NgaySinh = ngaySinh;
                nhanVien.NgayVaoLam = ngayVaoLam;

                listNhanVien.Add(nhanVien);
        }
    }
        private static bool ChekIsNumber(string number)
        {
            
            var isNumeric = int.TryParse(number, out int n);
           
                int changeNumber = Int32.Parse(number);
            if (changeNumber <= 0) return false;

            return isNumeric;
        }
    }
    
}
