using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Is_A_Has_A_Relationsip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem Statements for Applying \"Is-a\" and \"Has-a\" Relationships in C#");
            TMS();
            //SRMS();
            //EcomApp();
            //HRMS();
            //LMS();
            //BMS();
        }

        static void TMS()
        {
            Console.WriteLine("Transportation management system");

            Car myCar = new Car("ABC123", 180, 4);
            MotorBike myBike = new MotorBike("XYZ789", 120, false);
            BiCycle myCycle = new BiCycle("BIC456", 25, "Mountain Bike");

            myCar.DisplayDetails();
            myCar.StartEngine();
            Console.ReadLine();
            myBike.DisplayDetails();
            myBike.StartEngine();
            Console.ReadLine();
            myCycle.DisplayDetails();
            myCycle.StartEngine();
            Console.ReadLine();
        }

        static void SRMS()
        {
            Console.WriteLine("Student record management system");
            Console.Write("Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Roll Number: ");
                int rollNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Street: ");
                string street = Console.ReadLine();

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter State: ");
                string state = Console.ReadLine();

                Console.Write("Enter Postal Code: ");
                string postalCode = Console.ReadLine();

                Address address = new Address(street, city, state, postalCode);

                students[i] = new Student(name, rollNumber, address);
            }

            Console.WriteLine("\n--- Student Records ---");
            foreach (var student in students)
            {
                student.DisplayStudentInfo();
            }
        }

        static void EcomApp()
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter number of products: ");
            int productCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"\nEnter details for Product {i + 1}:");

                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Enter SKU: ");
                string sku = Console.ReadLine();

                Console.Write("Enter Supplier Name: ");
                string supplierName = Console.ReadLine();

                Console.Write("Enter Supplier Contact Info: ");
                string contactInfo = Console.ReadLine();

                Supplier supplier = new Supplier(supplierName, contactInfo);

                Console.WriteLine("Select Product Type (1. Electronics, 2. Clothing, 3. Groceries): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter Warranty Period (years): ");
                        int warranty = int.Parse(Console.ReadLine());
                        products.Add(new Electronics(name, price, sku, supplier, brand, warranty));
                        break;

                    case 2:
                        Console.Write("Enter Size: ");
                        string size = Console.ReadLine();
                        Console.Write("Enter Material: ");
                        string material = Console.ReadLine();
                        products.Add(new Clothing(name, price, sku, supplier, size, material));
                        break;

                    case 3:
                        Console.Write("Enter Expiry Date (yyyy-mm-dd): ");
                        DateTime expiryDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter Weight (kg): ");
                        double weight = double.Parse(Console.ReadLine());
                        products.Add(new Groceries(name, price, sku, supplier, expiryDate, weight));
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        i--; 
                        break;
                }
            }

            Console.WriteLine("\n--- Product Catalog ---");
            foreach (var product in products)
            {
                product.DisplayProductInfo();
                Console.WriteLine("---------------------------");
            }
            Console.ReadLine();
        }

        static void HRMS()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nChoose Employee Type: 1. Manager 2. Engineer 3. Intern");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Employee ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Salary: ");
                double salary = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Team Size: ");
                        int teamSize = int.Parse(Console.ReadLine());
                        employees.Add(new Manager(name, id, salary, teamSize));
                        break;
                    case 2:
                        Console.Write("Enter Specialization: ");
                        string specialization = Console.ReadLine();
                        employees.Add(new Engineer(name, id, salary, specialization));
                        break;
                    case 3:
                        Console.Write("Enter Internship Duration (months): ");
                        int duration = int.Parse(Console.ReadLine());
                        employees.Add(new Intern(name, id, salary, duration));
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        i--; // Retry input
                        break;
                }
            }

            Console.WriteLine("\nEmployee Details:");
            foreach (var emp in employees)
            {
                emp.DisplayInfo();
                Console.WriteLine("----------------------------");
            }
        }

        static void LMS()
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display All Books");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Publication Date (yyyy-mm-dd): ");
                        DateTime publicationDate = DateTime.Parse(Console.ReadLine());

                        Book newBook = new Book(title, author, publicationDate);
                        library.AddBook(newBook);
                        break;

                    case 2:
                        Console.Write("Enter Book Title to Remove: ");
                        string bookTitle = Console.ReadLine();
                        library.RemoveBook(bookTitle);
                        break;

                    case 3:
                        library.DisplayAllBooks();
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using Library Management System");
                    break;
                }
            }
        }

        static void BMS()
        {
            List<Account> accounts = new List<Account>();

            while (true)
            {
                Console.WriteLine("\nBanking System");
                Console.WriteLine("1. Create Savings Account");
                Console.WriteLine("2. Create Current Account");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Withdraw Money");
                Console.WriteLine("5. Display Account Details");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        accounts.Add(CreateAccount("savings"));
                        break;
                    case 2:
                        accounts.Add(CreateAccount("current"));
                        break;
                    case 3:
                        PerformTransaction(accounts, "deposit");
                        break;
                    case 4:
                        PerformTransaction(accounts, "withdraw");
                        break;
                    case 5:
                        DisplayAllAccounts(accounts);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using Library Management System");
                    break;
                }
            }
        }

        static Account CreateAccount(string type)
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Customer customer = new Customer(name, address, phone);

            if (type == "savings")
            {
                return new SavingsAccount(accountNumber, customer);
            }
            else
            {
                return new CurrentAccount(accountNumber, customer);
            }
        }

        static void PerformTransaction(List<Account> accounts, string type)
        {
            Console.Write("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Account account = accounts.Find(a => a.AccountNumber == accountNumber);

            if (account != null)
            {
                Console.Write("Enter Amount: ");
                double amount = double.Parse(Console.ReadLine());

                if (type == "deposit")
                {
                    account.Deposit(amount);
                }
                else
                {
                    account.Withdraw(amount);
                }
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        static void DisplayAllAccounts(List<Account> accounts)
        {
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts available.");
                return;
            }

            foreach (var acc in accounts)
            {
                acc.DisplayAccountDetails();
                Console.WriteLine("------------------------");
            }
        }
    }
}
