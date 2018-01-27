using Condominio.Controle.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Condominio.Controle.Infra.Data.Mapping
{
    public class BlocoMapping : EntityTypeConfiguration<Bloco>, IMapping
    {
        public BlocoMapping()
        {
            HasKey(b => b.BlocoId);

            Property(b => b.Descricao)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(1);
        }
    }
}
