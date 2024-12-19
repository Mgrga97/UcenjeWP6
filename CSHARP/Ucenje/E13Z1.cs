using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika unosi cijeli broj koji mora biti veći od 0 i manji od 10
    // Program ispisuje faktorijel od unesenog broja (npr. 2*3*4*5*6 za uneseni broj 6)

    internal class E13Z1
    {
        public static void Izvedi()
        {
            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            while (broj < 0 || broj > 10)
            {
                Console.WriteLine("broj mora biti izmedu  1 i 9");
                broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            }

            

        }
        
        private static int Faktorijel(int br)
        {
            if(br  == 1)
            {
                return 1;

            }

            return br * Faktorijel(br - 1);

        }
        
    }
    
}
