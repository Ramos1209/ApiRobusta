using CalculoGrafico_Application.Interfaces;
using CalculoGrafico_Domain;
using CalculoGrafico_Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGrafico_Application.Concret
{
   public class EmpresaAppService:AppServiceBase<Empresa>,IEmpresaAppService
    {
        private readonly IServiceEmpresa _serviceEmpresa;

        public EmpresaAppService(IServiceEmpresa serviceEmpresa):base(serviceEmpresa)
        {
            _serviceEmpresa = serviceEmpresa;
        }
    }
}
