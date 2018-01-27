using System;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Repositories;
using System.Linq;

namespace Condominio.Controle.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public bool IsAuthenticated(Usuario user)
        {
            var query = Db.Usuarios.Where(p => p.Nome == user.Nome && p.Senha == user.Senha).ToList();
            return query.Count > 0 ? true : false;
        }
    }
}
