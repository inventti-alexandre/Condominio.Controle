using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Repositories;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Domain.Services
{
    public class ApartamentoService : RepositoryService<Apartamento>, IApartamentoService
    {
        private readonly IApartamentoRepository _apartamentoRepository;

        public ApartamentoService(IApartamentoRepository apartamentoRepository)
            : base(apartamentoRepository)
        {
            _apartamentoRepository = apartamentoRepository;
        }

    }
}
