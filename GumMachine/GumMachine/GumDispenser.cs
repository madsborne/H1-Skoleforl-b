﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class GumDispenser
    {
        // vars + props
        private int totalNumber;
        public int TotalNumber
        {
            get
            {
                return totalNumber;
            }
            set
            {
                totalNumber = value;
            }
        }

        // list + random number
        public List<Gum> gumList = new List<Gum>();
        public Random rnd = new Random();

        public GumDispenser()
        {
            // adds blue berries to the gumList
            CreateGum(0, rnd.Next(13, 16));

            // adds black berries
            CreateGum(1, rnd.Next(6, 9));

            // adds tuttifrutti
            CreateGum(2, rnd.Next(10, 13));

            // adds orange
            CreateGum(3, rnd.Next(9, 12));

            // adds strawberries
            CreateGum(4, rnd.Next(7, 10));

            // adds apples
            CreateGum(5, rnd.Next(4, 7));

            CheckCount();
        }

        /// <summary>
        /// Creates Gum depending on Id of the gum and amount
        /// </summary>
        /// <param name="gumId"></param>
        /// <param name="rndNumber"></param>
        public void CreateGum(int gumId, int rndNumber)
        {
            for (int gumAdding = 0; gumAdding < rndNumber; gumAdding++)
            {
                Gum gum = new Gum(gumId);
                gumList.Add(gum);
            }

        }
        /// <summary>
        /// Checks the count in the dispenser and fills it or removes
        /// if used with below 55 it fills
        /// if used in the constructer and above 55 it removes
        /// </summary>
        public void CheckCount()
        {
            TotalNumber = gumList.Count;

            while (TotalNumber <= 55)
            {
                CreateGum(rnd.Next(0, 6), 1);
                TotalNumber++;
            }
            while (TotalNumber > 55)
            {
                gumList.RemoveAt(rnd.Next(0, 56));
                TotalNumber--;
            }

        }

    }
}
