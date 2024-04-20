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
        List<Product> listProduct = new List<Product>();
        public ReturnData BuyProduct(Product product)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }

    }
}
