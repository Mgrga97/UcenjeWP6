
namespace Ucenje
{

    // Za dani izraz bez razmaka provjeriti da li je palindrom

    internal class E10Z1
    {
     
        //abbi
        //kisik
        //anavolimilovana
        //amenetuniminutenema

        public static void Izvedi()
        {

            string s = "RužanEdoOdeNaŽur";
            Console.Write(string.Join(';',s.ToCharArray()));



            Console.WriteLine("Palindrom");
            string izraz = E12Metode.UcitajString("Unesi izraz za provjeru palindroma: ");

            bool palindrom = true;
            izraz = izraz.ToUpper();


            //Ispiši prvo slovo
            Console.WriteLine(izraz[0]); // i = 0

            // Ispiši zadnje slovo
            Console.WriteLine(izraz[izraz.Length-1-0]); // i = 0

            //Ispiši drugo slovo
            Console.WriteLine(izraz[1]); // i = 1

            //Ispiši predzadnje slovo 
            Console.WriteLine(izraz[izraz.Length - 1 - 1]); // i = 1


            for(int i = 0; i < izraz.Length/2; i++)
            {
                if (izraz[i] != izraz[izraz.Length - 1 - i])
                {
                    palindrom = false;
                    break;
                }

            }

            Console.WriteLine("Izraz {0} {1} palindrom", izraz, palindrom ? "JE" : "NIJE");

        }


    }


}
