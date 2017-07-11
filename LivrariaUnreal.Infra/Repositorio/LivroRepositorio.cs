using LivrariaUnreal.Dominio.Entidades;
using LivrariaUnreal.Infra.Contexto;
using LivrariaUnreal.Infra.Repositorio.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

namespace LivrariaUnreal.Infra.Repositorio
{
    public class LivroRepositorio : ILivroRepositorio
    {
        protected readonly ContextoData _db;

        public LivroRepositorio(ContextoData db)
        {
            _db = db;
        }

        public void Adicionar(Livro entidade)
        {
            _db.Set<Livro>().Add(entidade);
        }

        public void Atualizar(Livro entidade)
        {
            _db.Entry(entidade).State = EntityState.Modified;
        }

        public void Excluir(int[] ids)
        {
            foreach (var item in ids)
            {
                var livro = ObterPorId(item);
                _db.Set<Livro>().Remove(livro);
            }            
        }

        public void Excluir(int id)
        {
            var livro = ObterPorId(id);
            _db.Set<Livro>().Remove(livro);
        }

        public Livro ObterPorId(int id)
        {
            return _db.Set<Livro>().Find(id);
        }

        public IQueryable<Livro> ObterTodos()
        {
            return _db.Set<Livro>().AsQueryable();
        }
    }
}
