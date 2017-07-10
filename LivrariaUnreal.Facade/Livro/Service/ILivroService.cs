using LivrariaUnreal.Facade.Livro.Request;

namespace LivrariaUnreal.Facade.Livro.Service
{
    public interface ILivroService
    {
        void Persistir(LivroRequest request);
    }
}
