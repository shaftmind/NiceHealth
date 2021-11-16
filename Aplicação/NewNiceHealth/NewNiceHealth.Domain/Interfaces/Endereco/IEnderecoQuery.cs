using NewNiceHealth.Domain.Repository;

namespace NewNiceHealth.Domain.Interfaces.Endereco
{
    public interface IEnderecoQuery
    {
        ScriptSql ObterTodos();
        ScriptSql ObterPorId(int id);
    }
}
