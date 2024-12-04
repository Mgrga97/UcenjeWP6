using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{

    // Napišite program koji unosi ime i broj godina

    // Program ispisuje: Osoba XXXXXX ima YY godina.

    // Ova metoda je uvijek potrebna sada ju kucamo ručno
    internal class E02Z1
    {
        // ovdje se piše rješenje zadatka
        public static void Izvedi() 
        {
            Console.Write("Unesi ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesi broj godina (cijeli broj): ");
            int godine = int.Parse(Console.ReadLine());

            Console.WriteLine("Osoba {0} ima {1} godina.", ime, godine);
        
        
        
        }
        
            



    }
}
