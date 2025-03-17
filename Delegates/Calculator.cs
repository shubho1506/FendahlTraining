using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Problem 2: Simple Calculator with Delegates
    //Create a calculator using delegates for basic arithmetic operations.
    //Define a delegate CalculatorOperation that takes two integers and returns an integer.
    //Implement methods for Add, Subtract, Multiply, and Divide.
    //Use the delegate to perform operations dynamically based on user input.

    public delegate int CalculatorOperation(int a, int b);
    class Calculator
    {
        public CalculatorOperation Add = (x, y) => x + y;

        public CalculatorOperation Subtract = (x, y) => x - y;

        public CalculatorOperation Multiply = (x, y) => x * y;

        public CalculatorOperation Divide = (x, y) => x / y;
    }
}
