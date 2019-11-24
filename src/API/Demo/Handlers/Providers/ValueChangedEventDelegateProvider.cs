using CQRS.Common.Interfaces;
using Demo.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Handlers.Providers
{
    public interface IValueChangedEventDelegateProvider
    {
        void ValueChangedEventDelegate(IEvent @event);
    }
    public class ValueChangedEventDelegateProvider : IValueChangedEventDelegateProvider
    {
        private readonly ValueChangedEventDelegate valueChangedEventDelegate;

        public ValueChangedEventDelegateProvider(ValueChangedEventDelegate valueChangedEventDelegate)
        {
            this.valueChangedEventDelegate = valueChangedEventDelegate;
        }

        public void ValueChangedEventDelegate(IEvent @event)
        {
            valueChangedEventDelegate(@event);
        }
    }
}
