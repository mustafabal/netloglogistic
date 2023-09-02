using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Result
{
    public class SuccesResult : Result
    {
        public SuccesResult(bool IsSuccess, string Message) : base(true, Message) { }
        public SuccesResult() : base(true) { }
    }
}
