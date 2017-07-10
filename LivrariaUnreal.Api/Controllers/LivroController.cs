using LivrariaUnreal.Dominio.Entidades;
using LivrariaUnreal.Facade.Livro.Request;
using LivrariaUnreal.Negocio.Livro.Interface;
using LivrariaUnreal.Query.Livro.Interface;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LivrariaUnreal.Api.Controllers
{
    [RoutePrefix("api/cadastro/livro")]
    public class LivroController : ApiController
    {
        private readonly ILivroQuery _livroQuery;
        private readonly ILivroAplicacao _livroAplicacao;

        public LivroController(ILivroQuery livroQuery, ILivroAplicacao livroAplicacao)
        {
            _livroQuery = livroQuery;
            _livroAplicacao = livroAplicacao;
        }

        [HttpPost]
        [Route("listar")]
        public HttpResponseMessage Listar()
            => Request.CreateResponse(HttpStatusCode.OK, _livroQuery.ObterListagem());

        [HttpGet, Route]
        public HttpResponseMessage Criar()
            => Request.CreateResponse(HttpStatusCode.OK, _livroQuery.ObterParaCriacao());

        [HttpGet, Route("{id:int}")]
        public HttpResponseMessage Editar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK, _livroQuery.ObterParaEdicao(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }

        [HttpPost, Route]
        public HttpResponseMessage Create([FromBody] Livro request)
        {
            _livroAplicacao.Adicionar(request);
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
    }
}
