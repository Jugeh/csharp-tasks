int luku1, luku2;

Console.WriteLine("Anna luku: ");
luku1 = int.Parse(Console.ReadLine());

Console.WriteLine("Anna luku: ");
luku2 = int.Parse(Console.ReadLine());

if (luku1 < luku2)
{
    Console.WriteLine(luku1 + " " + luku2);
}

else if(luku2 < luku1)
{
    Console.WriteLine(luku2 + " " + luku1);
}

else
{
    Console.WriteLine("Luvut samat!");
}
