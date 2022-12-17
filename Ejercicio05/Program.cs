// See https://aka.ms/new-console-template for more information
double BASE, ALTURA, RESUL;
string linea;
Console.WriteLine("DIGITE LA BASE :");
linea= Console.ReadLine();
BASE=double.Parse(linea);
Console.WriteLine("DIGITE LA ALTURA :");
linea = Console.ReadLine();
ALTURA = double.Parse(linea);
RESUL = (BASE * ALTURA) / 2;
Console.WriteLine("AREA  TRIANGULO :" +String.Format("{0:####.00}",RESUL));
Console.WriteLine("AREA  TRIANGULO :" + String.Format("{0:c}", RESUL));
Console.WriteLine("AREA  TRIANGULO :" + String.Format("{0:f}", RESUL));
Console.WriteLine("AREA  TRIANGULO :" + String.Format("{0:g}", RESUL));
Console.ReadLine();