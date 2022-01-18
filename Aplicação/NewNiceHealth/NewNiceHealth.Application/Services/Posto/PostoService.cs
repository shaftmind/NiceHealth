using AutoMapper;
using NewNiceHealth.Application.Models.Posto;
using NewNiceHealth.Domain.Entities;
using NewNiceHealth.Domain.Interfaces.Base;
using NewNiceHealth.Domain.Interfaces.Posto;
using System.Collections.Generic;
using System.Linq;

namespace NewNiceHealth.Application.Services.Posto
{
    public class PostoService : IPostoService
    {

        private readonly IRepository<PostoEntity> _repository;
        private readonly IPostoQuery _postoQuery;
        private readonly IPostoCommand _postoCommand;
        private readonly IMapper _mapper;

        public PostoService(IRepository<PostoEntity> repository,
            IPostoQuery postoQuery, 
            IPostoCommand postoCommand, 
            IMapper mapper)
        {
            _repository = repository;
            _postoQuery = postoQuery;
            _postoCommand = postoCommand;
            _mapper = mapper;
        }

        public PostoModel Alterar(PostoModel posto)
        {
            var registrar = _mapper.Map<PostoEntity>(posto);
            var command = _postoCommand.Editar(registrar.Id, registrar);
            _repository.ExecutarCommand(command);

            return new PostoModel
            {
                Nome = registrar.Nome,
                EnderecoId = registrar.EnderecoId,
                Responsavel = registrar.Responsavel,
                Telefone = registrar.Telefone,
                QuantidadeDeTecnicos = registrar.QuantidadeDeTecnicos,
                QuantidadeDeLeitos = registrar.QuantidadeDeLeitos,

            };
        }

        public void Deletar(int id)
        {
            var command = _postoCommand.Remover(id);
            _repository.ExecutarCommand(command);
        }

        public IEnumerable<PostoModel> ObterPostos()
        {
            var script = _postoQuery.ObterTodos();
            var postos = _repository.ExecutarQuery(script);

            return postos.Select(p => new PostoModel
            {
                Id = p.Id,
                Nome = p.Nome,
                Responsavel = p.Responsavel,
                Telefone = p.Telefone,
                EnderecoId = p.EnderecoId,
                QuantidadeDeLeitos = p.QuantidadeDeLeitos,
                QuantidadeDeTecnicos = p.QuantidadeDeTecnicos
            });
        }

        public PostoModel ObterPorId(int id)
        {
            var script = _postoQuery.ObterPorId(id);
            var posto = _repository.ExecutarQuery(script)?.FirstOrDefault();

            //if(posto == null)
            //{

            //}

            return new PostoModel
            {
                Id = posto.Id,
                Nome = posto.Nome,
                Responsavel = posto.Responsavel,
                EnderecoId = posto.EnderecoId,
                Telefone = posto.Telefone,
                QuantidadeDeLeitos = posto.QuantidadeDeLeitos,
                QuantidadeDeTecnicos = posto.QuantidadeDeTecnicos
            };
        }

        public PostoModel Salvar(PostoModel posto)
        {
            var registrar = _mapper.Map<PostoEntity>(posto);
            var command = _postoCommand.Adicionar(registrar);
            _repository.ExecutarCommand(command);

            return new PostoModel
            {
                Nome = registrar.Nome,
                EnderecoId = registrar.EnderecoId,
                Responsavel = registrar.Responsavel,
                Telefone = registrar.Telefone,
                QuantidadeDeTecnicos = registrar.QuantidadeDeTecnicos,
                QuantidadeDeLeitos = registrar.QuantidadeDeLeitos,

            };

        }
    }
}
