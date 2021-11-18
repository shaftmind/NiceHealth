using NewNiceHealth.Domain.Repository;

namespace NewNiceHealth.Domain.Interfaces.Base
{
    public interface ICommand
    {
        void ExecutarCommand(ScriptSql script);
    }
}
