using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Application.App
{
    public class ApartamentoAppService : RepositoryAppService<Apartamento>, IApartamentoAppService
    {
        private readonly IApartamentoService _apartamentoService;

        public ApartamentoAppService(IApartamentoService apartamentoService)
            : base(apartamentoService)
        {
            _apartamentoService = apartamentoService;
        }
    }
}
