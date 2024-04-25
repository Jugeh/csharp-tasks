using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto
{
    public class Kirjasto
    {
        private string kirjastonNimi;
        private List<Kirja> kirjat;

        public Kirjasto(string kirjastonNimi, List<Kirja> kirjat)
        {
            this.kirjastonNimi = kirjastonNimi;
            this.kirjat = new List<Kirja>();
        }
        public string KirjastonNimi()
        {
            return kirjastonNimi;
        }
        /// <param name="uusiKirja"></param>
        public void LisaaKirja(Kirja uusiKirja)
        {
            kirjat.Add(uusiKirja);
        }
        public string HaeTekijanNimella(string nimi)
        {
            foreach (Kirja kirja in kirjat)
            {
                if (nimi == kirja.Tekija())
                {
                    return kirja.Nimi();
                }                  
            }
            return "";
        }
        public void PoistaKirja(string nimi)
        {
            Kirja loydetty = null;
            foreach (Kirja poistettava in kirjat)
            {
                if (nimi == poistettava.Nimi())
                {
                    loydetty = poistettava;
                }
                else
                {
                    loydetty = null;
                }
            }
            if (loydetty != null)
                {
                    kirjat.Remove(loydetty);
                }          
        }
    }
}
