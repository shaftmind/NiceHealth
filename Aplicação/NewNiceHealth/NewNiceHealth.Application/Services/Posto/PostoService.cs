using AutoMapper;
using NewNiceHealth.Application.Models.Posto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Application.Services.Posto
{
    public class PostoService : IPostoService
    {

        private readonly IRepository
        private readonly IMapper _mapper;

        public PostoModel Alterar(PostoModel posto)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostoModel> ObterEnderecos()
        {
            throw new NotImplementedException();
        }

        public PostoModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public PostoModel Salvar(PostoModel posto)
        {
            throw new NotImplementedException();
        }
    }
}
