using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;

namespace CalculoGrafico_Domain.Interface.Service.Base
{
    public interface IServiceBase<TEntity> where TEntity :class
    {
        IList<TEntity> GetAll();
        TEntity GetById(int Id);
        void Insert(TEntity obj);
        void Remover(TEntity obj);
        void RemoverPorId(int Id);
        void Alterar(TEntity obj);
    }
}
