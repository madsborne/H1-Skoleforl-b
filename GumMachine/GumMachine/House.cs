using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class House
    {
        // Creating a new obj of GumDispenser + Creating a random and a new list
        GumDispenser dispenser = new GumDispenser();
        List<Gum> kid = new List<Gum>();
        Random rnd = new Random();

        /// <summary>
        /// Pulls a random gum and returns the gum flavor
        /// </summary>
        /// <returns></returns>
        public string PullGum()
        {
            // puts the count of gumlist into a new int
            int gumLeftInDispenser = dispenser.gumList.Count;
            // creates a random number out of it
            int rndGum = rnd.Next(0, gumLeftInDispenser);

            try
            {
                if (gumLeftInDispenser == 0)
                {
                    return "No more gum left";
                }
                else
                {
                    kid.Add(dispenser.gumList[rndGum]);
                    dispenser.gumList.RemoveAt(rndGum);

                    gumLeftInDispenser--;

                    return $"Gum pulled you got {kid.Last().Flavor}";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        /// <summary>
        /// Filling the machine no matter the amount left in the machine
        /// </summary>
        /// <returns></returns>
        public string RefillMachine()
        {
            try
            {
                dispenser.CheckCount();
                return "Dispenser has been refilled";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
    }
}
