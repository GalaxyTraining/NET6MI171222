// See https://aka.ms/new-console-template for more information
int NUM, AUX, DEC, UNI, CEN;
string linea;
Console.WriteLine("INGRESE NUMERO DE TRES CIFRAS :");
linea= Console.ReadLine();
NUM=int.Parse(linea);
CEN = NUM / 100;
NUM=NUM % 100;
DEC=NUM/10;
UNI=NUM % 10;
AUX = (UNI * 100) + (DEC * 10) + CEN;
Console.WriteLine("NUMERO INVERTIDO ES: " + AUX);
Console.WriteLine("Pulse una tecla:");
Console.ReadLine();
