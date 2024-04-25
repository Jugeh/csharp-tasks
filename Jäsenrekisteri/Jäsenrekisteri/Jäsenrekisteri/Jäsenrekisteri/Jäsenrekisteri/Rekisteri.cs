using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    /// <summary>
    /// Luokka Rekisteri esittää Jäsenrekisteriä. Sinne voi
    /// lisätä ja poista jäseniä.
    /// </summary>
    public class Rekisteri
    {
        private List<Jasen> jasenet;
        private List<Maksu> maksaneet;

        /// <summary>
        /// Luo uuden jäsenrekisterin ja listan sen jäsenistä ja jäsenten jäsenmaksun
        /// </summary>
        /// <param name="jasenet">Lista jäsenrekisterin jäsenistä</param>
        /// <param name="maksaneet">Lista jäsenmaksun maksaneista jäsenistä</param>
        public Rekisteri(List<Jasen> jasenet, List<Maksu> maksaneet)
        {
            this.jasenet = new List<Jasen>();
            this.maksaneet = new List<Maksu>();
        }
        /// <summary>
        /// Luo uuden jäsenen jäsenrekisteriin
        /// </summary>
        /// <param name="uusiJasen">Uusi jäsen jäsenrekisteriin</param>
        public void LisaaJasen(Jasen uusiJasen)
        {
            jasenet.Add(uusiJasen);
        }

        /// <summary>
        /// Luo uuden maksun jäsenrekisteriin
        /// </summary>
        /// <param name="uusiJasen">Uusi maksu jäsenrekisteriin</param>
        public void LisaaMaksu(Maksu uusiMaksu)
        {
            maksaneet.Add(uusiMaksu);
        }

        /// <summary>
        /// Poistaa jäsenen jäsenrekisteristä
        /// </summary>
        /// <param name="poistettavaJasen">Poistettava jäsen</param>
        public void PoistaJasen(Jasen poistettavaJasen)
        {
            jasenet.RemoveAll(x => x == poistettavaJasen);
        }

        /// <summary>
        /// Hakee jäsenet jotka eivät ole maksaneet annetun vuoden jäsenmaksua.
        /// </summary>
        /// <param name="vuosi">Annettava vuosi</param>
        public List<Maksu> HaeMaksamattomat(int vuosi)
        {
            List<Maksu> loydetyt = new List<Maksu>();
            List<Maksu> maksamattomat = new List<Maksu>();

            foreach (Maksu maksaja in maksaneet)
            {
                if (maksaja.Maksupaiva.Year == vuosi)
                {
                    loydetyt.Add(maksaja);
                }
            }
            maksamattomat = maksaneet.Except(loydetyt).ToList();
            return maksamattomat;
        }

        /// <summary>
        /// Annetun vuoden jäsenmaksujen summa
        /// </summary>
        /// <param name="vuosi">Annettava vuosi</param>
        public int Summa(int vuosi)
        {
            int tulos = 0;
            foreach (Maksu maksaja in maksaneet)
            {
                if (maksaja.Maksupaiva.Year == vuosi)
                {
                    tulos = tulos + maksaja.Maara;
                }
            }
            return tulos;
        }

        /// <summary>
        /// Hakee kaikki jäsenet
        /// </summary>
        public List<Jasen> Jasenet
        {
            get { return jasenet; }
        }

        /// <summary>
        /// Hakee kaikki maksut
        /// </summary>
        public List<Maksu> Maksaneet
        {
            get { return maksaneet; }
        }
    }
}
