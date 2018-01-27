using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Application.App
{
    public class ProprietarioAppService : RepositoryAppService<Proprietario>, IProprietarioAppService
    {
        private readonly IProprietarioService _proprietarioService;

        public ProprietarioAppService(IProprietarioService proprietarioService)
            : base(proprietarioService)
        {
            _proprietarioService = proprietarioService;
        }

    }
}
