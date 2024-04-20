using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Library.AddBook(books);
            //Bai6.Run();

            Console.ReadLine();
        }
    }
}
