﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine ("Programa para saber su Tarifa (Comfama");

Console.WriteLine ("Ingrese su Salario: ");
double salarioMinimo = double.Parse(Console.ReadLine());

double smmlv = 1300000;

if (smmlv < 2600000)
{
    Console.WriteLine("Eres Tarifa D");
}
else if (smmlv > 3500000)
{ 
    Console.WriteLine("Eres Tarifa B");
}
else if (smmlv < 5200000)
{
    Console.WriteLine("Eres Tarifa A");
}