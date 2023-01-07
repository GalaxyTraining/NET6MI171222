
using System;
using System.Collections;

int notaPracticas = 13;
int examenParcial = 10;
int examenFinal = 06;
double promedioFinal = (notaPracticas + examenParcial + examenFinal) / 3;
if(promedioFinal>=11)
{
    Console.WriteLine("Alumno aprobado promedio final:" + promedioFinal.ToString());
}
else if(promedioFinal>8)
{
    Console.WriteLine("Alumno desaprobado promedio final"+ promedioFinal.ToString());
}
else
{
    Console.WriteLine("Alumno reprobado  promedio final" + promedioFinal.ToString());
}
string mensaje = promedioFinal >= 11 ? "Alumno aprobado promedio final:" + promedioFinal.ToString() : promedioFinal > 8 ? "Alumno desaprobado promedio final" + promedioFinal.ToString() : "Alumno reprobado  promedio final" + promedioFinal.ToString();
Console.WriteLine("if else simplicado:" + mensaje);
for(int i=0;i<=5;i++)
{
    Console.WriteLine("Los valores son "+i.ToString());
}
int a= 0;
while(a<=5)
{
    Console.WriteLine(a);
    a++;
}
for( int j=0;j<=10;j+=2)
{
    Console.WriteLine(j.ToString());
}

int day = 1;
switch(day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
         break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}

switch(day)
{
    case 6:
        Console.WriteLine("Today is saturday");
        break;
    case 7:
        Console.WriteLine("Today is sunday");
        break;
    default:
        Console.WriteLine("Looking forward  to the weekend");
        break;
}

int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach(int number in numbers)
{
     if(number==3)
    {
        break;
    }
    Console.WriteLine($"{number} ");
}

for(int outer=0;outer<5;outer++)
{
    for(int inner=0;inner<5;inner++)
    {
        if(inner>outer)
        {
            break;
        }
        Console.WriteLine($"bluce anidado break: {inner}");
    }
    Console.WriteLine();
}
//continue
for(int m=0;m<5;m++)
{
    Console.Write($"Iteration {m}: ");
    if(m<3)
    {
        Console.WriteLine("skip");
        continue;
    }
    Console.WriteLine("done");
}

//return 
Console.WriteLine("Primera llamada:");
DisplayIfNeccesary(6);
Console.WriteLine("Segunda llamada:");
DisplayIfNeccesary(5);
void DisplayIfNeccesary(int number)
{
    if (number % 2 == 0) return;

    Console.WriteLine(number);
}
//goto
Console.Write("Choose your coffe? milk or black: ");
//string coffeType = Console.ReadLine();
string coffeType = "milk";
switch (coffeType)
{
    case "milk":
        Console.WriteLine("Can I have a milk coffe?");
    break;
    case "black":
        Console.WriteLine("Can I have a black coffe?");
        goto case "milk";
    default:
        Console.WriteLine("Not available. ");
        break;
}

static void  ProcessString(string s)
{
    if(s==null)
    {
        throw new ArgumentNullException(paramName: nameof(s), message: "Parameter can't be null");
    }
}
try
{
    string s = null;
    ProcessString(s);
}
catch (ArgumentNullException e)
{
   Console.WriteLine("{0} First exception caught.", e);
}
catch(Exception e)
{
    Console.WriteLine("{0} Second exception caught.", e);
}


try
{
    string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    Console.WriteLine(weekDays2[0]);
    Console.WriteLine(weekDays2[1]);
    Console.WriteLine(weekDays2[2]);
    Console.WriteLine(weekDays2[3]);
    Console.WriteLine(weekDays2[4]);
    Console.WriteLine(weekDays2[5]);
    Console.WriteLine(weekDays2[6]);
    Console.WriteLine(weekDays2[7]);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
//array bidimensional
int[,] arrayBidimensional = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
Console.WriteLine(arrayBidimensional[0, 1]);
Console.WriteLine(arrayBidimensional[3, 1]);

int[,,] arrayTridimensional = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
Console.WriteLine(arrayTridimensional[1,1,2]);
Console.WriteLine(arrayTridimensional[0, 0, 2]);


List<int> list = new() { 1,2,3};
List<string> subjects = new() { "English", "Math" };
list.Add(4);
list.Add(5);
subjects.Add("Germany");

Console.WriteLine("Cuarto elemento: " + list[3]);
Console.WriteLine("Segundo elemento: " + subjects[1]);

ArrayList listaNaves= new();
listaNaves.Add(2);
listaNaves.Add("");
listaNaves.Add(5);
Console.WriteLine("Primer elemento " + listaNaves[0]);
Console.WriteLine("Cantidad de elementos " + listaNaves.Count);
listaNaves.RemoveAt(0);
SortedList<string, string> openWith = new();
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");


var ciudades = new Dictionary<string, string>()
{
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};
foreach(var ciudad in ciudades)
{
    Console.WriteLine("Key: {0}, Value: {1}", ciudad.Key, ciudad.Value);
}

Hashtable ht = new();
ht.Add("001", "Zara Ali");
ht.Add("002", "Abida Rehman");
ht.Add("003", "Joe Holzner");
ht.Add("004", "Mausam Benazir Nur");
if(ht.ContainsValue("Nuha Ali"))
{
    Console.WriteLine("This student name is already in the list");
}
else
{
    ht.Add("005", "Nuha Ali");
}

Stack<string> pila = new();
pila.Push("a");
pila.Push("b");
pila.Push("c");
pila.Push("d");

Queue<string> queue = new();
queue.Enqueue("Audi");
queue.Enqueue("Honda");
queue.Enqueue("BMW");

Console.WriteLine($"La primera marca es {queue.Peek()}");
Console.WriteLine($"La primera marca (otra vez) es {queue.Dequeue()}");


(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
Console.ReadLine();
