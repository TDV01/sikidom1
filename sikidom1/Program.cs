using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kocka kocka = new Kocka(9);
                Console.WriteLine($"Kocka oldala: {kocka.OldalA} \n\t Területe:{kocka.Terulet()}\n\t Kerülete:{kocka.Kerulet()}");
            }
            catch (ArgumentOutOfRangeException ad)
            {
                Console.WriteLine(ad.Message);
            }

            Console.WriteLine("Program vége");
            Console.ReadKey();
        }
    }
}
