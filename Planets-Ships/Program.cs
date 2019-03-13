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

            rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            Console.ReadLine();
        }
    }
}
