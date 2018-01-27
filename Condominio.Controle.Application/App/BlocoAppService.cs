using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Domain.Interfaces.Services;

namespace Condominio.Controle.Application.App
{
    public class BlocoAppService : RepositoryAppService<Bloco>, IBlocoAppService
    {
        private readonly IBlocoService _blocoService;

        public BlocoAppService(IBlocoService blocoService)
            : base(blocoService)
        {
            _blocoService = blocoService;
        }
    }


}
