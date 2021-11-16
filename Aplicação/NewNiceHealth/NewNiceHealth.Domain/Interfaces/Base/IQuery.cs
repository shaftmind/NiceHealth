using NewNiceHealth.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNiceHealth.Domain.Interfaces.Base
{
    public interface IQuery<T>
    {
        IEnumerable<T> ExecutarQuery(ScriptSql script);
    }
}
