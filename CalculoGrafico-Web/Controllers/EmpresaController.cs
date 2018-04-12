using CalculoGrafico_Application.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace CalculoGrafico_Web.Controllers
{
    [RoutePrefix("Api/Empresa")]
    public class EmpresaController : ApiController
    {
        private readonly IEmpresaAppService _empresaApService;

        public EmpresaController(IEmpresaAppService empresaApService)
        {
            _empresaApService = empresaApService;
        }


        public IEnumerable<string> Get()

        {
            _empresaApService.GetAll();
            return new string[] { "value1", "value2" };
        }

        // GET: api/Empresa/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Empresa
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Empresa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empresa/5
        public void Delete(int id)
        {
        }
    }
}
