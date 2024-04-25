using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    /// <summary>
    /// Korttipelin yksi käsi.
    /// </summary>
    public class Kasi
    {
        private List<Kortti> kasi;
        private string omistaja;
        private string kadenArvo;

        /// <summary>
        /// Luo tyhjän käden annetulle pelaajalle.
        /// </summary>
        /// <param name="nimi">Käden omistajan nimi (string).</param>
        public Kasi(string nimi)
        {
            kasi = new List<Kortti>();
            omistaja = nimi;
        }

        /// <summary>
        /// Palauttaa käden omistajan nimen.
        /// </summary>
        public string Pelaaja
        {
            get
            {
                return omistaja;
            }
        }

        /// <summary>
        /// Hakee annetussa paikassa ilevan kortin.
        /// </summary>
        /// <param name="indeksi">Näytettävän kortin indeksi.</param>
        /// <returns>Näytettävä kortti (Kortti)</returns>
        public Kortti HaeKorttiPaikasta(int indeksi)
        {
            return kasi[indeksi-1];
        }

        /// <summary>
        /// Lisää annetun kortin käteen.
        /// </summary>
        /// <param name="kortti">Lisättävä kortti (Kortti).</param>
        /// <returns>Onnistuiko lisäys. (true/false)</returns>
        public bool LisaaKortti(Kortti kortti)
        {
            // onko kädessä tilaa
            if (kasi.Count < PakanTiedot.korttejaKadessa)
            {
                kasi.Add(kortti);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Jos poistettava kortti löytyy kädestä, se poistetaan.
        /// </summary>
        /// <param name="kortti">Poistettava kortti.</param>
        /// <returns>Onnistuiko poisto.</returns>
        public bool PoistaKortti(Kortti kortti)
        {
            if (kasi.Contains(kortti))
            {
                kasi.Remove(kortti);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Luo tulostusta varten merkkijono, jossa ovat
        /// käden kaikki kortit.
        /// </summary>
        /// <returns>Kaikkien korttien arvot ja maat sisältävä merkkijono.</returns>
        public override string ToString()
        {
            string rivi1 = string.Empty;
            string rivi2 = string.Empty;
            foreach(Kortti kortti in kasi)
            {
                rivi1 = rivi1 + string.Format("{0,10}", kortti.Arvo);
                rivi2 = rivi2 + string.Format("{0,10}", kortti.Maa);
            }
            return rivi1 + "\n" + rivi2;
        }
    }
}


