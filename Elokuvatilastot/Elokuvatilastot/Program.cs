using System;

namespace ElokuvaTiedot
{
    class Program
    {
        static void Main(string[] args)
        {
            ParhaatElokuvat parhaatElokuvat = new ParhaatElokuvat();
            Elokuva parhainElokuva = parhaatElokuvat.ParasElokuva();
            Elokuva elokuvanSijoitus = parhaatElokuvat.HaeElokuvaPaikasta(50);
            int maaraVuosittain = parhaatElokuvat.ElokuvienMaaraPerVuosi(parhainElokuva.JulkaisuVuosi);
            Elokuva parasVuonna = parhaatElokuvat.ParasVuosilta(1990, 2000);
            int parhaanSijoitus = parhaatElokuvat.Sijoitus(parasVuonna);

            Console.WriteLine(parhainElokuva.Ohjaaja);
            Console.WriteLine(elokuvanSijoitus.Nimi);
            Console.WriteLine(maaraVuosittain);
            Console.WriteLine(parasVuonna.Nimi);
            Console.WriteLine(parhaanSijoitus);

            Console.ReadKey();

        }
    }
}
