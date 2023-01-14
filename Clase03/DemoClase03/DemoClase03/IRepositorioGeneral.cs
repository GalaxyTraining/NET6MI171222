using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public interface IRepositorioGeneral<T> where T : class
    {
        T Prueba(T valor);
    }
}
