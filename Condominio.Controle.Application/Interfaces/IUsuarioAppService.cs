using Condominio.Controle.Domain.Entities;

namespace Condominio.Controle.Application.Interfaces
{
    public interface IUsuarioAppService : IRepositoryAppService<Usuario>
    {
        bool IsAuthenticated(Usuario user);
    }
}
