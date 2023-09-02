using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Result
{
    public class SuccesDataResult<T> : DataResult<T>
    {
        public SuccesDataResult(T Data, bool IsSuccess, string Message) : base(Data, true, Message) { }
        public SuccesDataResult(T Data) : base(Data, true) { }
        public SuccesDataResult(string Message) : base(default, true, Message) { }
        public SuccesDataResult(List<T> Data) : base(default, true) { }
    }
}
