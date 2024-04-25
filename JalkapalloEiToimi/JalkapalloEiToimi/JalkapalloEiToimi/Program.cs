using System;

namespace JalkapalloEiToimi
{
    class JalkapalloTesti
    {
        static void Main(string[] args)
        {
            Joukkue joukkue1 = new Joukkue("Manchester United", "Old Trafford");
            Joukkue joukkue2 = new Joukkue("Liverpool", "Anfield");

            // Luo uusi ottelu, lisää joukkueet ja maleja. Hae tilastoja.
            Ottelu ottelu1 = new Ottelu(joukkue2, joukkue1);
            ottelu1.LisaaKotimaali();
            ottelu1.LisaaVierasmaali();
            ottelu1.LisaaVierasmaali();
            ottelu1.LisaaVierasmaali();
            ottelu1.LisaaKotimaali();
            Console.WriteLine(ottelu1.HaeKotimaalit());
            Console.WriteLine(ottelu1.HaeVierasmaalit());
            Console.WriteLine(ottelu1.HaeMaaliero());

            // Lisää maaleja ja tilastoja:
            ottelu1.LisaaKotimaali();
            ottelu1.LisaaKotimaali();
            Console.WriteLine(ottelu1.OnkoTasapeli());
            Console.WriteLine(ottelu1.HaeYhteismaalit());
            Console.WriteLine(ottelu1.HaeMaaliero());

            // Toinen ottelu:
            Ottelu ottelu2 = new Ottelu(joukkue1, joukkue2);
            // Kummassa tehtiin enemmän maaleja:
            Console.WriteLine(ottelu2.OnkoRunsasmaalisempi(ottelu1));
            Console.WriteLine(ottelu1.OnkoRunsasmaalisempi(ottelu2));

            // Hae otteluiden kentät:
            Console.WriteLine(ottelu1.HaePelikentta());
            Console.WriteLine(ottelu2.HaePelikentta());

            Console.ReadKey();

        }
    }
}

