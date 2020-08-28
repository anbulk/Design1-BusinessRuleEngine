using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Book : PhysicalProduct
    {
        public ProductCategoryType ProductType { get; }
        public Book()
        {
            this.ProductType = ProductCategoryType.Book;
        }

    }
}
