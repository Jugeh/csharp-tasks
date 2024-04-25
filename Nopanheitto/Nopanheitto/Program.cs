using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nopanheitto
{
    internal class Program
   {
        static void Main(string[] args)
        {
            Random noppa = new Random();
            char valinta;
            int heitto;

            heitto = noppa.Next(1, 7);
            Console.WriteLine("Heitit " + heitto);
            while (true)
            {
                valinta = KysyJatko();
                if (valinta == 'e' || valinta == 'E')
                {
                    break;
                }
                heitto = noppa.Next(1, 7);
                if (valinta == 'k' || valinta == 'K')
                {
                    Console.WriteLine("Heitit " + heitto);
                }

            }
            Console.ReadLine();

        }
        static char KysyJatko()
        {
            char valinta;
            string luettu;
            bool onnistuiko;
            Console.Write("jatketaanko? (k/K/e/E) ");
            luettu = Console.ReadLine();
            onnistuiko = char.TryParse(luettu, out valinta);

            if (onnistuiko != true)
            {
                Console.WriteLine("Anna k/K/e/E ");
            }
            else if (valinta != 'k' && valinta != 'K' && valinta != 'e' && valinta != 'E')
            {
                Console.WriteLine("Anna k/K/e/E ");
            }
            return valinta;
        }

    }
}
