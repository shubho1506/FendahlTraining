using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    //2E-Commerce System - Functional Requirements

    //6.	Error Handling & Security:
    //o Custom exceptions: OutOfStockException, InvalidPaymentException, UserNotFoundException.
    //o Try-catch-finally for secure error handling.

    //7.	SOLID & Design Patterns:
    //o Separate classes for user, product, cart, and order.
    //o Factory Pattern for Customer & Admin roles.

    //8.	File Handling:
    //o Persist user, product, and order details.

    //9.	Console Application:
    //o Simulate a real-world e-commerce experience with LINQ, delegates, events, file handling, and exception management.

    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            ShoppingCart cart = new ShoppingCart();
            ProductService product = new ProductService();
            InventoryResponses responses = new InventoryResponses();

            User loggedInUser = null;

            while (true)
            {
                if (loggedInUser == null)
                {
                    Console.WriteLine("!!! Welcome to SDS Store !!! ");
                    Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter name : ");
                            string name = Console.ReadLine();
                            Console.Write("Enter email : ");
                            string email = Console.ReadLine();
                            Console.Write("Enter password : ");
                            string password = Console.ReadLine();
                            Console.Write("Enter user role (Admin/Customer) : ");
                            string role = Console.ReadLine();
                            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                userService.RegisterUser(name, email, password, UserRoles.Admin);
                            else
                                userService.RegisterUser(name, email, password, UserRoles.Customer);
                            break;
                        case "2":
                            Console.Write("Enter email : ");
                            string email1 = Console.ReadLine();
                            Console.Write("Enter password : ");
                            string password1 = Console.ReadLine();
                            loggedInUser = userService.LoginUser(email1, password1);
                            break;
                        case "3":
                            Console.WriteLine("Thank you for visiting!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                else
                {
                    if (loggedInUser.UserRole.Equals(UserRoles.Customer))
                    {
                        OrderService orderService = new OrderService(loggedInUser, cart, product);

                        Console.WriteLine($"\nWelcome, {loggedInUser.UserName}!");
                        Console.WriteLine("1. View Products\n2. Add to Cart\n3. View Cart\n4. Place Order\n5. Logout");
                        Console.Write("Enter your choice: ");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                orderService.ViewAllItems(); ;
                                break;
                            case "2":
                                Console.Write("Please enter product ID of product to add in your cart : ");
                                int productId = Convert.ToInt32(Console.ReadLine());
                                orderService.AddProductToCart(productId);
                                break;
                            case "3":
                                orderService.ViewOrderItems();
                                break;
                            case "4":
                                orderService.PlaceOrder();
                                break;
                            case "5":
                                loggedInUser = null;
                                Console.WriteLine("Logged out successfully.");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;
                        }
                    }
                    else
                    {
                        InventoryServices inventory = new InventoryServices(product, responses);
                        Console.WriteLine($"\nWelcome {loggedInUser.UserRole}, {loggedInUser.UserName}!");
                        Console.WriteLine("1. Check All Stock \n2. Check Stocks By Category\n3. Add Product\n4. Logout");
                        Console.Write("Enter your choice: ");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                try
                                {
                                    inventory.CheckOnAllStocks();
                                }
                                catch(OutOfStockException e)
                                {
                                    Console.WriteLine(e);
                                }
                                break;
                            case "2":
                                Console.Write("Please enter category of product to check in your inventory : ");
                                string category = Console.ReadLine();
                                if (Enum.TryParse(category, true, out ProductCategories Pcategories))
                                {
                                    inventory.CheckOnStocks(Pcategories); ;
                                }
                                break;
                            case "3":
                                Console.Write("Enter name of Product : ");
                                string Pname = Console.ReadLine();
                                Console.Write("Enter category of Product(Electronics/Clothing/Books/HomeAppliances) : ");
                                string Pcategory = Console.ReadLine();
                                Console.Write("Enter price of Product : ");
                                decimal price = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Enter stock of Product : ");
                                int stock = Convert.ToInt32(Console.ReadLine());
                                if (Enum.TryParse(Pcategory, true, out ProductCategories categories))
                                {
                                    inventory.AddProduct(Pname, categories, price, stock);
                                }
                                break;
                            case "4":
                                loggedInUser = null;
                                Console.WriteLine("Logged out successfully.");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Try again.");
                                break;
                        }
                    }
                }
            }
        }
    }
}
