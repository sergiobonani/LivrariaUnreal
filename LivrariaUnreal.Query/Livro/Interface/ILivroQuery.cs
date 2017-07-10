using LivrariaUnreal.Query.Livro.ReadModel;
using System.Collections.Generic;

namespace LivrariaUnreal.Query.Livro.Interface
{
    public interface ILivroQuery
    {
        LivroDto ObterParaCriacao();
        LivroDto ObterParaEdicao(int id);
        IList<LivroListagemDto> ObterListagem();
    }
}
