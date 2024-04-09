using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CShapT3H
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack MyStack4 = new Stack();
            HoaDon hd = new HoaDon();
            // Thực hiện thêm vài phần tử vào Stack thông qua hàm Push.
            MyStack4.Push("Education");
            MyStack4.Push("Free");
            MyStack4.Push("HowKteam");
            MyStack4.Push(1);
            MyStack4.Push(hd);





            Console.WriteLine("CHUONG TRINH QUAN LY HOA  DON BAN HANG !");
            bool inputIsNotCorrect = false;
            List<HoaDon> listHoaDon = new List<HoaDon>();
            do
            {
                Dictionary<string, string> t = new Dictionary<string, string>()
                {
                    {"s", "b" },
                    {"s", "b" }

                };


                



                var yeuCau = LoiChao();
                
                switch (yeuCau)
                {
                    case 1:
                        do
                        {
                            NhapHoaDon(listHoaDon);
                       


                        } while (true);
                       
                        break;
                    case 2:
                        XoaNo();
                        break;
                    case 3:
                        XuatHoaDon();
                        break;
                    case 4:
                        HienThiHoaDonNo();
                        break;
                    case 5:
                        XuatFileHoaDon();
                        break;
                    case 6:
                        inputIsNotCorrect = false;
                        break;

                    default:
                        inputIsNotCorrect = true;
                        break;
                }

            } while (inputIsNotCorrect);

           
          

        }
        public static int LoiChao()
        {
            try
            {
                Console.WriteLine("Xin Hay Nhap Lua Chon Duoi Day");
                Console.WriteLine(" 1 + Enter : Nhap Hoa Don");
                Console.WriteLine(" 2 + Enter : Xoa No");
                Console.WriteLine(" 3 + Enter : Xuat Hoa Don");
                Console.WriteLine(" 4 + Enter : Hien Thi Hoa  Don Con No");
                Console.WriteLine(" 5 + Enter : Xuat Hoa Don Het No ra File txt ");
                Console.WriteLine(" 6 + Enter : Thoat Chuong Trinh ");

                var yeuCau = Console.ReadLine();
                return Int32.Parse(yeuCau);
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public static void NhapHoaDon(List<HoaDon> listHoaDon)
        {
            int soLuongHoaDonInt = 0;
            bool kiemTraGiaTriNhap = true;
            do
            {
                try
                {
                    Console.Write("Hay Nhap So Luong Hoa Don Chinh Xac Can Nhap: ");
                    var soLuongHoaDon = Console.ReadLine();
                    soLuongHoaDonInt = Int32.Parse(soLuongHoaDon);
                    if (soLuongHoaDonInt > 0)
                    {
                        kiemTraGiaTriNhap = false;
                    }

                }
                catch (Exception)
                {

                }
            } while (kiemTraGiaTriNhap);

            var maHoaDon = "";
            for (int i = 0; i < soLuongHoaDonInt; i++)
            {
                bool kiemTraMaHoaDon = true;
                do
                {
                    Console.Write("Ma Hoa Don : ");
                    maHoaDon = Console.ReadLine();
                    char[] charArr = null;
                    if(Helper.checkNumberCharacter (maHoaDon,9, ref charArr))
                    {
                        foreach (var item in charArr)
                        {
                            if (Helper.checkIsNumber(item.ToString()))
                            {
                                kiemTraMaHoaDon = false;
                            }
                        }
                    }
                } while (kiemTraMaHoaDon);


                var ngayPhatHanhHD = "";
                bool kiemtraNgay = true;
                do
                {
                    
                    Console.Write("Ngay Phat Hanh Hoa Don Theo Dinh Dang dd/MM/YYYY : ");
                    ngayPhatHanhHD = Console.ReadLine();
                    
                    if (Helper.checkIsDateTimeFormat(ngayPhatHanhHD))
                    {
                        kiemtraNgay = false;
                    }
                    else
                    {
                        Console.WriteLine("Ban Da Nhap Sai, Vui Long Nhap Lai....");
                        kiemtraNgay = true;
                    }
                    
                } while (kiemtraNgay);



                int tongSoTienInt = 0;
                bool kiemTraTongSoTien = true;
                do
                {
                    
                    try
                    {
                        Console.Write("Tong So Tien : ");
                        var tongSoTien = Console.ReadLine();
                        tongSoTienInt = Int32.Parse(tongSoTien);
                        if(tongSoTienInt >= 0)
                        {
                            kiemTraTongSoTien = false;
                        }
                        else
                        {
                            kiemTraTongSoTien = true;
                        }
                        
                    }
                    catch (Exception)
                    {
                        kiemTraTongSoTien = true;
                        Console.WriteLine("Ban Da Nhap Sai, Vui Long Nhap Lai....");
                    }
                } while (kiemTraTongSoTien);


                int tongSoTienNoInt = 0;
                bool kiemTraTongSoTienNo = true;
                do
                {
                    
                    try
                    {
                        Console.Write("Tong So Tien No : ");
                        var tongSoTienNo = Console.ReadLine();
                        tongSoTienNoInt = Int32.Parse(tongSoTienNo);
                        if (tongSoTienNoInt >= 0) kiemTraTongSoTienNo = false;

                    }
                    catch (Exception)
                    {
                        kiemTraTongSoTienNo = true;
                        Console.WriteLine("Ban Da Nhap Sai, Vui Long Nhap Lai....");
                    }
                } while (kiemTraTongSoTienNo);

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
            }
            

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
