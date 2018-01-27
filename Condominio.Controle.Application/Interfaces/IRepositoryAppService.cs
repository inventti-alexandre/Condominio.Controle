using System.Collections.Generic;

namespace Condominio.Controle.Application.Interfaces
{
    public interface IRepositoryAppService<TEntity> where TEntity : class
    {
        TEntity Add(TEntity model);    // Create
        IEnumerable<TEntity> GetAll(); // Read
        void Update(TEntity model);    // Update
        void Delete(TEntity model);    // Delete
        TEntity GetById(int id);       // Read 
        void Dispose();                // tira objeto da memoria
    }
}
