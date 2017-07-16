using LivrariaUnreal.Facade.Livro.Interface;
using LivrariaUnreal.Facade.Livro.Request;
using System;

namespace LivrariaUnreal.Facade.Livro
{
    public class LivroFactory : ILivroFactory
    {
        public Dominio.Entidades.Livro Criar(LivroRequest request)
        {
            if (request == null)
            {
                return null;
            }

            return new Dominio.Entidades.Livro
            {
                Id = request.Id,
                Descricao = request.Descricao,
                Isbn = request.Isbn,
                Titulo = request.Titulo
            };
        }
    }
}
