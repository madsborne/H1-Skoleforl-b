using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlanets
{
    class PlanetList
    {
        // lists that contains the Planet object
        public List<Planet> Planets = new List<Planet>();
        public List<Planet> BelowZeroPlanets = new List<Planet>();
        public List<Planet> DiameterPlanets = new List<Planet>();

        // creating the planets and giving them their values
        Planet merkur = new Planet("Merkur", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
        Planet venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
        Planet earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
        Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
        Planet jupiter = new Planet("Jupiter", 1898, 142.984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
        Planet saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, true);
        Planet uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, true);
        Planet neptune = new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
        Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

        // adding the planets to the Planet list through the con also inserting a planet and removing one and then adding it again
        public PlanetList()
        {
            Planets.Add(merkur);
            Planets.Add(earth);
            Planets.Add(mars);
            Planets.Add(jupiter);
            Planets.Add(saturn);
            Planets.Add(uranus);
            Planets.Add(neptune);
            Planets.Add(pluto);

            Planets.Insert(1, venus);

            Planets.Remove(pluto);
            Planets.Add(pluto);

            
        }

        // prints all the planets not sure if this way is okay to do it but it was more for me to learn about methods in classes and such
        public void PrintPlanets()
        {
            for (int i = 0; i < Planets.Count; i++)
            {
                Console.WriteLine(Planets[i].PrintInfo());
            }
        }

        // adding the planets with below zero MeanTemp to a new list and printing it
        public void BelowZeroPlanetControl()
        {
            foreach (Planet planet in Planets)
            {
                if (planet.MeanTemperature < 0)
                {
                    BelowZeroPlanets.Add(planet);
                    Console.WriteLine("Below Zero - " + planet.Name + "\n");
                }
            }

        }
        
        // adding planets with over 10000KM Diameter into a new list and then printing them
        public void DiameterPlanetControl()
        {
            foreach (Planet diameterPlanet in Planets)
            {
                if (diameterPlanet.Diameter > 10000 && diameterPlanet.Diameter < 50000)
                {
                    DiameterPlanets.Add(diameterPlanet);
                    Console.WriteLine("with over 10000KM Diameter - " + diameterPlanet.Name + "\n");
                }
            }
        }
        
        // removes all plants from Planet list
        public void RemoveAllPlanets()
        {
            Planets.Clear();
            Console.WriteLine("All planets removed");
        }
    }
}
