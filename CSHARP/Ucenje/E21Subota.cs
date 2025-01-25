using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E21Subota
    {
        public E21Subota()
        {
            Console.WriteLine("Hello from E21 Subota");
            SlucajniBrojevi();
            SlucajniDatumiRodenja();
            ljubav();

        }

        private void ljubav()
        {
            var ona = "Marta";
            var on = "Manuel";

            var izraz = ona.Trim().ToLower() + on.Trim().ToLower();

            Console.WriteLine(izraz);

            int[] brojevi = new int[izraz.Length];
            var ponovilose = 0;
            for (int i = 0; i < izraz.Length; i++)
            {
                for (int j = 0; j < izraz.Length; j++)
                {
                    if (izraz[i] == izraz[j])
                    {
                        brojevi[i]++;
                    }
                }
                
            }


        }

        private void SlucajniDatumiRodenja()
        {
            var random = new Random();

            for (int i = 0; i < 100; i++)
                try
                {
                    var d = new DateTime(2023, random.Next(1, 13), random.Next(1, 32));
                    Console.WriteLine((i+1) + ": " + d.ToString("yyyy-MM-dd"));
                }
                catch
                {
                    i--;

                }

        }

        private void SlucajniBrojevi()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(20, 31));
            }
        }
    }
}
