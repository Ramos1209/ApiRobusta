using CalculoGrafico_Application.Interfaces;
using CalculoGrafico_Domain.Interface.Service.Base;
using System;
using System.Collections.Generic;

namespace CalculoGrafico_Application.Concret
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Alterar(TEntity obj)
        {
            _serviceBase.Alterar(obj);
        }


        public IList<TEntity> GetAll()
        {
          return  _serviceBase.GetAll();
        }

        public TEntity GetById(int Id)
        {
           return _serviceBase.GetById(Id);
        }

        public void Insert(TEntity obj)
        {
            _serviceBase.Insert(obj);
        }

        public void Remover(TEntity obj)
        {
            _serviceBase.Remover(obj);
        }

        public void RemoverPorId(int Id)
        {

            _serviceBase.RemoverPorId(Id);
        }
        public void Dispose()
        {
            
        }
    }
}
