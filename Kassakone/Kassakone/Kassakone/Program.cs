using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassakone
{
    class Program
    {
        static void Main(string[] args)
        {
            Kassakone kassa = new Kassakone();
            double hinta;
            bool jatketaanko;
            string luettu;
            do
            {
                Console.Write("Anna ostoksen hinta: ");
                luettu = Console.ReadLine();
                jatketaanko = double.TryParse(luettu, out hinta);
                if (jatketaanko == true)
                {
                    kassa.LisaaOstos(hinta);
                }
            } while (jatketaanko == true);
            Console.WriteLine("Ostokset maksavat {0}", kassa.HaeLoppusumma());
            Console.Write("Maksettu: ");
            double annettu = double.Parse(Console.ReadLine());
            double takaisin = kassa.LaskeVaihtoraha(annettu);
            Console.WriteLine("Anna takaisin {0}", takaisin);

            Console.ReadKey();
        }
    }
}
