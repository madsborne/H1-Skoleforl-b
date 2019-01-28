using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a string array and a normal string the array will have all the names in it
            // the string will be used later to take in input from a user
            string[] boyNames = new string[20];
            string userInput;

            // my array containing all the names from the boys
            boyNames[0] = "William";
            boyNames[1] = "Oliver";
            boyNames[2] = "Noah";
            boyNames[3] = "Emil";
            boyNames[4] = "Victor";
            boyNames[5] = "Magnus";
            boyNames[6] = "Frederik";
            boyNames[7] = "Mikkel";
            boyNames[8] = "Lucas";
            boyNames[9] = "Alexander";
            boyNames[10] = "Oscar";
            boyNames[11] = "Mathias";
            boyNames[12] = "Sebastian";
            boyNames[13] = "Malthe";
            boyNames[14] = "Elias";
            boyNames[15] = "Christian";
            boyNames[16] = "Mads";
            boyNames[17] = "Gustav";
            boyNames[18] = "Villads";
            boyNames[19] = "Tobias";

            // sorting the array to be alfabetic order
            Array.Sort(boyNames);

            // greeting the user asking for a input and also letting the user know they can type all to see all the names
            Console.WriteLine("to search for a name type in the name or a part of the name");
            Console.WriteLine("or if you want to see all the names just write all");
            userInput = Console.ReadLine();

            // a foreach that runs through the array and giving the value to boyName to be check on 
            foreach (string boyName in boyNames)
            {
                // checks the input to see if anything from the array contains anything typed from the user
                if (boyName.Contains(userInput))
                {
                    Console.WriteLine(boyName);
                }   
            }
            // if the user types all the user will then get all the names from the array
            if (userInput == "all")
            {
                foreach (string boyName1 in boyNames)
                {
                    Console.WriteLine(boyName1);
                }
            }
        }
    }
}
