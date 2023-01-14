using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    internal class CompraNegocio:RepositorioGeneral<Compra>,ICompraNegocio
    {
        public CompraNegocio() 
        {
            repositorioGeneral = new RepositorioGeneral<Compra>();
        }
        public IRepositorioGeneral<Compra> repositorioGeneral { get; set; }
          public decimal CalculoTotalApagar(List<DetalleCompra>  detalleCompras,Compra compra)
        {
            decimal total = 0;
            foreach (DetalleCompra detalleCompra in detalleCompras)
            {
                detalleCompra.Total = detalleCompra.Precio * detalleCompra.Cantidad;
                Console.WriteLine("Total del producto: " + detalleCompra.Producto + " Total : " + detalleCompra.Total);
                total += detalleCompra.Total;
            }
            compra.Total = total;
               Compra compra2=  repositorioGeneral.Prueba(compra);
            return compra.Total;
        }

       
    }
}
