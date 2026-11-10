Console.WriteLine("Digite o primeiro lado do triângulo: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo lado do triângulo: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro lado do triângulo: ");
int z = int.Parse(Console.ReadLine());

if ((x < y + z) && (y < x + z) && (z < x + y))
{
    if (x == y && y == z)
    {
        Console.WriteLine("Seu triângulo é equilátero");
    }
    else if (x == y || y == z || z == x)
    {
        Console.WriteLine("Seu triângulo é isóceles");
    }
    else
    {
        Console.WriteLine("Seu triângulo é escaleno");
    }
}
else
{
    Console.WriteLine("Esse triângulo não existe");
}