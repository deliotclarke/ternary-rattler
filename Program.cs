using System;
using System.Collections.Generic;

namespace TernaryRattler
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome welcome = new Welcome();
            bool keepGoing = true;
            do
            {
                keepGoing = welcome.RunWelcome();
            } while (keepGoing != false);
        }
    }
}
