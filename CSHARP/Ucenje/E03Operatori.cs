using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Operatori
    {
        public static void Izvedi() 
        
        {

            //Console.WriteLine("E03");
            // operatori za rad s varijablama
            // = je dodjeljivanje vrijednosti
            // == provjera jednakosti -> bool

            int i = 7; // sada zamislimo da je korisnik unio 7 

            Console.WriteLine(i==6);

            // operatori + - * / zbrajanje,oduzimanje,mnozenje,dijeljenje

            int k = 2, l = 1;

            Console.WriteLine(l / k); // dva inta daju INT 

            // mehanizam cast -> 
            Console.WriteLine(l/(float)k);

            // != nije jednako

            Console.WriteLine(i!=k);

            // operator modulo %

            Console.WriteLine("5%2={0}",5%2);

            Console.WriteLine("4%2={0}",4%2);

            // automatsko formatiranje ctrl + k + d

            // uvećavati za 1

            int b = 0;

            // uvećaj za 1
            b = b + 1;

            //kraće
            b += 1;

            //najkraće
            b++;

            Console.WriteLine(b);

            b = 0;

            // b++ prvo koristi pa uveća
            Console.WriteLine(b++); // ovdje je 0

            Console.WriteLine(++b); // ovdje je 2

            // isto vrijedi i za b-- te --b



        
        
        
        }



    }
}
