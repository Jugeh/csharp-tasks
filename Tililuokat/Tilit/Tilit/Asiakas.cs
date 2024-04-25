using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilit
{
    /// <summary>
    /// Yksinkertaisen pankkijärjestelmän asiakasta esittävä luokka.
    /// Asiakkaalla on nimi ja muuttumaton asiakastunnus.
    /// </summary>
    public class Asiakas
    {
        private int tunnus;
        private string nimi;

        /// <summary>
        /// Luo uuden asiakkaan annetulla tunnuksella ja nimellä.
        /// </summary>
        /// <param name="tunnus">asiakkaan asiakastunnus (int)</param>
        /// <param name="nimi">asiakkaan nimi</param>
        public Asiakas(int tunnus, String nimi)
        {
            this.tunnus = tunnus;
            this.nimi = nimi;
        }

        /// <summary>
        /// Hakee asiakkaan asiakastunnuksen.
        /// </summary>
        public int Tunnus
        {
            get
            {
                return tunnus;
            }
        }

        /// <summary>
        /// Muuttaa ja hakee asiakkaan nimen.
        /// </summary>
        public string Nimi
        {
            get
            {
                return nimi;
            }
            set
            {
                nimi = value;
            }
        }

    }

}
