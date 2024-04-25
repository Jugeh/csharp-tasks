int raja, yhteen;

Console.WriteLine("Mihin asti lasketaan yhteen?");
raja = int.Parse(Console.ReadLine());

yhteen = 0;
for (int i = 1; i <= raja; i++)
{
    yhteen += i;
}
Console.WriteLine("Summa on " + yhteen);
