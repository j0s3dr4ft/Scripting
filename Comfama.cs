// See https://aka.ms/new-console-template for more information

Console.WriteLine("Programa para saber su Tarifa (Comfama");

Console.WriteLine("Ingrese su Salario: ");
double salario = double.Parse(Console.ReadLine());


if (salario < 2600000)
{
    Console.WriteLine("Eres Tarifa A");
}
else if(salario < 5200000)
{
    Console.WriteLine("Eres Tarifa B");
}
else 
{
    Console.WriteLine("Eres Tarfia C");
}

