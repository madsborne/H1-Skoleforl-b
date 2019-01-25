using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg3
{
    class Program
    {
        static void Main(string[] args)
        {
            // greets the user and tells them the convertion rate
            Console.WriteLine("Welcome to the convertion application");
            Console.WriteLine("input the amount of danish kroner you want to convert");
            Console.WriteLine("also here are the convertion rates");

            // all the rates off the valuta
            double dKroner = 100;
            double usDollar = 656.88;
            double pound = 856.15;
            double euro = 746.67;
            double swedishKroner = 72.88;

            // tells the user the convertion rates right from the start
            Console.WriteLine("_____________________________");
            Console.WriteLine("American dollar " + usDollar);
            Console.WriteLine("British Pound " + pound);
            Console.WriteLine("Euro " + euro);
            Console.WriteLine("Swedish Kroner " + swedishKroner);
            Console.WriteLine("_____________________________");

            Console.WriteLine("Input the ammount of Danish kroner you want converted");

            // takes in the user input and parses it
            double danishKroner = double.Parse(Console.ReadLine());

            // here is where the convertion is happening
            double danishToDollar = (danishKroner / (usDollar / dKroner));
            double danishToPound = (danishKroner / (pound / dKroner));
            double danishToEuro = (danishKroner / (euro / dKroner));
            double danishToSwedishKroner = (danishKroner / (swedishKroner / dKroner));

            // here it writes the end result
            Console.WriteLine("Here is the end convertions");
            Console.WriteLine("_____________________________");
            Console.WriteLine("The ammount of American Dollars " + danishToDollar);
            Console.WriteLine("The ammount of British Pound " + danishToPound);
            Console.WriteLine("The ammount of Euros " + danishToEuro);
            Console.WriteLine("The ammount of Swedish Kroner " + danishToSwedishKroner);
            Console.WriteLine("_____________________________");


            // just for the sake of not closing the program
            Console.ReadKey();



        }
    }
}
