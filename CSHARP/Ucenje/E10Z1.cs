using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z1
    {
        public static void Izvedi()
        {
            Console.WriteLine("E10z1");
            Console.Write("Unesi izraz: ");
            string izraz = Console.ReadLine();
            Console.WriteLine(izraz);

            if (izraz.Length%2 == 0 )
            {
                // izraz ima parni broj znakova
                Console.WriteLine("parni broj znakova");
                bool palindrom = true;
                for (int i = 0; i < izraz.Length / 2; i++) 
                {
                    if (izraz[i] != izraz[izraz.Length -1 - i]){
                        palindrom= false;
                        break;
                }
                }
                Console.WriteLine(palindrom ? "da" : "ne");
            }else
            
            {
                // izraz ima neparni broj znakova
                Console.WriteLine("neparni broj znakova");
            }
        }
        // kisik 5 znakova - neparni
        // anavolimilovana - 
        // a mene tu ni minute nema -

    } 
}
