using System;

namespace TernaryRattler
{
    class AddLocation
    {
        static public void AddNewLocation()
        {
            Console.Clear();
            Console.WriteLine("Okay! Let's do this!");
            Console.WriteLine("Let's start with the Name of this location (i.e. Yellowstone National Park, Yosemite, Your Mom's House...):");
            string locationName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Sounds sick! Now what state is it in?");
            string locationState = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("You're doing so good. Now have you been there yet?");
            string locationVisited = Console.ReadLine();
            bool Visited = false;
            bool Rattled = false;

            if (locationVisited.ToUpper() == "YES" || locationVisited.ToUpper() == "YUP" || locationVisited.ToUpper() == "Y")
            {
                Console.WriteLine();
                Visited = true;

                Console.WriteLine("Sick! Now the most important question... Did you see a snake??");
                string locationRattled = Console.ReadLine();

                if (locationRattled.ToUpper() == "YES" || locationRattled.ToUpper() == "Y")
                {
                    Console.WriteLine();
                    Rattled = true;
                    Console.WriteLine("Daaaamn! That's nuts. Let's add it.");
                    LocationList.AddMe(locationName, locationState, Visited, Rattled);
                    Console.WriteLine("Location... ADDED!");

                }
                else if (locationRattled.ToUpper() == "NO" || locationRattled.ToUpper() == "N")
                {
                    Console.WriteLine();
                    Rattled = false;
                    Console.WriteLine("OOF! That's probably best. Let's add it.");
                    LocationList.AddMe(locationName, locationState, Visited, Rattled);
                    Console.WriteLine("Location... ADDED!");
                }
            }
            else if (locationVisited.ToUpper() == "NO" || locationVisited.ToUpper() == "NOPE" || locationVisited.ToUpper() == "N")
            {
                Console.WriteLine();
                Console.WriteLine("That's cool. Let's put it on the list.");
                LocationList.AddMe(locationName, locationState, Visited, Rattled);
                Console.WriteLine("Location... ADDED!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I have no idea what you're talking about. You could've said, yes, yup, no, nope, n, y. So many other things.");
                Console.WriteLine("Try again? y/n");
                string oneMoreTime = Console.ReadLine();

                if (oneMoreTime.ToUpper() == "Y")
                {
                    AddNewLocation();
                }
                else
                {
                    Console.WriteLine("Okay, dude... We out.");
                }
            }


        }
    }

}