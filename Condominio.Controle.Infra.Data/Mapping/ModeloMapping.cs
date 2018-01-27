using Condominio.Controle.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Condominio.Controle.Infra.Data.Mapping
{
    public class ModeloMapping : EntityTypeConfiguration<Modelo>, IMapping
    {
        public ModeloMapping()
        {
            HasKey(m => m.ModeloId);

            Property(m => m.Descricao)
                .IsRequired();

            HasRequired(m => m.Marca)
                .WithMany()
                .HasForeignKey(m => m.MarcaId);
        }
    }
}
