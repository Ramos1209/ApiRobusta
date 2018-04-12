using CalculoGrafico_Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGafico_Infra.Persistence.Map
{
   public class EmpresaMap:EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            ToTable("Empresa");
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.NomeEmpresa).IsRequired();
            Property(e => e.RazaoSocial).IsRequired();
            Property(e => e.Cnpj).IsRequired();
        }
    }
}
