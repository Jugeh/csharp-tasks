using System.Collections.Generic;
using System.IO;

namespace ElokuvaTiedot
{
    class ArvosteluTiedosto
    {

        // tiedoston data
        private StreamReader data;

        public ArvosteluTiedosto(string tiedostopolku)
        {
            this.data = new StreamReader(tiedostopolku);
        }

        /// <summary>
        /// Lukee kaikki elokuvat arvostelu tiedostosta
        /// </summary>
        /// <returns>lista Elokuvia</returns>
        public List<Elokuva> LueKaikkiElokuvat()
        {
            List<Elokuva> elokuvat = new List<Elokuva>();
            Elokuva current;
            while ((current = this.LueElokuva()) != null)
            {
                elokuvat.Add(current);
            }
            return elokuvat;
        }

        /// <summary>
        /// Lukee yhden elokuvan tiedostosta
        /// </summary>
        /// <returns>uusi Elokuva olio tiedoston yhden rivin tiedoista</returns>
        private Elokuva LueElokuva()
        {
            // lue rivi
            string rivi = this.data.ReadLine();
            // jos ei ole rivejä jäljellä, palauta null
            if (rivi == null)
            {
                return null;
            }

            // pilko rivi osiin
            string[] tiedot = rivi.Split('#');

            string nimi = tiedot[2].Trim();
            string ohjaaja = tiedot[3].Trim();
            int vuosi = int.Parse(tiedot[1].Trim());
            string trimmattu = tiedot[0].Trim();
            trimmattu = trimmattu.Replace('.', ',');
            double arvo = double.Parse(trimmattu);

            // palauta uusi elokuva, rivin tiedoilla
            return new Elokuva(nimi, vuosi, ohjaaja, arvo);
        }

        /// <summary>
        /// Sulkee tiedoston lopullisesti
        /// </summary>
        private void Sulje()
        {
            this.data.Close();
        }

    }
}
