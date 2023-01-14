using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    internal interface ICompraNegocio
    {
        decimal CalculoTotalApagar(List<DetalleCompra> detalleCompras, Compra compra);
    }
}
