int pisteet;

Console.WriteLine("Anna luku: ");
pisteet = int.Parse(Console.ReadLine());

if (pisteet >= 0 && pisteet < 31)
{
    Console.WriteLine("Arvosana on 0");
}

else if (pisteet > 30 && pisteet < 41)
{
    Console.WriteLine("Arvosana on 4");
}

else if (pisteet > 40 && pisteet < 51)
{
    Console.WriteLine("Arvosana on 5");
}

else if (pisteet > 50 && pisteet < 61)
{
    Console.WriteLine("Arvosana on 6");
}

else if (pisteet > 60 && pisteet < 71)
{
    Console.WriteLine("Arvosana on 7");
}

else if (pisteet > 70 && pisteet < 81)
{
    Console.WriteLine("Arvosana on 8");
}

else if (pisteet > 80 && pisteet < 91)
{
    Console.WriteLine("Arvosana on 9");
}

else if (pisteet > 90 && pisteet < 101)
{
    Console.WriteLine("Arvosana on 10");
}

else
{
    Console.WriteLine("Virhe");
}
