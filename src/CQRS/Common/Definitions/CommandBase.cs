using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Common.Definitions
{
    public class CommandBase : ICommand
    {
        public CommandBase()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
