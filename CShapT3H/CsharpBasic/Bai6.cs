using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CsharpBasic
{
    class Bai6
    {
        public static void Run()
        {

            Console.WriteLine("-----------BAI TAP BUOI 6-----------");

            bool kiemtra = true;
            do
            {
                Console.WriteLine("Xin hay chon Menu duoi day");
                Console.WriteLine("1 + Enter ---> Bai Tap 1");
                Console.WriteLine("2 + Enter ---> Bai Tap 2");
                Console.WriteLine("3 + Enter ---> Bai Tap 3");
                Console.WriteLine("4 + Enter ---> THOAT CHUONG TRINH");
                Console.WriteLine("------------------------------------");

                var buttonValue = Console.ReadLine();
                switch (buttonValue)
                {
                    case "1":
                        Bai1();
                        kiemtra = false;
                        break;
                    case "2":
                        kiemtra = false;
                        break;
                    case "3":
                        Bai3();
                        break;

                    default:
                        Console.WriteLine("Ban da nhap sai, xin vui long nhap lai .....");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                }
            } while (kiemtra);

            

        }

        public static void Bai1()
        {
            Console.WriteLine("Please Input With Menu : ");
            Console.WriteLine("1 + Enter ---> Add New Student");
            Console.WriteLine("2 + Enter ---> Edit Student Info");
            Console.WriteLine("3 + Enter ---> Delete Student");
            Console.WriteLine("4 + Enter ---> Search Student");
            Console.WriteLine("------------------------------------");

            List<SinhVien> listSinhVien = new List<SinhVien>();
            bool checkInput = true;
            do
            {
                var buttonValue = Console.ReadLine();
                switch (buttonValue)
                {
                    //Add New Studen
                    case "1":
                        MyGeneric<SinhVien>.addNew(listSinhVien);
                        checkInput = false;
                        break;
                    case "2":
                        checkInput = false;
                        break;
                    case "3":
                        Bai3();
                        break;

                    default:
                        Console.WriteLine("Input is Correct, Please Retry .....");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                }

            } while (checkInput);


            
            
        }
        public static void Bai3() {
            Console.WriteLine("---------------Bai Tap 3-----------------");
            Console.WriteLine("Xay dung generic method có tên là Swap<T>");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
            Thread.Sleep(500);
            Console.WriteLine("public static void Swap<T>(ref T a, ref T b)");
            Thread.Sleep(500);
            Console.WriteLine("{");
            Thread.Sleep(500);
            Console.WriteLine("    T temp = a;");
            Thread.Sleep(500);
            Console.WriteLine("    a = b;");
            Thread.Sleep(500);
            Console.WriteLine("    b = temp;");
            Thread.Sleep(500);
            Console.WriteLine("}");

        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
