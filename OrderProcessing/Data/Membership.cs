using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Membership:VirtualProduct
    {
        public ProductCategoryType ProductType { get; }
        public Membership()
        {
            this.ProductType = ProductCategoryType.Membership;
        }
        
    }
}
