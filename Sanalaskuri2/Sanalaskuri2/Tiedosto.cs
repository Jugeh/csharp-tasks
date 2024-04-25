using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sanalaskuri2
{
    public class Tiedosto
    {
        /// <summary>
        /// Luokasta Tiedosto löytyy tekstitiedoston sanojen ja merkkien lukumäärä
        /// </summary>
        private Dictionary<string, int> sanakirja;
        int sanalaskuri;
        int merkkilaskuri;
        /// <summary>
        /// Luo uuden tekstitiedoston, joka on muutetaan pieniksi kirjaimiksi, hankkiuduttu
        /// eroon välilyönneistä yms. ja pilkottu sanalistaksi
        /// </summary>
        /// <param name="nimi">Annettavan tiedoston nimi</param>
        public Tiedosto(string nimi)
        {
            sanakirja = new Dictionary<string, int>();

            using (StreamReader file = new StreamReader(nimi))
            {
                string line;
                string rivi;
                while ((line = file.ReadLine()) != null)
                {
                    rivi = line.Trim();
                    string pienetkirjaimet = rivi.ToLower();
                    string[] sanalista = pienetkirjaimet.Split(new char[] { ' ' });
                    merkkilaskuri += pienetkirjaimet.Length;
                    sanalaskuri += sanalista.Length;
                    int luku;

                    foreach (string sana in sanalista)
                    {
                        if (sanakirja.ContainsKey(sana)) 
                        {
                            bool doesExist = sanakirja.TryGetValue(sana, out luku);
                            sanakirja[sana] = luku + 1;
                        }
                        else
                        {
                            sanakirja[sana] = 1;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Palauttaa sanojen määrän tekstitiedostossa
        /// </summary>
        public int SanojenMaara
        {
            get { return sanalaskuri; } set { sanalaskuri = value; } 
        }
        /// <summary>
        /// Palauttaa merkkien määrän tekstitiedostossa
        /// </summary>
        public int MerkkienMaara
        {
            get { return merkkilaskuri; } set { merkkilaskuri = value; }    
        }
        /// <summary>
        /// Palauttaa annetun sanan lukumäärän tekstitiedostossa
        /// </summary>
        /// <param name="sana">Annettava sana, jonka lukumäärä palautetaan</param>
        /// <returns></returns>
        public int YksittaisenMaara(string sana)
        {
            int maara = 0;
            if (sanakirja.ContainsKey(sana))
            {
                maara = sanakirja[sana];
            }
            return maara;
        }
    }
}
