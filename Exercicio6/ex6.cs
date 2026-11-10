Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
if(idade > 60)
{
    Console.WriteLine("Você é idoso");
}
else if(idade >= 18)
{
    Console.WriteLine("Você é adulto");
}
else if(idade >= 12)
{
    Console.WriteLine("Você é adolescente");
}
else
{
    Console.WriteLine("Você é criança");
}
