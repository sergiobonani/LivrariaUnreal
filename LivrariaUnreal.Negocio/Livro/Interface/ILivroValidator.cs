using System;
using System.Collections.Generic;

namespace LivrariaUnreal.Negocio.Livro.Interface
{
    public interface ILivroValidator
    {
        IList<Exception> Validar(Dominio.Entidades.Livro entidade);
    }
}
