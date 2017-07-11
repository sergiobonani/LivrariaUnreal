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