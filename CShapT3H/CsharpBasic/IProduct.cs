using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    interface IProduct
    {
        void Product_Insert(Product product);
        void Product_Update();
        void Product_Search();
        void Product_Delete();
    }
}
