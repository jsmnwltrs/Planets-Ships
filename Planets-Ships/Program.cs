using System;
using System.Collections.Generic;

namespace Planets_Ships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> anotherPlanetList = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(anotherPlanetList);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = new List<string>();
            List<string> gasPlanets = new List<string>() { "Jupiter", "Saturn", "Uranus", "Neptune" };

            rockyPlanets = planetList.GetRange(0, 4);


            planetList.Remove("Pluto");

            var shipsAndDestinations = new Dictionary<string, List<string>>
            {
                {"ToughShip", rockyPlanets},
                {"FloatyShip", gasPlanets}
            };

            foreach (var (ship,planets) in shipsAndDestinations) {
                Console.WriteLine($"{ship}: ");
                foreach (var planet in planets)
                {
                    Console.WriteLine(planet);
                }
            } 

           

            Console.ReadLine();
        }
    }
}
