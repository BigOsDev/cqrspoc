using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Common.Interfaces
{
    public interface IQuery
    {
        Guid Id { get; }
    }
}
