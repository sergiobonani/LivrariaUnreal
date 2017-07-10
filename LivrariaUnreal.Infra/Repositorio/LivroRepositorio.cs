using LivrariaUnreal.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaUnreal.Dominio.Entidades;
using LivrariaUnreal.Infra.Contexto;

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
            throw new NotImplementedException();
        }

        public void Excluir(int[] ids)
        {
            throw new NotImplementedException();
        }

        public Livro ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Livro> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
