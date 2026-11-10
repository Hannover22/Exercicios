Console.WriteLine("Digite o valor do seu salário: ");
double salario = double.Parse(Console.ReadLine());
if(salario > 4000.01){
    Console.WriteLine("Aumento = " + (salario + (salario * 0.05)));
}
else if(salario > 2000.01){
    Console.WriteLine("Aumento = " + (salario + (salario * 0.1)));
}
else if(salario <= 2000)
{
    Console.WriteLine("Aumento = " + (salario + (salario * 0.15)));
}
