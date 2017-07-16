using LivrariaUnreal.Infra.Repositorio.Interface;
using LivrariaUnreal.Negocio.Livro;
using Moq;
using Xunit;

namespace LivrariaUnreal.Negocio.Teste
{
    public class LivroValidatorTestes
    {
        private LivroValidator Setup() => new LivroValidator(MockRepositorio().Object);

        private Mock<ILivroRepositorio> MockRepositorio()
        {
            var mock = new Mock<ILivroRepositorio>();

            mock.Setup(x => x.ObterTodos()).Returns(LivroDataTeste.ObterListaLivro);
            
            return mock;
        }

        [Fact]
        public void DeveValidarObrigatoriedadeDescricao()
        {
            //            
        }
    }
}
