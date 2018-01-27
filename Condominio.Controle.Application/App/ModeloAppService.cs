using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Application.App
{
    public class ModeloAppService : RepositoryAppService<Modelo>, IModeloAppService
    {
        private readonly IModeloService _modeloService;

        public ModeloAppService(IModeloService modeloService)
            : base(modeloService)
        {
            _modeloService = modeloService;
        }
    }
}
