using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS
{
    public class Response<T>
    {
        public T Content { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }

    public class SucessResponse<T> : Response<T>
    {
        public SucessResponse(T content, string message)
        {
            Content = content;
            Status = true;
            Message = message;
        }

        public SucessResponse(T content)
        {
            Content = content;
            Status = true;
            Message = "Operation successfull";
        }

        public SucessResponse()
        {
            Content = typeof(T).IsValueType ? default(T) : Activator.CreateInstance<T>();
            Status = true;
            Message = "Operation successfull";
        }
    }

    public class FailureResponse<T> : Response<T>
    {
        public FailureResponse(T content, string message, Exception exception)
        {
            Content = content;
            Status = false;
            Message = message;
            Exception = exception;
        }

        public FailureResponse(Exception exception)
        {
            Content = typeof(T).IsValueType ? default(T) : Activator.CreateInstance<T>();
            Status = false;
            Message = exception.Message;
            Exception = exception;
        }

        public FailureResponse(string messge)
        {
            Content = typeof(T).IsValueType ? default(T) : Activator.CreateInstance<T>();
            Status = false;
            Message = messge;
            Exception = new Exception();
        }

        public FailureResponse()
        {
            Content = typeof(T).IsValueType ? default(T) : Activator.CreateInstance<T>();
            Status = false;
            Message = "Operation failed";
            Exception = new Exception();
        }
    }

}
