using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Application.App
{
    public class VeiculoAppService : RepositoryAppService<Veiculo>, IVeiculoAppService
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoAppService(IVeiculoService veiculoService)
            : base(veiculoService)
        {
            _veiculoService = veiculoService;
        }
    }
}
