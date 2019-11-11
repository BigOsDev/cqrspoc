using CQRS.Common.Interfaces;
using Demo.Handlers.Event;
using Demo.Models.Common;
using Demo.Models.Grid;
using Demo.Persistance.Entities;
using Demo.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Handlers.Grid
{
    public interface IGridValueChangeCommandHandler : ICommandHandler<GridValueChangeCommand, Result> { }
    public class GridValueChangeCommandHandler : IGridValueChangeCommandHandler
    {
        private readonly IEventRepository eventRepository;
        private readonly IBackgroundProcesor backgroundProcesor;

        public GridValueChangeCommandHandler(IEventRepository eventRepository, IBackgroundProcesor backgroundProcesor)
        {
            this.eventRepository = eventRepository;
            this.backgroundProcesor = backgroundProcesor;
        }

        public async Task<Result> Handle(GridValueChangeCommand query)
        {
            var addResult = await eventRepository.New(new EventAgregate()
            {
                EventType = (int)EventType.GridValueChange,
                AgregateId = query.AgregateId,
                AgregateType = (int)AgregateType.GridItem,
                Caller = 99999999,
                CallerName = "test",
                CreatedAt = DateTime.Now,
                NewValue = query.NewValue,
                OldValue = query.OldValue
            });
            //TODO: One more layer? Like factory for events? Pass as id?
            backgroundProcesor.Run<IEventHandler<IEvent>>(p => p.Handle(addResult));
            return await Task.FromResult(Result.Success());
        }
    }
}
