using CQRS.Common.Interfaces;
using Demo.Handlers.Providers;
using Demo.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Handlers.Event
{
    public class GridValueChangeEventHandler : IEventHandler<IEvent>
    {
        private readonly IValueChangedEventDelegateProvider valueChangedEventDelegate;
        public GridValueChangeEventHandler(IValueChangedEventDelegateProvider valueChangedEventDelegate)
        {
            this.valueChangedEventDelegate = valueChangedEventDelegate;
        }

        public Task Handle(IEvent @event)
        {
            //TODO: Update Agregate model.

            //TODO: use another model for events! 
            valueChangedEventDelegate.ValueChangedEventDelegate(@event);
            return Task.CompletedTask;


        }
    }
}
