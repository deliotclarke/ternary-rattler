using System;

namespace TernaryRattler
{
    class Program
    {
        static void Main(string[] args)
        {
            LocationList.HardList();
            bool keepGoing = true;
            do
            {
                keepGoing = Welcome.RunWelcome();
            } while (keepGoing != false);
        }
    }
}
