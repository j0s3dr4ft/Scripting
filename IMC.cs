// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese su Peso: ");
double masaCorporal = double.Parse(Console.ReadLine());

//se usa coma para los decimales (1,2 en lugar de 1.2)
Console.WriteLine("Ingrese su Estatura con coma: ");
double altura = double.Parse(Console.ReadLine());


double imc = ( masaCorporal / (altura * altura));
Console.WriteLine("Indice de Masa Corporal: " + imc);

if (imc > 40)
{
    Console.WriteLine("Obesidad Mórbida ");
}
else if (imc > 35)
{
    Console.WriteLine("Obesidad Media ");
}
else if (imc > 30)
{
    Console.WriteLine("Obesidad Leve ");
}
else if (imc > 25)
{
    Console.WriteLine("Peso normal ");
}
else if (imc > 18.5) {

    Console.WriteLine("Peso normal ");
}
else if (imc < 18.5)
{
    Console.WriteLine("Bajo de Peso");
}









