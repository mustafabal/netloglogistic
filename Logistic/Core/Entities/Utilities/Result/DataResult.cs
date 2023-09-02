using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }
        public List<T>? DataList { get; set; }


        public DataResult(T data, bool IsSuccess, string Message) : base(IsSuccess, Message)
        {
            Data = data;
        }
        public DataResult(T data, bool IsSuccess) : base(IsSuccess)
        { Data = data; }
    }
}
