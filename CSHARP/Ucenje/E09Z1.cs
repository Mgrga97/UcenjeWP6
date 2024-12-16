using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika unosi cijeli broj 
    // Koristeći while petlju program ispisuje 
    // zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
    // unos 10 ispis 30
    // unos 12 ispis 42

    internal class E09Z1
    {

        public static void Izvedi()
        {
            //Console.WriteLine("Z1");
            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj);


            int i = 0, sum = 0;
            while (i<=broj)
            {
                Console.WriteLine("U petlji sam, i={0}",i);
                if(++i % 2 == 0)
                {

                    sum += i++;
                }
            }
            Console.WriteLine(sum);


        }
        

    }
}
