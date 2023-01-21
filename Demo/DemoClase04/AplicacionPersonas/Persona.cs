using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPersonas
{
    public class Persona
    {
        private Conexion con = new();
        private string nombre, direccion;
        private string[] datos = new string[2];
        private string[,] datos2 = new string[11, 11];

        public void setNombre(string nom)
        {
            nombre = nom;
        }
        public string getNombre() { return nombre; }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string getDireccion() { return direccion; }
        public string[,] getDatos2()
        {
            return datos2;
        }
        public void leeNombre(int id)
        {
            datos = con.getNombre(id);
            nombre = datos[0];
            direccion = datos[1];
        }
        public void borrar(int id)
        {
            nombre = con.getBorrar(id);
        }
        public void agregar(string nombre,string direccion)
        {
          nombre=  con.getAgregar(nombre,direccion);
        }
        public void modificar(int id,string nombre, string direccion)
        {
            nombre = con.getModificar(id,nombre, direccion);
        }
        public string[,] mostrar()
        {
            datos2 = con.getTabla();
            return datos2;
        }
    }
}
