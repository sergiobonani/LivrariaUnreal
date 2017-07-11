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

            var retorno = (from livro in livros
                           select new LivroListagemDto
                           {
                               Id = livro.Id,
                               Descricao = livro.Descricao
                           }).ToList();

            return retorno;
        }

        public LivroDto ObterParaEdicao(int id)
            => new LivroDto(_repositorio.ObterPorId(id));
    }
}
