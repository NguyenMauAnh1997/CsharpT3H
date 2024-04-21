using DataAccess.DTA;
using DataAccess.DTIM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bai 9 BT2.1 Nhap Thong Tin Khoa  Hoc
            StudentRegister studentRegister = new StudentRegister();
            studentRegister.InputInfoCource();

            //Bai 9 BT3
            ProductManage productManage = new ProductManage();
            productManage.BuyProduct();

            Console.ReadLine();
        }
    }
}
