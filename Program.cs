using System;

namespace TernaryRattler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Hello World Traveller!");
            Console.WriteLine("Welcome to Ternary Rattler. What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("UPDATE your travel list, ADD to your travel list, VIEW your travel list?");
            string userStart = Console.ReadLine();

            if (userStart.ToUpper() == "UPDATE")
            {
                Console.WriteLine("Update");
            }
            else if (userStart.ToUpper() == "ADD")
            {
                AddLocation.AddNewLocation();
            }
            else if (userStart.ToUpper() == "VIEW")
            {
                Console.WriteLine("View");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your answer sucks.");
                Console.WriteLine();
                Console.WriteLine("End program?");
                string userEnd = Console.ReadLine();

                if (userEnd.ToUpper() == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Okaayyyyy byyyyyeeeeeee");
                }
                else if (userEnd.ToUpper() == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Okay, let's start over.");
                    //return to original user input
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Your answer sucks again. BUH!");
                }
            }
        }
    }
}
