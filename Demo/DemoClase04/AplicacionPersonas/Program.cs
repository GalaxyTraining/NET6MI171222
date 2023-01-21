
using AplicacionPersonas;

string num, opc, nom, dir;
int id, opcion, rompe = 0;
string[,] datos2 = new string[11, 11];
while(rompe!=6)
{
    Console.Clear();
    Console.WriteLine("\n SISTEMA BASE DE DATOS \n  (Modo Conectado)\n");
    Console.WriteLine("\n *** MENU DE OPCIONES *** \n  \n  1 - Agregar Registro \n " +
        "2.-Eliminar Registro \n 3. -Modificar Registro \n 4.  -Buscar Por Id \n 5. -Mostrar Registro \n 6.- Salir");
    Console.WriteLine("\n ********************");
    Console.Write("\n \t \t Opcion = ");
    opc = Console.ReadLine();
    opcion = Convert.ToInt32(opc);
    Persona persona = new();
    switch(opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("\n :::::: AGREGAR REGISTRO :::::\n");
            Console.Write(">Nombre:");
            nom=Console.ReadLine();
            Console.Write(">Direccion:");
            dir = Console.ReadLine();
            persona.agregar(nom, dir);
            Console.WriteLine("\n\n  NOMBRE DIRECCION");
            Console.WriteLine("" + nom + " " + dir + "");
            Console.ReadLine();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("\n :::::: ELIMINAR REGISTRO :::::\n");
            Console.Write(">ID A ELIMINAR");
            num=Console.ReadLine();
            id = Convert.ToInt32(num);
            persona.borrar(id);
            Console.WriteLine("\n *** REGISTRO ELIMINADO ***\n");
            Console.ReadLine();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("\n :::::: MODIFICAR REGISTRO :::::\n");
            Console.Write(">ID A MODIFICAR");
            num = Console.ReadLine();
            id = Convert.ToInt32(num);
            Console.Write(">Nombre: ");
            nom= Console.ReadLine();
            Console.Write(">Direccion: ");
            dir = Console.ReadLine();
            persona.modificar(id, nom, dir);
            Console.WriteLine("\n\n ID  NOMBRE DIRECCION");
            Console.WriteLine("" + id + "" + nom + " " + dir + "");
            Console.WriteLine("\n *** REGISTRO MODIFICADO ***\n");
            Console.ReadLine();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("\n :::::: BUSCAR REGISTRO :::::\n");
            Console.Write(">ID A BUSCAR");
            num = Console.ReadLine();
            id = Convert.ToInt32(num);
            persona.leeNombre(id);
            Console.WriteLine("\n\n ID  NOMBRE DIRECCION");
            Console.WriteLine("" + id + "" + persona.getNombre() + " " + persona.getDireccion() + "");
            Console.WriteLine("\n *** REGISTRO ENCONTRADO ***\n");
            Console.ReadLine();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("\n :::::: MOSTRAR REGISTROS :::::\n");
            Console.WriteLine("\n\n ID  NOMBRE DIRECCION");
            datos2=persona.mostrar();
             for(int x=0;x<10;x++)
            {
                Console.WriteLine(datos2[x, 1] + "\t" + datos2[x, 2] + "\t\t" + datos2[x, 3]);
            }
            Console.ReadLine();
            break;
        case 6:
            rompe = 6;
            Console.WriteLine("\n\n ::: CERRANDO EL SISTEMA :::");
            Console.ReadLine();
            break;
    }

}
