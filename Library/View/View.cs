using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Add;
using Book;

namespace View
{
    public class Program
    {
        public static void Main()
        {
            bool check = true;
            int select = 0;
            //Book1
            do
            {
                Console.Clear();
                Console.WriteLine("Please select the ISBN number of the book you would like to view");
                Console.WriteLine();
                Console.WriteLine("1) {0}", Add.Program.Book1.ISBN);
                Console.WriteLine("2) {0}", Add.Program.Book2.ISBN);
                Console.WriteLine("3) {0}", Add.Program.Book3.ISBN);
                Console.WriteLine("4) {0}", Add.Program.Book4.ISBN);
                Console.WriteLine("5) {0}", Add.Program.Book5.ISBN);
                Console.WriteLine("6) {0}", Add.Program.Book6.ISBN);
                Console.WriteLine("7) Return To Main Menu");
                check = int.TryParse(Console.ReadLine(), out select);
                if (check == false)
                {
                    Console.WriteLine("Invalid entry, please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (select > 7)
                {
                    Console.WriteLine("Please enter a number between 1 and 7");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    switch (select)
                    {
                        case 1:
                            View.Program.Display(Add.Program.Book1);
                            break;
                        case 2:
                            View.Program.Display(Add.Program.Book2);
                            break;
                        case 3:
                            View.Program.Display(Add.Program.Book3);
                            break;
                        case 4:
                            View.Program.Display(Add.Program.Book4);
                            break;
                        case 5:
                            View.Program.Display(Add.Program.Book5);
                            break;
                        case 6:
                            View.Program.Display(Add.Program.Book6);
                            break;
                        case 7:
                            break;
                        default:
                            break;


                    }
                }
                
            } while (select != 7);
        }
            public static void Display(Book.Book BookRef)
            {
            Console.WriteLine("Title: {0}", BookRef.Title);
            Console.WriteLine("Author Last Name: {0}", BookRef.AuthorLName);
            Console.WriteLine("Author First Name: {0}", BookRef.AuthorFName);
            Console.WriteLine("Category: {0}", BookRef.Category);
            Console.WriteLine("Location: {0}", BookRef.Location);
            Console.WriteLine("ISBN: {0}", BookRef.ISBN);
            Console.WriteLine("Press enter to view another book");
            Console.ReadLine();
            }
    }

} 
