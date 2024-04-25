using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jasen jasen1, jasen2, jasen3, jasen4, jasen5;
            // Luodaan uudet jäsen-oliot
            jasen1 = new Jasen("Jaska", "Ykkönen", "Csharpintie 5", "Imatra", "044 1234567", 2018);
            jasen2 = new Jasen("Timo", "Kakkonen", "Ohjelmoijankatu 1", "Helsinki", "050 1234567", 2017);
            jasen3 = new Jasen("Kari", "Kolmonen", "Jäsenrekisteriraitti 6", "Oulu", "040 1234567", 2017);
            jasen4 = new Jasen("Karoliina", "Nelonen", "Oliotie 2", "Turku", "044 7654321", 2018);
            jasen5 = new Jasen("Tiina", "Vitonen", "Koodarikatu 1", "Rauma", "050 7654321", 2016);

            Maksu maksu1, maksu2, maksu3, maksu4, maksu5;
            // Luodaan maksupäivät ennen olioon siirtoa
            DateTime dt1 = new DateTime(2020, 12, 20);
            DateTime dt2 = new DateTime(2020, 08, 06);
            DateTime dt3 = new DateTime(2020, 11, 01);
            DateTime dt4 = new DateTime(2021, 10, 10);
            DateTime dt5 = new DateTime(2021, 03, 06);

            // Luodaan uudet maksu-oliot
            maksu1 = new Maksu(dt1, 200, jasen1);
            maksu2 = new Maksu(dt2, 200, jasen2);
            maksu3 = new Maksu(dt3, 200, jasen3);
            maksu4 = new Maksu(dt4, 250, jasen4);
            maksu5 = new Maksu(dt5, 250, jasen5);

            Rekisteri jasenrekisteri;

            // Luodaan uusi rekisteri-olio
            jasenrekisteri = new Rekisteri(new List<Jasen>(), new List<Maksu>());

            // Lisätään jäsenet jäsenrekisteriin
            jasenrekisteri.LisaaJasen(jasen1);
            jasenrekisteri.LisaaJasen(jasen2);
            jasenrekisteri.LisaaJasen(jasen3);
            jasenrekisteri.LisaaJasen(jasen4);
            jasenrekisteri.LisaaJasen(jasen5);

            // Lisätään maksut jäsenrekisteriin
            jasenrekisteri.LisaaMaksu(maksu1);
            jasenrekisteri.LisaaMaksu(maksu2);
            jasenrekisteri.LisaaMaksu(maksu3);
            jasenrekisteri.LisaaMaksu(maksu4);
            jasenrekisteri.LisaaMaksu(maksu5);

            // Tulostetaan jäsenten tiedot
            Console.WriteLine("Jäsenet:");
            Console.WriteLine(jasen1.JasenenTiedot());
            Console.WriteLine();
            Console.WriteLine(jasen2.JasenenTiedot());
            Console.WriteLine();
            Console.WriteLine(jasen3.JasenenTiedot());
            Console.WriteLine();
            Console.WriteLine(jasen4.JasenenTiedot());
            Console.WriteLine();
            Console.WriteLine(jasen5.JasenenTiedot());
            Console.WriteLine();

            // Tulostetaan jäsenten maksujen tiedot
            Console.WriteLine("Maksujen tiedot:");

            foreach (var i in jasenrekisteri.Maksaneet)
            {
                Console.WriteLine(i.Maksaja.Etunimi + " " + i.Maksaja.Sukunimi + " " + i.Maara + "$ " + i.Maksupaiva.ToShortDateString());
            }
            Console.WriteLine();

            // Haetaan jäsenet, ketkä eivät ole maksaneet vuoden 2020 jäsenmaksua
            foreach (var i in jasenrekisteri.HaeMaksamattomat(2020))
            {
                Console.WriteLine(i.Maksaja.Etunimi + " " + i.Maksaja.Sukunimi + " ei ole maksanut.");
            }
            Console.WriteLine();

            // Jäsenmaksujen summa annetuilta vuosilta
            Console.WriteLine("Maksujen summa vuosilta 2020 ja 2021:");
            Console.WriteLine(jasenrekisteri.Summa(2020) + "$");
            Console.WriteLine(jasenrekisteri.Summa(2021) + "$");
            Console.WriteLine();

            // Poistetaan jäsen ja tulostetaan jäsenlista
            jasenrekisteri.PoistaJasen(jasen1);
            foreach (var i in jasenrekisteri.Jasenet)
            {
                Console.WriteLine(i.Etunimi + " " + i.Sukunimi);
            }
            Console.ReadKey();
        }   // FIKSAA HAEMAKSAMATTOMAT VIELÄ
    }
}
