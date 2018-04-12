using CalculoGrafico_Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CalculoGafico_Infra.Persistence
{
   public  class CalculoGraficoContext:DbContext
    {
        public CalculoGraficoContext():base("")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(150));

            #region Adiciona entidades automaticamente via assembly
            
            modelBuilder.Configurations.AddFromAssembly(typeof(CalculoGraficoContext).Assembly);
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
