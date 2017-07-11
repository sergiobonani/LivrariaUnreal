using LivrariaUnreal.Facade.Livro.Interface;
using LivrariaUnreal.Facade.Livro.Request;
using LivrariaUnreal.Infra.Repositorio.Interface;
using LivrariaUnreal.Negocio.Livro.Interface;

namespace LivrariaUnreal.Negocio.Livro
{
    public class LivroAplicacao : ILivroAplicacao
    {
        private readonly ILivroRepositorio _repositorio;
        private readonly ILivroFactory _livroFactory;
        private readonly ILivroValidator _validator;

        public LivroAplicacao(ILivroRepositorio repositorio,
            ILivroFactory livroFactory,
            ILivroValidator validator)
        {
            _repositorio = repositorio;
            _livroFactory = livroFactory;
            _validator = validator;
        }

        public void Excluir(int[] ids)
        {
            if (ids.Length > 0)
            {
                _repositorio.Excluir(ids);
            }
        }

        public void Excluir(int id)
        {
            _repositorio.Excluir(id);
        }

        public void Persistir(LivroRequest request)
        {
            var entidade = _livroFactory.Criar(request);

            _validator.Validar(entidade);

            if (entidade.Id == 0)
            {
                _repositorio.Adicionar(entidade);
            }
            else
            {
                _repositorio.Atualizar(entidade);
            }            
        }
    }
}
