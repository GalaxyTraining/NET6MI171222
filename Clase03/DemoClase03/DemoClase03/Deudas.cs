using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public class Deudas : BaseClass
    {
        public Deudas(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async  Task<string> MostrarMensajePrueba()
        {
            return await _unitOfWork.MensajeRespuesta();
        }
         public double CalcularPromedio(int notaParcial,int notaFinal)
        {
            return (double)(notaParcial + notaFinal) /2;
        }
        public double CalcularPromedio(int notaParcial, int notaFinal, int notaPracticas)
        {
            try
            {
                return (double)(notaParcial + notaFinal + notaPracticas) / 3;
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }
    }
}
