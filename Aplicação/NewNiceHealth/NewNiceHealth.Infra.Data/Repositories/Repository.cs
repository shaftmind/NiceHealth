using Dapper;
using NewNiceHealth.Domain.Interfaces.Base;
using NewNiceHealth.Domain.Repository;
using System.Collections.Generic;
using System.Data.SQLite;

namespace NewNiceHealth.Infra.Data.Repositories.Endereco
{
    public class Repository<T> : IRepository<T>
    {
        public string ConnectionString { get; set; }

        public Repository()
        {
            ConnectionString = "Data Source=C:\\Users\\adaias\\Desktop\\Projetos\\NiceHealth\\Aplicação\\NewNiceHealth\\NewNiceHealth\\db\\db_NiceHealth";
        }

        public void ExecutarCommand(ScriptSql script)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Execute(script.Query, script.Parametros); 
        }

        public IEnumerable<T> ExecutarQuery(ScriptSql script)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            var retorno = connection.Query<T>(script.Query, script.Parametros);

            return retorno;

        }
    }
}
