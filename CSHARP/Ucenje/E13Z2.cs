﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{


    internal class E13Z2
    {
        public static void Izvedi()
        {
            Zad1();

        }

        // Zadatak 1. program upisuje ime i ispisuje koliko ime ima znakova
        private static void Zad1()
        {
            Console.WriteLine("dobrodošli u 1.zadatak");
            string ime;
            while (true)
            {
                ime = E12Metode.UcitajString("unesi ime osobe(-1 za kraj): ");
                if (ime.ToUpper() == "-1")
                {
                    Console.WriteLine("Hvala na korištenju programa 1. zadatak!");
                    break;
                }
                Console.WriteLine(ime.Length);
            }

        }

    }
}
