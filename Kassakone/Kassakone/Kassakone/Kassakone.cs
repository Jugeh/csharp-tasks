using System;

namespace Kassakone
{
    /// <summary>
    /// Luokka esittää kassakonetta. Kassakoneeseen
    /// voi lisätä ostosten hinnat, hakea loppusumman ja vaihtorahan.
    /// </summary>
    public class Kassakone
    {
        double loppusumma;

        /// <summary>
        /// Alustusmetodi luo uuden kassakoneen ja nollaa loppusumman.
        /// </summary>
        public Kassakone()
        {
            loppusumma = 0;
        }

        /// <summary>
        /// Lisää annetun ostoksen hinnan loppusummaan.
        /// </summary>
        /// <param name="hinta">Lisättävän ostoksen hinta (double).</param>
        public void LisaaOstos(double hinta)
        {
            loppusumma = hinta + loppusumma;
        }

        /// <summary>
        /// Hakee ostasten loppusumman.
        /// </summary>
        /// <returns>Ostosten loppusumma (double).</returns>
        public double HaeLoppusumma()
        {
            return loppusumma;
        }

        /// <summary>
        /// Laskee asiakkaalle annettavan vaihtorahan annetusta summasta.
        /// </summary>
        /// <param name="annettuRaha">Asiakkaan antama rahamäärä.</param>
        /// <returns>Vaihtoraha (double).</returns>
        public double LaskeVaihtoraha(double annettuRaha)
        {
            return annettuRaha - loppusumma;
        }
    }
}
