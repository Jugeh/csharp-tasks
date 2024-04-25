using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovuokraamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HenkiloAuto hauto1, hauto2;
            hauto1 = new HenkiloAuto("Henkilöauto", "Ford Focus", 3, 5);
            hauto2 = new HenkiloAuto("Henkilöauto", "Mercedes-Benz SLK", 1, 2);

            PakettiAuto pauto1, pauto2;
            pauto1 = new PakettiAuto("Pakettiauto", "Ford Transit", 2, "Umpipaku");
            pauto2 = new PakettiAuto("Pakettiauto", "Volkswagen Lt46 a", 1, "Avolava");

            Vuokraamo vuokraamo;
            vuokraamo = new Vuokraamo(new List<HenkiloAuto>(), new List<PakettiAuto>());

            vuokraamo.LisaaHloauto(hauto1);
            vuokraamo.LisaaHloauto(hauto2);
            vuokraamo.LisaaPaku(pauto1);
            vuokraamo.LisaaPaku(pauto2);

            Console.WriteLine(hauto1.HloautonTiedot());
            Console.WriteLine();
            Console.WriteLine(hauto2.HloautonTiedot());
            Console.WriteLine();
            Console.WriteLine(pauto1.PakunTiedot());
            Console.WriteLine();
            Console.WriteLine(pauto2.PakunTiedot());
            Console.WriteLine();

            vuokraamo.VuokraaHloauto(hauto1);
            Console.WriteLine(hauto1.HloautonTiedot());
            Console.ReadKey();
        }
    }
}
