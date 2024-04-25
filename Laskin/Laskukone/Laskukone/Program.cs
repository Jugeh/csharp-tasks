using System;

namespace Laskukone
{
    class LaskinTesti
    {
        static void Main(string[] args)
        {
            string rivi;
            bool onnistuiko;
            Laskin laskin = new Laskin();
            while (true)
            {
                Console.WriteLine("Anna laskutoimitus muodossa esim. 2,34 + 4,2.");
                // Luetaan laskutoimitus.
                rivi = Console.ReadLine();
                // Jos pelkkä enter, lopetetaan.
                if (rivi.Length == 0)
                {
                    Console.WriteLine("Lopetetaan");
                    Console.ReadKey();
                    break;
                }
                // Puretaan teksti laskutoimituksen osiksi.
                onnistuiko = laskin.PuraRivi(rivi);
                // Jos syötteessä vikaa, ohitetaan
                if (onnistuiko == false)
                {
                    Console.WriteLine(laskin.HaeSyy() + ". Ei voi laskea.");
                }
                if (onnistuiko == true)
                {
                    laskin.Laske();
                    Console.WriteLine("Tulos on " + laskin.HaeTulos());
                }
            }
        }
    }
}
