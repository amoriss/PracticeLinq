using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> videoGameList = new List<string>()
            {
                "Meatpacker 2000",
                "Maury Poppons",
                "CoQ10",
                "Guns and Crap",
                "FanTime ManTime",
                "POPit and Lockit",
                "FigurePainter",
                "Truth Be Told",
                "Anime Cars and Cops",
                "Hakuna Matata",

            };

            var gamesOrdered = videoGameList.OrderBy(name => name.Length);
            Console.WriteLine("List of Video Games By Length of Name:");
            foreach (var game in gamesOrdered)
            {
                Console.WriteLine($"{game}");
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine();         
            var gamesOrderedbyName = videoGameList.OrderBy(name => name);
            Console.WriteLine("List of Video Games Alphabetically:");
            foreach (var game in gamesOrderedbyName)
            {
                Console.WriteLine($"{game}");
            }
        }
    }
}
