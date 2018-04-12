using CalculoGrafico_Domain.Interface.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace CalculoGafico_Infra.Persistence.Repository.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly CalculoGraficoContext _context = new CalculoGraficoContext();
        //public RepositoryBase(CalculoGraficoContext context)
        //{
        //    this._context = context;
        //}
        public void Alterar(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int Id)
        {
            return _context.Set<TEntity>().Find(Id);
        }

        public void Insert(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
        }

        public void Remover(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
        }

        public void RemoverPorId(int Id)
        {
            TEntity obj = GetById(Id);
            Remover(obj);
        }
    }
}
