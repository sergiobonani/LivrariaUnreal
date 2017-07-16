using LivrariaUnreal.Dominio.ObjetoDeValor;

namespace LivrariaUnreal.Facade.Livro.Request
{
    public class LivroRequest
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Isbn { get; set; }

        public string Titulo { get; set; }
    }
}
