using System;

namespace TernaryRattler
{
    public class Location
    {
        public string ParkName { get; set; }
        public string State { get; set; }
        public bool Visited { get; set; }
        public bool Rattled { get; set; }

        public void EditMe(string locationKey)
        {
            Console.Clear();
            Console.WriteLine("Okay! Let's do this!");
            Console.WriteLine();
            Console.WriteLine($"Editing: {LocationList.locations[locationKey].ParkName} in {LocationList.locations[locationKey].State}");
            Console.WriteLine();
            Console.WriteLine($"Visited: {LocationList.locations[locationKey].Visited}? y/n");
            string newVisited = Console.ReadLine();
            bool finalVisited = false;
            if (newVisited.ToUpper() == "Y")
            {
                finalVisited = true;
            }
            Console.WriteLine($"Rattled??: {LocationList.locations[locationKey].Rattled}? y/n");
            string newRattled = Console.ReadLine();
            bool finalRattled = false;
            if (newRattled.ToUpper() == "Y")
            {
                finalRattled = true;
            }
            var newLocation = new Location
            {
                ParkName = LocationList.locations[locationKey].ParkName,
                State = LocationList.locations[locationKey].State,
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
                LocationList.locations.Remove(LocationList.locations[locationKey].ParkName);
                //adds new location object
                LocationList.locations.Add(newLocation.ParkName, newLocation);
            }

        }
    }
}