using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskukone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            char merkki, valinta;

            Console.WriteLine("Laskutoimitus. E/e lopettaa. J/j jatkaa.");
            while (true)
            {
                luku1 = TarkistaEkaLuku();

                luku2 = TarkistaTokaLuku();
                

                merkki = TarkistaSyote();
                if (merkki == '+')
                {
                    Console.WriteLine(luku1 + " + " + luku2 + " = " + (luku1 + luku2));
                }
                else if (merkki == '-')
                {
                    Console.WriteLine(luku1 + " - " + luku2 + " = " + (luku1 - luku2));
                }
                else if (merkki == '*')
                {
                    Console.WriteLine(luku1 + " * " + luku2 + " = " + (luku1 * luku2));
                }
                else if (merkki == '/')
                {
                    Console.WriteLine(luku1 + " / " + luku2 + " = " + (luku1 / luku2));
                }

                valinta = KysyJatko();
                if (valinta == 'e' || valinta == 'E')
                {
                    break;
                }
                else if (valinta == 'j' || valinta == 'J')
                {
                    Console.WriteLine("Jatketaan");
                }
            }
            Console.ReadLine();
        }
        static char TarkistaEkaLuku()
        {
            int luku1;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Anna eka luku: ");
                luettu = Console.ReadLine();
                onnistuiko = int.TryParse(luettu, out luku1);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Syötä numero: ");
                }
            } while (!onnistuiko);
            return (char)luku1;
        }

        static char TarkistaTokaLuku()
        {
            int luku2;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Anna toka luku: ");
                luettu = Console.ReadLine();
                onnistuiko = int.TryParse(luettu, out luku2);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Syötä numero: ");
                }
            } while (!onnistuiko);
            return (char)luku2;
        }
        static char TarkistaSyote()
        {
            char merkki;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Syötä laskutapa luvuille: ");
                luettu = Console.ReadLine();
                onnistuiko = char.TryParse(luettu, out merkki);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Syötä +, -, * tai / merkki");
                }
                else if (merkki != '+' && merkki != '-' && merkki != '*' && merkki != '/')
                {
                    Console.WriteLine("Syötä +, -, *, tai / merkki");
                }
            } while (!onnistuiko || merkki != '+' && merkki != '-' && merkki != '*' && merkki != '/');
            return merkki;
        }
        static char KysyJatko()
        {
            char valinta;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Jatketaanko? (j/J/e/E) ");
                luettu = Console.ReadLine();
                onnistuiko = char.TryParse(luettu, out valinta);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Anna j/J/e/E ");
                }
                else if (valinta != 'j' && valinta != 'J' && valinta != 'e' && valinta != 'E')
                {
                    Console.WriteLine("Anna j/J/e/E ");
                }
            } while (!onnistuiko || valinta != 'j' && valinta != 'J' && valinta != 'e' && valinta != 'E');
            return valinta;
        }
    }
}
