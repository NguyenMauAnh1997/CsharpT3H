using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapT3H
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH QUAN LY HOA  DON BAN HANG !");
            bool inputIsNotCorrect = false;
            List<HoaDon> listHoaDon = new List<HoaDon>();
            do
            {
                LoiChao();
                var yeuCau = Console.ReadLine();
                switch (yeuCau)
                {
                    case "1":
                        do
                        {
                            NhapHoaDon(listHoaDon);
                            Console.WriteLine(" Ban Co Muon Tiep Tuc Nhap Hoa Don ? 1:Yes   2:No ");


                        } while (true);
                       
                        break;
                    case "2":
                        XoaNo();
                        break;
                    case "3":
                        XuatHoaDon();
                        break;
                    case "4":
                        HienThiHoaDonNo();
                        break;
                    case "5":
                        XuatFileHoaDon();
                        break;
                    case "6":
                        inputIsNotCorrect = false;
                        break;

                    default:
                        inputIsNotCorrect = true;
                        break;
                }

            } while (inputIsNotCorrect);

           
          

        }
        public static void LoiChao()
        {
            Console.WriteLine("Xin Hay Nhap Lua Chon Duoi Day");
            Console.WriteLine(" 1 + Enter : Nhap Hoa Don");
            Console.WriteLine(" 2 + Enter : Xoa No");
            Console.WriteLine(" 3 + Enter : Xuat Hoa Don");
            Console.WriteLine(" 4 + Enter : Hien Thi Hoa  Don Con No");
            Console.WriteLine(" 5 + Enter : Xuat Hoa Don Het No ra File txt ");
            Console.WriteLine(" 6 + Enter : Thoat Chuong Trinh ");
        }

        public static void NhapHoaDon(List<HoaDon> listHoaDon)
        {
            Console.WriteLine("Hay Nhap Thong Tin Hoa Don");
            Console.Write("Ma Hoa Don : ");
            var maHoaDon = Console.ReadLine();

            Console.Write("Ngay Phat Hanh Hoa Don : ");
            var ngayPhatHanhHD = Console.ReadLine();

            Console.Write("Tong So Tien : ");
            var tongSoTien = Console.ReadLine();
            var tongSoTienInt = Int32.Parse(tongSoTien);

            Console.Write("Tong So Tien No : ");
            var tongSoTienNo = Console.ReadLine();
            var tongSoTienNoInt = Int32.Parse(tongSoTienNo);

            var trangThaiNo = 0;
            if (tongSoTienNoInt > 0) trangThaiNo = 1;
            Console.Write("Ten Khach Hang : ");
            var tenKhachHang = Console.ReadLine();

            listHoaDon.Add(new HoaDon()
            {
                MaHoaDon = maHoaDon,
                NgayPhatHanhHD = ngayPhatHanhHD,
                TongSoTien = tongSoTienInt,
                TongSoTienNo = tongSoTienNoInt,
                TrangThaiNo = trangThaiNo,
                TenKhachHang = tenKhachHang
            });

            Console.WriteLine("********** Hoa Don Da Nhap Thanh Cong **********");
        }
        public static void XoaNo()
        {

        }
        public static void XuatHoaDon()
        {

        }
        public static void HienThiHoaDonNo()
        {

        }
        public static void XuatFileHoaDon()
        {

        }
    }
}
