using LivrariaUnreal.Infra.Repositorio.Interface;
using LivrariaUnreal.Negocio.Livro.Interface;
using Recursos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaUnreal.Negocio.Livro
{
    public class LivroValidator : ILivroValidator
    {
        private readonly ILivroRepositorio _repositorio;

        public LivroValidator(ILivroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public IList<Exception> Validar(Dominio.Entidades.Livro entidade)
        {
            var excecoes = new List<Exception>();

            if (entidade.Descricao == null)
            {
                var mensagem = string.Format(Geral.CampoObrigatorio, Geral.Descricao);

                excecoes.Add(new Exception(mensagem));
            }

            if (_repositorio.ObterTodos().Any(x => 
            x.Descricao.ToUpper().Contains(entidade.Descricao.ToUpper()) && x.Id != entidade.Id))
            {
                var mensagem = string.Format(Geral.RegistroDuplicado, Geral.Descricao);

                excecoes.Add(new Exception(mensagem));
            }

            return excecoes;
        }
    }
}
