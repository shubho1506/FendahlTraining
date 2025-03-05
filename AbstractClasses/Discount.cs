using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Scenario 2: Online Shopping Discount System
    //An e-commerce website offers different types of discounts:
    //Seasonal Discount
    //Festival Discount
    //Membership Discount
    //Each discount type has its own logic to calculate the discount on a given price.
    //Question:
    //Design an abstract class Discount with an abstract method CalculateDiscount(decimal price).
    //Implement SeasonalDiscount, FestivalDiscount, and MembershipDiscount classes.

    abstract class Discount
    {
        public abstract void CalculateDiscount(decimal price);
    }
}
