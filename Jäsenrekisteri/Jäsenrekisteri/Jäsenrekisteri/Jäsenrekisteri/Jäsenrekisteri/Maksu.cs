using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    /// <summary>
    /// Luokka Rekisteri esittää jäsenrekisterin maksulistaa. Sinne voi
    /// lisätä jäsenten maksuja ja hakemaan ne, jotka eivät ole vielä
    /// maksaneet annetun vuoden jäsenmaksua. Luokka pystyy myös näyttämään
    /// annetun vuoden jäsenmaksujen summan.
    /// </summary>
    public class Maksu
    {
        private DateTime maksupaiva;
        private int maara;
        private Jasen maksaja;

        /// <summary>
        /// Kaikki tiedot jäsenmaksusta
        /// </summary>
        /// <param name="maksupaiva">Jäsenmaksun maksupäivä</param>
        /// <param name="maara">Jäsenmaksun määrä</param>
        /// <param name="maksaja">Jäsenmaksun maksaja</param>
        public Maksu(DateTime maksupaiva, int maara, Jasen maksaja)
        {
            this.maksupaiva = maksupaiva;
            this.maara = maara;
            this.maksaja = maksaja;
        }

        /// <summary>
        /// Palauttaa jäsenen jäsenmaksun maksupäivän
        /// </summary>
        public DateTime Maksupaiva
        {
            get { return maksupaiva; }
        }

        /// <summary>
        /// Palauttaa jäsenen jäsenmaksun määrän
        /// </summary>
        public int Maara
        {
            get { return maara; }
        }

        /// <summary>
        /// Palauttaa jäsenmaksun maksaneen jäsenen
        /// </summary>
        public Jasen Maksaja
        {
            get { return maksaja; }
        }
    }
}
