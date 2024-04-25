using System;


namespace KriitikkoTeksti
{
    /// <summary>
    /// Luokka Leffa esittää käyttäjän muistiinpanoja
    /// leffa-arvosteluista. Jokaisessa arvostelussa 
    /// on lefan nimi, lyhyt kommentti, pituus ja 
    /// arvosana 1 - 10. Leffan tietoja ei muuteta
    /// luomisen jälkeen.
    /// </summary>
    class Leffa
    {
        /// <summary>
        /// Elokuvan nimi</summary>
        private string nimi;
        /// <summary>
        /// Lyhyt kuvaus elokuvan sisällöstä
        /// </summary>
        private string kuvaus;
        /// <summary>
        /// Elokuvan pituus ajanjaksotyyppinä
        /// </summary>
        private TimeSpan pituus;
        /// <summary>
        /// Elokuvan saama arvosana
        /// </summary>
        private int arvosana;

        /// <summary>
        /// Luo uuden leffan annetuilla tiedoilla
        /// </summary>
        /// <param name = "nimi" > Arvostellun elokuvan nimi</param>
        /// <param name = "kommentti" > Kommentit elokuvasta</param>
        /// <param name = "kesto" > Elokuvan pituus hh:mm:ss</param>
        /// <param name = "arvostelu" > Arvosana elokuvalle</param>
        public Leffa(string nimi, string kommentti, TimeSpan kesto, int arvostelu)
        {
            this.nimi = nimi;
            kuvaus = kommentti;
            pituus = kesto;
            arvosana = arvostelu;
        }

        /// <summary>Elokuvan nimi property</summary>
        /// <value>
        /// Tyyppinä string.</value>
        public string Nimi
        {
            get { return nimi; }
        }

        /// <summary>Elokuvan kommentti property</summary>
        /// <value>
        /// Tyyppinä string.</value>
        public string Kuvaus
        {
            get { return kuvaus; }
        }

        /// <summary>Elokuvan pituus property</summary>
        /// <value>
        /// Tyyppinä TimeSpan.</value>
        public TimeSpan Pituus
        {
            get { return pituus; }
        }

        /// <summary>Elokuvan arvio property</summary>
        /// <value>
        /// Tyyppinä int 1 - 10.</value>
        public int Arvosana
        {
            get { return arvosana; }
        }


        ///<summary>Palauttaa tiedon siitä, onko leffa katsomisen
        ///arvoinen. Tämä saadaan vertaamalla pituutta arvioon.
        ///Jos kuva on yli kaksituntinen ja arvosana on alle 7,
        ///ei kannata vaivautua.</summary>
        ///<returns>Kannattaako katsoa totuusarvona true/falses</returns>
        public bool KannattaakoKatsoa()
        {
            if (Arvosana < 7 && Pituus > new TimeSpan(2, 00, 00))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Kertoo, onko leffa parempi kuin toinen.
        /// Vertailu perustuu arvosanoihin.
        /// </summary>
        /// <param name="toinenLeffa">verrattava leffa</param>
        /// <returns>Tieto (true/false), onko leffa parempi kuin parametrina tuleva.</returns>
        public bool OnkoParempi(Leffa toinenLeffa)
        {
            return Arvosana > toinenLeffa.Arvosana;
        }

    }
}
