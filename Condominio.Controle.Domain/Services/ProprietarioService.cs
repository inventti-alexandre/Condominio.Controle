using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Repositories;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Domain.Services
{
    public class ProprietarioService : RepositoryService<Proprietario>, IProprietarioService
    {
        private readonly IProprietarioRepository _proprietarioRepository;

        public ProprietarioService(IProprietarioRepository proprietarioRepository)
            : base(proprietarioRepository)
        {
            _proprietarioRepository = proprietarioRepository;
        }
    }
}
