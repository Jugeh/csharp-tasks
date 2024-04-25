using System;

namespace Puhelinlasku
{
    class LaskuTesti
    {
        static void Main(string[] args)
        {
            Puhelinlasku maaliskuu = new Puhelinlasku("Jussi Juonio");
            maaliskuu.LisaaPuhelu(new Puhelu(0.013, 0.007, 3));
            maaliskuu.LisaaPuhelu(new Puhelu(0.012, 0.007, 29.5));
            maaliskuu.LisaaPuhelu(new Puhelu(0.03, 0.13, 14));
            maaliskuu.LisaaPuhelu(new Puhelu(0.017, 0.005, 56));
            maaliskuu.LisaaPuhelu(new Puhelu(0.013, 0.007, 34));
            maaliskuu.LisaaPuhelu(new Puhelu(0.03, 0.12, 2));
            maaliskuu.LisaaPuhelu(new Puhelu(0.012, 0.007, 12));

            Puhelu pisinPuhelu = maaliskuu.HaePisinPuhelu();
            Console.WriteLine(pisinPuhelu.HaePuhelunKuvaus());

            Puhelu kalleinPuhelu = maaliskuu.HaeKalleinPuhelu();
            Console.WriteLine(kalleinPuhelu.HaePuhelunKuvaus());

            Console.ReadKey();
            
        }
    }
}
