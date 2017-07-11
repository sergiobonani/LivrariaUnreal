using LivrariaUnreal.Infra.Repositorio.Interface;
using LivrariaUnreal.Negocio.Livro;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var setup = Setup();

            var livro = new Dominio.Entidades.Livro { Descricao = "Descricao3" };

            var retorno = setup.Validar(livro);

            Assert.Null(retorno);
        }
    }
}
