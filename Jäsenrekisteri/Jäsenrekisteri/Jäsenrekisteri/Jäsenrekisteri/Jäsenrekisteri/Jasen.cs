using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    /// <summary>
    /// Luokka esittää jäsenrekisterin jäsenten tietoja
    /// Luokasta löytyy jäsenten etu- ja sukunimi, osoite
    /// postitoimipaikka, numero sekä liittymisvuosi.
    /// </summary>
    public class Jasen
    {
        private string etunimi;
        private string sukunimi;
        private string osoite;
        private string postitoimipaikka;
        private string numero;
        private int liittymisvuosi;

        /// <summary>
        /// Luo jäsenen ja tiedot sille
        /// </summary>
        /// <param name="etunimi">Jäsenen etunimi</param>
        /// <param name="sukunimi">Jäsenen sukunimi</param>
        /// <param name="osoite">Jäsenen osoite</param>
        /// <param name="postitoimipaikka">Jäsenen postitoimipaikka</param>
        /// <param name="numero">Jäsenen puhelinnumero</param>
        /// <param name="liittymisvuosi">Vuosi jolloin jäsen on liitetty rekisteriin</param>
        public Jasen(string etunimi, string sukunimi, string osoite, string postitoimipaikka, string numero, int liittymisvuosi)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.osoite = osoite;
            this.postitoimipaikka = postitoimipaikka;
            this.numero = numero;
            this.liittymisvuosi = liittymisvuosi;
        }
        /// <summary>
        /// Palauttaa jäsenen etunimen
        /// </summary>
        public string Etunimi
        {
            get { return etunimi; }
        }

        /// <summary>
        /// Palauttaa jäsenen sukunimen
        /// </summary>
        public string Sukunimi
        {
            get { return sukunimi; }
        }

        /// <summary>
        /// Palauttaa jäsenen osoitteen
        /// </summary>
        public string Osoite
        {
            get { return osoite; }
        }

        /// <summary>
        /// Palauttaa jäsenen postitoimipaikan
        /// </summary>
        public string Postitoimipaikka
        {
            get { return postitoimipaikka; }
        }

        /// <summary>
        /// Palauttaa jäsenen puhelinnumeron
        /// </summary>
        public string Numero
        {
            get { return numero; }
        }

        /// <summary>
        /// Palauttaa vuosiluvun milloin jäsen on liitetty rekisteriin
        /// </summary>
        public int Vuosi
        {
            get { return liittymisvuosi; }
        }

        /// <summary>
        /// Palauttaa kaikki tiedot yksittäisestä jäsenestä.
        /// </summary>
        public string JasenenTiedot()
        {
            return string.Format("Jäsenen nimi: {0} {1}\nJäsenen osoite: {2}\nJäsenen postitoimipaikka: {3}\nJäsenen numero: {4}\nJäsenen liittymisvuosi: {5}",
                etunimi, sukunimi, osoite, postitoimipaikka, numero, liittymisvuosi);
        }
    }
}
