
using CalculoGrafico_Domain.Interface.Base;
using CalculoGrafico_Domain.Interface.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculoGrafico_Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this._repositoryBase = repositoryBase;
        }

        public void Alterar(TEntity obj)
        {
            _repositoryBase.Alterar(obj);
        }

        public IList<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int Id)
        {
            return _repositoryBase.GetById(Id);
        }

        public void Insert(TEntity obj)
        {
            _repositoryBase.Insert(obj);
        }

        public void Remover(TEntity obj)
        {
            _repositoryBase.Remover(obj);
        }

        public void RemoverPorId(int Id)
        {
            var obj = _repositoryBase.GetById(Id);
            _repositoryBase.Remover(obj);
        }
        public void Dispose()
        {
            
        }
    }
}
