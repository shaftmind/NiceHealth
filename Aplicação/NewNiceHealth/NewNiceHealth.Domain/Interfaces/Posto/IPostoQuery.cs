using NewNiceHealth.Domain.Repository;

namespace NewNiceHealth.Domain.Interfaces.Posto
{
    public interface IPostoQuery
    {
        ScriptSql ObterTodos();
        ScriptSql ObterPorId(int id);

    }
}
