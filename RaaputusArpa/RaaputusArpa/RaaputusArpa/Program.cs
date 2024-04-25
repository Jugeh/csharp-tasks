using System;

/// <summary>
/// Ohjelma esittää raaputusarpaa. Kolmella samalla numerolla 
/// voittaa.
/// Ohjelma täyttää 3x3 ruudukon satunnaisluvuilla välillä 1-3.
/// Käyttäjä voi valita ruudukosta kolme ruutua antamalla rivin
/// ja sarakkeen. Ohjelma tarkastaa, onko kaikissa kolmessa 
/// ruudussa sama luku. Jos luvut ovat samat, 
/// tulostuu: Onnittelut! Voitit pääpotin!
/// Jos yksikin luku on eri, tulostuu: Ei arpaonnea, yritä uudelleen
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Random luku = new Random();
        int koko = 3;
        int[,] luvut = new int[koko, koko];
        int[,] arvatut = new int[koko, koko];
        int rivi1, rivi2, rivi3, sarake1, sarake2, sarake3;

        //Ruudukon täyttö
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                luvut[i, j] = luku.Next(1, 4);
            }
        }

        NaytaRuudukko(luvut, arvatut, koko);
        Console.WriteLine("Anna eka ruutu: ");
        Console.Write("Rivi: ");
        rivi1 = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Sarake: ");
        sarake1 = int.Parse(Console.ReadLine()) - 1;
        arvatut[rivi1, sarake1] = 1;
        Console.Write("Ruudussa oli: " + luvut[rivi1, sarake1]);
        NaytaRuudukko(luvut, arvatut, koko);


        Console.WriteLine("Anna toka ruutu: ");
        Console.Write("Rivi: ");
        rivi2 = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Sarake: ");
        sarake2 = int.Parse(Console.ReadLine()) - 1;
        arvatut[rivi2, sarake2] = 1;
        Console.Write("Ruudussa oli: " + luvut[rivi2, sarake2]);
        NaytaRuudukko(luvut, arvatut, koko);


        Console.WriteLine("Anna kolmas ruutu: ");
        Console.Write("Rivi: ");
        rivi3 = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Sarake: ");
        sarake3 = int.Parse(Console.ReadLine()) - 1;
        arvatut[rivi3, sarake3] = 1;
        Console.Write("Ruudussa oli: " + luvut[rivi3, sarake3]);
        NaytaRuudukko(luvut, arvatut, koko);


        if ((luvut[rivi1, sarake1] == luvut[rivi2, sarake2]) && (luvut[rivi3, sarake3] == luvut[rivi2, sarake2]) && (luvut[rivi1, sarake1] == luvut[rivi3, sarake3]))
        {
            Console.WriteLine("Onnittelut! Voitit pääpotin!");
        }
        else
        {
            Console.WriteLine("Ei arpaonnea, yritä uudelleen");
        }
        Console.ReadKey();

    }

    static void NaytaRuudukko(int [,] luvut, int[,] arvatut, int koko)
    {
        Console.WriteLine();
        Console.Write("  |");
        for (int i = 0; i < koko; i++)
        {
            Console.Write("{0,2}", i + 1);
        }
        Console.WriteLine();
        for (int i = 0; i <= koko; i++)
        {
            Console.Write("--");
        }
        Console.WriteLine("-");
        for (int i = 0; i < koko; i++)
        {
            Console.Write("{0, -2}|", i + 1);
            for (int j = 0; j < koko; j++)
            {
                if(arvatut[i, j] == 1)
                {
                    Console.Write("{0,2}", luvut[i, j]);
                }
                else
                {
                    Console.Write("{0,2}", 'X');
                }
                
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
