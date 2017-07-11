using LivrariaUnreal.Facade.Livro.Request;
using System.Collections;

namespace LivrariaUnreal.Negocio.Livro.Interface
{
    public interface ILivroAplicacao
    {
        void Persistir(LivroRequest request);

        void Excluir(int[] ids);

        void Excluir(int id);
    }
}
