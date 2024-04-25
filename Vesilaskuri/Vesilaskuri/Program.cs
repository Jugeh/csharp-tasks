using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vesilaskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vetta, litrat, kmh, kilometria, aika, tulos;
            int hh, mm;

            vetta = VettaJaljella();

            litrat = LitraaKuluu();

            kmh = KilometriaTunnissa();

            kilometria = KilometriaJaljella();

            aika = kilometria / kmh;
            var timeSpan = TimeSpan.FromHours(aika);
            hh = timeSpan.Hours;
            mm = timeSpan.Minutes;
            Console.WriteLine("Matkaan menee aikaa noin {0} tuntia {1} minuuttia", hh, mm);

            tulos = vetta - (aika * litrat);

            if (tulos <= 0)
            {
                Console.WriteLine("Etsi jostakin {0:0.0} litraa vettä.", tulos * -1);
            }
            else if (tulos > 0)
            {
                Console.WriteLine("Vesi riittää, yli jää {0:0.0} litraa.", tulos);
            }
            Console.ReadKey();
        }
        static double VettaJaljella()
        {
            double vetta;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Paljonko vettä on jäljellä? ");
                luettu = Console.ReadLine();
                onnistuiko = double.TryParse(luettu, out vetta);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Syötä vesimäärä litroina: ");
                }
            } while (!onnistuiko);
            return vetta;
        }
        static double LitraaKuluu()
        {
            double litrat;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Monta litraa vettä kuluu tunnissa? ");
                luettu = Console.ReadLine();
                onnistuiko = double.TryParse(luettu, out litrat);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Syötä vedenkulutus litroina tunnissa: ");
                }
            } while (!onnistuiko);
            return litrat;
        }
        static double KilometriaTunnissa()
        {
            double kmh;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Monta kilometriä tunnissa etenet? ");
                luettu = Console.ReadLine();
                onnistuiko = double.TryParse(luettu, out kmh);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Syötä matkanopeus kilometreinä tunnissa: ");
                }
            } while (!onnistuiko);
            return kmh;
        }
        static double KilometriaJaljella()
        {
            double kilometria;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.Write("Monta kilometriä on jäljellä? ");
                luettu = Console.ReadLine();
                onnistuiko = double.TryParse(luettu, out kilometria);

                if (onnistuiko != true)
                {
                    Console.WriteLine("Syötä jäljellä oleva matka kilometreinä: ");
                }
            } while (!onnistuiko);
            return kilometria;
        }

    }
}
