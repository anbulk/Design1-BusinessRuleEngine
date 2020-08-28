using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PackagingSlipRule:IRule
    {
        public bool PostPaymentProcess(Order order)
        {
           if (order.Product.ProductCategory.Equals(ProductCategoryValue.Physical))
           {
                order.ProcessingOutcome.Add("generate packing slip for shipping");
                return true;
           }

            return false;

        }

    }
}
