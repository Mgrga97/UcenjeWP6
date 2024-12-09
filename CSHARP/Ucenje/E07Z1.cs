using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z1
    {
        // program od korisnika unosi cijeli broj

        // Ako je uneseni broj paran, program ispisuje zbroj svih brojeva od 1 do unesenog
        // inace program ispisuje svaki neparni broj od 1 do unesenog
        public static void Izvedi() 
        {
            //Console.WriteLine("E07Z1");
            Console.WriteLine("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            // Console.WriteLine(broj);
            if (broj % 2 == 0)
            {
                int sum = 0;
                for (int i = 1; i <= broj; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
