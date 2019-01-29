using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_arrays._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the 2d array
            float[,] grades = new float[2, 10];
            float totalScore = 0;
            float totalScore1 = 0;

            // creating the two forloops that will loop through and let me assign values into the 2d array
            for (int groups = 0; groups < 2; groups++)
            {
                for (int students = 0; students < 10; students++)
                {
                    // let me know which student i currently on and which of the two groups he's from
                    Console.WriteLine("Enter grades for the student {0} from group {1}", students + 1, groups + 1);
                    grades[groups, students] = Convert.ToSingle(Console.ReadLine());

                }
            }

            // two more loops that loops through and pluses the grades and then divides them with the total ammount of grades in that group/class
            for (int group = 0; group < grades.GetLength(0); group++)
            {
                for (int student = 0; student < grades.GetLength(1); student++)
                {
                    totalScore += grades[0, student];
                    totalScore1 += grades[1, student];
                }
            }
            Console.WriteLine("The totalscore is for the first group " + totalScore / 10);
            Console.WriteLine("The totalscore is for the second group " + totalScore1 / 10);

        }
    }
}
