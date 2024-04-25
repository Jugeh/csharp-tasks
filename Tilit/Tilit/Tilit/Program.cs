using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilit
{
    public class PankkiTesti
    {
        static void Main()
        {
            Console.WriteLine("Luodaan tekstiasiakas.");
            Asiakas asiakas1 = new Asiakas(54321, "Teemu Datanomi");

            Console.WriteLine("Luodaan tili. Sen saldo on nyt:");
            Tili tili1 = new Tili(asiakas1);
            Console.WriteLine(tili1.Saldo);

            Console.WriteLine("Talletetaan vähän rahaa tilille. Saldo on nyt:");
            tili1.Talleta(4000);
            Console.WriteLine(tili1.Saldo);

            Console.WriteLine("Otetaan rahaa tililtä. Saldo on nyt:");
            tili1.Nosta(2500);
            Console.WriteLine(tili1.Saldo);

            Console.WriteLine("Otetaan vähän lisää rahaa. Saldo on nyt:");
            tili1.Nosta(2000);
            Console.WriteLine(tili1.Saldo);

            Console.WriteLine("Luodaan toinen tili samalle asiakkaalle. Sen saldo on nyt:");
            Tili tili2 = new Tili(asiakas1);
            Console.WriteLine(tili2.Saldo);

            Console.WriteLine("Siirretään rahaa tokalta tililtä ekalle. Tilien saldot ovat nyt:");

            tili1.SiirraTilille(tili2, 1800);
            Console.WriteLine(tili1.Saldo);
            Console.WriteLine(tili2.Saldo);

            Console.ReadKey();
        }
    }

}
