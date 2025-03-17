using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    //2.	Product Management:
    //o Product class with ProductID, Name, Category, Price, StockQuantity.
    //o Filter and sort products using LINQ.
    class Product
    {
        internal int ProductID { get; set; }
        internal string ProductName { get; set; }
        internal ProductCategories ProductCategory { get; set; }
        internal decimal ProductPrice { get; set; }
        internal int ProductStockQuantity { get; set; }

        public Product(int id,string name, ProductCategories category, decimal price, int stock)
        {
            ProductID = id;
            ProductName = name;
            ProductCategory = category;
            ProductPrice = price;
            ProductStockQuantity = stock;
        }
    }
}
