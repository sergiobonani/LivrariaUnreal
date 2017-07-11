namespace LivrariaUnreal.Query.Livro.ReadModel
{
    public class LivroDto
    {
        public LivroDto()
        { }

        public LivroDto(Dominio.Entidades.Livro entidade)
        {
            Id = entidade.Id;
            Descricao = entidade.Descricao;
        }

        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}
