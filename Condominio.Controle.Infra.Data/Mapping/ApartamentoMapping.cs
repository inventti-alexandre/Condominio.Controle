using Condominio.Controle.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Condominio.Controle.Infra.Data.Mapping
{
    public class ApartamentoMapping : EntityTypeConfiguration<Apartamento>, IMapping
    {
        public ApartamentoMapping()
        {
            HasKey(a => a.ApartamentoId);

            Property(a => a.Descricao)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(4);

            HasRequired(a => a.Bloco)
                .WithMany()
                .HasForeignKey(a => a.BlocoId);

            HasRequired(a => a.Proprietario)
                .WithMany(p => p.Apartamentos)
                .HasForeignKey(a => a.ProprietarioId);
        }
    }
}
