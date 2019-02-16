using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace opg_SqlNumberGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // global vars
            Random rnd = new Random();
            int rndNumber = 0;
            List<string> numbers = new List<string>();

            // for loop to create the numbers and then add them to the list 
            for (int i = 0; i < 1000001; i++)
            {
                rndNumber = rnd.Next(0, 10000);
                numbers.Add(i + "," + rndNumber);
            }

            // the stream writer to write to the file 
            using (var writer = new StreamWriter(
                new FileStream(@".\Number.txt", FileMode.Create)))
            {
                // a foreach that adds all the info into the file and when it's done it closes the connection
                foreach (string sqlN in numbers)
                {
                    writer.WriteLine(sqlN);
                }
                writer.Close();
            }
        }
    }
}
