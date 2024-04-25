using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pelaaja1 = "Pelaaja1";
            string kone = "Kone";
            int valinnat;
            int koneValinta;

            while (true)
            {

                Console.WriteLine("Valinnat:");
                Console.WriteLine("Enter - Lopeta");
                Console.WriteLine("1 - kivi");
                Console.WriteLine("2 - sakset");
                Console.WriteLine("3 - paperi");

                valinnat = Pelaaja1Valitsee();

                koneValinta = KoneValitsee();

                if (valinnat == 0)
                {
                    break;
                }

                else if (valinnat == 1 && koneValinta == 2)
                {
                    Console.WriteLine("Voitit!");
                }
                else if (valinnat == 1 && koneValinta == 3)
                {
                    Console.WriteLine("Hävisit!");
                }
                else if (valinnat == 2 && koneValinta == 1)
                {
                    Console.WriteLine("Hävisit!");
                }
                else if (valinnat == 2 && koneValinta == 3)
                {
                    Console.WriteLine("Voitit!");
                }
                else if (valinnat == 3 && koneValinta == 1)
                {
                    Console.WriteLine("Voitit!");
                }
                else if (valinnat == 3 && koneValinta == 2)
                {
                    Console.WriteLine("Hävisit!");
                }
                else
                {
                    Console.WriteLine("Tasapeli!");
                }
            }
        }
        static int Pelaaja1Valitsee()
        {
             int valinta;
             string tyhja;
             Console.Write("Mikä on valintasi: ");
            tyhja = Console.ReadLine();
            if (tyhja == string.Empty)
            {
                return 0;
            }
             valinta = int.Parse(tyhja);

             if (valinta < 1 || valinta > 3)
             {
                 Console.WriteLine("Valitse luku 1, 2 tai 3");
                 Console.Write("Mikä on valintasi: ");
                 valinta = int.Parse(Console.ReadLine());
             }
             return valinta;
        }
            
        static int KoneValitsee()
        {
            Random rnd = new Random();
            int valinta = rnd.Next(1, 4);
            Console.WriteLine("Kone valitsi " + valinta);

            return valinta;
        }
    }
}
