using Recursos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LivrariaUnreal.Dominio.ObjetoDeValor
{
    public enum TipoLivro
    {
        [Display(Name = nameof(Geral.Romance), ResourceType = typeof(Recursos.Geral))]
        Romance = 1,
        [Display(Name = nameof(Geral.Ficcao), ResourceType = typeof(Recursos.Geral))]
        Ficacao = 2,
        [Display(Name = nameof(Geral.Monografia), ResourceType = typeof(Recursos.Geral))]
        Monografia = 3    
    }
}
