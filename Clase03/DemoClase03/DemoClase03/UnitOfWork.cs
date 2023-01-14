using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public class UnitOfWork: IUnitOfWork
    {
        public async Task<string> MensajeRespuesta()
        {
            return  await Task.FromResult("message test");
        }
    }
}
