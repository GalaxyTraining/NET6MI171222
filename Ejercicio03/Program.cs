﻿// See https://aka.ms/new-console-template for more information
byte CANB, CANH, CANP;
double APAGAR;
string linea;
const double PRECIOB = 0.8;
const double PRECIOH = 2;
const double PRECIOP = 1.2;
Console.WriteLine("CANTIDAD DE HAMBURGUESAS :");
linea=Console.ReadLine();
CANH=byte.Parse(linea);
Console.WriteLine("CANTIDAD DE PAPAS :");
linea = Console.ReadLine();
CANP=byte.Parse(linea);
Console.WriteLine("CANTIDAD DE BEBIDAS :");
linea = Console.ReadLine();
CANB=byte.Parse(linea);
Console.WriteLine();
APAGAR=(CANH*PRECIOH) +(CANP*PRECIOP)+(CANB*PRECIOB);
Console.WriteLine("VALOR A PAGAR: " + APAGAR);
Console.WriteLine("Pulse una tecla:");
Console.ReadLine();
