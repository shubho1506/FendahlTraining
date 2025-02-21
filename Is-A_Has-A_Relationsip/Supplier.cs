using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Supplier
    {
        public string SupplierName { get; set; }
        public string ContactInfo { get; set; }

        public Supplier(string supplierName, string contactInfo)
        {
            SupplierName = supplierName;
            ContactInfo = contactInfo;
        }

        public void DisplaySupplier()
        {
            Console.WriteLine($"Supplier: {SupplierName}, Contact: {ContactInfo}");
        }
    }
}
