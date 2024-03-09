// Se usa \n para dejar un renglón
Console.WriteLine("Programa que permite calcular la vida y armadura del pj Braun de acuerdo al nivel y la cant" +
    "de vida al recibir un golpe \n");

//Entradas
Console.Write("Ingrese el nivel: ");
double nivel = double.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de daño a recibir: ");
double golpe = double.Parse(Console.ReadLine());

// Si NO va a cambiar se usa el modificador const y se usa Mayus inicial
const double VidaInicial = 576.16;
const double VidaNivel = 87;

const double ArmaduraInicial = 47;
const double ArmaudaNivel = 4;

double armadura = ArmaduraInicial + (ArmaudaNivel * (nivel - 1));
double vida = VidaInicial + (VidaNivel * (nivel - 1));

double multiplicadorGolpe = 100 / (100 + armadura);
double vidaReal = vida - golpe * multiplicadorGolpe;

//Para mostrar texto podemos usar $ y poner llaves {}
Console.WriteLine($"Armadura: {(int)armadura}");
Console.WriteLine($"Vida: {(int)vida}");
Console.WriteLine($"Vida después del golpe: {(int)vidaReal}");