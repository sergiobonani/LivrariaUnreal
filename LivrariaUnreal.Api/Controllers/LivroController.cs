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

        [HttpPost, Route]
        public HttpResponseMessage Criar(LivroRequest request)
        {
            try
            {
                _livroAplicacao.Persistir(request);
                return Request.CreateResponse(HttpStatusCode.OK, "");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }

        }

        [HttpGet, Route("{id:int}")]
        public HttpResponseMessage Editar(int id)
            => Request.CreateResponse(HttpStatusCode.OK, _livroQuery.ObterParaEdicao(id));

        [HttpPut, Route]
        public HttpResponseMessage Editar(LivroRequest request)
        {
            try
            {
                _livroAplicacao.Persistir(request);
                return Request.CreateResponse(HttpStatusCode.OK, "");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }

        }

        [HttpDelete]
        [Route("")]
        public HttpResponseMessage Delete(int[] ids)
        {
            try
            {
                _livroAplicacao.Excluir(ids);

                return Request.CreateResponse(HttpStatusCode.OK, "");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }            
        }
    }
}
