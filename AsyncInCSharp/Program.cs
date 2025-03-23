using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncInCSharp
{
    class Program
    {
        static async Task Main(string[] args)  // Make Main async
        {
            //Console.WriteLine("Main thread started ....");

            //Task task1 = Task1(); // Start Task1 without awaiting

            //Console.WriteLine("During task 1 sleeping period ....");  // Now this prints earlier

            //await task1;  // Await Task1 later

            //Console.WriteLine("Main thread ended ....");

            Console.WriteLine("🏠 You are at home.");

            // Start ordering food asynchronously
            Task<string> foodTask = OrderFoodAsync();

            // Meanwhile, do other tasks
            WatchTV();
            ReadBook();

            // Wait for the food to be delivered
            string food = await foodTask;
            Console.WriteLine($"🍽 Time to eat {food}!");
        }

        static async Task Task1()
        {
            Console.WriteLine("Task 1 started ....");
            await Task.Delay(10000);
            await Task2();  // Now Task2 will execute properly
            Console.WriteLine("Task 1 ended ....");
        }

        static async Task Task2()
        {
            Console.WriteLine("Task 2 started ....");
            await Task.Delay(2000); // Fixed: Used await Task.Delay instead of Thread.Sleep
            Console.WriteLine("Task 2 ended ....");
        }



        // Asynchronous task: Ordering food online
        static async Task<string> OrderFoodAsync()
        {
            Console.WriteLine("📲 Ordering food online...");
            await Task.Delay(5000);  // Simulating 5 seconds delay for food preparation
            Console.WriteLine("🚴 Food is delivered!");
            return "Pizza";
        }

        // Synchronous method: Watching TV
        static async Task WatchTV()
        {
            Console.WriteLine("📺 Watching TV while waiting...");
        }

        // Synchronous method: Reading a book
        static void ReadBook()
        {
            Console.WriteLine("📖 Reading a book while waiting...");
        }
    }
}
