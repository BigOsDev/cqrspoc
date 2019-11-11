using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Common.Definitions
{
    public class QueryBase : IQuery
    {
        public QueryBase()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
