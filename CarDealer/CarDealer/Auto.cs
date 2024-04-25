using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public class Auto
    {
        private string merkki;
        private string malli;
        private string rekisterinumero;
        private int ajetutkilometrit;
        /// <summary>
        /// Luo uuden auton, jossa on auton merkki, malli, rekisterinumero ja ajetut kilometrit
        /// </summary>
        /// <param name="tupleAuthor"></param>
        public Auto(Tuple<string, string, string, int> tupleAuthor)
        {
            merkki = tupleAuthor.Item1;
            malli = tupleAuthor.Item2;
            rekisterinumero = tupleAuthor.Item3;
            ajetutkilometrit = tupleAuthor.Item4;
        }
        /// <summary>
        /// Palauttaa auton merkin
        /// </summary>
        public string Merkki
        {
            get { return merkki; }
        }
        /// <summary>
        /// Palauttaa auton mallin
        /// </summary>
        public string Malli
        {
            get { return malli; }
        }
        /// <summary>
        /// Palauttaa auton rekisterinumeron
        /// </summary>
        public string Rekisterinumero
        {
            get { return rekisterinumero; }
        }
        /// <summary>
        /// Palauttaa autolla ajetut kilometrit
        /// </summary>
        public int Ajetutkilometrit
        {
            get { return ajetutkilometrit; }
        }
        /// <summary>
        /// Kaikki auton tiedot
        /// </summary>
        /// <returns>Palauttaa auton merkin, mallin, rekisterinumeron ja ajetutkilometit</returns>
        public Tuple<string, string, string, int> HaeTiedot() //tee pääohjelmalla
        {
            return new Tuple<string, string, string, int>(merkki, malli, rekisterinumero, ajetutkilometrit);
        }
    }
}
