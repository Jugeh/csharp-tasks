using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    /// <summary>
    /// Luokka esittää yhtä pelikorttia korttipakassa. Pakka
    /// on määritelty rakenteessa PakanTiedot.
    /// </summary>
    public class Kortti
    {
        private string maa;
        private string arvo;

        public Kortti(string maa, string arvo)
        {
            this.maa = maa;
            this.arvo = arvo;
        }
        
        /// <summary>
        /// Palauttaa kortin maan.
        /// </summary>
        public string Maa
        {
            get
            {
                return maa;
            }
        }

        /// <summary>
        /// Palauttaa kortin arvon.
        /// </summary>
        public string Arvo
        {
            get
            {
                return arvo;
            }
        }

        /// <summary>
        /// Korttien arvojen vertailussa tarvittava operaattorin 
        /// uudelleen määrittely. Vertaa kortit hakemalla 
        /// korttioliosta kortin arvon.
        /// </summary>
        /// <param name="kortti1">Ensimmäinen verrattava kortti</param>
        /// <param name="kortti2">Toinen verrattava kortti</param>
        /// <returns></returns>
        public static bool operator <(Kortti kortti1, Kortti kortti2)
        {
            bool tulos = false;
            if (PakanTiedot.arvot.IndexOf(kortti1.arvo) < PakanTiedot.arvot.IndexOf(kortti2.arvo))
            {
                tulos =  true;
            }
            return tulos;
        }

        /// <summary>
        /// Korttien arvojen vertailussa tarvittava operaattorin 
        /// uudelleen määrittely. Vertaa kortit hakemalla 
        /// korttioliosta kortin arvon.
        /// </summary>
        /// <param name="kortti1">Ensimmäinen verrattava kortti</param>
        /// <param name="kortti2">Toinen verrattava kortti</param>
        /// <returns></returns>
        public static bool operator >(Kortti kortti1, Kortti kortti2)
        {
            bool tulos = false;
            if (PakanTiedot.arvot.IndexOf(kortti1.arvo) > PakanTiedot.arvot.IndexOf(kortti2.arvo))
            {
                return true;
            }
            return tulos;
        }

        /// <summary>
        /// Korttien arvojen vertailussa tarvittava operaattorin 
        /// uudelleen määrittely. Vertaa kortit hakemalla 
        /// korttioliosta kortin arvon.
        /// </summary>
        /// <param name="kortti1">Ensimmäinen verrattava kortti</param>
        /// <param name="kortti2">Toinen verrattava kortti</param>
        /// <returns></returns>
        public static bool operator ==(Kortti kortti1, Kortti kortti2)
        {
            bool tulos = false;
            if (PakanTiedot.arvot.IndexOf(kortti1.arvo) == PakanTiedot.arvot.IndexOf(kortti2.arvo))
            {
                return true;
            }
            return tulos;
        }

        /// <summary>
        /// Korttien arvojen vertailussa tarvittava operaattorin 
        /// uudelleen määrittely. Vertaa kortit hakemalla 
        /// korttioliosta kortin arvon.
        /// </summary>
        /// <param name="kortti1">Ensimmäinen verrattava kortti</param>
        /// <param name="kortti2">Toinen verrattava kortti</param>
        /// <returns></returns>
        public static bool operator !=(Kortti kortti1, Kortti kortti2)
        {
            bool tulos = false;
            if (PakanTiedot.arvot.IndexOf(kortti1.arvo) != PakanTiedot.arvot.IndexOf(kortti2.arvo))
            {
                return true;
            }
            return tulos;
        }

        /// <summary>
        /// Hakee korttioliosta maan ja arvon ja palauttaa ne merkkijonona.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Maa + " " + this.Arvo;
        }
    }
}
