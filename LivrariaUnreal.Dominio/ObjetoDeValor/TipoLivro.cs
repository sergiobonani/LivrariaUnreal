using System.ComponentModel;

namespace LivrariaUnreal.Dominio.ObjetoDeValor
{
    public enum TipoLivro
    {
        [Description("Romance")]
        Romance = 1,
        [Description("Fição")]
        Ficacao = 2,
        [Description("Monografia")]
        Monografia = 3    
    }
}
