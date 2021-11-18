using NewNiceHealth.Application.Models.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
