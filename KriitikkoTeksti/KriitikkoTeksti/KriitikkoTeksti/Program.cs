using System;
using System.Collections.Generic;

namespace KriitikkoTeksti
{
    class KriitikkoTeksti
    {
        static void Main(string[] args)
        {
            // Luo uuden kriitikon, jolla ei ole vielä arvosteluja
            Kriitikko pena = new Kriitikko();

            // Luo uuden leffan. Parametrit: nimi, kommentti, kesto, arvostelu 0-10.
            Leffa leffa1 = new Leffa("Oblivion", "kiva", new TimeSpan(2, 36, 00), 9);
            Leffa leffa2 = new Leffa("Puuha pete", "huono", new TimeSpan(1, 30, 00), 5);
            Leffa leffa3 = new Leffa("Pokemon", "kiva", new TimeSpan(2, 45, 00), 10);
            Leffa leffa4 = new Leffa("Niilo22 The Movie", "huono", new TimeSpan(1, 20, 00), 2);
            Leffa leffa5 = new Leffa("CSharp", "kiva", new TimeSpan(3, 00, 00), 8);

            // Lisää leffan kriitikon arvosteluihin.
            pena.LisaaLeffa(leffa1);
            pena.LisaaLeffa(leffa2);
            pena.LisaaLeffa(leffa3);
            pena.LisaaLeffa(leffa4);
            pena.LisaaLeffa(leffa5);

            Console.Write(pena.Suosikki.Nimi + " ");
            Console.WriteLine(pena.Suosikki.Pituus);

            Leffa[] lista = pena.Leffat;
            int i = 0;
            foreach (Leffa leffa in lista)
            {
                if (leffa.KannattaakoKatsoa() == true)
                {
                    i++;
                }
            }
            Console.WriteLine(i);
            

            Console.ReadKey();
        }
    }
}
