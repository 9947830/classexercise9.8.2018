using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book;

namespace Add
{
    public class Program

    {
        static int menu = 0;
        public static Book.Book Book1 = new Book.Book("", "", "", "", "", 0);
        public static Book.Book Book2 = new Book.Book("", "", "", "", "", 0);
        public static Book.Book Book3 = new Book.Book("", "", "", "", "", 0);
        public static Book.Book Book4 = new Book.Book("", "", "", "", "", 0);
        public static Book.Book Book5 = new Book.Book("", "", "", "", "", 0);
        public static Book.Book Book6 = new Book.Book("", "", "", "", "", 0);

        public static void Main()
        {
            bool check = true;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter your selection");
                Console.WriteLine("Note: A book with ISBN 0 has no data entered yet");
                Console.WriteLine();
                Console.WriteLine("1) Add or edit book with ISBN: {0}", Add.Program.Book1.ISBN);
                Console.WriteLine("2) Add or edit book with ISBN: {0}", Add.Program.Book2.ISBN);
                Console.WriteLine("3) Add or edit book with ISBN: {0}", Add.Program.Book3.ISBN);
                Console.WriteLine("4) Add or edit book with ISBN: {0}", Add.Program.Book4.ISBN);
                Console.WriteLine("5) Add or edit book with ISBN: {0}", Add.Program.Book5.ISBN);
                Console.WriteLine("6) Add or edit book with ISBN: {0}", Add.Program.Book6.ISBN);
                Console.WriteLine("7) Return to the main menu");
                check = int.TryParse(Console.ReadLine(), out menu);
                if (check == false)
                {
                    Console.WriteLine("Invalid entry, please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (menu > 7)
                {
                    Console.WriteLine("Please enter a number between 1 and 7");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    switch (menu)
                    {
                        case 1:
                            Add.Program.NewBook(Book1);
                            break;
                        case 2:
                            Add.Program.NewBook(Book2);
                            break;
                        case 3:
                            Add.Program.NewBook(Book3);
                            break;
                        case 4:
                            Add.Program.NewBook(Book4);
                            break;
                        case 5:
                            Add.Program.NewBook(Book5);
                            break;
                        case 6:
                            Add.Program.NewBook(Book6);
                            break;
                        case 7:
                            break;
                        default:
                            break;




                    }
                }
            } while (menu != 7);
        }

        public static void NewBook(Book.Book currentBook)
        {           
            
            Console.WriteLine("Please enter the title of the book");
            currentBook.Title = Console.ReadLine();
            Console.WriteLine("Please enter the Last name of the author");
            currentBook.AuthorLName = Console.ReadLine();
            Console.WriteLine("Please enter the First name of the author");
            currentBook.AuthorFName = Console.ReadLine();
            Console.WriteLine("Please enter the Category of the book");
            currentBook.Category = Console.ReadLine();
            Console.WriteLine("Please enter the Location of the book");
            currentBook.Location = Console.ReadLine();
            Console.WriteLine("Please enter the ISBN of the book");
            currentBook.ISBN = double.Parse(Console.ReadLine());
            Console.WriteLine("Press enter to return to the menu");
            string choice = Console.ReadLine();
             
        }

    }
}
/* 
Book1

    Console.WriteLine("Title: {0}", Add.Program.Book1.Title); 
    Console.WriteLine("Author Last Name: {0}", Add.Program.Book1.AuthorLName);
    Console.WriteLine("Author First Name: {0}", Add.Program.Book1.AuthorFName);
    Console.WriteLine("Category: {0}", Add.Program.Book1.Category);
    Console.WriteLine("Location: {0}", Add.Program.Book1.Location);
    Console.WriteLine("ISBN: {0}", Add.Program.Book1.ISBN);
    */
