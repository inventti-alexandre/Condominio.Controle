using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Application.App
{
    public class MarcaAppService : RepositoryAppService<Marca>, IMarcaAppService
    {
        private readonly IMarcaService _marcaService;

        public MarcaAppService(IMarcaService marcaService)
            : base(marcaService)
        {
            _marcaService = marcaService;
        }
    }
}
