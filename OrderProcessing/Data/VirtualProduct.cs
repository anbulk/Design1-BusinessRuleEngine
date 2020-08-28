using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{

    public class VirtualProduct:Product
    {
        public VirtualProduct()
        {
            this.ProductCategory = ProductCategoryValue.Virtual;
        }
        
    }
}
