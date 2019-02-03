using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_arrays2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            AddGrades(0, 0);
        }
        public static void AddGrades(int numberOne, int numberTwo)
        {
            int[,] grades = new int[1000, 1000];

            grades[0, 0] = 1;
            grades[0, 1] = 2;

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
