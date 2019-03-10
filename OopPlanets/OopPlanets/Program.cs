using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a new Planet list called solarSystem
            PlanetList solarSystem = new PlanetList();

            // runs a method that prints all the planets
            solarSystem.PrintPlanets();
            // also prints the number of planets
            Console.WriteLine("Number of planets - " + solarSystem.Planets.Count + "\n");

            // runs two methods from solarSystem that controls the two lists in PlanetList
            solarSystem.BelowZeroPlanetControl();
            solarSystem.DiameterPlanetControl();

            // runs the method that removes the Planet List
            solarSystem.RemoveAllPlanets();
        }
    }
}
