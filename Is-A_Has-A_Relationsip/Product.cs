using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    //3 Problem:
    //Develop an e-commerce application where users can purchase products.
    //Each product should have common attributes like Name, Price, and SKU.
    //There should be different types of products like Electronics, Clothing, and Groceries, which inherit from a Product base class.
    //Additionally, each product should have a Supplier class that stores the supplier's name and contact details.
    //Solution Hint:
    //•	Create a Product base class with properties like Name, Price, and SKU.
    //•	Derive specific classes (Electronics, Clothing, Groceries) from the Product base class.
    //•	Create a Supplier class and use it as a composition inside the Product class.
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string SKU { get; set; }
        public Supplier ProductSupplier { get; set; } 

        public Product(string name, double price, string sku, Supplier supplier)
        {
            Name = name;
            Price = price;
            SKU = sku;
            ProductSupplier = supplier;
        }

        public virtual void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, SKU: {SKU}");
            ProductSupplier.DisplaySupplier();
        }
    }
}
