using CQRS.Common.Interfaces;
using Demo.Models.Common;
using Demo.Persistance.Entities;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC1.Notification
{
    public class EventNotifications : Hub
    {
        public event ValueChangedEventDelegate valueChangedEventDelegate;

        public EventNotifications() : base()
        {
            valueChangedEventDelegate += ValueChangedEventDelegate;
        }

        private async Task ValueChangedEventDelegate(IEvent @event)
        {
            //TODO: trycatch
            await SendNotification(@event);
        }

        public async Task SendNotification(IEvent @event)
        {
            //TODO: users to notify
            await Clients.All.SendAsync(@event.EventType.ToString(), @event.AgregateType, @event.AgregateId, @event.NewValue);
        }
    }
}
