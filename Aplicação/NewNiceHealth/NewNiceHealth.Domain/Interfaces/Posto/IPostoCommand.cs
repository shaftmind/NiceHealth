using NewNiceHealth.Domain.Entities;
using NewNiceHealth.Domain.Repository;

namespace NewNiceHealth.Domain.Interfaces.Posto
{
    public interface IPostoCommand 
    {
        ScriptSql Adicionar(PostoEntity posto);
        ScriptSql Editar(int id, PostoEntity posto);
        ScriptSql Remover(int id);
    }
}
