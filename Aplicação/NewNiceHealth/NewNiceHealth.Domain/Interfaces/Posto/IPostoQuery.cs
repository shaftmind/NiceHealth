using NewNiceHealth.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Domain.Interfaces.Posto
{
    public interface IPostoQuery
    {
        ScriptSql ObterTodos();
        ScriptSql ObterPorId(int id);

    }
}
