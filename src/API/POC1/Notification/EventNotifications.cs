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
           // valueChangedEventDelegate += ValueChangedEventDelegate;
        }

        //public static async Task ValueChangedEventDelegate(IEvent @event)
        //{
        //    var context = Startup.ConnectionManager.GetHubContext<SomeHub>();
        //    context.Clients.All.someMethod();
        //}

        public async Task SendNotification(IEvent @event)
        {
            //TODO: users to notify
            await Clients.All.SendAsync("SendNotification", @event.EventType.ToString(), @event.AgregateType, @event.AgregateId, @event.NewValue);
        }
    }
}
