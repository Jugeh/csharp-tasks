using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikanoppa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valinta;
            Console.WriteLine("Sikanoppa");
            Console.WriteLine("Valitse 1 aloittaaksesi uuden pelin.\nValitse 2 jatkaaksesi aikaisempaa peliä.");
            Console.Write("Valintasi: ");
            valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.Write("Syötä ensimmäisen pelaajan tyyppi (ihminen tai tietokone: ");
                var tyyppi = Console.ReadLine();
                Console.Write("Syötä ensimmäisen pelaajan nimi: ");
                var nimi = Console.ReadLine();

                Pelaaja pelaaja1 = new Pelaaja(tyyppi, nimi);
                Console.WriteLine();

                Console.Write("Syötä toisen pelaajan tyyppi (ihminen tai tietokone: ");
                var tyyppi2 = Console.ReadLine();
                Console.WriteLine("Syötä toisen pelaajan nimi");
                var nimi2 = Console.ReadLine();

                Pelaaja pelaaja2 = new Pelaaja(tyyppi2, nimi2);
                Console.WriteLine();

                Console.Write("Syötä pelin nimi: ");
                var pelinnimi = Console.ReadLine();

                Peli peli = new Peli(pelinnimi, pelaaja1, pelaaja2);
                Console.WriteLine();

                Console.WriteLine("paina 1 keskeyttääksesi peli");
                int keskeytys = int.Parse(Console.ReadLine());
                if (keskeytys == 1)
                {
                    peli.Keskeyta();
                }
                Console.WriteLine("paina 1 jatkaaksesi peli");
                int jatka = int.Parse(Console.ReadLine());
                if (jatka == 1)
                {
                    peli.Jatka();
                }
                Console.WriteLine(pelaaja1.Nimi);
                Console.WriteLine(pelaaja2.Nimi);
            }
                Console.ReadKey();
        }
    }
}
