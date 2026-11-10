//Fui ajudado pelo copilot para saber as regras de um ano bissexto

Console.WriteLine("Digite um ano: ");
int ano = int.Parse(Console.ReadLine());
if(ano % 400 == 0)
{
    Console.WriteLine("O ano é bissexto");
}
else if(ano % 4 == 0 && ano % 100 != 0)
{
    Console.WriteLine("O ano é bissexto");
}
else
{
    Console.WriteLine("O ano não é bissexto");
}

