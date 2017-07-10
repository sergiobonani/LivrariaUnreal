using LivrariaUnreal.Dominio.Interfaces.Repositorio;
using LivrariaUnreal.Infra.Repositorio;
using LivrariaUnreal.Negocio.Livro;
using LivrariaUnreal.Negocio.Livro.Interface;
using LivrariaUnreal.Query.Livro;
using LivrariaUnreal.Query.Livro.Interface;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace LivrariaUnreal.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            //container.RegisterType<ILivroQuery, LivroQuery>();
            //container.RegisterType<ILivroRepositorio, LivroRepositorio>();
            //container.RegisterType<ILivroAplicacao, LivroAplicacao>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}