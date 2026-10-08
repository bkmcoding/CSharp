using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryBookTracker
{
    internal class Program
    {
        private List<Book> Books = new List<Book> { };
        //private String[] commands { get; } = ["1", "2", "3"];

        static void Main(string[] args)
        {
            var BookTracker = new Program();
            //Console.WriteLine("The");
            //Console.ReadLine();
            Console.WriteLine("Hello, Welcome to the book keeping application.");

            while (true)
            {
            Console.WriteLine("\nPlease Select an option.");
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Delete book");
            Console.WriteLine("4. Exit\n");
            Console.Write("~");
            String userSelection = PromptUser();
                switch (userSelection)
                {
                    case "1":
                        BookTracker.ListBooks();
                        break;
                    case "2":
                        BookTracker.AddBook();
                        break;
                    case "3":
                        BookTracker.DeleteBook();
                    case "4":
                        System.Environment.Exit(0);
                        break;
                    default
                        Console.WriteLine("Please select a proper option listed");
                        printDivider();
                        break;

                }
            }
        }

        private static String PromptUser()
        {

            return Console.ReadLine();
        }

        private void ListBooks()
        {
            int index = 0;
            foreach (Book book in this.Books)
            {
                index++;
                book.List();
            }
            if (index == 0)
            {
                Console.WriteLine("There are no books in the tracker.");
                printDivider();
            }
        }

        private void AddBook(int ISBN, String Title, String Author, String Description, float Price)
        {

        }

        private void AddBook()
        {
            // Manage adding the data internally.
        }

        private static void printDivider()
        {
            Console.WriteLine("------------------------------");
        }
    }
}
