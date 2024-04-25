using System;
using System.Collections.Generic;
using System.Linq;

namespace ElokuvaTiedot
{

    class ParhaatElokuvat
    {
        private List<Elokuva> elokuvat;

        public ParhaatElokuvat()
        {
            // tiedostonimi mistä lukea
            string tiedostoNimi = "imdb_top_250_aug_2006.txt";

            // lue elokuvat listaan
            ArvosteluTiedosto tiedosto = new ArvosteluTiedosto(tiedostoNimi);
            this.elokuvat = tiedosto.LueKaikkiElokuvat();

            // järjestele elokuvat arvosanan mukaan
            this.elokuvat.OrderByDescending(x => x.Arvosana);
        }

        /// <summary>
        /// kertoo elokuvien määrän top listoilla
        /// </summary>
        /// <returns>määrä</returns>
        public int Maara()
        {
            return this.elokuvat.Count;
        }

        /// <summary>
        /// hakee elokuvan listalta indeksillä
        /// </summary>
        /// <param name="indeksi">indeksi josta haetaan</param>
        /// <returns>elokuva</returns>
        public Elokuva HaeElokuvaPaikasta(int indeksi)
        {
            return this.elokuvat[indeksi - 1];
        }

        /// <summary>
        /// hakee parhaimman elokuvan listoilta
        /// </summary>
        /// <returns>paras elokuva</returns>
        public Elokuva ParasElokuva()
        {
            return this.HaeElokuvaPaikasta(1);
        }

        /// <summary>
        /// hakee elokuvan sijoituksen
        /// </summary>
        /// <param name="elokuva">élokuva, jonka sijoitusta haetaan</param>
        /// <returns>elokuvan sijoitus</returns>
        public int Sijoitus(Elokuva elokuva)
        {
            return this.elokuvat.IndexOf(elokuva);
        }

        /// <summary>
        /// hakee elokuvien määrän listoilta vuoden mukaan
        /// </summary>
        /// <param name="vuosi">vuosi jolla haetaan</param>
        /// <returns>sinä vuonna julkaistujen elokuvien määrä</returns>
        public int ElokuvienMaaraPerVuosi(int vuosi)
        {
            int maara = 0;
            foreach (Elokuva e in this.elokuvat)
            {
                if (e.JulkaisuVuosi == vuosi)
                {
                    maara++;
                }
            }
            return maara;
        }

        /// <summary>
        /// hakee parhaimman elokuvan vuosien väliltä
        /// </summary>
        /// <param name="alku">mistä lähtien</param>
        /// <param name="loppu">mihin</param>
        /// <returns>paras elokuva vuosien väliltä</returns>
        public Elokuva ParasVuosilta(int alku, int loppu)
        {
            Elokuva paras = null;
            foreach (Elokuva leffa in this.elokuvat)
            {
                if (leffa.JulkaisuVuosi >= alku && leffa.JulkaisuVuosi <= loppu)
                {
                    if (paras == null || paras.Arvosana < leffa.Arvosana)
                    {
                        paras = leffa;
                    }
                }
            }
            return paras;
        }

        internal Elokuva ElokuvienMaaraPerVuosi(Elokuva parasElokuva)
        {
            throw new NotImplementedException();
        }
    }
}
