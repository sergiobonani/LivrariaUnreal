using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaUnreal.Infra.Repositorio
{
    internal static class DadosFake
    {
        public static IQueryable<Dominio.Entidades.Livro> ObterListaLivro =>
            new List<Dominio.Entidades.Livro>
            {
                new Dominio.Entidades.Livro
                {
                    Id = 1,
                    Descricao = "Descricao1",
                    Titulo = "Titulo1"
                },

                new Dominio.Entidades.Livro
                {
                    Id = 2,
                    Descricao = "Descricao2",
                    Titulo = "Titulo12"
                }
            }.AsQueryable();
    }
}
