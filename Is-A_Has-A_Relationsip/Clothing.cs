using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public Clothing(string name, double price, string sku, Supplier supplier, string size, string material)
            : base(name, price, sku, supplier)
        {
            Size = size;
            Material = material;
        }

        public override void DisplayProductInfo()
        {
            base.DisplayProductInfo();
            Console.WriteLine($"Size: {Size}, Material: {Material}");
        }
    }
}
