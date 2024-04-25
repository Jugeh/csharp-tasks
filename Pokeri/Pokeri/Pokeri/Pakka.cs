using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    /// <summary>
    /// Tämä on korttipakka. Pakka voidaan sekoittaa,
    /// sen voi nostaa ja siitä voi jakaa kortteja
    /// kortti kerrallaan.
    /// </summary>
    public class Pakka
    {
        private Random satunnaisluvut;
        private List<Kortti> pakka;

        /// <summary>
        /// Luo uuden korttipakan. Perustiedot haetaan pakan tiedoista.
        /// Luotu pakka sekoitetaan kerran.
        /// </summary>
        public Pakka()
        {
            satunnaisluvut = new Random();
            pakka = new List<Kortti>();
            foreach(string maa in PakanTiedot.maat)
            {
                foreach(string arvo in PakanTiedot.arvot)
                {
                    pakka.Add(new Kortti(maa, arvo));
                }
            }
            SekoitaSatunnaisesti();
        }

        /// <summary>
        /// Sekoittaa pakan satunnaisesti. Käytetään pakan luonnissa.
        /// </summary>
        private void SekoitaSatunnaisesti()
        {
            int n = pakka.Count;
            Kortti arvo;
            while (n > 1)
            {
                n--;
                int k = satunnaisluvut.Next(n + 1);
                arvo = pakka[k];
                pakka[k] = pakka[n];
                pakka[n] = arvo;
            }
        }

        /// <summary>
        /// Sekoittaa pakan, kuten "virallisesti" käsin.
        /// </summary>
        public void Sekoita()
        {
            // Jakaa pakan noin kahtia.
            int raja = PakanTiedot.korttejaPakassa / 2 + satunnaisluvut.Next(-5, 5);
            // Ensimmäinen pino kortteja.
            List<Kortti> pino1 = pakka.GetRange(0, raja);
            // Toinen pino kortteja.
            List<Kortti> pino2 = pakka.GetRange(raja, PakanTiedot.korttejaPakassa - raja);
            // Lista uudelle pakalle.
            List<Kortti> uusiPakka = new List<Kortti>();
            int i = 0;

            // Tyhjennetään pinot uuteen pakkaaan.
            while (i < PakanTiedot.korttejaPakassa)
            {
                int luku1 = 0, luku2 = 0;
                // Otetaan vuorotellen kummastakin pinosta,
                // kunnes ne tyhjenevät.
                if (pino1.Count > 0)
                {
                    // Otetaan pinosta 1 tqi 2 korttia kerralla.
                    luku1 = satunnaisluvut.Next(1, 3);
                    if (pino1.Count < luku1)
                    {
                        luku1 = pino1.Count;
                    }
                    // Lisätään pinosta kortit uuteen pakkaan.
                    uusiPakka.AddRange(pino1.GetRange(0, luku1));
                    // Poistetaan kortit pinosta.
                    pino1.RemoveRange(0, luku1);
                }
                if (pino2.Count > 0)
                {
                    luku2 = satunnaisluvut.Next(1, 3);
                    if (pino2.Count < luku1)
                    {
                        luku2 = pino2.Count;
                    }
                    uusiPakka.AddRange(pino2.GetRange(0, luku2));
                    pino2.RemoveRange(0, luku2);
                }
                // kuinka monta korttia pinoista poistui.
                i = i + luku1 + luku2;
            }
            // Siirretään sekoitettu pakka vanhan tilalle.
            pakka = uusiPakka;
        }

        /// <summary>
        /// Pakan nosto.
        /// </summary>
        public void NostaPakka()
        {
            // Merkataan nostokohta.
            int raja = satunnaisluvut.Next(0, PakanTiedot.korttejaPakassa);
            // Jaetaan pakka kahtia.
            List<Kortti> pino1 = pakka.GetRange(0, raja);
            List<Kortti> pino2 = pakka.GetRange(raja, PakanTiedot.korttejaPakassa - raja);
            // Luodaan uusi pakka uudelle järjestykselle.
            List<Kortti> uusiPakka = new List<Kortti>();
            // Laitetaan päälimmäinen osa alle uuteen pakkaan.
            uusiPakka.AddRange(pino2);
            uusiPakka.AddRange(pino1);
            // Siirretään nostettu pakka vanhan tilalle.
            pakka = uusiPakka;
        }

        /// <summary>
        /// Poistaa pakan päältä yhden kortin ja 
        /// palauttaa sen.
        /// </summary>
        /// <returns>Pakan päälimmäinen kortti</returns>
        public Kortti JaaYksiKortti()
        {
            Kortti kortti;
            kortti = pakka[0];
            pakka.RemoveAt(0);
            return kortti;
        }

    }
}
