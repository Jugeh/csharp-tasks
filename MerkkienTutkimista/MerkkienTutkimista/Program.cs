using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkkienTutkimista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader file = new StreamReader("merkkitiedosto.txt"))
            {
                int luku;
                while ((luku = file.Read()) != -1)
                {
                    char merkki = (char)luku;

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
                        Console.WriteLine(merkki + " on mikälie merkki");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
