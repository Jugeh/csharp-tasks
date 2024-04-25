using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puhelinlasku
{
    /// <summary>
    /// Luokka Puhelu edustaa yhden puhelun laskutustietoja.
    /// Puhelusta tiedetään kesto ja hinta minuutissa ja
    /// paikallisverkkomaksu. Kun puheluolio on luotu, 
    /// sen tietoja ei enää muuteta.
    /// </summary>
    public class Puhelu
    {

        private const double paikallisverkkomaksuAloitusmaksu = 0.0099;
        private const double paikallisverkkomaksuMinuuttihinta = 0.0199;

        private double aloitusmaksuYhteensä;
        private double puheluhintaYhteensä;
        private double kesto;

        /// <summary>
        /// Luo uuden puheluolion
        /// </summary>
        /// <param name="aloitusmaksu">Puhelun aloitusmaksu euroissa, ei sisällä paikallisverkkomaksua. (double)</param>
        /// <param name="minuuttihinta">Puhelun minuuttihinta euroissa, ei sisällä paikallisverkkomaksua. (double)</param>
        /// <param name="kesto">Puhelun kesto minuuteissa. (double)</param>
        public Puhelu(double aloitusmaksu, double minuuttihinta, double kesto)
        {
            aloitusmaksuYhteensä = aloitusmaksu + paikallisverkkomaksuAloitusmaksu;
            puheluhintaYhteensä = minuuttihinta + paikallisverkkomaksuMinuuttihinta;
            this.kesto = kesto;
        }

        
        public double Kesto
        {
            get
            {
                return kesto;
            }
        }

        /// <summary>
        /// Kertoo, onko puhelu kalliimpi kuin parametrina tuleva toinen puhelu.
        /// </summary>
        /// <param name="toinenPuhelu">Verrattava puheluolio (Puhelu).</param>
        /// <returns>true, jos puhelu kalliimpi kuin parametrina tuleva, muuten false.</returns>
        public bool onkoKalliimpKuin(Puhelu toinenPuhelu)
        {
            return HaeHinta() > toinenPuhelu.HaeHinta();
        }

        /// <summary>
        /// Palauttaa puhelun kokonaishinnan euroina.
        /// </summary>
        /// <returns>Puhelun kokonaishinta euroina. (double)</returns>
        public double HaeHinta()
        {
            return aloitusmaksuYhteensä + puheluhintaYhteensä * kesto;
        }

        /// <summary>
        /// Palauttaa puhelun tiedot tekstimuodossa erotellen puhelun
        /// hinnan ja keston.
        /// </summary>
        /// <returns>puhelun kuvauksen tekstinä. (string)</returns>
        public String HaePuhelunKuvaus()
        {
            return kesto + " min, " +
                   HaeHinta() + " e " +
                   "(" + aloitusmaksuYhteensä + " e" + " + " + puheluhintaYhteensä + " e/min)";
        }
    }

}
