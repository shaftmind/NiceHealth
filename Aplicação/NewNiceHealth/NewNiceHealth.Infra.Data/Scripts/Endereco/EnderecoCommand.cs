using NewNiceHealth.Domain.Entities.Endereco;
using NewNiceHealth.Domain.Interfaces.Endereco;
using NewNiceHealth.Domain.Repository;

namespace NewNiceHealth.Infra.Data.Scripts.Endereco
{
    public class EnderecoCommand : IEnderecoCommand
    {
        public ScriptSql Adicionar(EnderecoEntity endereco)
        {
            var query = @"INSERT INTO Endereco (Rua, Bairro, Cidade, Longitude, Latitude, Ativo)
                            VALUES
                          (@Rua, @Bairro, @Cidade,@Longitude, @Latitude, 1)
                            SELECT SCOPE_INDENTITY()";

            var paramer = new
            {
                Rua = endereco.Rua,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Longitude = endereco.Longitude,
                Latitude = endereco.Latitude

            };

            return new ScriptSql(query, paramer);
        }

        public ScriptSql Editar(int id, EnderecoEntity endereco)
        {
            var query = @"UPDATE Endereco SET 
                            Rua = @Rua,
                            Bairro = @Bairro,
                            Cidade = @Cidade,
                            Longitude = @Longitude,
                            Latitude = @Latitude
                            WHERE
                            Id = @Id";

            var paramer = new
            {
                Id = id,
                Rua = endereco.Rua,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Longitude = endereco.Longitude,
                Latitude = endereco.Latitude

            };

            return new ScriptSql(query, paramer);
        }

        public ScriptSql Remover(int id)
        {
            var query = @"UPDATE Endereco SET Ativo = 0 WHERE Id = @id";

            var paramer = new
            {
                Id = id
            };

            return new ScriptSql(query, paramer);
        }
    }
}
