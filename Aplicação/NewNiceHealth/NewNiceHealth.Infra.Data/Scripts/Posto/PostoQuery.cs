using NewNiceHealth.Domain.Interfaces.Posto;
using NewNiceHealth.Domain.Repository;

namespace NewNiceHealth.Infra.Data.Scripts.Posto
{
    public class PostoQuery : IPostoQuery
    {
        public ScriptSql ObterPorId(int id)
        {
            var query = @"SELECT * FROM Posto WHERE Id = @Id AND Ativo = 1";

            var paramer = new
            {
                Id = id
            };

            return new ScriptSql(query, paramer);
        }

        public ScriptSql ObterTodos()
        {
            var query = @"SELECT * FROM Posto WHERE Ativo = 1";

            return new ScriptSql(query);
        }
    }
}
