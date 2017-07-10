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
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            var container = new UnityContainer();
            container.RegisterType<ILivroQuery, LivroQuery>();
            container.RegisterType<ILivroRepositorio, LivroRepositorio>();
            container.RegisterType<ILivroAplicacao, LivroAplicacao>();
            config.DependencyResolver = new UnityDependencyResolver(container);


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
