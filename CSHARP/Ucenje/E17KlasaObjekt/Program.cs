using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17KlasaObjekt.Edunova;

namespace Ucenje.E17KlasaObjekt
{
    public class Program
    {
        // 5. vrsta metode (posebna) KONSTRUKTOR
        // konstruktor mora imati isti naziv kao i klasa, a lista parametara može biti različita

       public Program() {
            //Objekt je instanca (pojavnost) klase 

            //Osoba je ime klase ( primjetiti veliko početno slovo O) 
            //osoba je ime objekta


            Osoba osoba = new Osoba();

            osoba.Sifra = 1;

            osoba.Ime = "Pero"; //E12Metode.UcitajString("Unesi ime: ");
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);

            osoba = new Osoba() {
                Sifra=2,
                Ime="Karlo",
                Prezime="Lik" 

            };


            Console.WriteLine("{0} {1}",osoba.Ime, osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();

            Mjesto mjesto = new Mjesto() { Naziv = "Osijek", PostanskiBroj = "31000" };

            // osoba.Mjesto = mjesto;

            // Ispišemo OSIJEK
           // Console.WriteLine(osoba.Mjesto.Naziv);

            // stari način provjere
            if (osoba.Mjesto != null)
            {
                Console.WriteLine(osoba.Mjesto.Naziv); ;
            }

            // kraći način
            Console.WriteLine(osoba.Mjesto?.Naziv); // ? je ovdje indikacija da me pukne ako je null

            osoba.Mjesto = new Mjesto() { Naziv = "Osijek" };

            Console.WriteLine(osoba.Mjesto.Zupanija?.Zupan ?? "Prazno");




            Smjer smjer = new Smjer() { Naziv = "Web programiranje" };

            Grupa grupa = new Grupa() { Naziv = "WP6", Smjer = smjer }; // još kraće - new ()

            Polaznik[] polazniciNiz = new Polaznik[2];

            polazniciNiz[0] = new Polaznik() { Ime = "Pero" };
            polazniciNiz[1] = new Polaznik() { Ime = "Marija" };

            grupa.Polaznici = polazniciNiz;

            // ispisati podatke o grupi
            Console.WriteLine(grupa.Naziv);
            Console.WriteLine(grupa.Smjer.Naziv);

            foreach(Polaznik p in grupa.Polaznici)
            {

                Console.WriteLine("{0} {1}",p.Ime, p.Prezime);
            }


        
        }



    }
}
