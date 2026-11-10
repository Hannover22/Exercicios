using System.Net.Http.Headers;

Console.WriteLine("Digite o nome do aluno: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite quanto " + nome + " tirou na primeira prova: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite quanto " + nome + " tirou na segunda prova: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite quanto " + nome + " tirou na terceira prova: ");
float nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite quanto " + nome + " tirou na quarta prova: ");
float nota4 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4) / 4;

if(media <= 5)
{
    Console.WriteLine("REPROVADO, nota: " +  media);
}
else if(media >= 5.1 &&  media <= 6.9)
{
    Console.WriteLine("RECUPERAÇÃO, nota: " + media);
}
else if(media >= 7)
{
    Console.WriteLine("APROVADO, nota: " + media);
}
