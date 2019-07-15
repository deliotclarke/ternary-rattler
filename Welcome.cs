using System;

namespace TernaryRattler
{
    class Welcome
    {

        static public bool RunWelcome()
        {
            Console.Clear();

            Console.WriteLine("Hello World Traveller!");
            Console.WriteLine("Welcome to Ternary Rattler. What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("UPDATE your travel list, ADD to your travel list, VIEW your travel list?");
            string userStart = Console.ReadLine();

            if (userStart.ToUpper() == "UPDATE")
            {
                LocationList.UpdateList();
                return true;
            }
            else if (userStart.ToUpper() == "ADD")
            {
                AddLocation.AddNewLocation();
                return true;
            }
            else if (userStart.ToUpper() == "VIEW")
            {
                var printList = LocationList.ViewList();
                printList.ForEach(loc =>
                {
                    Console.WriteLine();
                    Console.WriteLine($"Name: {loc.ParkName}");
                    Console.WriteLine($"State: {loc.State}");
                    Console.WriteLine($"Visited: {loc.Visited}");
                    Console.WriteLine($"Rattled??: {loc.Rattled}");
                });

                Console.WriteLine();
                printList.Clear();
                Console.WriteLine("All good?? Return to Main Menu?? y/n");
                string returnResponse = Console.ReadLine();

                if (returnResponse.ToUpper() == "Y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
                    return false;
                }
                else if (userEnd.ToUpper() == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Okay, let's start over.");
                    //return to original user input
                    return true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Your answer sucks again. BUH!");
                    return false;
                }
            }
        }
    }
}