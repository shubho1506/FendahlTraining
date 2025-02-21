using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public void RemoveBook(string title)
        {
            Book bookToRemove = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book '{title}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the library.");
            }
        }

        public void DisplayAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("The library has no books.");
            }
            else
            {
                Console.WriteLine("\nLibrary Book List:");
                foreach (var book in books)
                {
                    book.DisplayInfo();
                }
            }
        }
    }
}
