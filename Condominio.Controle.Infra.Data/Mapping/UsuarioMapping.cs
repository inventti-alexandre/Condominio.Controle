using Condominio.Controle.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Controle.Infra.Data.Mapping
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            HasKey(u => u.UsuarioId);
            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(15);

            Property(u => u.Senha)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(8);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
