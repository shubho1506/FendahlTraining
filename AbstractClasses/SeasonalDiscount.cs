using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class SeasonalDiscount : Discount
    {
        public override void CalculateDiscount(decimal price)
        {
            Console.WriteLine($"The price of the product after Seasonal discount will be {price - (price*0.1m)} rs.");
        }
    }
}
