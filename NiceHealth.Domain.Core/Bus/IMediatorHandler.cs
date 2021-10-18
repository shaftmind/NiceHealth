using NiceHealth.Domain.Core.Commands;
using NiceHealth.Domain.Core.Events;
using System.Threading.Tasks;

namespace NiceHealth.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
