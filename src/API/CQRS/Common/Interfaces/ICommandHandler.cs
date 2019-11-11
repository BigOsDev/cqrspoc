using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Common.Interfaces
{
    public interface ICommandHandler<Command, Result> where Command : ICommand where Result : IResult
    {
        Task<Result> Handle(Command query);
    }
}
