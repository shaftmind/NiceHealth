using NewNiceHealth.Domain.Entities.Endereco;
using NewNiceHealth.Domain.Repository;

namespace NewNiceHealth.Domain.Interfaces.Endereco
{
    public interface IEnderecoCommand
    {
        ScriptSql Adicionar(EnderecoEntity endereco);
        ScriptSql Editar(int id, EnderecoEntity endereco);
        ScriptSql Remover(int id);
    }
}
