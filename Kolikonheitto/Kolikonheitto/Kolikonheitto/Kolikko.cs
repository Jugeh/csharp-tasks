using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolikonheitto
{
    public class Kolikko
    {
        //Kokonaislukutaulukko lukuja varten
        private int[] taulukko;
        //Heittojen lukumäärä
        private int heitot = 0;
        //Klaavojen lukumäärä
        private int klaava = 0;
        //Kruunien lukumäärä
        private int kruuna = 0;

        /// <summary>
        /// Luo uuden kolikkotaulukon
        /// </summary>
        /// <param name="taulukko">Taulukko nollia ja ykkösiä, jotka vastaavat joko klaavaa tai kruunaa</param>
        public Kolikko(int[] taulukko)
        {
            this.taulukko = taulukko;
        }
        /// <summary>
        /// Päivittää heittojen, klaavojen ja kruunien määrän
        /// </summary>
        public void Tilastot()
        {
            foreach (int luku in taulukko)
            {
                heitot += 1;

                if (luku == 0)
                {
                    klaava += 1;
                }
                else if (luku == 1)
                {
                    kruuna += 1;
                }
            }
        }
        /// <summary>
        /// Tulostaa kolikonheitosta heittojen, klaavojen ja kruunien lukumäärän
        /// </summary>
        public override string ToString()
        {
            return String.Format("Kolikkoa heitetty {0} kertaa\nKlaavoja tullut {1}\nKruunia tullut {2}", heitot, klaava, kruuna);
        }

    }
}

