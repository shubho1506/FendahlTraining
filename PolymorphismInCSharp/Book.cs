using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInCSharp
{
    //4. Problem Statement: Book Object with Different Details
    //Task: Create a Book class with overloaded constructors to handle varying levels of detail.
    //•	Requirement:
    //o A constructor that initializes only the book title.
    //o A constructor that initializes the title and author.
    //o A constructor that initializes the title, author, and price.
    //•	Objective: Show how to create objects with different sets of data using constructor overloading.

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string title)
        {
            Title = title;
            Author = "Unknown";  
            Price = 0.0;         
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Price = 0.0;         
        }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: rs {Price}");
        }
    }
}
