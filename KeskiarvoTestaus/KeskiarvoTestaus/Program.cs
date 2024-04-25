using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiarvoTestaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LaskeKeskiarvo(new int[] { 1, 2 }));
            Console.ReadKey();
        }
        /// <summary>
        /// Funktio laskee keskiarvon parametrina tulevan taulukon 
        /// sisällöstä ja palauttaa keskiarvon.(Sum vaatii System.Linq)
        /// </summary>
        /// <param name="luvut">Kokonaislukutaulukko sisältäen käsiteltävät luvut</param>
        /// <returns>Käsiteltävien lukujen keskiarvo</returns>
        static double LaskeKeskiarvo(int[] luvut)
        {
            int summa = luvut.Sum();
            int maara = luvut.Length;
            return summa / maara;
        }
    }
}
