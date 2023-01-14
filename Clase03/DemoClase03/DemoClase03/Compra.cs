using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    internal class Compra
    {
        public int Codigo { get; set; }
        public int NumeroDocumento { get; set; }
        public string RazonSocial { get; set; }
        public decimal Total { get; set; }

        public List<DetalleCompra> CompraList { get; set; }
    }
}
