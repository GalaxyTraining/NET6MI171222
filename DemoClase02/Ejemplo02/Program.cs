#region Programacion Concurrente
static void Proceso1()
{
    int i = 0;
    while (i < 500)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Estoy en el proceso 1 " + i.ToString());
        i++;
    }

}

static void Proceso2()
{
    int i = 0;
    while (i < 500)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Estoy en el proceso 2 " + i.ToString());
        i++;
    }

}
Thread hilloProceso1 = new Thread(Proceso1);
Thread hiloProceso2 = new Thread(Proceso2);
Console.WriteLine("Proceso Principal");
hilloProceso1.Start();
hiloProceso2.Start();
//Proceso1();
//Proceso2();
#endregion
