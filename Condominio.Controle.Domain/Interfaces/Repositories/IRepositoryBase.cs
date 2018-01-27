﻿using System.Collections.Generic;

namespace Condominio.Controle.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity model);    // Create
        IEnumerable<TEntity> GetAll(); // Read
        void Update(TEntity model);    // Update
        void Delete(TEntity model);    // Delete
        TEntity GetById(int id);       // Read 
        void Dispose();                // tira objeto da memoria
    }
}
