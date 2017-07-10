using LivrariaUnreal.Dominio.ObjetoDeValor;
using System;

namespace LivrariaUnreal.Dominio.Entidades
{
    public class Livro
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Isbn { get; set; }

        public TipoLivro TipoLivro { get; set; }

        public DateTime DataCriação { get; set; }
    }
}
