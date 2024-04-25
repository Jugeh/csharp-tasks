using System;
using System.Collections.Generic;

namespace Papukaija
{
/// <summary>
/// Tämä luokka kuvaa papukaijoja (kuvitteellisessa) järjestelmässä,
/// jossa käyttäjillä voi olla "virtuaalieläimiä" lemmikkeinä.
/// Yksi papukaijaolio kuvaa yhden papukaijan perustietoja ja
/// -toimintoja. Kukin papukaija osaa aluksi vain toistaa yhtä
/// lausetta (kun sen puhu-metodia kutsutaan), mutta lauseita voi
/// opettaa sille lisää (opiLause-metodia kutsumalla).
 /// </summary>
    public class Papukaija
    {

        private List<string> repertuaari;
        private string nimi;
        private string vari;
        private Random arpakone;

        /// <summary>
        /// Tämä on konstruktori. Se määrittää millaista parametritietoa 
        /// täytyy antaa, kun luodaan uusi papukaijaolio, ja hoitaa olion tilan 
        /// alustustoimenpiteet. Tässä tapauksessa papukaijaoliota luotaessa 
        /// tulee antaa parametreina uuden papukaijan nimi ja väri,
        /// jotka konstruktori asettaa uuden olion ilmentymämuuttujien 
        /// arvoiksi. Juuri luotu papukaijaolio osaa sanoa vasta yhden lauseen.
        /// </summary>
        /// <param name="nimi">Uuden papukaijaolion nimi</param>
        /// <param name="vari">Uuden papukaijaolion väri</param>
        public Papukaija(string nimi, string vari)
        {
            this.nimi = nimi;
            this.vari = vari;
            repertuaari = new List<string>();
            repertuaari.Add("NIMI tahtoo keksin.");
            arpakone = new Random();
        }


        /// <summary>
        /// Tämä metodi opettaa papukaijalle uuden lauseen. Uusi lause
        /// annetaan parametrina tälle metodille. Kun tätä metodia 
        /// kutsuttu, niin parametrina annettu lause pysyy papukaijan
        /// lauserepertuaarissa ja papukaija sen silloin lausuu puhu-metodia
        /// kutsuttaessa (ks. puhu-metodi).
        /// </summary>
        /// <param name="uusiLause">Papukaijalle opetettava lause</param>
        public void OpiLause(string uusiLause)
        {
            repertuaari.Add(uusiLause);
        }

        /// <summary>
        /// Tämä on metodi nimeltä puhu. Sille ei tarvitse antaa mitään 
        /// parametreja. Kun tätä metodia kutsutaan, papukaijaolio valitsee
        /// jonkin lauseen omasta lauserepertuaaristaan ja "sanoo" sen, ts.
        /// tämä metodi palauttaa puhutun lauseen.
        /// </summary>
        /// <returns>satunnaisesti jonkin opetetuista lauseista</returns>
        public string Puhu()
        {
            int lausenumero = arpakone.Next(repertuaari.Count);
            return repertuaari[lausenumero].Replace("NIMI", nimi);
        }


        /// <summary>
        /// Tämä parametriton metodi palauttaa tekstikuvauksen papukaijaoliosta.
        /// </summary>
        /// <returns>papukaijan kuvauksen tekstinä</returns>
        public override string ToString()
        {
            if (repertuaari.Count == 1)
            {
                return "Nimi: " + nimi + ", väri: " + vari + ", osaa 1 lauseen.";
            }
            else
            {
                return "Nimi: " + nimi + ", väri: " + vari + ", osaa " + repertuaari.Count + " lausetta.";
            }
        }

    }

}
