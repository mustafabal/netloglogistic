using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(bool IsSuccess, string Message) : base(false, Message) { }
        public ErrorResult() : base(true) { }
    }
}
