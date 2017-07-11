using LivrariaUnreal.Facade.Livro.Request;

namespace LivrariaUnreal.Facade.Livro.Interface
{
    public interface ILivroFactory
    {
        Dominio.Entidades.Livro Criar(LivroRequest request);
    }
}
