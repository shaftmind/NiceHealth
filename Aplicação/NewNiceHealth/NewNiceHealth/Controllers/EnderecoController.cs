using Microsoft.AspNetCore.Mvc;
using NewNiceHealth.Application.Models.Endereco;
using NewNiceHealth.Application.Services;
using System.Collections.Generic;

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
        public IEnumerable<EnderecoModel> ObterEnderecos()
        {
            return  _enderecoService.ObterEnderecos();
        }

        [HttpGet("/{enderecoId}")]
        public EnderecoModel ObterEnderecoPorId(int enderecoId)
        {
           return _enderecoService.ObterPorId(enderecoId);
        }

        [HttpPost]
        public EnderecoModel CadastrarEndereco(EnderecoModel endereco)
        {
            return _enderecoService.Salvar(endereco);
        }

        [HttpPut]
        public EnderecoModel AlterarEndereco(EnderecoModel endereco)
        {
            return _enderecoService.Alterar(endereco);
        }

        [HttpDelete("/{enderecoId}")]
        public void DeletarEndereco(int enderecoId)
        {
            _enderecoService.Deletar(enderecoId);
        }
    }
}
