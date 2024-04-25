using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovuokraamo
{
    /// <summary>
    /// Luokka HenkiloAuto esittää tiedot henkilöauto tyypistä
    /// </summary>
    public class HenkiloAuto : Autot
    {
        private int paikat;

        /// <summary>
        /// Luo uuden henkiloauton
        /// </summary>
        /// <param name="tyyppi">Auton tyyppi</param>
        /// <param name="merkki">Auton merkki</param>
        /// <param name="jaljella">Monta autoa jäljellä</param>
        /// <param name="paikat">Monta paikkaa autossa on</param>
        public HenkiloAuto (string tyyppi, string merkki, int jaljella, int paikat)
            : base(tyyppi, merkki, jaljella)
        {
            this.paikat = paikat;
        }

        /// <summary>
        /// Palauttaa tiedon siitä, kuinka monta paikkainen auto on kyseessä
        /// </summary>
        public int Paikat
        {
            get { return paikat; }
        }

        /// <summary>
        /// Palauttaa kaikki tiedot yksittäisestä auton merkistä.
        /// </summary>
        public string HloautonTiedot()
        {
            return string.Format("Auton tyyppi: {0}\nAuton merkki: {1}\nAutoja jäljellä: {2}\nMonta paikkaa: {3}",
                tyyppi, merkki, jaljella, paikat);
        }

    }
}
