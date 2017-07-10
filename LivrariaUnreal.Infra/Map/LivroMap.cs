using LivrariaUnreal.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace LivrariaUnreal.Infra.Map
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            HasKey(x => x.Id);

            Property(x => x.Descricao).IsRequired();

            Property(x => x.TipoLivro);

            Property(x => x.Isbn);
        }
    }
}
