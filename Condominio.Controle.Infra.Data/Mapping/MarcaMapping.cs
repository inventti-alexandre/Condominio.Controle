using Condominio.Controle.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Condominio.Controle.Infra.Data.Mapping
{
    public class MarcaMapping : EntityTypeConfiguration<Marca>, IMapping
    {
        public MarcaMapping()
        {
            HasKey(m => m.MarcaId);

            Property(m => m.Descricao)
                .IsRequired();
        }
    }
}
