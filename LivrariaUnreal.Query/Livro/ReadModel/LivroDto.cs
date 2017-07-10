namespace LivrariaUnreal.Query.Livro.ReadModel
{
    public class LivroDto
    {
        public LivroDto()
        { }

        public LivroDto(Dominio.Entidades.Livro entidade)
        {
            Descricao = entidade.Descricao;
        }

        public string Descricao { get; set; }
    }
}
