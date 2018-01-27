using Condominio.Controle.Domain.Entities;
using Condominio.Controle.Infra.Data.Mapping;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace Condominio.Controle.Infra.Data.Context
{
    public class CondominioContext : DbContext
    {
        public CondominioContext()
            : base("CondominioContext")
        {

        }

        ///////////////////// Definição dos DBSet<> das Entidades ///////////////////////////////////////////////////

        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Bloco> Blocos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            ///////////////// Desabilitando Pluralização dos Nomes de Tabelas e Exclusão em Cascatas 1:N e N:N ///////////

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            ///////////////// Configuração das propriedades Ids para serem Chave Primarias ///////////////////////////////////////
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
            /////////////// Configuração das Propriedades Strings dos tipo de dados e tamanho na Base //////////////////////////
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(200));

            /////////////// Adicionando os Mapping de cada Entitidade atraves da Assembly refleção /////////////////////////////////////

            var TypesMapping = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && typeof(IMapping).IsAssignableFrom(t)).ToList();

            foreach (var Mapping in TypesMapping)
            {
                dynamic mappingClass = Activator.CreateInstance(Mapping);
                modelBuilder.Configurations.Add(mappingClass);
            }

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                //verificando o momento em que estado esta o contex
                // Momento de Insert
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                // Momento de Update
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }

            }
            return base.SaveChanges();
        }




    }
}
