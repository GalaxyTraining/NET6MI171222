using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public  class Auto
    {
        public int ConductorId { get; set; }
        public string Modelo { get; set; }   
        public Conductor Conductor { get; set; }
    }
    public class Conductor
    {
        public int ConductorId { get; set; }
        public string Nombre { get; set; }
        public  Auto Auto { get; set; }
    }
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string RazonSocial { get; set; }
        public List<ProveedorCampañia> proveedorCampañias { get; set; }

    }
    public class ProveedorCampañia
    {
        public int ProveedorId { get; set; }
        public int  CompaniaId { get; set; }
    }

    public class Campania
    {
        public int CompaniaId { get; set; }
        public string RazonSocial { get; set; }

        public List<ProveedorCampañia> proveedorCampañias { get; set; }
    }
}
