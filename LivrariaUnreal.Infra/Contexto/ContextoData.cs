using LivrariaUnreal.Dominio.Entidades;
using LivrariaUnreal.Infra.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaUnreal.Infra.Contexto
{
    public class ContextoData : DbContext
    {
        public ContextoData() : base("stringConexao") { }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Properties()
                .Where(el => el.Name == string.Format("Id{0}", el.ReflectedType.Name))
                .Configure(el => el.IsKey());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(el => el.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(el => el.HasMaxLength(100));

            modelBuilder.Configurations.Add(new LivroMap());
        }

        public override int SaveChanges()
        {

            foreach (var entry in ChangeTracker.Entries().Where(el => el.Entity.GetType().GetProperty("DataInclusao") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;
                    entry.Property("DataInclusao").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
