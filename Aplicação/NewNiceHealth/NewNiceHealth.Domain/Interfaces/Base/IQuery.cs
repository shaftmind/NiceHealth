using NewNiceHealth.Domain.Repository;
using System.Collections.Generic;

namespace NewNiceHealth.Domain.Interfaces.Base
{
    public interface IQuery<T>
    {
        IEnumerable<T> ExecutarQuery(ScriptSql script);
    }
}
