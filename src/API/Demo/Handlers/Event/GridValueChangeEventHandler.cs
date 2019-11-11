using CQRS.Common.Interfaces;
using Demo.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Handlers.Event
{
    public class GridValueChangeEventHandler : IEventHandler<IEvent>
    {
        private readonly ValueChangedEventDelegate valueChangedEventDelegate;
        public GridValueChangeEventHandler(ValueChangedEventDelegate valueChangedEventDelegate)
        {
            this.valueChangedEventDelegate = valueChangedEventDelegate;
        }

        public async Task Handle(IEvent @event)
        {
            //TODO: Update Agregate model.

            //TODO: use another model for events! 
            await valueChangedEventDelegate(@event);


        }
    }
}
