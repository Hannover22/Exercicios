Console.WriteLine("Digite um numero decimal: ");
float x;
x = float.Parse(Console.ReadLine());
Console.WriteLine("Digite outro numero decimal: ");
float y;
y = float.Parse(Console.ReadLine());
if(x > y)
{
    Console.WriteLine(x + " > " + y);
}
else
{
    Console.WriteLine(x + " < " + y);
}
