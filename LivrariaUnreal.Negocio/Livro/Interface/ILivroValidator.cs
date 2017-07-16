using System;
using System.Collections.Generic;

namespace LivrariaUnreal.Negocio.Livro.Interface
{
    public interface ILivroValidator
    {
        void Validar(Dominio.Entidades.Livro entidade);
    }
}
