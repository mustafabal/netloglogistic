﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool IsSuccess, string Message) : this(IsSuccess)
        {
            this.Message = Message;
        }
        public Result(bool IsSuccess)
        {
            this.IsSuccess = IsSuccess;
        }
        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
