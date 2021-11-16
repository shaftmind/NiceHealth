using NewNiceHealth.Domain.Repository;
using NewNiceHealth.Domain.Entities;

namespace NewNiceHealth.Domain.Interfaces.Posto
{
    public interface IPostoCommand 
    {
        ScriptSql Adicionar(PostoEntity posto);
        ScriptSql Editar(int id, PostoEntity posto);
        ScriptSql Remover(int id);
    }
}
