using Condominio.Controle.Domain.Interfaces.Repositories;
using Condominio.Controle.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Condominio.Controle.Domain.Services
{
    public class RepositoryService<TEntity> : IDisposable, IRepositoryService<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;
        /// <summary>
        /// Construtor recebe injeção da Classe Concreta
        /// </summary>
        /// <param name="repository">repository Classe Concreta via Injeção</param>
        public RepositoryService(IRepositoryBase<TEntity> repository)
        {
            _repositoryBase = repository;
        }

        public TEntity Add(TEntity model)
        {
            return _repositoryBase.Add(model);
        }

        public void Delete(TEntity model)
        {
            _repositoryBase.Delete(model);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Update(TEntity model)
        {
            _repositoryBase.Update(model);
        }
    }
}
