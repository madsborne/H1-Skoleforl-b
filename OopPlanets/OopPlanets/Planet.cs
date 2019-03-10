using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlanets
{
    class Planet
    {
        // all my private vars
        private string name;
        private double mass;
        private double diamenter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private double meanTemperature;
        private byte numberOfMoons;
        private bool ringSystem;

        // all my props
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public double Diameter
        {
            get
            {
                return diamenter;
            }
            set
            {
                diamenter = value;
            }
        }
        public int Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }
        public double Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                rotationPeriod = value;
            }
        }
        public double LengthOfDay
        {
            get
            {
                return lengthOfDay;
            }
            set
            {
                lengthOfDay = value;

            }
        }
        public double DistanceFromSun
        {
            get
            {
                return distanceFromSun;
            }
            set
            {
                distanceFromSun = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }
            set
            {
                orbitalPeriod = value;

            }
        }
        public double OrbitalVelocity
        {
            get
            {
                return orbitalVelocity;
            }
            set
            {
                orbitalVelocity = value;
            }
        }
        public double MeanTemperature
        {
            get
            {
                return meanTemperature;
            }
            set
            {
                meanTemperature = value;
            }
        }
        public byte NumberOfMoons
        {
            get
            {
                return numberOfMoons;
            }
            set
            {
                numberOfMoons = value;

            }
        }
        public bool RingSystem
        {
            get
            {
                return ringSystem;
            }
            set
            {
                ringSystem = value;
            }
        }

        // my con that asign values to the props
        public Planet(string pName, double pMass, double pDiameter, int pDensity, double pGravity, double pRotationPeriod, double pLengthOfDay, double pDistanceFromSun, double pOrbitalPeriod, double pOrbitalVelocity, double pMeanTemperature, byte pNumberOfMoons, bool pRingSystem)
        {
            Name = pName;
            Mass = pMass;
            Diameter = pDiameter;
            Density = pDensity;
            Gravity = pGravity;
            RotationPeriod = pRotationPeriod;
            LengthOfDay = pLengthOfDay;
            DistanceFromSun = pDistanceFromSun;
            OrbitalPeriod = pOrbitalPeriod;
            OrbitalVelocity = pOrbitalVelocity;
            MeanTemperature = pMeanTemperature;
            NumberOfMoons = pNumberOfMoons;
            RingSystem = pRingSystem;
        }

        // returns the planets info
        public string PrintInfo()
        {
            return $"Name = {Name}\n" +
                   $"Mass = {Mass}\n" +
                   $"Diameter = {Diameter}\n" +
                   $"Density = {Density}\n" +
                   $"Gravity = {Gravity}\n" +
                   $"Rotation Period = {RotationPeriod}\n" +
                   $"Length Of Day = {LengthOfDay}\n" +
                   $"Distrance From Sun = {DistanceFromSun}\n" +
                   $"Orbital Period = {OrbitalPeriod}\n" +
                   $"Orbital Velocity = {OrbitalVelocity}\n" +
                   $"Mean Temperature = {MeanTemperature}\n" +
                   $"Number of Moons = {NumberOfMoons}\n" +
                   $"Ring System = {RingSystem}\n";
        }
    }
}
