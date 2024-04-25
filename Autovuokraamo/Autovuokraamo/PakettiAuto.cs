using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovuokraamo
{
    /// <summary>
    /// Luokka PakettiAuto esittää tiedot pakettiauto tyypistä
    /// </summary>
    public class PakettiAuto : Autot
    {
        private string malli;

        /// <summary>
        /// Luo uuden pakettiauton
        /// </summary>
        /// <param name="tyyppi">Auton tyyppi</param>
        /// <param name="merkki">Auton merkki</param>
        /// <param name="jaljella">Monta autoa jäljellä</param>
        /// <param name="malli">Monta paikkaa autossa on</param>
        public PakettiAuto (string tyyppi, string merkki, int jaljella, string malli)
            : base(tyyppi, merkki, jaljella)
        {
            this.malli = malli;
        }

        /// <summary>
        /// Palauttaa tiedon siitä, minkä mallinen pakettiauto on kyseessä
        /// </summary>
        public string Malli
        {
            get { return malli; }
        }

        /// <summary>
        /// Palauttaa kaikki tiedot yksittäisestä auton merkistä.
        /// </summary>
        public string PakunTiedot()
        {
            return string.Format("Auton tyyppi: {0}\nAuton merkki: {1}\nAutoja jäljellä: {2}\nAuton malli: {3}",
                tyyppi, merkki, jaljella, malli);
        }
    }
}
