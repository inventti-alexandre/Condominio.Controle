using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Repositories;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Domain.Services
{
    public class BlocoService : RepositoryService<Bloco>, IBlocoService
    {
        private readonly IBlocoRepository _blocoRepository;

        public BlocoService(IBlocoRepository blocoRepository)
            : base(blocoRepository)
        {
            _blocoRepository = blocoRepository;
        }

    }
}
