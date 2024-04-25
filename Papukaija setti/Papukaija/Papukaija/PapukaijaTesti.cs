using System;


namespace Papukaija
{
    class PapukaijaTesti
    {
        static void Main()
        {
            Papukaija eka = new Papukaija("Polli", "kirjava");
            Console.WriteLine(eka.Puhu());
            eka.OpiLause("Silliä pöytään");
            Console.WriteLine(eka.Puhu());
            Console.WriteLine(eka);


            //ToDo: Luo lisää papukaijoja ja opeta niitä puhumaan
            Papukaija toka = new Papukaija("Nakke", "vihreä");
            Console.WriteLine(toka.Puhu());
            toka.OpiLause("Viunaa pöytään");

            Console.WriteLine(toka.Puhu());
            Console.WriteLine(toka);
            toka.OpiLause(eka.Puhu());
            Console.WriteLine(toka.Puhu());
            Console.WriteLine(toka);


            Papukaija kolmas = new Papukaija("Kaija", "raidallinen");
            Console.WriteLine(kolmas.Puhu());
            kolmas.OpiLause("Hei moi");

            Console.WriteLine(kolmas.Puhu());
            Console.WriteLine(kolmas);

            Console.ReadKey();
        }
    }
}
