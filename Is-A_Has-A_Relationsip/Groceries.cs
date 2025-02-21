using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Groceries : Product
    {
        public DateTime ExpiryDate { get; set; }
        public double Weight { get; set; }

        public Groceries(string name, double price, string sku, Supplier supplier, DateTime expiryDate, double weight)
            : base(name, price, sku, supplier)
        {
            ExpiryDate = expiryDate;
            Weight = weight;
        }

        public override void DisplayProductInfo()
        {
            base.DisplayProductInfo();
            Console.WriteLine($"Expiry Date: {ExpiryDate.ToShortDateString()}, Weight: {Weight} kg");
        }
    }
}
