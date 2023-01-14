using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public interface IUnitOfWork
    {
        Task<string> MensajeRespuesta();
    }
}
