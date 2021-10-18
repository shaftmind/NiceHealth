using NiceHealth.Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NiceHealth.Application.Services.Endereco
{
    public class EnderecoService : IEnderecoService
    {
        public Task<Endereco> AdicionarEndereco(EnderecoModel enderecoModel)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> EditarEndereco(EnderecoModel enderecoModel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnderecoModel>> ObterEndereco()
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoModel> ObterEnderecoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoverEndereco(int id)
        {
            throw new NotImplementedException();
        }
    }
}
