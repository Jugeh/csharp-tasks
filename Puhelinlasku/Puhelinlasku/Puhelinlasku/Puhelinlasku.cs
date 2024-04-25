using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puhelinlasku
{
    /// <summary>
    /// Luokka Puhelinlasku esittää asiakkaan puhelinlaskua.
    /// Laskussa on kaikki siihen kuuluvat puhelut, jotka 
    /// yhdessä muodostavat koko laskun.
    /// </summary>
    public class Puhelinlasku
    {
        private double kuukausimaksu;
        private string asiakas;
        private List<Puhelu> soitetutPuhelut;

        /// <summary>
        /// Luo uuden tyhjän puhelinlaskun annetulle asiakkaalle.
        /// </summary>
        /// <param name="asiakas">Asiakkaan nimi. (string)</param>
        public Puhelinlasku(string asiakas)
        {
            this.asiakas = asiakas;
            this.soitetutPuhelut = new List<Puhelu>();
        }

        /// <summary>
        /// Lisää laskuun annetun puhelun
        /// </summary>
        /// <param name="uusiPuhelu">Laskuun lisättävä puheluolio.</param>
        public void LisaaPuhelu(Puhelu uusiPuhelu)
        {
            soitetutPuhelut.Add(uusiPuhelu);
        }

        /// <summary>
        /// Palauttaa laskun kokonaishinnan sisältäen kuukausimaksun.
        /// </summary>
        /// <returns>Puhelujen yhteishinta euroissa. (double)</returns>
        public double HaeKokonaishinta()
        {
            double yhteensa = kuukausimaksu;
            foreach (Puhelu puhelu in soitetutPuhelut)
            {  
                yhteensa = yhteensa + puhelu.HaeHinta();
            }
            return yhteensa;
        }

        /// <summary>
        /// Palauttaa laskun puheluerittelyn puheluittain.
        /// </summary>
        /// <returns>Puheluerittely tekstinä. (string)</returns>
        public string HaeErittely()
        {
            string erittely; 
            erittely = asiakas + ":";
            foreach (Puhelu puhelu in soitetutPuhelut)
            {
                erittely = erittely + "\n - " + puhelu.HaePuhelunKuvaus();
            }
            return erittely + "\n";
        }

        /// <summary>
        /// Hakee laskun pisimmän puhelun.
        /// </summary>
        /// <returns>Palauttaa puheluolion. (Puhelu)</returns>
        public Puhelu HaePisinPuhelu()
        {
            Puhelu pisinPuhelu = soitetutPuhelut[0];

            foreach(Puhelu puhelu in soitetutPuhelut)
            {
                if(puhelu.Kesto > pisinPuhelu.Kesto)
                {
                    pisinPuhelu = puhelu;
                }
            }
            return pisinPuhelu;
        }

        //ToDo: kalleimman puhelun hakeva metodi.
        public Puhelu HaeKalleinPuhelu()
        {
            Puhelu kalleinPuhelu = soitetutPuhelut[0];

            foreach(Puhelu puhelu in soitetutPuhelut)
            {
                if(puhelu.HaeHinta() > kalleinPuhelu.HaeHinta())
                {
                    kalleinPuhelu = puhelu;
                }
            }
            return kalleinPuhelu;
        }
    }
}
