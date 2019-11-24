using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Common.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace POC1.Notification
{
    public interface IBackgroundHandler
    {
        Task ValueChangedEventDelegate(IEvent @event);
    }
    public class BackgroundHandler : IBackgroundHandler
    {
        private IHubContext<EventNotifications> hubContext;

        public BackgroundHandler(IHubContext<EventNotifications> hubContext)
        {
            this.hubContext = hubContext;
        }

        private async Task SendNotification(IEvent @event)
        {
            await hubContext.Clients.All.SendAsync("SendNotification", @event);
        }

        public async Task ValueChangedEventDelegate(IEvent @event)
        {
            await SendNotification(@event);
        }
    }
}
