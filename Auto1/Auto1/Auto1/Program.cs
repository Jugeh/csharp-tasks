using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto1
{
    class AutoTesti
    {
        static void Main()
        {
            Auto kulkuneuvo, kaara;
            // Luodaan uusi Auto-olio ja tulostetaan sen kuvaus
            kulkuneuvo = new Auto("Volkkari", "X5", "Jorma", "ABC-123");
            Console.WriteLine(kulkuneuvo.AnnaKuvaus());

            // Lisätään auton matkamittariin 10 km ja tulostetaan sen kuvaus uudestaan
            kulkuneuvo.LisaaMatka(10);
            Console.WriteLine(kulkuneuvo.AnnaKuvaus());

            // Luodaan toinen ilmentymä Auto-luokasta ja tulostetaan sen kuvaus
            kaara = new Auto("Sitikka", "Sitruuna", "Janne", "XYZ-666");
            Console.WriteLine(kaara.AnnaKuvaus());

            // Lisätään taas matka ensimmäisenä luodun olion matkamittariin ja tulostetaan kuvaus uudelleen
            kulkuneuvo.LisaaMatka(5);
            Console.WriteLine(kulkuneuvo.AnnaKuvaus());

            // Lopuksi tulostetaan vielä toisen auto-olion kuvaus. Tämän olion matkamittarin 
            // lukema on edelleen nolla:
            Console.WriteLine(kaara.AnnaKuvaus());
            
            DateTime dt1 = new DateTime(2015, 12, 20);
            kulkuneuvo.Huolla(dt1);
            DateTime dt2 = new DateTime(2017, 10, 05);
            kulkuneuvo.Huolla(dt2);
            Console.WriteLine(kulkuneuvo.HaeHuollot());

            DateTime dt3 = new DateTime(2012, 12, 24);
            kaara.Huolla(dt3);
            DateTime dt4 = new DateTime(2019, 04, 01);
            kaara.Huolla(dt4);
            Console.WriteLine(kaara.HaeHuollot());

            Console.ReadKey();
        }
    }
}
