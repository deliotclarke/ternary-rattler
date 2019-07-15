using System;
using System.Collections.Generic;
using System.Linq;

namespace TernaryRattler
{
    public class LocationList
    {
        // public Dictionary<string, Location> locations = new Dictionary<string, Location>();
        public List<Location> locations = new List<Location>(){
            new Location()
                {
                    ParkName = "Yellowstone National Park",
                    State = "WY",
                    Visited = false,
                    Rattled = false
                },
            new Location()
                {
                    ParkName = "Your Dad's House",
                    State = "TN",
                    Visited = true,
                    Rattled = false
                },
            new Location()
                {
                    ParkName = "Mammoth Cave",
                    State = "KY",
                    Visited = false,
                    Rattled = false
                },
            new Location()
                {
                    ParkName = "That Crooked House In California",
                    State = "CA",
                    Visited = true,
                    Rattled = true
                }
        };

        public void AddMe(string name, string state, bool visited, bool rattled)
        {
            Location newSpot = new Location()
            {
                ParkName = name,
                State = state,
                Visited = visited,
                Rattled = rattled
            };
            locations.Add(newSpot);
        }

        public void AddNewLocation()
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
                    this.AddMe(locationName, locationState, Visited, Rattled);
                    Console.WriteLine("Location... ADDED!");

                }
                else if (locationRattled.ToUpper() == "NO" || locationRattled.ToUpper() == "N")
                {
                    Console.WriteLine();
                    Rattled = false;
                    Console.WriteLine("OOF! That's probably best. Let's add it.");
                    this.AddMe(locationName, locationState, Visited, Rattled);
                    Console.WriteLine("Location... ADDED!");
                }
            }
            else if (locationVisited.ToUpper() == "NO" || locationVisited.ToUpper() == "NOPE" || locationVisited.ToUpper() == "N")
            {
                Console.WriteLine();
                Console.WriteLine("That's cool. Let's put it on the list.");
                this.AddMe(locationName, locationState, Visited, Rattled);
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

        public void UpdateList()
        {
            Console.Clear();
            Console.WriteLine("Okay! Which location would you like to update?");
            Console.WriteLine();

            int selector = new int();

            for (int i = 0; i < locations.Count; i++)
            {
                //creates a selecting integer that doesn't start at 0 for the user to select a specific object later
                selector = i + 1;
                var item = locations.ElementAt(i);

                Console.WriteLine($"{selector}: {item.ParkName}");
            }

            Console.WriteLine();
            Console.WriteLine("Okay, which entry would you like to update? Enter the number.");

            //converts the console ReadLine which is inherently a string to an integer
            int userSelector = Convert.ToInt32(Console.ReadLine());

            UpdateItem(userSelector);
        }

        public void UpdateItem(int selector)
        {
            //converts selector for user to index postion for use with ElementAt()
            int newSelector = selector - 1;

            //grabs a reference to the object for editing
            var item = locations.ElementAt(newSelector);

            Console.Clear();
            Console.WriteLine("Okay! Let's do this!");
            Console.WriteLine();
            Console.WriteLine($"Editing: {item.ParkName} in {item.State}");
            Console.WriteLine();
            Console.WriteLine($"Visited: {item.Visited}? y/n");
            string newVisited = Console.ReadLine();
            bool finalVisited = false;
            if (newVisited.ToUpper() == "Y")
            {
                finalVisited = true;
            }
            Console.WriteLine($"Rattled??: {item.Rattled}? y/n");
            string newRattled = Console.ReadLine();
            bool finalRattled = false;
            if (newRattled.ToUpper() == "Y")
            {
                finalRattled = true;
            }
            var newLocation = new Location
            {
                ParkName = item.ParkName,
                State = item.State,
                Visited = finalVisited,
                Rattled = finalRattled
            };

            Console.WriteLine();
            Console.WriteLine($"Name: {newLocation.ParkName}");
            Console.WriteLine($"State: {newLocation.State}");
            Console.WriteLine($"Visited: {newLocation.Visited}");
            Console.WriteLine($"Rattled??: {newLocation.Rattled}");
            Console.WriteLine();
            Console.WriteLine("Is that correct? y/n");

            var userConfirm = Console.ReadLine();
            if (userConfirm.ToUpper() == "Y")
            {
                //removes old version of location
                locations.Remove(item);
                //adds new location object
                locations.Insert(newSelector, newLocation);
            }
        }

        public void DeleteList()
        {
            Console.Clear();
            Console.WriteLine("Okay! Let's destory something beautiful!");
            Console.WriteLine();

            int selector = new int();

            for (int i = 0; i < locations.Count; i++)
            {
                //creates a selecting integer that doesn't start at 0 for the user to select a specific object later
                selector = i + 1;
                var item = locations.ElementAt(i);

                Console.WriteLine($"{selector}: {item.ParkName}");
            }

            Console.WriteLine();
            Console.WriteLine("Okay, which entry would you like to update? Enter the number.");

            //converts the console ReadLine which is inherently a string to an integer
            int userSelector = Convert.ToInt32(Console.ReadLine());

            DeleteItem(userSelector);
        }

        public void DeleteItem(int selector)
        {
            int newSelector = selector - 1;

            //grabs a reference to the object for deletion
            var item = locations.ElementAt(newSelector);

            Console.WriteLine();
            Console.WriteLine($"Name: {item.ParkName}");
            Console.WriteLine($"State: {item.State}");
            Console.WriteLine($"Visited: {item.Visited}");
            Console.WriteLine($"Rattled??: {item.Rattled}");
            Console.WriteLine();
            Console.WriteLine("Delete this location! Is that correct? y/n");
            var userConfirmDelete = Console.ReadLine();

            if (userConfirmDelete.ToUpper() == "Y")
            {
                //permanently removes item
                locations.Remove(item);
            }

        }
    }
}