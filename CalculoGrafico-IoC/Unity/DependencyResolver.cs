using CalculoGafico_Infra.Persistence;
using CalculoGafico_Infra.Persistence.Repository;
using CalculoGafico_Infra.Persistence.Repository.Base;
using CalculoGrafico_Domain.Interface.Base;
using CalculoGrafico_Domain.Interface.Repository;
using CalculoGrafico_Domain.Interface.Service;
using CalculoGrafico_Domain.Interface.Service.Base;
using CalculoGrafico_Domain.Services;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;

namespace CalculoGrafico_IoC.Unity
{

    public static class DependencyResolver
        {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, CalculoGraficoContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
           // container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            container.RegisterType(typeof(IServiceBase<>), typeof(ServiceBase<>));

            container.RegisterType<IServiceEmpresa, ServiceEmpresa>(new HierarchicalLifetimeManager());
           // container.RegisterType<IServiceJogo, ServiceJogo>(new HierarchicalLifetimeManager());



            //Repository
            container.RegisterType(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            container.RegisterType<IEmpresaRepository, EmpresaRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IRepositoryJogo, RepositoryJogo>(new HierarchicalLifetimeManager());



        }
    }
    }


