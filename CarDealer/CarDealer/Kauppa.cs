using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public class Kauppa
    {
        private List<Auto> autot;
        /// <summary>
        /// Luo uuden autokaupan
        /// </summary>
        /// <param name="autot">Lista autokaupan autoista</param>
        public Kauppa(List<Auto> autot)
        {
            this.autot = autot;
        }
        /// <summary>
        /// Lisää uuden auton autokauppaa
        /// </summary>
        /// <param name="uusiAuto"></param>
        public void LisaaAuto(Auto uusiAuto)
        {
            autot.Add(uusiAuto);
        }
        /// <summary>
        /// Myy auton ja poistaa auton autokaupasta
        /// </summary>
        /// <param name="myytavaAuto"></param>
        public void MyyAuto(Auto myytavaAuto)
        {
            autot.Remove(myytavaAuto);
        }
        /// <summary>
        /// Palauttaa listan autonkaupan autoista
        /// </summary>
        public List<Auto> Autot
        {
            get { return autot; }
        }
        /// <summary>
        /// Hakee tietyn merkin autot autokaupasta
        /// </summary>
        /// <param name="merkki">Annettava auton merkki</param>
        /// <returns></returns>
        public List<Auto> HaeMerkilla(string merkki)
        {
            List<Auto> loydetyt = new List<Auto>();

            foreach (Auto auto in autot)
            {
                if (auto.Merkki == merkki)
                {
                    loydetyt.Add(auto);
                }
            }
            return loydetyt;
        }
        /// <summary>
        /// Hakee 3 vähiten ajettua autoa autokaupasta
        /// </summary>
        /// <returns>Palauttaa listan kolmesta vähiten ajetusta autosta</returns>
        public List<Auto> VahitenAjetut()
        {
            List<Auto> vahiten = new List<Auto>();
            List<Auto> kopiolista = Autot;

            int i = 0;
            Auto muuttuja = null;
            while (i < 3)
            {
                int vahiten_ajettu = int.MaxValue;
                foreach (Auto auto in kopiolista)
                {
                    if (auto.Ajetutkilometrit <= vahiten_ajettu)
                    {
                        vahiten_ajettu = auto.Ajetutkilometrit;
                        muuttuja = auto;
                    }
                }
                vahiten.Add(muuttuja);
                i++;
                kopiolista.Remove(muuttuja);
            }
            return vahiten;
        }
    }
}
