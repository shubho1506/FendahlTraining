using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesignPattern;

namespace FactoryDesignPattern
{
    public interface IProduct
    {
        void Show();
    }

    public class ConcreteProductA : IProduct
    {
        public void Show() => Console.WriteLine("Product A created");
    }

    public class ConcreteProductB : IProduct
    {
        public void Show() => Console.WriteLine("Product B created");
    }

    //public class ProductFactory
    //{
    //    public static IProduct GetProduct(string type)
    //    {
    //        switch (type)
    //        {
    //            case "A":
    //                return new ConcreteProductA();
    //            case "B":
    //                return new ConcreteProductB();
    //            default:
    //                throw new ArgumentException("Invalid type");
    //        }
    //    }

    //}

    public static class ProductFactory
    {
        public static IProduct GetProduct(string type) =>
            type switch
            {
                "A" => new ConcreteProductA(),
                "B" => new ConcreteProductB(),
                _ => throw new ArgumentException($"Invalid type: {type}")
            };
    }

    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = ProductFactory.GetProduct("A");
            product.Show(); // Output: Product A created
        }
    }
}
