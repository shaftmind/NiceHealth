using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewNiceHealth.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewNiceHealth.Controllers
{
    [ApiController]
    [Route("api/v1/enderecos")]
    [Produces("application/json")]
    //[Authorize("acesso")]
    public class EnderecoController
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterEnderecos()
        {
            await  _enderecoService;
        }

        [HttpGet("/{EnderecoId}")]
        public async Task<IActionResult> ObterEnderecoPorId()
        {
           await _enderecoService.ObterPostoPorId(enderecoId);
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarEndereco()
        {
            _enderecoService.Salvar();
        }

        [HttpPut]
        public async Task<IActionResult> AlterarEndereco()
        {
            _enderecoService.Alterar();
        }

        [HttpDelete("/{enderecoId}")]
        public async Task<IActionResult> DeletarEndereco()
        {
            _enderecoService.Deletar(enderecoId);
        }
    }
}
