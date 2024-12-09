using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z2
    {

        // za dva unesena cijela broja ispisati sve brojeve izmedu

        // DZ rjesiti program gdje je prvi broj veci od drugog i ispise brojeve 
        public static void Izvedi()
        {
            Console.WriteLine("Unesite prvi broj: ");
            int prvibroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj: ");
            int drugibroj = int.Parse(Console.ReadLine());

            for (int i = prvibroj; i < drugibroj; i++)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
