using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Repositories;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Domain.Services
{
    public class MarcaService : RepositoryService<Marca>, IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaService(IMarcaRepository marcaRepository)
            : base(marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

    }
}
