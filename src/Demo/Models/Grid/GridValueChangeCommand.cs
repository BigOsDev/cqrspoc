using CQRS.Common.Definitions;
using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models.Grid
{
    public class GridValueChangeCommand : CommandBase
    {
        public int AgregateId { get; set; }
        public string Agregate { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
