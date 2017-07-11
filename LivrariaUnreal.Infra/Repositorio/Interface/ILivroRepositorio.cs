using LivrariaUnreal.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaUnreal.Infra.Repositorio.Interface
{
    public interface ILivroRepositorio
    {
        void Adicionar(Livro entidade);

        void Atualizar(Livro entidade);

        void Excluir(int[] ids);

        void Excluir(int id);

        Livro ObterPorId(int id);

        IQueryable<Livro> ObterTodos();        
    }
}
