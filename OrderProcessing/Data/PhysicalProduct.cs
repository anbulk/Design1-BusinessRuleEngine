using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PhysicalProduct : Product   {


        public PhysicalProduct()
        {
            this.ProductCategory = ProductCategoryValue.Physical;
        }
    }
}
