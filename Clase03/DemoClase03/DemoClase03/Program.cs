// See https://aka.ms/new-console-template for more information

using DemoClase03;

Producto producto1 = new()
{
    Id = 1,
    Nombre="Donofrio",
    Tipo="Paneton",
    Precio=15
};


Producto producto2 = new()
{
    Id = 2,
    Nombre = "Todino",
    Tipo = "Paneton",
    Precio = 13
};
List<Producto> listProduct = new()
{
    producto1,
    producto2
};
Console.WriteLine(producto1.Nombre);
Console.WriteLine(producto1.Tipo);
Console.WriteLine(producto1.Precio);

foreach(Producto item in listProduct)
{
    Console.WriteLine(item.Precio);
}
Compra compra = new();
DetalleCompra detalleCompra1 = new()
{
    Codigo=1,
    Cantidad=3,
    CodigoCompra=1,
    OrdenSecuencia=2,
    Precio=15,
    Producto="Donofrio"
};
DetalleCompra detalleCompra2 = new()
{
    Codigo = 2,
    Cantidad = 4,
    CodigoCompra = 1,
    OrdenSecuencia = 2,
    Precio = 13,
    Producto = "Todino"
};

DetalleCompra detalleCompra3 = new()
{
    Codigo = 3,
    Cantidad = 5,
    CodigoCompra = 1,
    OrdenSecuencia = 2,
    Precio = 10,
    Producto = "Bimbo"
};
compra.CompraList = new List<DetalleCompra>
{
    detalleCompra1,
    detalleCompra2,
    detalleCompra3
};
ICompraNegocio compraNegocio = new CompraNegocio();
decimal resultado=compraNegocio.CalculoTotalApagar(compra.CompraList, compra);

Console.WriteLine("Total a Pagar: " + resultado);

IUnitOfWork unitOfWork = new UnitOfWork();
Deudas deudas = new Deudas(unitOfWork);
IRepositorioGeneral<string> repositorioGeneral = new RepositorioGeneral<string>();
IRepositorioGeneral<Compra> repositorioGeneral2 = new RepositorioGeneral<Compra>();



Console.WriteLine("Resultado generico :" + repositorioGeneral.Prueba("Prueba Generica"));
Console.WriteLine("Resultado generico  entidades:" + repositorioGeneral2.Prueba(compra));
Console.WriteLine("Resultado : " + deudas.MostrarMensajePrueba());
Console.WriteLine("Notas final sin contar la nota de practicas : " + deudas.CalcularPromedio(2,15));
Console.WriteLine("Notas final  : " + deudas.CalcularPromedio(2, 15, 20));

#region Lambda
Producto resultFilter = listProduct.Where(compra => compra.Nombre == "Todino").FirstOrDefault();
var resultadoFinal = listProduct.Any(compra => compra.Nombre == "Donofrio");

var listOrderDesc = listProduct.OrderBy(a => a.Id).ToList() ;
Console.WriteLine("Respuesta lambda:  " + resultFilter.Nombre);


Console.WriteLine(listOrderDesc);



#endregion

#region Delegate
PruebaDelegate pruebaDelegate = new();
pruebaDelegate.FuncionFinal("Esto es un delegado");
#endregion
Console.ReadLine();