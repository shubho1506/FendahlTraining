using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class MembershipDiscount : Discount
    {
        public override void CalculateDiscount(decimal price)
        {
            Console.WriteLine($"The price of the product after Membership discount will be {price - (price * 0.3m)} rs.");
        }
    }
}
