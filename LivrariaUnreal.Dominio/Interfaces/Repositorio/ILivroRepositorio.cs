using LivrariaUnreal.Dominio.Entidades;
using System.Collections.Generic;

namespace LivrariaUnreal.Dominio.Interfaces.Repositorio
{
    public interface ILivroRepositorio
    {
        void Adicionar(Livro entidade);

        void Atualizar(Livro entidade);

        void Excluir(int[] ids);

        Livro ObterPorId(int id);

        IList<Livro> ObterTodos();        
    }
}
