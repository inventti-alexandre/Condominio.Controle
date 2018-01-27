using Condominio.Controle.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Condominio.Controle.Infra.Data.Mapping
{
    public class VeiculoMapping : EntityTypeConfiguration<Veiculo>, IMapping
    {
        public VeiculoMapping()
        {
            HasKey(v => v.VeiculoId);

            Property(v => v.Placa)
                .IsRequired()
                .HasMaxLength(8);

            Property(v => v.Cor)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(10);

            HasRequired(v => v.Proprietario)
                .WithMany(p => p.Veiculos)
                .HasForeignKey(v => v.VeiculoId);

            HasRequired(v => v.Modelo)
                .WithMany()
                .HasForeignKey(v => v.ModeloId);
                
        }
    }
}
