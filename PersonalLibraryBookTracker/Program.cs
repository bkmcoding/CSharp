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

        static void Main(string[] args)
        {
            var BookTracker = new Program();
            Console.WriteLine("Hello, Welcome to the book keeping application.");

            while (true)
            {
            Console.WriteLine("\nPlease Select an option.");
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Delete book");
            Console.WriteLine("4. Exit\n");
            Console.Write("~");
            String userSelection = Console.ReadLine();
            switch (userSelection)
            {
                case "1":
                    BookTracker.ListBooks();
                    break;

                case "2":
                    int ISBN;
                    string Title;
                    string Author;
                    string Description;
                    float Price;

                    printDivider();
                    Console.WriteLine("Books require ISBN, Title, Author, Description, and Price.\n");


                    Console.WriteLine("Please enter the ISBN for the new book.");
                    while(!int.TryParse(Console.ReadLine(), out ISBN)) {
                        Console.WriteLine("Invalid input. Please enter a ISBN.");
                    }

                    Console.WriteLine("\nPlease enter the Title for the new book.");
                    Title = Console.ReadLine();

                    Console.WriteLine("\nPlease enter the Author for the new book.");
                    Author = Console.ReadLine();

                    Console.WriteLine("\nPlease enter the Description for the new book.");
                    Description = Console.ReadLine();

                    Console.WriteLine("\nPlease enter the Price for the new book. (ex. 23.99)");
                    while (!float.TryParse(Console.ReadLine(), out Price))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid price: ");
                    }

                    BookTracker.AddBook(ISBN, Title, Author, Description, Price);
                    break;

                case "3":
                    BookTracker.ListBooks();
                    printDivider();

                    bool bookFound = false;

                    Console.WriteLine("Which Book would you like to delete? Type the ISBN.");
                    while (!int.TryParse(Console.ReadLine(), out ISBN))
                    {
                        Console.WriteLine("Invalid input. Please enter a ISBN.");
                    }

                    foreach (var book in BookTracker.Books)
                        {
                            if (book.ISBN == ISBN)
                            {
                                BookTracker.Books.Remove(book);
                                bookFound = true;
                                Console.WriteLine($"\nBook {ISBN} has been deleted.\n");
                                break;
                            }
                        }
                    if (!bookFound)
                        {
                            Console.WriteLine("\nMatching ISBN not found. 0 Books Deleted\n");
                        }
                    break;

                case "4":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a proper option listed");
                    break;
            }
            printDivider();
            }
        }

        private void ListBooks()
        {
            printDivider();
            Console.WriteLine("Here are your books.\n");
            int index = 0;
            foreach (Book book in this.Books)
            {
                index++;
                book.List();
            }
            if (Books.Count == 0)
            {
                Console.WriteLine("There are no books in the tracker.");
            }
            Console.WriteLine();
        }

        private void AddBook(int ISBN, String Title, String Author, String Description, float Price)
        {
            Book book = new Book(ISBN, Title, Author, Description, Price);
            this.Books.Add(book);
        }

        private static void printDivider()
        {
            Console.WriteLine("------------------------------");
        }
    }
}
