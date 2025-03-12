using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections_LINQ
{
    //Practice Problems for Collections and LINQ





    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeSalaryProcessing();
            //FindingMostOrderedProducts();
            //FilteringStudents();
            //GroupCustomersByCity();
            //RemoveDuplicateEntries();
            //CountWordFrequency();
            //FindEmployeesByDepartment();
            //FindMostExpensiveProduct();
            //GroupStudentsByGrades();
            RemoveDuplicateIPs();
        }

        //Problem 1: Employee Salary Processing
        //Scenario:
        //A company maintains a list of employees, each having a Name, Department, and Salary. The HR department wants to:
        //1.	Filter employees earning more than 50,000.
        //2.	Sort employees in descending order of salary.
        //3.	Display only the names and salaries of these employees.
        static void EmployeeSalaryProcessing()
        {
            List<Employee> employees = new List<Employee> { 
                new Employee("Shubhodeep Sarkar", "Developer", 53000),
                new Employee("Hrutik Bhalerao", "Developer", 60000),
                new Employee("Tanishq Shukla", "Human Resource", 35000),
                new Employee("Utkarsh Pardhi", "Tester", 30000),
                new Employee("Mohit Shahu", "House Keeping", 15000)};


            //Query Syntax
            var employeeDetails =  from emp in employees
                                   where emp.Salary > 50000
                                   orderby emp.Salary descending
                                   select new { emp.Name, emp.Salary };

            // Display results
            Console.WriteLine("Employees earning more than 50,000 (Sorted by Salary in Descending Order):");
            foreach (var emp in employeeDetails)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }

            //Method Syntax
            var filteredEmployees = employees
                                        .Where(e => e.Salary > 50000)  
                                        .OrderByDescending(e => e.Salary)  
                                        .Select(e => new { e.Name, e.Salary });

            Console.WriteLine();

            // Display results
            Console.WriteLine("Employees earning more than 50,000 (Sorted by Salary in Descending Order):");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

        //Problem 2: Finding Most Ordered Products
        //Scenario:
        //An e-commerce website stores a list of orders containing a ProductName and QuantityOrdered. The admin wants to:
        //1.	Get the top 3 most ordered products.
        //2.	Display them in descending order of quantity.
        static void FindingMostOrderedProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop",50),
                new Product("Smartphone",80),
                new Product("Headphones",30),
                new Product("Keyboard",35),
                new Product("Mouse",40),
                new Product("Television",95),
            };

            var productDetails = (from product in products
                                  orderby product.QuantityOrdered descending
                                  select new { product.ProductName, product.QuantityOrdered })
                                   .Take(3);

            Console.WriteLine("Top 3 Most Ordered Products (Query Syntax):");
            foreach (var product in productDetails)
            {
                Console.WriteLine($"Product: {product.ProductName}, Quantity Ordered: {product.QuantityOrdered}");
            }

            Console.WriteLine();

            var filteredProducts = products.OrderByDescending(a => a.QuantityOrdered)
                                    .Take(3);
            Console.WriteLine("Top 3 Most Ordered Products (Query Syntax):");
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Product: {product.ProductName}, Quantity Ordered: {product.QuantityOrdered}");
            }
        }

        //Problem 3: Filtering Students with High Marks
        //Scenario:
        //A school maintains a list of students with their Names and Marks. The management wants to:
        //1.	Filter students who scored above 75 marks.
        //2.	Sort them in descending order of marks.
        //3.	Display only top 5 students.

        static void FilteringStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student("Shubhodeep", 85),
                new Student("Hrutik", 78),
                new Student("Tanishq", 92),
                new Student("Utkarsh", 65),
                new Student("Mohit", 88),
                new Student("Parth", 90),
                new Student("Mohan", 72),
                new Student("Omprakash", 95),
                new Student("Sahil", 81),
                new Student("Saurabh", 76)
            };

            var topStudentsQuery = (from student in students
                                    where student.Mark > 75
                                    orderby student.Mark descending
                                    select new { student.Name, student.Mark })
                                    .Take(5);

            Console.WriteLine("Top 5 Students with Marks Above 75 :");
            foreach (var student in topStudentsQuery)
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Mark}");
            }

            Console.WriteLine();

            var topStudentsMethod = students
                .Where(s => s.Mark > 75)
                .OrderByDescending(s => s.Mark)
                .Take(5);

            Console.WriteLine("Top 5 Students with Marks Above 75 :");
            foreach (var student in topStudentsMethod)
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Mark}");
            }
        }

        //Problem 4: Grouping Customers by City
        //Scenario:
        //A company stores customer records with CustomerName and City.The sales team wants to:
        //1.	Group customers based on their City.
        //2.	Display the city along with the number of customers in that city.

        static void GroupCustomersByCity()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer("Shubhodeep", "Delhi"),
                new Customer("Hrutik", "Shirpur"),
                new Customer("Tanishq", "Kanpur"),
                new Customer("Utkarsh", "Gondia"),
                new Customer("Mohit", "Nagpur"),
                new Customer("Parth", "Shegaon"),
                new Customer("Omprakash", "Nagpur")
            };

            var querySyntax = from customer in customers
                              group customer by customer.City into cityGroup
                              select new { City = cityGroup.Key, Count = cityGroup.Count() };

            Console.WriteLine("Customers Grouped by City :");
            foreach (var group in querySyntax)
            {
                Console.WriteLine($"City: {group.City}, Customers: {group.Count}");
            }

            var methodSyntax = customers.GroupBy(c => c.City)
                                        .Select(g => new { City = g.Key, Count = g.Count() });

            Console.WriteLine("\nCustomers Grouped by City :");
            foreach (var group in methodSyntax)
            {
                Console.WriteLine($"City: {group.City}, Customers: {group.Count}");
            }
        }

        //Problem 5: Removing Duplicate Entries in a List
        //Scenario:
        //A software logs user activities in a list, but some entries are duplicated.The development team wants to:
        //1.	Remove duplicate entries.
        //2.	Display a unique list of user activities.

        static void RemoveDuplicateEntries()
        {
            List<Activity> activities = new List<Activity>
            {
                new Activity("Login"), 
                new Activity("View Page"), 
                new Activity("Download Report"), 
                new Activity("Logout"),
                new Activity("Login"), 
                new Activity("Download Report"), 
                new Activity("View Page"), 
                new Activity("Logout")
            };

            var querySyntax = (from activity in activities
                               select activity.Action).Distinct();

            Console.WriteLine("\nUnique User Activities :");
            foreach (var activity in querySyntax)
            {
                Console.WriteLine(activity);
            }

            var methodSyntax = activities.Select(a => a.Action).Distinct();

            Console.WriteLine("\nUnique User Activities :");
            foreach (var activity in methodSyntax)
            {
                Console.WriteLine(activity);
            }
        }

        //Problem 6: Counting Word Frequency in a Text (Dictionary)
        //Scenario:
        //A content management system stores words from an article.The system needs to:
        //1.	Count occurrences of each word.
        //2.	Display words and their frequencies in descending order.

        static void CountWordFrequency()
        {
            string text = "apple banana apple orange banana apple orange orange grape";
            string[] words = text.Split(' ');

            var querySyntax = from word in words
                              group word by word into wordGroup
                              orderby wordGroup.Count() descending
                              select new { Word = wordGroup.Key, Count = wordGroup.Count() };

            Console.WriteLine("\nWord Frequency :");
            foreach (var word in querySyntax)
            {
                Console.WriteLine($"{word.Word}: {word.Count}");
            }

            var methodSyntax = words.GroupBy(word => word)
                                    .OrderByDescending(g => g.Count())
                                    .Select(g => new { Word = g.Key, Count = g.Count() });

            Console.WriteLine("\nWord Frequency :");
            foreach (var word in methodSyntax)
            {
                Console.WriteLine($"{word.Word}: {word.Count}");
            }
        }

        //Problem 7: Finding Employees by Department (Hashtable)
        //Scenario:
        //A company stores employees and their departments in a Hashtable. HR wants to:
        //1.	Find all employees in a specific department.
        //2.	Display them in alphabetical order.

        static void FindEmployeesByDepartment()
        {
            Hashtable employees = new Hashtable
            {
                { "Hrutik", "HR" }, { "Shubhodeep", "IT" }, { "Tanishq", "Finance" },
                { "Omprakash", "IT" }, { "Utkarsh", "HR" }, { "Mohit", "Finance" }
            };

            string targetDepartment = "IT";

            var querySyntax = from DictionaryEntry e in employees
                              where e.Value.ToString() == targetDepartment
                              orderby e.Key
                              select e.Key;

            Console.WriteLine($"\nEmployees in {targetDepartment} Department :");
            foreach (var emp in querySyntax)
            {
                Console.WriteLine(emp);
            }

            var methodSyntax = employees.Cast<DictionaryEntry>()
                                        .Where(e => e.Value.ToString() == targetDepartment)
                                        .OrderBy(e => e.Key)
                                        .Select(e => e.Key);

            Console.WriteLine($"\nEmployees in {targetDepartment} Department :");
            foreach (var emp in methodSyntax)
            {
                Console.WriteLine(emp);
            }
        }

        //Problem 8: Finding the Most Expensive Product (Dictionary)
        //Scenario:
        //An e-commerce platform stores Product Names and Prices in a dictionary. The admin wants to:
        //1.	Find the most expensive product.
        //2.	Display its name and price.

        static void FindMostExpensiveProduct()
        {
            Dictionary<string, double> products = new Dictionary<string, double>
            {
                { "Laptop", 1200.00 }, 
                { "Smartphone", 800.00 }, 
                { "Headphones", 150.00 },
                { "Television", 1800.00 }, 
                { "Tablet", 600.00 }
            };

            var querySyntax = (from product in products
                               orderby product.Value descending
                               select product).First();

            Console.WriteLine("\nMost Expensive Product :");
            Console.WriteLine($"Product: {querySyntax.Key}, Price: {querySyntax.Value}");

            var methodSyntax = products.OrderByDescending(p => p.Value).First();

            Console.WriteLine("\nMost Expensive Product :");
            Console.WriteLine($"Product: {methodSyntax.Key}, Price: {methodSyntax.Value}");
        }

        //Problem 9: Grouping Students by Grades (Dictionary)
        //Scenario:
        //A school stores student names and grades in a dictionary. The administration wants to:
        //1.	Group students by their grades.
        //2.	Display the grade along with the list of students.

        static void GroupStudentsByGrades()
        {
            Dictionary<string, string> students = new Dictionary<string, string>
            {
                { "Shubhodeep", "A" }, { "Hrutik", "B" }, { "Tanishq", "A" },
                { "Omprakash", "C" }, { "Utkarsh", "B" }, { "Mohit", "A" }
            };

            var querySyntax = from student in students
                              group student.Key by student.Value into gradeGroup
                              select new { Grade = gradeGroup.Key, Students = gradeGroup };

            Console.WriteLine("\nStudents Grouped by Grades :");
            foreach (var group in querySyntax)
            {
                Console.WriteLine($"Grade: {group.Grade}, Students: {string.Join(", ", group.Students)}");
            }

            var methodSyntax = students.GroupBy(s => s.Value)
                                       .Select(g => new { Grade = g.Key, Students = g.Select(s => s.Key) });

            Console.WriteLine("\nStudents Grouped by Grades :");
            foreach (var group in methodSyntax)
            {
                Console.WriteLine($"Grade: {group.Grade}, Students: {string.Join(", ", group.Students)}");
            }
        }

        //Problem 10: Removing Duplicates from Hashtable
        //Scenario:
        //A log system stores IP addresses and timestamps in a Hashtable but some IPs repeat. The admin wants to:
        //1.	Remove duplicate IP addresses.
        //2.	Display the unique list of IP addresses.

        static void RemoveDuplicateIPs()
        {
            Dictionary<string, string> ipLogs = new Dictionary<string, string>
            {
                { "192.168.1.1", "10:00 AM" },
                { "192.168.1.2", "10:05 AM" },
                { "192.168.1.3", "10:10 AM" },
                { "192.168.1.4", "10:25 AM" }
            };

            var querySyntax = from entry in ipLogs
                              select entry.Key;

            Console.WriteLine("\nUnique IP Addresses :");
            foreach (var ip in querySyntax)
            {
                Console.WriteLine(ip);
            }

            var methodSyntax = ipLogs.Select(entry => entry.Key);

            Console.WriteLine("\nUnique IP Addresses :");
            foreach (var ip in methodSyntax)
            {
                Console.WriteLine(ip);
            }
        }
    }

}
