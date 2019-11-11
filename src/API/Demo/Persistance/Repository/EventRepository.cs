using CQRS.Common.Interfaces;
using Demo.Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Persistance.Repository
{
    public interface IEventRepository
    {
        Task<IEvent> New(IEvent data);
    }

    public class EventRepository : IEventRepository
    {
        private DemoContext context;

        public EventRepository(DemoContext context)
        {
            this.context = context;
        }

        public async Task<IEvent> New(IEvent data)
        {
            var entity = new Event()
            {
                AgregateId = data.AgregateId,
                AgregateType = data.AgregateType,
                Caller = data.Caller,
                CallerName = data.CallerName,
                CreatedAt = data.CreatedAt,
                EventType = data.EventType,
                NewValue = data.NewValue,
                OldValue = data.OldValue
            };
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            data.Id = entity.Id;
            return data;
        }
    }


}
