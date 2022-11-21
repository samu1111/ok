using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 4, 2, 8, 1, 10, 7, 9, 5 };
            int maxHely = 0;
            int minHely = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[maxHely])
                {
                    maxHely = i;
                    
                }
                if (tomb[i] < tomb[minHely])
                {
                    minHely = i;

                }
            }

            

            Console.WriteLine($"Hol van: {maxHely}");
            Console.WriteLine($"Melyik elem: {tomb[maxHely]}");

            Console.WriteLine($"Hol van: {minHely}");
            Console.WriteLine($"Melyik elem: {tomb[minHely]}");


            Console.ReadKey();
        }
    }
}
