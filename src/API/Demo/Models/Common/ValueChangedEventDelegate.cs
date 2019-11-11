using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.Common
{
    public delegate Task ValueChangedEventDelegate(IEvent @event);
}
