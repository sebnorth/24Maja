using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceiMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            // int y;
            int wynik;

            x = Convert.ToInt32(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out int y);

            wynik = TylkoDodaj.Dodaj(x, y);

            Console.WriteLine($"wynik: {wynik}");
        }
    }
}
