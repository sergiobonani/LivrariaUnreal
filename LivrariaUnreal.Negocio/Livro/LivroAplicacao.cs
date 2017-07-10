using LivrariaUnreal.Dominio.Interfaces.Repositorio;
using LivrariaUnreal.Negocio.Livro.Interface;

namespace LivrariaUnreal.Negocio.Livro
{
    public class LivroAplicacao : ILivroAplicacao
    {
        private readonly ILivroRepositorio _repositorio;

        public LivroAplicacao(ILivroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Dominio.Entidades.Livro entidade)
        {
            _repositorio.Adicionar(entidade);
        }
    }
}
