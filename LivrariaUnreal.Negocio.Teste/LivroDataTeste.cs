using System.Collections.Generic;
using System.Linq;

namespace LivrariaUnreal.Negocio.Teste
{
    internal static class LivroDataTeste
    {
        public static IQueryable<Dominio.Entidades.Livro> ObterListaLivro =>
            new List<Dominio.Entidades.Livro>
            {
                new Dominio.Entidades.Livro
                {
                    Id = 1,
                    Descricao = "Descricao1"
                },

                new Dominio.Entidades.Livro
                {
                    Id = 2,
                    Descricao = "Descricao2"
                }
            }.AsQueryable();
    }
}
