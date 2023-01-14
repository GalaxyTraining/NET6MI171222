using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public class RepositorioGeneral<T>: IRepositorioGeneral<T> where T : class
    {
          public T Prueba(T valor) 
        {
            return valor;
        }
    }
}
