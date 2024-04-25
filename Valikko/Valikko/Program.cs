double luku1, luku2;
int vastaus;

Console.WriteLine("Anna luku: ");
luku1 = double.Parse(Console.ReadLine());

Console.WriteLine("Anna luku: ");
luku2 = double.Parse(Console.ReadLine());

Console.WriteLine("Mitä haluat tehdä?");
Console.WriteLine("1 - Laske yhteen");
Console.WriteLine("2 - Vähennä");
Console.WriteLine("3 - Kerro");
Console.WriteLine("4 - Jaa");

Console.WriteLine("Anna Valintasi");
vastaus = int.Parse(Console.ReadLine());

if (vastaus == 1)
{
    Console.WriteLine(luku1 + luku2);
}

else if (vastaus == 2)
{
    Console.WriteLine(luku1 - luku2);
}

else if (vastaus == 3)
{
    Console.WriteLine(luku1 * luku2);
}

else if (vastaus == 4)
{
    Console.WriteLine(luku1 / luku2);
}

else
{
    Console.WriteLine("Valinnan piti olla 1 - 4");
}