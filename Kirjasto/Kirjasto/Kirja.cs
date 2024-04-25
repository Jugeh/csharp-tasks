using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto
{
    public class Kirja
    {
        private string nimi;
        private string tekija;
        private string julkaisija;
        private int julkaisuvuosi;
        private int isbn;

        public Kirja(string nimi, string tekija, string julkaisija, int julkaisuvuosi, int isbn)
        {
            this.nimi = nimi;
            this.tekija = tekija;
            this.julkaisija = julkaisija;
            this.julkaisuvuosi = julkaisuvuosi;
            this.isbn = isbn;
        }
        public string Nimi()
        {
            return nimi;
        }
        public string Tekija()
        {
            return tekija;
        }
        public string Julkaisija()
        {
            return julkaisija;
        }
        public int JulkaisuVuosi()
        {
            return julkaisuvuosi;
        }
        public int ISBN()
        {
            return isbn;
        }
        public string AnnaKuvaus()
        {
            return string.Format("Kirjan nimi: {0}, tekijä: {1}, julkaisija: {2}, julkaisuvuosi: {3}, ISBN: {4}.", nimi, tekija, julkaisija, julkaisuvuosi, isbn);
        }
    }
}
