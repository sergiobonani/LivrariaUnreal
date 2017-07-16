using LivrariaUnreal.Facade.Livro.Request;
using LivrariaUnreal.Negocio.Livro.Interface;
using LivrariaUnreal.Query.Livro.Interface;
using LivrariaUnreal.Query.Livro.ReadModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LivrariaUnreal.WebUi.Controllers
{
    public class LivroController : ApiController
    {
        private readonly ILivroQuery _livroQuery;
        private readonly ILivroAplicacao _livroAplicacao;

        public LivroController(ILivroQuery livroQuery, ILivroAplicacao livroAplicacao)
        {
            _livroQuery = livroQuery;
            _livroAplicacao = livroAplicacao;
        }

        [HttpGet]
        public IEnumerable<LivroListagemDto> Get()
            => _livroQuery.ObterListagem();

        [HttpGet, Route]
        public HttpResponseMessage Create()
            => Request.CreateResponse(HttpStatusCode.OK, _livroQuery.ObterParaCriacao());

        [HttpPost]
        public HttpResponseMessage Create(LivroRequest request)
        {
            try
            {
                request.Id = _livroAplicacao.Persistir(request);
                return Request.CreateResponse(HttpStatusCode.OK, request);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Edit(int id)
            => Request.CreateResponse(HttpStatusCode.OK, _livroQuery.ObterParaEdicao(id));

        [HttpPut]
        public HttpResponseMessage Edit(LivroRequest request)
        {
            try
            {
                _livroAplicacao.Persistir(request);
                return Request.CreateResponse(HttpStatusCode.OK, ModelState);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                _livroAplicacao.Excluir(id);

                return Request.CreateResponse(HttpStatusCode.OK, ModelState);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
