using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Repositories;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Domain.Services
{
    public class ModeloService : RepositoryService<Modelo>, IModeloService
    {
        private readonly IModeloRepository _modeloRepository;

        public ModeloService(IModeloRepository modeloRepository)
            : base(modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }

    }
}
