using System.Collections.Generic;

namespace KriitikkoTeksti
{
    ///<summary>Luokka Kriitikko esittää elokuvien arvostelijaa.
    ///Jokainen arvostelija on katsellut ja arvioinut useamman leffan.
    ///</summary>
    class Kriitikko
    {
        /// <summary>
        /// Arvostelijan suosikkielokuva
        /// </summary>
        private Leffa suosikki;
        /// <summary>
        /// Kaikki käyttäjän arvostelemat elokuvat
        /// </summary>
        private List<Leffa> leffat;

        /// <summary>
        /// Konstruktori. Luo uuden käyttäjän, joka
        /// ei ole arvostellut yhtään leffaa
        /// </summary>
        public Kriitikko()
        {
            leffat = new List<Leffa>();
        }

        ///<summary>Lisää uuden leffan arvosteltujen
        ///leffojen listaan.</summary>
        ///<param name="uusiLeffa">Arvostelulistaan lisättävä uusi leffa</param>
        public void LisaaLeffa(Leffa uusiLeffa)
        {
            if (leffat.Count == 0 || uusiLeffa.OnkoParempi(Suosikki))
            {
                Suosikki = uusiLeffa;
            }
            leffat.Add(uusiLeffa);
        }

        /// <summary>
        /// Suosikkileffan property</summary>
        public Leffa Suosikki
        {
            get { return suosikki; }
            set { suosikki = value; }
        }

        ///<summary>palauttaa taulukon käyttäjän
        ///arvioimista leffoista.</summary>
        ///<returns>Lista leffaolioita</returns>
        public Leffa[] Leffat
        {
            get { return leffat.ToArray(); }
        }

    }
}
