using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace metoder_files
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select the homework you wanna see");
                Console.WriteLine("1 : He shot first - StarWars");
                Console.WriteLine("2 : Delete the file from He Shot first");
                Console.WriteLine("3 : Create starwars folders and txt files");
                Console.WriteLine("4 : Create ");
                Console.WriteLine(Menu(Console.ReadLine()));

            }
        }

        static string Menu(string userInput)
        {
            string returnedString = "";
            switch (userInput)
            {
                case "1":
                    returnedString = HeShotFirst();
                    break;
                case "2":
                    returnedString = DeleteFile();
                    break;
                case "3":
                    returnedString = CreateFolder();
                    break;
                case "4":
                    returnedString = DeleteFile();
                    break;
                case "5":
                    LookUp();
                    break;

                case "test":
                    TestMethod();
                    break;

                default:
                    returnedString = "Wrong input";
                    break;
            }
            return returnedString;

        }

        static string HeShotFirst()
        {
            File.WriteAllText(@".\StarWars.txt", "Han skød først");

            string content = File.ReadAllText(@".\StarWars.txt");
            return content;
        }

        static string DeleteFile()
        {
            File.Delete(@".\StarWars.txt");
            return "File deleted";
        }

        static string CreateFolder()
        {
            Directory.CreateDirectory(@".\Droids");
            Directory.CreateDirectory(@".\Droids\Astromech");
            Directory.CreateDirectory(@".\Droids\Protocol");
            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
            File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "Sir!");

            return "Folder created together with R2D2 and C3P0";
        }

        static string DeleteFolder()
        {
            Directory.Delete(@".\Droids", true);

            return "Droids folder deleted with R2D2 txt file";
        }

        static void LookUp()
        {
            string[] files = Directory.GetFiles(@".\Droids", "*", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }

        static void TestMethod()
        {
            // Testing of GetFiles
            /*foreach (string file in Directory.GetFiles(@".\"))
            {
                Console.WriteLine(file);
            }*/

            //Create Folder
            /*
            Directory.CreateDirectory(@".\folder");
            Console.WriteLine("Folder Created");
            */

            /*//Delete Folder
            Directory.Delete(@".\folder", true);
            Console.WriteLine("Folder deleted");
            */

            /*//GetFiles
            string[] files = Directory.GetFiles(@".\Droids", "*", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
            */
        }
    }
}
