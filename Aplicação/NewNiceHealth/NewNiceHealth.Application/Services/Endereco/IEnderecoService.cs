using NewNiceHealth.Application.Models.Endereco;
using System.Collections.Generic;

namespace NewNiceHealth.Application.Services
{
    public interface IEnderecoService
    {

        IEnumerable<EnderecoModel> ObterEnderecos();
        EnderecoModel ObterPorId(int id);
        EnderecoModel Salvar(EnderecoModel endereco);
        EnderecoModel Alterar(EnderecoModel endereco);
        void Deletar(int id);

    }
}
