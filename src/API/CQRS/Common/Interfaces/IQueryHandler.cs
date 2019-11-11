using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Common.Interfaces
{
    public interface IQueryHandler<Query,Result> where Query : IQuery where Result : IResult
    {
        Task<Result> Handle(Query query);
    }
}
