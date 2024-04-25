using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovuokraamo
{
    /// <summary>
    /// Yliluokasta Vuokraamo löytyy auton merkki, sen tyyppi ja vuokrattavien autojen määrä.
    /// </summary>
    public class Autot
    {
        protected string tyyppi;
        protected string merkki;
        protected int jaljella;

        /// <summary>
        /// Luo uuden vuokraamon
        /// </summary>
        /// <param name="tyyppi">Auton tyyppi</param>
        /// <param name="merkki">Auton merkki</param>
        /// <param name="jaljella">Monta autoa jäljellä</param>
        public Autot(string tyyppi, string merkki, int jaljella)
        {
            this.tyyppi = tyyppi;
            this.merkki = merkki;
            this.jaljella = jaljella;
        }

        /// <summary>
        /// Palauttaa auton tyypin
        /// </summary>
        public string Tyyppi { get { return tyyppi; } }

        /// <summary>
        ///Palauttaa auton merkin
        /// </summary>
        public string Merkki { get { return merkki; } }

        /// <summary>
        /// Palauttaa tiedon, että kuinka monta autoa jäljellä
        /// </summary>
        public int Jaljella { get { return jaljella; } set { jaljella = value; } }
    }
}
