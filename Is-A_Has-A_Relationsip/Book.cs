using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    //5. Problem:
    //Develop a library management system where each Library contains multiple Books.
    //Each book should have a title, author, and publication date.
    //Use a "Has-a" relationship to model the fact that a Library has multiple Book objects.
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }

        public Book(string title, string author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Published on: {PublicationDate.ToShortDateString()}");
        }
    }
}
