using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTIM
{
    public abstract class BT1ProductManager : BT1Product
    {
        List<BT1ProductManager> ListProductManagers = new List<BT1ProductManager>();
        public void NhapThongTinSanPham()
        {
            Console.WriteLine("NHAP THONG TIN SAN PHAM");

            bool nhapTiep = true;
            do
            {
                BT1Product product = new BT1Product();

                bool checkProductCode = true;
                var productCode = "";
                do
                {
                    Console.Write("Ma San Pham: ");
                    productCode = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(productCode))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkProductCode = true;
                    }
                    else
                    {
                        checkProductCode = false;
                    }

                } while (checkProductCode);


                bool checkProductName = true;
                var productName = "";
                do
                {
                    Console.Write("Ten San Pham: ");
                    productName = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(productName))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkProductName = true;
                    }
                    else
                    {
                        checkProductName = false;
                    }

                } while (checkProductName);



                bool checkPrice = true;
                double price = 0;
                do
                {
                    Console.Write("Gia San Pham: ");
                    var strPrice = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(strPrice) || !CommonLibs.ValidationData.CheckIsNumberAndLessThanZeroDouble(strPrice))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkPrice = true;
                    }
                    else
                    {
                        checkPrice = false;
                        price = double.Parse(strPrice);
                    }

                } while (checkPrice);

                bool checkStock = true;
                int stock = 0;
                do
                {
                    Console.Write("So Luong Trong Kho: ");
                    var strStock = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(strStock) || !CommonLibs.ValidationData.CheckIsNumberAndLessThanZero(strStock))
                    {
                        Console.WriteLine("Input Error !!! Please Retry Input ");
                        checkStock = true;
                    }
                    else
                    {
                        checkStock = false;
                        stock = Int32.Parse(strStock);
                    }

                } while (checkStock);

                bool checkDiscountType = true;
                int discountType = 0;
                do
                {
                    Console.Write("Triet Khau Theo loai 1.Theo Tien   2.  Theo % :  ");
                    var strDiscountType = Console.ReadLine();
                    if (CommonLibs.ValidationData.CheckIsNullOrWhiteSpace(strDiscountType) || !CommonLibs.ValidationData.CheckIsNumberAndLessThanZero(strDiscountType))
                    {

                    }
                    else
                    {
                        if (Int32.Parse(strDiscountType) != 1 || Int32.Parse(strDiscountType) != 2)
                        {
                            Console.WriteLine("Input Error !!! Please Retry Input ");
                            checkDiscountType = true;
                        }
                        else
                        {
                            checkDiscountType = false;
                            stock = Int32.Parse(strDiscountType);
                        }

                    }

                } while (checkDiscountType);

                bool checkInputNhapTiep = true;
                do
                {
                    Console.Write("Ban Muon nhap tiep 1.Yes  0.No");
                    var tiepTucNhap = Console.ReadLine();
                    if (tiepTucNhap == "1")
                    {
                        nhapTiep = true;
                        checkInputNhapTiep = false;
                    }
                    else if (tiepTucNhap == "0")
                    {
                        nhapTiep = false;
                        checkInputNhapTiep = false;
                    }
                    else
                    {
                        Console.WriteLine("Input Error !  Xin Hay Nhap Lai");
                        checkInputNhapTiep = true;
                    }
                } while (checkInputNhapTiep);



            } while (nhapTiep);

        }
    }
}
