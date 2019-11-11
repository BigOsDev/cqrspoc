using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Common.Interfaces
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message = null)
        {
            this.Id = Guid.NewGuid();
            this.IsSuccess = isSuccess;
            this.Message = message;
        }

        public Guid Id { get; set; }

        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public static Result Success()
        {
            return new Result(true);
        }

        public static Result Failed()
        {
            return new Result(false);
        }
    }
}
