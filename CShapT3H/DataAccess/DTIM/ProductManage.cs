using DataAccess.DTI;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTA
{
    public class ProductManage : DTI.IProductManagerDTI
    {

        List<Product> listProduct = new List<Product>() {
        new Product()
        {
            ProductCode = "pr1",
            ProductName = "Kem Danh Rang",
            Price = 10000,
            Stock = 100
        },
        new Product()
        {
            ProductCode = "pr2",
            ProductName = "Dau Goi Dau",
            Price = 8000,
            Stock = 99
        },
        new Product()
        {
            ProductCode = "pr1",
            ProductName = "Sua Rua Mat",
            Price = 100000,
            Stock = 102
        }

        };
        List<Bill> listBill = new List<Bill>();

        public ReturnData BuyProduct()
        {

            ReturnData returnData = new ReturnData();
            try
            {
                //1. Hien Thi List SP
                ShowListProduct(listProduct);

                //2.Mua Hang
                bool muaTiep = true;
                do
                {
                    Buy();
                    Console.WriteLine("Ban Co Muon Mua Tiep Khong? 1.Yes  0.No");
                    var tiepTucMua = Console.ReadLine();
                    if (tiepTucMua == "1")
                    {
                        muaTiep = true;
                    }
                    else if (tiepTucMua == "0")
                    {
                        muaTiep = false;
                    }
                    else
                    {
                        Console.WriteLine("Input Error !  Xin Hay Nhap Lai");
                        muaTiep = true;
                    }
                } while (muaTiep);

                Console.WriteLine("");
                Console.WriteLine("------------THONG TIN DON HANG------------------------");
                //3. Show Bill and Caculator All
                ShowBill(listBill);

                returnData.ReturnCode = 1;
                returnData.ReturnMsg = "SUCCESS";
                return returnData;
            }
            catch (Exception)
            {
                returnData.ReturnCode = 0;
                returnData.ReturnMsg = "SYSTEM ERROR ! ";
                return returnData;
            }

        }

        private void ShowListProduct(List<Product> listProduct)
        {
            try
            {
                if (listProduct != null && listProduct.Count() > 0)
                {
                    Console.WriteLine("--------------Danh Sach San Pham ----------------");
                    foreach (var item in listProduct)
                    {

                        Console.WriteLine("Ma San Pham: " + item.ProductCode);
                        Console.WriteLine("Ten San Pham: " + item.ProductName);
                        Console.WriteLine("Gia San Pham: " + item.Price);
                        Console.WriteLine("So Luong Trong Kho(Warehouse): " + item.Stock);

                        Console.WriteLine("-------------");
                    }
                    Console.WriteLine("--------------------------------------------");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Khong co san pham trong KHO(WAREHOUSE)");
            }
        }

        private void ShowBill(List<Bill> listBill)
        {
            int tongSoLuongSp = 0;
            double tongSoTien = 0;
            if (listBill == null || listBill.Count() <= 0)
            {
                Console.WriteLine("System Error !  Please Contact to System Enginner ");
            }
            else
            {
                foreach (var item in listBill)
                {
                    Console.WriteLine("Ma SP: " + item.MaSanPham);
                    Console.WriteLine("Ten SP: " + item.TenSanPham);
                    Console.WriteLine("So Luong: " + item.SoLuong);
                    tongSoLuongSp += item.SoLuong;
                    Console.WriteLine("Thanh Tien: " + item.ThanhTien);
                    tongSoTien += (double)(item.ThanhTien);
                }
                if (tongSoLuongSp > 5)
                {
                    // Giam 5% Tong Bill
                    tongSoTien = tongSoTien * (0.95);
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("TONG SO TIEN CAN THANH TOAN SAU TRIET KHAU: "+ tongSoTien);
            }
        }

        private void Buy()
        {
            Bill bill = new Bill();
            bool checkMaSanPham = true;
            int stockSanPham = 0;
            do
            {
                Console.Write("Hay Nhap Ma San Pham can Mua: ");
                var strMaSanPham = Console.ReadLine();
                var searchSanPham = listProduct.Select(r => r.ProductCode).FirstOrDefault();
                if (searchSanPham == null)
                {
                    Console.WriteLine("Input Error !  Xin Hay Nhap Lai");
                    checkMaSanPham = true;
                }
                else
                {
                    bill.MaSanPham = strMaSanPham;
                    stockSanPham = listProduct.Select(r => r.Stock).FirstOrDefault();
                    checkMaSanPham = false;
                }

            } while (checkMaSanPham);


            Console.Write("Hay Nhap So Luong can Mua: ");
            bool checkInputSoluong = true;
            do
            {
                try
                {
                    bill.SoLuong = Int16.Parse(Console.ReadLine());

                    if (bill.SoLuong <= 0 || bill.SoLuong > stockSanPham)
                    {
                        Console.WriteLine("Input Error !  Xin Hay Nhap Lai");
                        checkInputSoluong = true;
                    }
                    else
                    {
                        checkInputSoluong = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Input Error !  Xin Hay Nhap Lai");
                    checkInputSoluong = true;
                }

            } while (checkInputSoluong);

            bill.TenSanPham = listProduct.Select(r => r.ProductName).FirstOrDefault();
            bill.DonGia = listProduct.Select(r => r.Price).FirstOrDefault();
            bill.ThanhTien = bill.DonGia * bill.SoLuong;

            listBill.Add(bill);
        }
    }
}
