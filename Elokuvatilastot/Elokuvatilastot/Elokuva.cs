using System;


namespace ElokuvaTiedot
{
    /// <summary>
    /// Luokka yhdelle elokuvalle, jonka tiedot luetaan 
    /// tiedostosta.
    /// </summary>
    public class Elokuva
    {
        private string nimi;
        private int vuosi;
        private string ohjaaja;
        private double arvosana;

        /// <summary>
        /// Luo uuden elokuvan.
        /// </summary>
        /// <param nimi="nimi">Elokuvan nimi.</param>
        /// <param nimi="vuosi">Elokuvan julkaisuvuosi.</param>
        /// <param nimi="ohjaaja">Elokuvan ohjaaja.</param>
        /// <param nimi="rating">Elokuvan arvosana.</param>
        public Elokuva(String nimi, int vuosi, String ohjaaja, double arvosana)
        {
            this.nimi = nimi;
            this.vuosi = vuosi;
            this.ohjaaja = ohjaaja;
            this.arvosana = arvosana;
        }

        /// <summary>
        /// Hakee elokuvan nimen.
        /// </summary>
        public string Nimi
        {
            get
            {
                return nimi;
            }
        }


        /// <summary>
        /// Hakee elokuvan julkaisuvuoden.
        /// </summary>
        public int JulkaisuVuosi
        {
            get
            {
                return vuosi;
            }
        }


        /// <summary>
        /// Hakee elokuvan arvosanan.
        /// </summary>
        public double Arvosana
        {
            get
            {
                return arvosana;
            }
        }

        /// <summary>
        /// Hakee elokuvan ohjaajan.
        /// </summary>
        public string Ohjaaja
        {
            get
            {
                return ohjaaja;
            }
        }
    }
}
