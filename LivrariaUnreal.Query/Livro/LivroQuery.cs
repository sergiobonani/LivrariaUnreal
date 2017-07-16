using LivrariaUnreal.Dominio.ObjetoDeValor;
using LivrariaUnreal.Infra.Repositorio.Interface;
using LivrariaUnreal.Query.Livro.Interface;
using LivrariaUnreal.Query.Livro.ReadModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LivrariaUnreal.Query.Livro
{
    public class LivroQuery : ILivroQuery
    {
        private readonly ILivroRepositorio _repositorio;

        public LivroQuery(ILivroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public LivroDto ObterParaCriacao()
            => new LivroDto();

        public IList<LivroListagemDto> ObterListagem()
        {
            var livros = _repositorio.ObterTodos();

            if (livros.Count() == 0)
            {
                return new List<LivroListagemDto>();
            }

            var retorno = (from livro in livros
                           select new LivroListagemDto
                           {
                               Id = livro.Id,
                               Descricao = livro.Descricao,
                               Titulo = livro.Titulo,
                               Isbn = livro.Isbn
                           }).OrderBy(x => x.Titulo).ToList();

            return retorno;
        }

        public LivroDto ObterParaEdicao(int id)
            => new LivroDto(_repositorio.ObterPorId(id));
    }
}
