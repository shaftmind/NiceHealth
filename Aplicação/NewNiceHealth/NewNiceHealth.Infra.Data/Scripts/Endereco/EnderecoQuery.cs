﻿using NewNiceHealth.Domain.Interfaces.Endereco;
using NewNiceHealth.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Infra.Data.Scripts.Endereco
{
    public class EnderecoQuery : IEnderecoQuery
    {
        public ScriptSql ObterPorId(int id)
        {
            var query = @"SELECT * FROM Endereco WHERE Id = @Id AND Ativo = 1";

            var paramer = new
            {
                Id = id
            };

            return new ScriptSql(query, paramer);
        }

        public ScriptSql ObterTodos()
        {
            var query = @"SELECT * FROM Endereco WHERE Ativo = 1";

            return new ScriptSql(query);
        }
    }
}
