using CalculoGrafico_Domain.Interface.Repository;
using CalculoGrafico_Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGrafico_Domain.Services
{
   public class ServiceEmpresa: ServiceBase<Empresa>,IServiceEmpresa
    {
        private readonly IEmpresaRepository _empresaRepository;

        public ServiceEmpresa(IEmpresaRepository empresaRepository):base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
    }
}
