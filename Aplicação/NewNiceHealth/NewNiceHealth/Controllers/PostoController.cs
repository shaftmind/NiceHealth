using Microsoft.AspNetCore.Mvc;
using NewNiceHealth.Application.Models.Posto;
using NewNiceHealth.Application.Services.Posto;
using System.Collections.Generic;

namespace NewNiceHealth.Controllers
{
    [Controller]
    [Route("api/v1/postos")]
    public class PostoController
    {

        private readonly IPostoService _postoService;

        public PostoController(IPostoService postoService)
        {
            _postoService = postoService;
        }

        [HttpGet]
        public IEnumerable<PostoModel> ObterTodos()
        {
            return _postoService.ObterPostos();
        }

        [HttpGet("/{postoId}")]
        public PostoModel ObterPostoPorId(int postoId)
        {
            return _postoService.ObterPorId(postoId);
        }

        [HttpPost]
        public PostoModel SalvarPosto(PostoModel posto)
        {
            return _postoService.Salvar(posto);
        }

        [HttpPut]
        public PostoModel AlterarPosto(PostoModel posto)
        {
            return _postoService.Alterar(posto);
        }

        [HttpDelete("/{postoId}")]
        public void DeletarPosto(int postoId)
        {
            _postoService.Deletar(postoId);
        }


    }
}
