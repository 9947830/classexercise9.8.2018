using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Add;
using View;

namespace Library
{
    public class Program
    {

        static void Main(string[] args)
        {
            int option = 0;
            bool check = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Library System");
                Console.WriteLine();
                Console.WriteLine("1) Add Or Edit A Book");
                Console.WriteLine("2) View Details Of A Book");
                Console.WriteLine("3) Exit");
                check = int.TryParse(Console.ReadLine(), out option);
                if (check == false)
                {
                    Console.WriteLine("Invalid entry, please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (option > 3)
                {
                    Console.WriteLine("Please enter a number between 1 and 3");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {

                    switch (option)
                    {
                        case 1:
                            string password = "Password";
                            Console.WriteLine("Please enter your password");
                            string pass = Console.ReadLine();
                            if (pass == password)
                            {
                                Add.Program.Main();
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Password");
                                Console.ReadLine();
                            }

                            break;
                        case 2:
                            View.Program.Main();
                            break;
                        case 3:
                            break;
                        default:
                            break;


                    }
                }
                } while (option != 3) ;
            
        }
    }
}
