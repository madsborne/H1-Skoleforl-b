using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg3_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type in your name");
            string name = Console.ReadLine();

            Console.WriteLine("now type in your age");
            int age = Int32.Parse(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine(name + " du skal gå med ble");
            }
            else if (age > 3 && age < 15)
            {
                Console.WriteLine(name + " du må ingenting");
            }
            else if (age > 15 && age < 18)
            {
                Console.WriteLine(name + " du må drikke");
            }
            else
            {
                Console.WriteLine("du må alt");
            }
        }
    }
}
