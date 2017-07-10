using LivrariaUnreal.Facade.Livro.Request;

namespace LivrariaUnreal.Facade.Livro.Factory
{
    public interface ILivroFactory
    {
        Dominio.Entidades.Livro Criar(LivroRequest request);
    }
}
