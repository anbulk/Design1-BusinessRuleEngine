using System;

namespace OrderProcessing
{
    public enum ProductCategoryValue { Virtual, Physical };
    public enum ProductCategoryType { Book, Membership };
    public class Product
    {
        public ProductCategoryValue ProductCategory { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }

    }
}
