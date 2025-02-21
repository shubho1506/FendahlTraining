using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Electronics : Product
    {
        public string Brand { get; set; }
        public int WarrantyPeriod { get; set; }

        public Electronics(string name, double price, string sku, Supplier supplier, string brand, int warranty)
            : base(name, price, sku, supplier)
        {
            Brand = brand;
            WarrantyPeriod = warranty;
        }

        public override void DisplayProductInfo()
        {
            base.DisplayProductInfo();
            Console.WriteLine($"Brand: {Brand}, Warranty: {WarrantyPeriod} years");
        }
    }
}
