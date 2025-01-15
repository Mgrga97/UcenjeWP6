using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Program
    {

        public Program(string s)
        {

            Console.WriteLine("E18");

            var smjer = new Smjer() { Sifra = 1, Naziv = "Web programiranje" };

            Console.WriteLine(smjer); // kada se ispisuje cijeli objekt izvodi se metoda toString iz klasa od objekta

            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Perić" };

            osoba = new Osoba("Marija", "Zisku");

            Console.WriteLine(osoba);

            string s1 = "AA";
            Console.WriteLine(s1.GetHashCode()); // hashcode je reprezentant memorijske lokacije

            s1 = "BB";

            Console.WriteLine(s1.GetHashCode());

            // dosadašnja praksa spajanja stringova sa plusom nije dobra

            // dobra praksa je koristiti string builder 

            var sb = new StringBuilder();

            sb.Append("AA");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");

            Console.WriteLine(sb.GetHashCode());


            Smjer smjer1 = new Smjer() { Naziv = "Web programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "Web programiranje" };

            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());    


            Console.WriteLine(smjer.Equals(smjer2));


            // var e = new Entitet();
            // e.Sifra = 1;

            var e = new EntitetImpl() { Sifra=1};


            // još nismo na poliformizmu

            Obrada[] obrade = new Obrada[2];

            obrade[0] = new ObradaUlazniRacun();
            obrade[1] = new ObradaIzlazniRacun();



            // POLIMORFIZAM 
            foreach(Obrada o in obrade)
            {
                o.Procesuiraj();
            }

        }
    }
}
