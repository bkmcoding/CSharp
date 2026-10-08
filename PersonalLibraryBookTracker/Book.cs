using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryBookTracker
{
    internal class Book
    {

        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public void List()
        {
            Console.WriteLine($"\nISBN: {this.ISBN}");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Author: {this.Author}");
            Console.WriteLine($"Description: {this.Description}");
            Console.WriteLine($"Price: {this.Price}");
        }
    }
}
