using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProductPriceCalculator
{
    class TaxCategory
    {
        public double A = 6;
        public double B = 8;
        public double C = 10;

        public double getTaxPrice(string taxCategory)
        {
            if (taxCategory == "A")
            {
                return A;
            }else if(taxCategory == "B")
            {
                return B;
            }
            return C;
        }
    }
}
