using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kirjasto kirjasto = new Kirjasto("Lappeen kirjasto", new List<Kirja>());
            Kirja kirja1 = new Kirja("Harri Potteri", "Jaska Jokunen", "Sampo", 2020, 123456);
            Kirja kirja2 = new Kirja("C#", "Ope Opettaja", "Harvard", 2022, 100000);
            Kirja kirja3 = new Kirja("SQL", "Sauli Niinistö", "Yale", 2001, 666666);
            Kirja kirja4 = new Kirja("PHP", "Tarja Halonen", "LUT", 2015, 999999);

            kirjasto.LisaaKirja(kirja1);
            kirjasto.LisaaKirja(kirja2);
            kirjasto.LisaaKirja(kirja3);
            kirjasto.LisaaKirja(kirja4);

            Console.WriteLine(kirjasto.KirjastonNimi());

            Console.WriteLine(kirja1.Nimi());
            Console.WriteLine(kirja2.Nimi());
            Console.WriteLine(kirja3.Nimi());
            Console.WriteLine(kirja4.Nimi());

            Console.WriteLine(kirja1.Tekija());

            Console.WriteLine(kirja2.Julkaisija());

            Console.WriteLine(kirja4.JulkaisuVuosi());

            Console.WriteLine(kirja3.ISBN());

            Console.WriteLine(kirja1.AnnaKuvaus());
            Console.WriteLine(kirja2.AnnaKuvaus());
            Console.WriteLine(kirja3.AnnaKuvaus());
            Console.WriteLine(kirja4.AnnaKuvaus());

            Console.Write("Syötä tekijän nimi: ");
            string tekija = Console.ReadLine();
            tekija = kirjasto.HaeTekijanNimella(tekija);
            Console.WriteLine(tekija);

            Console.Write("Syötä poistettavan kirjan nimi: ");
            string poistettava = Console.ReadLine();
            kirjasto.PoistaKirja(poistettava);

            Console.WriteLine(kirjasto.HaeTekijanNimella("C#"));

            Console.ReadKey();
        }
    }
}
