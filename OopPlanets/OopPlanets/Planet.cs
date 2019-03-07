using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlanets
{
    class Planet
    {
        private double mass;
        private double diamenter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private uint meanTemperature;
        private byte numberOfMoons;
        private bool ringSystem;

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
        public uint MeanTemperature
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

        static List<string> planets = new List<string>();

        public void AddPlanet()
        {

        }

    }
}
