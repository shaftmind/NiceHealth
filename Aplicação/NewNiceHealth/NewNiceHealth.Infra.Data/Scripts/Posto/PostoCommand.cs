using NewNiceHealth.Domain.Entities;
using NewNiceHealth.Domain.Interfaces.Posto;
using NewNiceHealth.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Infra.Data.Scripts.Posto
{
    public class PostoCommand : IPostoCommand
    {
        public ScriptSql Adicionar(PostoEntity posto)
        {
            var query = @"INSERT INTO Posto (Nome, Responsavel, Telefone, QtdTecnicos, QtdLeitos, fkEndereco, Ativo)
                            VALUES
                          (@Nome, @Responsavel, @Telefone,@QuantidadeDeTecnicos, @QuantidadeDeLeitos, @EnderecoId, 1)
                            SELECT SCOPE_INDENTITY()";

            var paramer = new
            {
                Nome = posto.Nome,
                Responsavel = posto.Responsavel,
                Telefone = posto.Telefone,
                QuantidadeDeTecnicos = posto.QuantidadeDeTecnicos,
                QuantidadeLeitos = posto.QuantidadeDeLeitos,
                EnderecoId = posto.EnderecoId

            };

            return new ScriptSql(query, paramer);

        }

        public ScriptSql Editar(int id, PostoEntity posto)
        {
            var query = @"UPDATE Posto SET 
                            Nome = @Nome,
                            Responsavel = @Responsavel,
                            Telefone = @Telefone,
                            QtdTecnicos = @QuantidadeDeTecnicos,
                            QtdLeitos = @QuantidadeDeLeitos,
                            fkEndereco = @EnderecoId
                            WHERE
                            Id = @Id";

            var paramer = new
            {
                Id = id,
                Nome = posto.Nome,
                Responsavel = posto.Responsavel,
                Telefone = posto.Telefone,
                QuantidadeDeTecnicos = posto.QuantidadeDeTecnicos,
                QuantidadeDeLeitos = posto.QuantidadeDeLeitos,
                EnderecoId = posto.EnderecoId

            };

            return new ScriptSql(query, paramer);

        }

        public ScriptSql Remover(int id)
        {
            var query = @"UPDATE Posto SET Ativo = 0 WHERE Id = @id";

            var paramer = new
            {
                Id = id
            };

            return new ScriptSql(query, paramer);
        }
    }
}
