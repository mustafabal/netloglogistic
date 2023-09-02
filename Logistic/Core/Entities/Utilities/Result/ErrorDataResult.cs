using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Result
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T Data, string Message) : base(Data, false, Message) { }
        public ErrorDataResult(T Data) : base(Data, false) { }
        public ErrorDataResult(string Message) : base(default, false, Message) { }
        public ErrorDataResult() : base(default, false) { }
    }
}
