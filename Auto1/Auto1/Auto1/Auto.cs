using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

///<summary>
/// Autoluokka. Autolla voi ajaa ja matkamittariin voi
/// lisätä kilometrejä.
///</summary>

namespace Auto1
{ 
    public class Auto
    {
        /// <summary>
        /// Auton matkamittari, int.
        /// </summary>
        private int matkamittari;
        /// <summary>
        /// Auton merkki, string.
        /// </summary>
        private string merkki;
        /// <summary>
        /// Auton malli, string.
        /// </summary>
        private string malli;
        /// <summary>
        /// Auton omistaja, string.
        /// </summary>
        private string omistaja;
        /// <summary>
        /// Auton rekisteri, string.
        /// </summary>
        private string rekisteri;
        /// <summary>
        /// Auton huoltopäivät, list.
        /// </summary>
        private List<DateTime> huoltopaivat;


        /// <summary>
        /// Alustusmetodi. Parametriarvona annettaan luotavan auton merkki.
        /// Uudella autolla on ajettu 0 km.
        /// </summary>
        /// <param name="autonMerkki">Luotavan auton merkki</param>
        public Auto(string autonMerkki, string autonMalli, string autonOmistaja, string autonRekisteri)
        {
            matkamittari = 0;
            merkki = autonMerkki;
            malli = autonMalli;
            omistaja = autonOmistaja; 
            rekisteri = autonRekisteri;
            huoltopaivat = new List<DateTime>();
        }

        /// <summary>
        /// Tämä metodi tulostaa ainoastaan tekstin "Wroom!".
        /// </summary>
        public void Aja()
        {
            Console.WriteLine("Wroom!");
        }

        /// <summary>
        /// Tällä metodilla lisätään matka Auto-olion matkamittariin.
        /// </summary>
        /// <param name="matka">Mittariin lisättävä matka. (int)</param>
        public void LisaaMatka(int matka)
        {
            matkamittari += matka;
        }

        /// <summary>
        /// Tämä metodi palauttaa kuvauksen siitä autosta, jonka kautta metodia kutsutaan.
        /// Kuvauksessa näytetään auton malli ja sen matkamittarin lukema.
        /// </summary>
        /// <returns>Kuvaus autosta tekstinä.</returns>
        public string AnnaKuvaus()
        {
            return string.Format("Auton merkki: {0}, malli: {1}, rekisteri: {2}, omistaja: {3}, ajettu: {4} km.",
                merkki, malli, rekisteri, omistaja, matkamittari);
        }

        public string HaeTyyppi()
        {
            return merkki + malli;
        }

        public void MuutaOmistaja(string muutettuOmistaja)
        {
            omistaja = muutettuOmistaja;
        }
        public string HaeOmistaja()
        {
            return omistaja;
        }
        public void MuutaRekisteri(string muutettuRekisteri)
        {
            rekisteri = muutettuRekisteri;
        }
        public string HaeRekisteri()
        {
            return rekisteri;
        }
        public int HaeKilometrit()
        {
            return matkamittari;
        }
        public void Huolla(DateTime pvm)
        {
            huoltopaivat.Add(pvm);
        }
        public string HaeHuollot()
        {
            string uusiLista = String.Empty;           
            foreach (DateTime paivat in huoltopaivat)
            {
                uusiLista = uusiLista + paivat.ToShortDateString() + "\n";
            }
            return uusiLista;
        }
    }
}