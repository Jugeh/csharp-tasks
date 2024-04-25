using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanalaskuri2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Luodaan uudet jäsen oliot ja string muuttujat
            Tiedosto testinks, testinks2; 
            testinks = new Tiedosto("jjjj.txt");
            testinks2 = new Tiedosto("test_file.txt");
            string vastaus, sana;

            //Kysytään luettava tiedosto
            Console.Write("Anna tiedoston nimi: "); 
            vastaus = Console.ReadLine();

            //Jos tiedosto on jjjj.txt tulostetaan sen sanojen ja merkkien määrä sekä
            //yksittäisen sanan lukumäärää niin kauan, kunnes käyttäjä syöttää tyhjän arvon.
            if (vastaus == "jjjj.txt")
            {
                Console.WriteLine("Sanoja tiedostossa: " + testinks.SanojenMaara);
                Console.WriteLine("Merkkejä tiedostossa: " + testinks.MerkkienMaara);
                
                while (true)
                {
                    Console.Write("Anna sana (tyhjä lopettaa): ");
                    sana = Console.ReadLine();
                    if (sana != "")
                    {                        
                        Console.WriteLine("Sana " + sana + " esiintyy " + testinks.YksittaisenMaara(sana) + " kertaa.");
                    }
                    else if (sana == "")
                    {
                        Console.WriteLine("Lopetetaan...");
                        Console.ReadKey();
                        break;
                    }
                }
            }
            //Jos tiedosto on test_file.txt tulostetaan sen sanojen ja merkkien määrä sekä
            //yksittäisen sanan lukumäärää niin kauan, kunnes käyttäjä syöttää tyhjän arvon.
            else if (vastaus == "test_file.txt")
            {
                Console.WriteLine("Sanoja tiedostossa: " + testinks2.SanojenMaara);
                Console.WriteLine("Merkkejä tiedostossa: " + testinks2.MerkkienMaara);

                while (true)
                {
                    Console.Write("Anna sana (tyhjä lopettaa): ");
                    sana = Console.ReadLine();
                    if (sana != "")
                    {
                        Console.WriteLine("Sana " + sana + " esiintyy " + testinks2.YksittaisenMaara(sana) + " kertaa.");
                    }
                    else if (sana == "")
                    {
                        Console.WriteLine("Lopetetaan...");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
