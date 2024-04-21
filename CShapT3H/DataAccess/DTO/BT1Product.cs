using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class BT1Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public Double Price { get; set; }
        public int Stock { get; set; }
        public int DiscountType { set; get; }   // 1.Theo Tien   2.  Theo %
        public Double PriceAfteriscount { get; set; }


        public Double calculatorDiscount(BT1Product bT1Product)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return 0.1;
        }

    }
}
