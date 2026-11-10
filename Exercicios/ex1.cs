int x;
Console.Write("Digite o numero para ver se ele é par ou impar: ");
x = int.Parse(Console.ReadLine());
if (x % 2 == 1)
{
    Console.WriteLine("O numero é impar");
}
else
{
    Console.WriteLine("O numero é par"); 
}
