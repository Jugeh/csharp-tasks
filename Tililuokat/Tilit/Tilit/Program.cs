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
            Console.WriteLine("Luodaan testiasiakas.");
            Asiakas asiakas1 = new Asiakas(54321, "Teemu Datanomi");
            Tili tili1 = new Tili(asiakas1);
            Console.WriteLine("Luodaan tili, Sen saldo on nyt: " + tili1.Saldo);
            Console.WriteLine("Talletetaan vähän rahaa tilille. Saldo on nyt: ");
            tili1.Talleta(4000);
            Console.WriteLine("Saldo on nyt: " + tili1.Saldo);
            Console.WriteLine("Otetaan rahaa tililtä. Saldo on nyt: " + tili1.Saldo);
            tili1.Nosta(2500);
            Console.WriteLine("Saldo on nyt: " + tili1.Saldo);
            Console.WriteLine("Otetaan vähän lisää rahaa. Saldo on nyt: " + tili1.Saldo);
            tili1.Nosta(-100);
            Console.WriteLine("Saldo on nyt: " + tili1.Saldo);
            Tili tili2 = new Tili(asiakas1);
            Console.WriteLine("Luodaan toinen tili samalle asiakkaalle. Sen saldo on nyt:" + tili2.Saldo);

            tili2.Talleta(4000);
            tili2.SiirraTilille(tili1, 1800);
            Console.WriteLine("Siirretään rahaa tokalta tililtä ekalle. Tilien saldot ovat nyt: " + tili1.Saldo + " " + tili2.Saldo);
            Console.WriteLine("Tili1 saldo on nyt: " + tili1.Saldo + " Tili2 saldo on nyt: " + tili2.Saldo);

            Console.ReadLine();
        }
    }

}
