using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring the vars
            int height=0;
            int length=0;
            int width=0;
            int volume =0;

            // giving the user instructions on how to use this program
            Console.WriteLine("Hello and welcome please type in 3 values");
            Console.WriteLine("first the height then how wide the object is and lastly the length");

            // tells the user to input the height
            Console.WriteLine("type in the height");
            height = Int32.Parse(Console.ReadLine());

            // tells the user to input the width
            Console.WriteLine("now type in the width");
            width = Int32.Parse(Console.ReadLine());

            // tells the user to input the length
            Console.WriteLine("lastly type in the length");
            length = Int32.Parse(Console.ReadLine());



            // doing the math
            volume = height*width*length;

            Console.WriteLine("the volume is " + volume);

            // stops the program from closing
            Console.ReadKey();

        }
    }
}
