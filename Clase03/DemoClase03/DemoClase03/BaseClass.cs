using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClase03
{
    public class BaseClass
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BaseClass(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
    }
}
