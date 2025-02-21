using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInCSharp
{
    //1. Problem Statement: Calculator with Multiple Add Methods
    //Task: Create a Calculator class with an Add method overloaded for different input types.
    //•	Requirement:
    //o One method should take two integers and return their sum.
    //o   Another method should take three doubles and return their sum.
    //o A third method should take an array of integers and return the sum of all elements.
    //•	Objective: Demonstrate how to provide different implementations for the same operation based on parameter types.
    class AddCalculator
    {
        public int add(int a,int b)
        {
            return a + b;
        }

        public double add(double a,double b,double c)
        {
            return a + b + c;
        }

        public int add(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
