using NiceHealth.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NiceHealth.Application.Services
{
    public interface IEnderecoService
    {
        Task<EnderecoModel> ObterEnderecoPorId(int id);
        Task<IEnumerable<EnderecoModel>> ObterEndereco();
        Task<int> RemoverEndereco(int id);
        Task<Endereco> AdicionarEndereco(EnderecoModel enderecoModel);
        Task<Endereco> EditarEndereco(EnderecoModel enderecoModel);
    }
}
