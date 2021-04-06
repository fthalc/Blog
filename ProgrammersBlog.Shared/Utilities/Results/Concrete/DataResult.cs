using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus,T data)
        {
            Data = data;
            ResultStatus = resultStatus;
        }
        public DataResult(ResultStatus resultStatus,String message,T data)
        {
            ResultStatus = resultStatus;
            message = Message;
            Data = data;
            
        }
        public DataResult(ResultStatus resultStatus,String message,T data,Exception exception)
        {
            ResultStatus = resultStatus;
            message = Message;
            Data = data;
            exception = Exception;
        }
        public T Data { get; }

        public ResultStatus ResultStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Exception Exception { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
