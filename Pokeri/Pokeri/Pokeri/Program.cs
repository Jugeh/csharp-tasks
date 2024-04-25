using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Poker Pokeri = new Poker();
            Pokeri.LisaaTyhjaKasi("Hessu");
            Pokeri.LisaaTyhjaKasi("Mikki");
            Pokeri.JaaKortit();

            Console.WriteLine("Kortit on numeroitu 1-  5.");
            Console.WriteLine("Voit vaihtaa enintään 5.");

            List<Kasi> lista = Pokeri.Kadet;
            foreach (Kasi kasi in lista)
            {
                Console.WriteLine(kasi.Pelaaja);
                Console.WriteLine(kasi);
                Console.WriteLine("Anna Poistettavien korttien numerot välilyönneillä erotettuina");
                string poistettu = Console.ReadLine();
                string[] split = poistettu.Split();

                List<Kortti> kortit = new List<Kortti>();
                foreach (string i in split)
                {
                    int luku = int.Parse(i);
                    kortit.Add(kasi.HaeKorttiPaikasta(luku));
                }
                foreach (Kortti kortti in kortit)
                {
                    kasi.PoistaKortti(kortti);
                }

            }
            Pokeri.JaaKortit();
            foreach (Kasi kasi in lista)
            {
                Console.WriteLine(kasi.Pelaaja);
                Console.WriteLine(kasi);
            }
            Console.ReadKey();
        }

    }
}
