using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07ForPetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E07forpetlja");

            // 10 puta jedno ispod drugog ispišite Osijek
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            // ovo je rješenje ali nije dobra praksa

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. Osijek iz petlje", i);
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{0}. Unazad", i);
            }

            // ugnježđena petlja
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("\t{0}", i * j);
                }
                Console.WriteLine();
            }

            // DZ lijepo formatirati brojeve prema desno


            // koliko je je zbroj prvih 100 brojeva?
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i; // postojećoj sumi dodajem vrijednost i ( sum = sum + i je sum +=
            }
            Console.WriteLine(sum);
            int x = 100;
            Console.WriteLine((x + 1) * x / 2);

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine(i);
                    Console.Write("{0},", i);
                }
            }
            // DZ Maknuti zadnji zarez

            Console.WriteLine();
            int idiOd = 12;
            int idiDo = 34;

            for (int i = idiOd; i <= idiDo; i++)
            {
                Console.WriteLine(i);
            }


            int[] brojevi = { 1, 2, 3, 4, 5, 6, 6, 5, 4, 3 };

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }

            int[,] tablica =
                {
                {1, 2, 3,},
                { 4, 5, 6,},
                { 7, 8, 9,}
            };

            for (int i = 0; i < tablica.GetLength(0); i++) // X dimenzija GetLenght(0)
            {
                for (int j = 0; j < tablica.GetLength(1); j++) // Y dimenzija GetLenght(1)
                {
                    Console.Write(tablica[i,j] + " ");
                }
                Console.WriteLine();
            }




        }


    }
}
