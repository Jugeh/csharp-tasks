using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkien_testausta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string merkit;
            Console.WriteLine("Anna merkkejä");
            merkit = Console.ReadLine();

            foreach (char merkki in merkit)
            {
                if (char.IsNumber(merkki) == true)
                {
                    Console.WriteLine(merkki + " on numero");
                }
                else if (char.IsLower(merkki) == true)
                {
                    Console.WriteLine(merkki + " on pienikirjain");
                }
                else if (char.IsUpper(merkki) == true)
                {
                    Console.WriteLine(merkki + " on isokirjain");
                }
                else if (char.IsPunctuation(merkki) == true)
                {
                    Console.WriteLine(merkki + " on välimerkki");
                }
                else if (char.IsWhiteSpace(merkki) == true)
                {
                    Console.WriteLine(merkki + " on tyhjä merkki");
                }
                else
                {
                    Console.WriteLine("Mikälie merkki");
                }
            }
            Console.ReadKey();
        }
    }
}
