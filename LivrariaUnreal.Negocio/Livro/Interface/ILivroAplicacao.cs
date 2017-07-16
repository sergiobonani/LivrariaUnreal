using LivrariaUnreal.Facade.Livro.Request;
using System.Collections;

namespace LivrariaUnreal.Negocio.Livro.Interface
{
    public interface ILivroAplicacao
    {
        int Persistir(LivroRequest request);

        void Excluir(int[] ids);

        void Excluir(int id);
    }
}
