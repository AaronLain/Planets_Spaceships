using System;
using System.Collections.Generic;

namespace Planets_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");

            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");

            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            Console.WriteLine("All the Planets: \r\n");

            foreach (var planet in planetList)
            {
                Console.WriteLine($"{planet}");
            }

            Console.WriteLine("\r\nRocky Planets: \r\n");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine($"{planet}");
            }

            Console.WriteLine("\r\nGet out of here, Pluto: \r\n");

            planetList.RemoveAt(8);

            foreach (var planet in planetList)
            {
                Console.WriteLine($"{planet}");
            }

            var Spaceships = new Dictionary<string, List<string>>
            {
                {
                    "Voyager 1",
                    new List<string> {"Jupiter", "Saturn"}
                },
                {
                    "Voyager 2",
                    new List<string> {"Jupiter", "Saturn", "Uranus", "Neptune"}
                },
                {
                    "Mariner 10",
                    new List<string> {"Mercury", "Venus"}
                },
                {
                    "MESSENGER",
                    new List<string> {"Mercury", "Venus", "Earth"}
                }
            };



            foreach (var planet in planetList)
            {
                Console.WriteLine($"\r\n{planet}:");

                foreach (var (probe, planets) in Spaceships)
                {
                    foreach (var pPlanet in planets)
                    {
                        if (planet == pPlanet)
                        {
                            Console.WriteLine($"{probe}");
                        }
                    }
                }
            }
        }
    }
}
