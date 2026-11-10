Console.WriteLine("Quantos quilos você pesa: ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Quantos centimetros você mede: ");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine("Qual seu genero? 1 - Mulher | 2 - Homem");
int opcao = int.Parse(Console.ReadLine());
altura /= 100;
float IMC = peso / (altura * altura);
if (IMC >= 40)
{
    Console.WriteLine("Diagnostico: " + IMC + " Titanic");
}
else if (IMC >= 35)
{
    Console.WriteLine("Diagnostico: " + IMC + " Cazemiro");
}
else if (IMC >= 30)
{
    Console.WriteLine("Diagnostico: " + IMC + " Gordo");
}
else if(IMC >= 25)
{
    Console.WriteLine("Diagnostico: " + IMC + " Ossos largos");
}
else if(IMC >= 18.5){
    Console.WriteLine("Disgnostico: " + IMC + " Peso adequado");
}
else if(IMC < 18.5)
{
    Console.WriteLine("Diagnostico: " + IMC + " Cracudo");
}
