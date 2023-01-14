using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    internal class DetalleCompra
    {
        public int Codigo { get; set; }
        public int CodigoCompra { get; set;}

        public string Producto { get; set; }

        public decimal Precio { get; set;}

        public int  Cantidad { get; set; }

        public decimal Total { get; set; }

        public int OrdenSecuencia { get; set; }

        public Compra idCompra { get; set; }
    }
}
