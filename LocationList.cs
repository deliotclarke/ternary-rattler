using System;
using System.Collections.Generic;
using System.Linq;

namespace TernaryRattler
{
    public class LocationList
    {
        static Dictionary<string, Location> locations = new Dictionary<string, Location>();

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
                selector = i + 1;
                var item = locations.ElementAt(i);
                var itemKey = item.Key;

                Console.WriteLine($"{selector}: {item.Key}");
            }

            Console.WriteLine();
            Console.WriteLine("Okay, which entry would you like to update? Enter the number.");
            int userSelector = Convert.ToInt32(Console.ReadLine());

            UpdateItem(userSelector);
        }

        static public void UpdateItem(int selector)
        {
            int newSelector = selector - 1;
            var item = locations.ElementAt(newSelector);

            foreach (var id in locations.ToList())
            {
                if (item.Key == id.Key)
                {
                    Console.Clear();
                    Console.WriteLine("Okay! Let's do it!");
                    Console.WriteLine($"Editing: {locations[id.Key].ParkName} in {locations[id.Key].State}");
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
                    locations.Remove(locations[id.Key].ParkName);
                    Console.WriteLine($"Name: {newLocation.ParkName}");
                    Console.WriteLine($"Name: {newLocation.State}");
                    Console.WriteLine($"Name: {newLocation.Visited}");
                    Console.WriteLine($"Name: {newLocation.Rattled}");
                    Console.WriteLine("Is that correct? y/n");
                    var userConfirm = Console.ReadLine();
                    if (userConfirm.ToUpper() == "Y")
                    {
                        locations.Add(newLocation.ParkName, newLocation);
                    }
                }
            }

        }

    }
}