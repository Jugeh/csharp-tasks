using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Kivi, sakset, paperi peli.
/// Pelaaja valitsee vuorollaan jonkun yllämainituista konetta vastaan.
/// </summary>

namespace Kps_Viimeistelty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pelaajat ja niiden nimet
            string pelaaja1 = "Pelaaja1";
            string kone = "Kone";
            //pelaajan valinta
            int valinnat;
            //koneen valinta
            int koneValinta;

            //Pelin silmukka. Kutsutaan kummankin valintafunktiota.
            //Valinnan jälkeen katsotaan kumpi voitti
            //Ohjelma jatkuu kunnes käyttäjä painaa Enteriä.
            while (true)
            {
                Console.WriteLine("Valinnat:");
                Console.WriteLine("Enter - Lopeta");
                Console.WriteLine("1 - kivi");
                Console.WriteLine("2 - sakset");
                Console.WriteLine("3 - paperi");
                
                //Kutsutaan funktiota pelaajan valinnasta
                valinnat = Pelaaja1Valitsee();
                //Kutsutaan funktiota koneen valinnasta
                koneValinta = KoneValitsee();

                //Määritellään if rakenteella et mikä numero voittaa kunkin
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
        //Pelaajan valinta funktio
        //Funktio palauttaa pelaajan valinnan tai lopettaa ohjelman
        static int Pelaaja1Valitsee()
        {
            //Minkä luvun pelaaja valitsee
            int valinta;
            //Muuttuja tyhjälle merkille
            string tyhja;
            Console.Write("Mikä on valintasi: ");
            tyhja = Console.ReadLine();
            //Jos valinta on tyhjä ohjelma keskeytyy
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
        //Koneen valinta funktio
        //Funktio palauttaa koneen valinnan
        static int KoneValitsee()
        {
            Random rnd = new Random();
            int valinta = rnd.Next(1, 4);
            Console.WriteLine("Kone valitsi " + valinta);

            return valinta;
        }
    }
}
