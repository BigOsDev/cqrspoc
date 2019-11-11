using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Common.Interfaces
{
    public interface IEventHandler<Event> where Event : IEvent
    {
        Task Handle(IEvent @event);
    }
}
