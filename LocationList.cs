using System;
using System.Collections.Generic;
using System.Linq;

namespace TernaryRattler
{
    static public class LocationList
    {
        static Dictionary<string, Location> locations = new Dictionary<string, Location>();

        static Location hardCodedLocation1 = new Location()
        {
            ParkName = "Yellowstone National Park",
            State = "WY",
            Visited = false,
            Rattled = false
        };
        static Location hardCodedLocation2 = new Location()
        {
            ParkName = "Your Dad's House",
            State = "TN",
            Visited = true,
            Rattled = false
        };
        static Location hardCodedLocation3 = new Location()
        {
            ParkName = "Mammoth Cave",
            State = "KY",
            Visited = false,
            Rattled = false
        };
        static Location hardCodedLocation4 = new Location()
        {
            ParkName = "That Crooked House In California",
            State = "CA",
            Visited = true,
            Rattled = true
        };

        static public void HardList()
        {
            locations.Add(hardCodedLocation1.ParkName, hardCodedLocation1);
            locations.Add(hardCodedLocation2.ParkName, hardCodedLocation2);
            locations.Add(hardCodedLocation3.ParkName, hardCodedLocation3);
            locations.Add(hardCodedLocation4.ParkName, hardCodedLocation4);
        }

        static public void AddMe(string name, string state, bool visited, bool rattled)
        {
            Location newSpot = new Location()
            {
                ParkName = name,
                State = state,
                Visited = visited,
                Rattled = rattled
            };
            locations.Add(name, newSpot);
        }

        static public List<Location> BuildList = new List<Location>();

        static public List<Location> ViewList()
        {

            foreach (var locationKey in locations.Keys)
            {
                BuildList.Add(locations[locationKey]);
            }
            return BuildList;
        }

        static public void UpdateList()
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
                var itemKey = item.Key;

                Console.WriteLine($"{selector}: {item.Key}");
            }

            Console.WriteLine();
            Console.WriteLine("Okay, which entry would you like to update? Enter the number.");

            //converts the console ReadLine which is inherently a string to an integer
            int userSelector = Convert.ToInt32(Console.ReadLine());

            UpdateItem(userSelector);
        }

        static public void UpdateItem(int selector)
        {
            //converts selector for user to index postion for use with ElementAt()
            int newSelector = selector - 1;

            //grabs a reference to the object for editing
            var item = locations.ElementAt(newSelector);

            foreach (var id in locations.ToList())
            {
                //i'm not 100 percent that this is the best way to do this, but using this statement to match
                if (item.Key == id.Key)
                {
                    Console.Clear();
                    Console.WriteLine("Okay! Let's do this!");
                    Console.WriteLine();
                    Console.WriteLine($"Editing: {locations[id.Key].ParkName} in {locations[id.Key].State}");
                    Console.WriteLine();
                    Console.WriteLine($"Visited: {locations[id.Key].Visited}? y/n");
                    string newVisited = Console.ReadLine();
                    bool finalVisited = false;
                    if (newVisited.ToUpper() == "Y")
                    {
                        finalVisited = true;
                    }
                    Console.WriteLine($"Rattled??: {locations[id.Key].Rattled}? y/n");
                    string newRattled = Console.ReadLine();
                    bool finalRattled = false;
                    if (newRattled.ToUpper() == "Y")
                    {
                        finalRattled = true;
                    }
                    var newLocation = new Location
                    {
                        ParkName = locations[id.Key].ParkName,
                        State = locations[id.Key].State,
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
                        locations.Remove(locations[id.Key].ParkName);
                        //adds new location object
                        locations.Add(newLocation.ParkName, newLocation);
                    }
                }
            }

        }

        static public void locationsToList()
        {



        }

    }
}