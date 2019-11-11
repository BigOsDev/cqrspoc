using CQRS.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models.Grid
{
    public class GridResult
    {
        public GridResult()
        {
            Result = new List<Item>();
        }
        public GridResult(IList<Item> result)
        {
            Result = result;
        }

        public IList<Item> Result { get; set; }

    }
}
