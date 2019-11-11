using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Handlers.Event
{
    public class EventHandler : IEventHandler<IEvent>
    {
        public Task Handle(IEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
