using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalkapalloEiToimi
{
    /// <summary>
    /// Luokka Joukkue esittä jalkapallojoukkuetta 
    /// joukkuetilastoissa. Joukueesta talletetaan
    /// vain joitakin perustietoja. Joukkueen tietoja
    /// ei muuteta luomisen jälkeen.
    /// </summary>
    public class Joukkue
    {
        /// <summary>
        /// Joukueen nimi.
        /// </summary>
        private String nimi;
        /// <summary>
        /// Joukkueen kotikenttä.
        /// </summary>
        private String kotikentta;

        /// <summary>
        /// Alustusmetodi luo uuden joukkueen annetuilla tiedoilla.
        /// </summary>
        /// <param name="nimi">Joukkueen nimi.</param>
        /// <param name="kotikentta">Joukkueen kotikenttä.</param>
        public Joukkue(string nimi, string kotikentta)
        {
            this.nimi = nimi;
            this.kotikentta = kotikentta;
        }

        /// <summary>
        /// Hakee joukkueen nimen.
        /// </summary>
        /// <returns>Joukkueen nimi. (string)</returns>
        public string HaeNimi()
        {
            return nimi;
        }

        /// <summary>
        /// Hakee joukkuene kotikentän.
        /// </summary>
        /// <returns>Joukkueen kotikenttä. (string)</returns>
        public String HaeKentta()
        {
            return kotikentta;
        }
    }
}
