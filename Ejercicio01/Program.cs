// See https://aka.ms/new-console-template for more information
int NUM, AUX, DEC, UNI;
string linea;
Console.WriteLine("INGRESE NUMERO DE DOS CIFRAS :");
linea = Console.ReadLine();
NUM = int.Parse(linea);
DEC = NUM / 10;
UNI = NUM % 10;
AUX = (UNI * 10) + DEC;
Console.WriteLine("NUMERO INVERTIDO ES: " + AUX);
Console.WriteLine("Pulse una tecla:");
Console.ReadLine();