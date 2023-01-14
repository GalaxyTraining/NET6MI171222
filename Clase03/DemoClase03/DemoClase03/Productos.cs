using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public abstract class Productos
    {
        private int precio;
        public Productos(int precio)
        {
            this.precio = precio;
        }

        public virtual int getPrecio()
        {
            return this.precio;
        }
        public abstract string getName();
    }
    public class Alimento : Productos
    {
        public Alimento(int precio) : base(precio)
        {
        }

        public override string  getName()
        {
            return "alimento";
        }

        public override int getPrecio()
        {
            return 2;
        }
    }
}
