using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1, auto2, auto3, auto4, auto5;
            auto1 = new Auto(Tuple.Create("Ford", "Focus", "ABC-123", 10000));
            auto2 = new Auto(Tuple.Create("Ford", "Fiesta", "CBA-321", 20000));
            auto3 = new Auto(Tuple.Create("Lada", "1200L", "XYZ-666", 30000));
            auto4 = new Auto(Tuple.Create("Opel", "Omega", "MNO-777", 40000));
            auto5 = new Auto(Tuple.Create("Opel", "Astra", "ÅÄÖ-789", 50000));

            Kauppa autokauppa;
            autokauppa = new Kauppa(new List<Auto>());

            autokauppa.LisaaAuto(auto1);
            autokauppa.LisaaAuto(auto2);
            autokauppa.LisaaAuto(auto3);
            autokauppa.LisaaAuto(auto4);
            autokauppa.LisaaAuto(auto5);

            Console.WriteLine("Autokaupan autot:");
            foreach (var i in autokauppa.Autot)
            {
                Console.Write(i.Merkki + " ");
                Console.WriteLine(i.Malli);
            }

            Console.WriteLine();
            Console.WriteLine("Ford merkkiset autot:");
            foreach (var i in autokauppa.HaeMerkilla("Ford"))
            {
                Console.WriteLine(i.Malli);
            }

            Console.WriteLine();
            Console.WriteLine("Yksittäisen auton tiedot:");
            Console.WriteLine(auto1.HaeTiedot());

            Console.WriteLine();
            Console.WriteLine("Autokaupan kolme vähiten ajettua autoa:");
            foreach (var i in autokauppa.VahitenAjetut())
            {
                Console.Write(i.Merkki + " ");
                Console.Write(i.Malli + " ");
                Console.Write(i.Rekisterinumero + " ");
                Console.WriteLine(i.Ajetutkilometrit + "km");
            }

            Console.ReadKey();
        }
    }
}
