// See https://aka.ms/new-console-template for more information
int NUM1;
string linea;
long RESUL;
Console.WriteLine("DIGITE UN NUMERO :");
linea=Console.ReadLine();
NUM1=int.Parse(linea);
RESUL=Math.Abs(NUM1);
Console.WriteLine("VALOR ABSOLUTO : " + RESUL);
Console.WriteLine("POTENCIA : " + Math.Pow(NUM1,3));
Console.WriteLine("RAIZ CUADRADA : " + Math.Sqrt(NUM1));
Console.WriteLine("SENO :  " + Math.Sin(NUM1*Math.PI/180));
Console.WriteLine("COSENO: " + Math.Cos(NUM1 * Math.PI / 180));
Console.WriteLine("NUMERO MAXIMO : " + Math.Max(NUM1, 50));
Console.WriteLine("NUMERO MINIMO : " + Math.Min(NUM1, 50));
Console.WriteLine("PARTE ENTERA : " + Math.Truncate(18.78));
Console.WriteLine("REDONDEO : " + Math.Round(18.78));
Console.WriteLine("Pulse una tecla:");
Console.ReadLine();