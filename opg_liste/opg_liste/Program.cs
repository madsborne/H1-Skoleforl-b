using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listeB = new List<int>();
            int modu;

            for (int i = 1; i < 21; i++)
            {
                i = i + 1;
                modu = i % 3;
                listeB.Add(i);
                for (int j = 0; j < listeB.Count; j++)
                {
                    if (listeB[j] == modu)
                    {
                        listeB.Remove(listeB[j]);
                        Console.WriteLine(listeB[j]);
                    }
                }
            }
            
        }
    }
}
