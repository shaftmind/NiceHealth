using AutoMapper;
using NewNiceHealth.Application.Models.Endereco;
using System;
using System.Collections.Generic;

namespace NewNiceHealth.Application.Services.Endereco
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IRepository<EnderecoEntity> _enderecoRepository;
        private readonly IEnderecoQuery _enderecoQuery;
        private readonly IEnderecoCommand _enderecoCommand;
        private readonly IMapper _mapper;

        public EnderecoService(IRepository<EnderecoEntity> enderecoRepository, 
            IEnderecoQuery enderecoQuery, 
            IEnderecoCommand enderecoCommand,
            IMapper mapper)
        {
            _enderecoRepository = enderecoRepository;
            _enderecoQuery = enderecoQuery;
            _enderecoCommand = enderecoCommand;
            _mapper = mapper;
        }

        public EnderecoModel Alterar(EnderecoModel endereco)
        {
            var registrar = _mapper.Map<EnderecoModel>(endereco);
            _enderecoCommand.Alterar(endereco);
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
