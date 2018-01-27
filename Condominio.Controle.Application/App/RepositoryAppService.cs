using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Condominio.Controle.Application.App
{
    public class RepositoryAppService<TEntity> : IDisposable, IRepositoryAppService<TEntity> where TEntity : class
    {
        private readonly IRepositoryService<TEntity> _repositoryService;

        public RepositoryAppService(IRepositoryService<TEntity> repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public TEntity Add(TEntity model)
        {
            return _repositoryService.Add(model);
        }

        public void Delete(TEntity model)
        {
            _repositoryService.Delete(model);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryService.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositoryService.GetById(id);
        }

        public void Update(TEntity model)
        {
            _repositoryService.Update(model);
        }

        public void Dispose()
        {
            _repositoryService.Dispose();
        }
    }
}
