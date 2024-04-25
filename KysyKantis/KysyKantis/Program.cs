using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KysyKantis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KysyKantis());
            Console.ReadKey();
        }
        ///<summary>Funktio kysyy käyttäjältä kirjainta k tai e, kunnes käyttäjä
        ///antaa jomman kumman.</summary>
        ///<returns>Funktio palauttaa kirjaimen (char) k tai e.</returns>
        static char KysyKantis()
        {

            char valinta;
            string luettu;
            string vaihtoehdot = "keKE";
            bool onnistuiko;

            do
            {
                Console.Write("Onko kanta-asiakas? (k - kyllä, e - ei): ");

                luettu = Console.ReadLine();
                onnistuiko = char.TryParse(luettu, out valinta);
                if (onnistuiko == false)
                {
                    Console.WriteLine("Syöte ei kelpaa merkiksi, yritä uudelleen.");
                }
                else if (vaihtoehdot.Contains(valinta.ToString()) == false)
                {
                    Console.WriteLine("Valinnan pitää olla k tai e. Yritä uudelleen.");
                }
            } while (onnistuiko == false && vaihtoehdot.Contains(valinta.ToString()) == false);

            return valinta;

        }
    }
}
