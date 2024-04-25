using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Ohjelma lukee listaan sarjan liukulukutyyppisiä mittaustietoja.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        List<Double> arvot;
        string arvotTekstina;

        arvot = LueArvot();
        Console.WriteLine(arvot.Count);
        arvotTekstina = MuunnaListaTekstiksi(arvot);
        Console.WriteLine(arvotTekstina);
        Console.WriteLine(arvot[arvot.Count - 1]);
        double keskiarvo = LaskeKeskiarvo(arvot);
        Console.WriteLine("Keskiarvo: " + keskiarvo);
        Console.WriteLine("Suurin on paikassa " + HaeSuurimmanSijainti(arvot));
        Console.WriteLine("Haettu löytyy kohdasta " + HaeValilta(arvot, 5, 1));

        Console.ReadKey();
    }

    /// <summary>
    /// Luo syötteen luvuista listan.
    /// </summary>
    /// <returns>Mittaustiedot liukulukulistana syöttöjärjestyksessä.</returns>
    static List<double> LueArvot()
    {
        // Syöterivin jakamisen määräävät välimerkit, tässä välilyönti.
        char[] erottimet = new char[] { ' ' };
        // Koko syöterivi.
        string luettu;
        // Syöterivi pätkittynä välilyöntien kohdalta.
        string[] arvotTekstina;
        // Palautettava liukulukulista
        List<double> mittausarvot = new List<double>();

        Console.WriteLine("Anna arvot välilyönnillä erotettuina");
        luettu = Console.ReadLine();
        arvotTekstina = luettu.Split(erottimet);

        // Käy läpi mittaustiedot sisältävän tekstitaulukon ja muuttaa 
        // jokaisen arvon tekstistä liukuluvuksi ja lisää mittausarvojen listaan.
        foreach (string arvoTekstina in arvotTekstina)
        {
            // TODO: muunna tekstimuotoinen arvo liukuluvuksi ja lisää listaan.
            mittausarvot.Add(double.Parse(arvoTekstina));
        }

        return mittausarvot;
    }

    /// <summary>
    /// Palauttaa mittausarvojen keskiarvon.
    /// </summary>
    /// <param name="arvot">Lista, jossa mitteustiedot sijaitsevat.</param>
    /// <returns>Arvojen keskiarvon liukulukuna.</returns>
    static double LaskeKeskiarvo(List<double> arvot)
    {
        double summa = 0, keskiarvo;

        foreach (double arvo in arvot)
        {
            summa = summa + arvo;
        }
        keskiarvo = summa / arvot.Count;

        return keskiarvo;
    }

    /// <summary>
    /// Muuttaa mittaustiedot sisältävän liukulukulistan tekstiksi,
    /// jonka voi tulostaa.
    /// </summary>
    /// <param name="arvot">Mittaustiedot sisältävä liukulukulista.</param>
    /// <returns>Mittaustiedot tekstinä.</returns>
    static string MuunnaListaTekstiksi(List<double> arvot)
    {
        string listaTekstina;

        listaTekstina = arvot.Count.ToString() + " arvoa: ";

        foreach (double arvo in arvot)
        {
            listaTekstina = listaTekstina + " " + arvo.ToString();
        }

        return listaTekstina;
    }

    /// <summary>
    /// Palauttaa listan suurimman arvon sijainnin kokonaislukuna.
    /// Jos samaa arvoa on enemmän kuin 1, palauttaa ensimmäisen 
    /// sijainnin.
    /// </summary>
    /// <param name="arvot">Mittaustiedot sisältävä liukulukulista</param>
    /// <returns>Suurimman arvon indeksi kokonaislukuna.</returns>
    static int HaeSuurimmanSijainti(List<double> arvot)
    {
        // TODO: Hae listasta suurin arvo ja sen sijainti ja
        // palauta sijainti.
        double isoin = arvot.Max();
        return arvot.IndexOf(isoin);
    }

    /// <summary>
    /// Palauttaa ensimmäisen arvon sijainnin, joka osuu annetulle välille.
    /// Jos haettava arvo on 3,0 ja väli on 1, niin kelpaavat arvot ovat
    /// välillä 2,1 - 3,9. Välin loppu ei siis kuulu alueeseen.
    /// </summary>
    /// <param name="arvot">Mittaustiedot sisältävä liukulukulista.</param>
    /// <param name="haettava">Haettava mittaustieto.</param>
    /// <param name="vali">Kuinka paljon isommat ja pienemmät arvot kelpaavat.</param>
    /// <returns>Haetun arvon sijainti tai -1, jos sopivaa arvoa ei löydy.</returns>
    static int HaeValilta(List<double> arvot, double haettava, int vali)
    {
        // TODO: Etsi ensimmäinen arvo, joka osuu halutulle alueelle ja
        // palauta sen sijainti
        foreach (double i in arvot)
        {
            if (i <= haettava + vali && i >= haettava - vali)
                return arvot.IndexOf(i);
        }
        return -1; 


    }
}

