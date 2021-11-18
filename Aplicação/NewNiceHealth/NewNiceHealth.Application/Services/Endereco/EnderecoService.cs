using AutoMapper;
using NewNiceHealth.Application.Models.Endereco;
using NewNiceHealth.Domain.Entities.Endereco;
using NewNiceHealth.Domain.Interfaces.Base;
using NewNiceHealth.Domain.Interfaces.Endereco;
using System.Collections.Generic;
using System.Linq;

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
            var registrar = _mapper.Map<EnderecoEntity>(endereco);
            var command =_enderecoCommand.Editar(registrar.Id, registrar);
            _enderecoRepository.ExecutarCommand(command);

            return new EnderecoModel
            {
                Rua = registrar.Rua,
                Bairro = registrar.Bairro,
                Cidade = registrar.Cidade,
                Longitude = registrar.Longitude,
                Latitude = registrar.Latitude
            };
        }

        public void Deletar(int id)
        {
            var command = _enderecoCommand.Remover(id);
            _enderecoRepository.ExecutarCommand(command);
        }

        public IEnumerable<EnderecoModel> ObterEnderecos()
        {
            var script = _enderecoQuery.ObterTodos();
            var enderecos = _enderecoRepository.ExecutarQuery(script);

            return enderecos.Select(e => new EnderecoModel
            {
                Id = e.Id,
                Rua = e.Rua,
                Bairro = e.Bairro,
                Cidade = e.Cidade,
                Longitude = e.Longitude,
                Latitude = e.Latitude
            });
                
        }

        public EnderecoModel ObterPorId(int id)
        {
            var script = _enderecoQuery.ObterPorId(id);
            var enderecos = _enderecoRepository.ExecutarQuery(script)?.FirstOrDefault();

            if(enderecos == null)
            {

            }

            return new EnderecoModel
            {
                Id = enderecos.Id,
                Rua = enderecos.Rua,
                Bairro = enderecos.Bairro,
                Cidade = enderecos.Cidade,
                Longitude = enderecos.Longitude,
                Latitude = enderecos.Latitude
            };
        }

        public EnderecoModel Salvar(EnderecoModel endereco)
        {
            var registrar = _mapper.Map<EnderecoEntity>(endereco);
            var command = _enderecoCommand.Adicionar(registrar);
            _enderecoRepository.ExecutarCommand(command);

            return new EnderecoModel
            {
                Rua = registrar.Rua,
                Bairro = registrar.Bairro,
                Cidade = registrar.Cidade,
                Longitude = registrar.Longitude,
                Latitude = registrar.Latitude
            };
        }
    }
}
