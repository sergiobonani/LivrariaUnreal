using LivrariaUnreal.Query.Livro.Interface;
using LivrariaUnreal.Query.Livro.ReadModel;
using System.Collections.Generic;

namespace LivrariaUnreal.Query.Livro
{
    public class LivroQuery : ILivroQuery
    {
        public LivroDto ObterParaCriacao()
            => new LivroDto();

        public IList<LivroListagemDto> ObterListagem()
            => new List<LivroListagemDto>();

        public LivroDto ObterParaEdicao(int id)
            => new LivroDto();
    }
}
