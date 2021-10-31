using Microsoft.AspNetCore.Mvc;
using NewNiceHealth.Application.Services.Posto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> ObterTodos()
        {
            await _postoService.ObterPostos();
        }

        [HttpGet("/{postoId}")]
        public async Task<IActionResult> ObterPostoPorId()
        {
            await _postoService.ObterPostoPorId(postoId);
        }

        [HttpPost]
        public async Task<IActionResult> SalvarPosto()
        {
            await _postoService.Salvar();
        }

        [HttpPut]
        public async Task<IActionResult> AlterarPosto()
        {
            await _postoService.Alterar();
        }

        [HttpDelete("/{postoId}")]
        public async Task<IActionResult> DeletarPosto()
        {
            await _postoService.Deletar();
        }


    }
}
