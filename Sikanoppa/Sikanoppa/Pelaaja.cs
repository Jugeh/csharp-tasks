using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikanoppa
{
    public class Pelaaja
    {
        /// <summary>
        /// Pelaajan tyyppi, eli onko kyseessä ihminen vai tietokone pelaaja
        /// </summary>
        private string tyyppi;
        /// <summary>
        /// Pelaajan nimi
        /// </summary>
        private string nimi;
        /// <summary>
        /// Pelaajan kokonaispisteet
        /// </summary>
        private int kokonaispisteet;
        /// <summary>
        /// Pelaajan saamat pisteet heittovuoron aikana
        /// </summary>
        private int pisteet;
        /// <summary>
        /// Pelaajan tiedot, jossa parametreina pelaajan tyyppi ja nimi
        /// </summary>
        /// <param name="tyyppi"></param>
        /// <param name="nimi"></param>
        public Pelaaja(string tyyppi, string nimi)
        {
            this.tyyppi = tyyppi;
            this.nimi = nimi;
        }
        /// <summary>
        /// Palauttaa pelaajan tyypin
        /// </summary>
        public string Tyyppi { get { return tyyppi; } set { tyyppi = value; } }
        /// <summary>
        /// Palauttaa pelaajan nimen
        /// </summary>
        public string Nimi { get { return nimi; } }
        /// <summary>
        /// Pelaajan kokonaispisteet
        /// </summary>
        public int Kokonaispisteet { get { return kokonaispisteet; } set { kokonaispisteet = value; } }
        /// <summary>
        /// Pelaajan yhden vuoron aikana saadut pisteet
        /// </summary>
        public int Pisteet { get { return pisteet; } set { kokonaispisteet = value; } }
        /// <summary>
        /// Tarkasta kokonaispisteesi
        /// </summary>
        /// <returns>Palauttaa kokonaispisteesi</returns>
        public string TarkistaPisteesi()
        {
            return string.Format("Sinulla on {0} pistettä.", kokonaispisteet);
        }
    }
}
