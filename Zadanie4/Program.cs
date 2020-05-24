using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {

        static int PodwojElement(int[] tab, int indeks) {
            return 2 * tab[indeks];
        }

        static int PodwojPierwszyElement(int[] array) {
            return 2*array[0];
        }
        static void Main(string[] args)
        {
            int[] array = { -1, -10, -100 };
            //Console.WriteLine(PodwojPierwszyElement(array));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(PodwojElement(array, i)); 
            }

            Console.ReadKey();
        }
    }
}
