using NewNiceHealth.Application.Models.Endereco;
using System;
using System.Collections.Generic;

namespace NewNiceHealth.Application.Services.Endereco
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IRepository<> _enderecoRepository;
        private readonly IEnderecoQuery _enderecoQuery;
        private readonly IEnderecoCommand _enderecoCommand;

        public EnderecoService(IRepository<object> enderecoRepository, 
            IEnderecoQuery enderecoQuery, 
            IEnderecoCommand enderecoCommand)
        {
            _enderecoRepository = enderecoRepository;
            _enderecoQuery = enderecoQuery;
            _enderecoCommand = enderecoCommand;
        }

        public EnderecoModel Alterar(EnderecoModel endereco)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EnderecoModel> ObterEnderecos()
        {
            throw new NotImplementedException();
        }

        public EnderecoModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public EnderecoModel Salvar(EnderecoModel endereco)
        {
            throw new NotImplementedException();
        }
    }
}
