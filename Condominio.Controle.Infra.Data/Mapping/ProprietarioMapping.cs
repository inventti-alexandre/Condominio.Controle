using Condominio.Controle.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Condominio.Controle.Infra.Data.Mapping
{
    public class ProprietarioMapping : EntityTypeConfiguration<Proprietario>, IMapping
    {
        public ProprietarioMapping()
        {
            HasKey(p => p.ProprietarioId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Telefone)
                .IsRequired()
                .HasMaxLength(15);

            Property(p => p.Numero_Interfone)
                .IsOptional()
                .HasColumnType("char")
                .HasMaxLength(5);

            Property(p => p.Apelido)
                .IsOptional()
                .HasMaxLength(20);

            Property(p => p.CPF)
                .IsOptional()
                .HasMaxLength(12);

            Property(p => p.DataCadastro)
                .IsRequired()
                .HasColumnType("datetime");
        }
    }
}
