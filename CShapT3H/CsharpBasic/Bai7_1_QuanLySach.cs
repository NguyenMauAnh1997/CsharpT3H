using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    class Library
    {
        public static void AddBook(List<Book> books)
        {
            
            bool KiemTraSoLuongSach = true;
            var SoLuongSach = "";
            do
            {
                Console.Write("Hay Nhap vao So luong Sach muon them moi: ");
                SoLuongSach = Console.ReadLine();
                KiemTraSoLuongSach = MyCommonLibs.checkIsNumberAndLessThanZero(SoLuongSach);
            } while (!KiemTraSoLuongSach);

            var SoLuongSachInt = Int32.Parse(SoLuongSach);
            for (int i = 1; i <= SoLuongSachInt; i++)
            {
                Console.WriteLine("Hay Nhap Thong Tin Cuon Sach So " + i);

                bool CheckInputTitle = true;
                var title = "";
                do
                {
                    Console.Write("Hay Nhap Thong Tin title: ");
                    title = Console.ReadLine();
                    CheckInputTitle = string.IsNullOrWhiteSpace(title);
                } while (CheckInputTitle);

                bool CheckInputAuthor = true;
                var author = "";
                do
                {
                    Console.Write("Hay Nhap Thong Tin Author: ");
                    author = Console.ReadLine();
                    CheckInputAuthor = string.IsNullOrWhiteSpace(author);
                } while (CheckInputAuthor);

                bool CheckInputISBN = true;
                var iSBN = "";
                do
                {
                    Console.Write("Hay Nhap Thong Tin ISBN: ");
                    iSBN = Console.ReadLine();
                    CheckInputISBN = string.IsNullOrWhiteSpace(iSBN);
                } while (CheckInputISBN);

                bool CheckInputPrice = true;
                var price = "";
                do
                {
                    Console.Write("Hay Nhap Thong Tin ISBN: ");
                    price = Console.ReadLine();
                    CheckInputPrice = MyCommonLibs.checkIsNumberAndLessThanZero(price);

                } while (!CheckInputISBN);
                var priceLong = Int64.Parse(price);

                Book book = new Book();
                book.Author = author;
                book.Title = title;
                book.Price = priceLong;
                book.ISBN = iSBN;

                books.Add(book);


            }

        }

        public static void TimKiem(List<Book> books)
        {
            Console.WriteLine("Chuong trinh tim kiem sach theo ISBN");
            var iSBN = "";
            var checkInputISBN = true; 
            do
            {
                Console.Write("Hay Nhap thong tin ISBN cuon sach");
                iSBN = Console.ReadLine();
                checkInputISBN = string.IsNullOrWhiteSpace(iSBN);

            } while (checkInputISBN);

            int countLoopSearch = 0;
;           foreach (var item in books)
            {
                
                if (item.ISBN == iSBN)
                {
                    Console.WriteLine("Thong tin Cuon Sach ban tim la ");
                    Console.WriteLine("Title: " + item.Title);
                    Console.WriteLine("Author: " + item.Author);
                    Console.WriteLine("ISBN: " + item.ISBN);
                    Console.WriteLine("Price: " + item.Price);
                    countLoopSearch++;
                }
            }
            if(countLoopSearch == 0)
            {
                Console.WriteLine("Khong co cuon sach ban tim kiem !!!!");
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public long Price { get; set; }
    }
}
