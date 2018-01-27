using Condominio.Controle.Domain.Interfaces.Repositories;
using Condominio.Controle.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Condominio.Controle.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        /// <summary>
        /// instancia do CondominioContext que dar acesso ao Banco de dados.
        /// </summary>
        protected CondominioContext Db = new CondominioContext();

        public TEntity Add(TEntity model)
        {
            Db.Set<TEntity>().Add(model);
            Db.SaveChanges();
            return model;
        }

        public void Delete(TEntity model)
        {
            Db.Set<TEntity>().Remove(model);
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity model)
        {
            Db.Entry(model).State = EntityState.Modified;
            Db.Set<TEntity>().Remove(model);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
