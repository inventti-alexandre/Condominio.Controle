using Condominio.Controle.Domain.Entities;

namespace Condominio.Controle.Domain.Interfaces.Services
{
    public interface IUsuarioService : IRepositoryService<Usuario>
    {
        bool IsAuthenticated(Usuario user);
    }
}
