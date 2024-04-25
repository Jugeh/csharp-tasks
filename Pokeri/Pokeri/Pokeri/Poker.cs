using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    /// <summary>
    /// Pelin luokka. Luo pakan ja listan käsille.
    /// </summary>
    public class Poker
    {
        private Pakka pakka;
        private List<Kasi> kadet;

        /// <summary>
        /// Luojametodi, joka luo tyhjän pakan ja tyhjän listan käsille.
        /// </summary>
        public Poker()
        {
            pakka = new Pakka();
            kadet = new List<Kasi>();
        }

        /// <summary>
        /// Lisää listaan uuden tyhjän käden annetulle palaajalle.
        /// </summary>
        /// <param name="omistaja">Käden omistajan nimi (string).</param>
        public void LisaaTyhjaKasi(string omistaja)
        {
            kadet.Add(new Kasi(omistaja));
        }

        /// <summary>
        /// Hakee pelin kädet sisältävän listan.
        /// </summary>
        public List<Kasi> Kadet
        {
            get
            {
                return kadet;
            }
        }

        /// <summary>
        /// Ottaa kortteja pakasta ja täyttää kädet.
        /// </summary>
        public void JaaKortit()
        {
            // Jakaa kortin kerrallaan vuorotellen jokaiseen pelin käteen.
            for (int i=0; i < PakanTiedot.korttejaKadessa; i++)
            {
                foreach(Kasi kasi in kadet)
                {
                    kasi.LisaaKortti(pakka.JaaYksiKortti());
                }
            }
        }

        /// <summary>
        /// Poistaa annetusta kädestä kaikki listalla olevat kortit
        /// </summary>
        /// <param name="kasi">Käsi, josta kortit poistetaan</param>
        /// <param name="kortit">Lista poistettavista korttiolioista.</param>
        public void PoistaTarpeettomatKortit(Kasi kasi, List<Kortti> kortit)
        {
            foreach(Kortti kortti in kortit)
            {
                kasi.PoistaKortti(kortti);
            }
        }
    }
}


        
