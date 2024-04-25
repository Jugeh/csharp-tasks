using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolikonheitto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Luodaan uusi kolikko-olio
            Kolikko kolikonheitto;
            int[] taulukko = new int[] { 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1 };
            kolikonheitto = new Kolikko(taulukko);
            
            //Päivitetään tilastot
            kolikonheitto.Tilastot();

            //Tulostetaan kolikonheiton kaikki tiedot
            Console.WriteLine(kolikonheitto);
            Console.ReadKey();
        }
    }
}
