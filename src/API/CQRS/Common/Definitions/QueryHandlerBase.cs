using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Common.Definitions
{
    public abstract class QueryHandlerBase<Query, Result> : IQueryHandler<Query, Result> where Query : IQuery where Result : IResult
    {
        public abstract Task<Result> Handle(Query query);
    }
}
