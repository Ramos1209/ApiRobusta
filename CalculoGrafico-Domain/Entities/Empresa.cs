

using CalculoGrafico_Domain.Entities.Base;
using prmToolkit.NotificationPattern;

namespace CalculoGrafico_Domain
{
   public class Empresa:EntityBase
    {
     
        public string NomeEmpresa { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }

        protected Empresa()
        {

        }

        public Empresa(string nomeEmpresa, string cnpj, string razaoSocial, string endereco)
        {
            NomeEmpresa = nomeEmpresa;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Endereco = endereco;

            ValidarEntidade();

        }

        private void ValidarEntidade()
        {
            new AddNotifications<Empresa>(this)
                .IfNullOrInvalidLength(e => e.NomeEmpresa, 3, 150)
                .IfNullOrInvalidLength(e => e.RazaoSocial, 3, 100)
                .IfNotCnpj(e=>e.Cnpj,"Cnpj inválido")
                .IfNullOrInvalidLength(e => e.NomeEmpresa, 3, 100);
        }
    }
}
