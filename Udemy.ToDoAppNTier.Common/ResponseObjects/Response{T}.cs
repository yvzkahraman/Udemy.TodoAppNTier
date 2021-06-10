using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ToDoAppNTier.Common.ResponseObjects
{
    public class Response<T> : Response , IResponse<T>
    {
        public T Data { get; set; }

        public Response(ResponseType responseType) : base(responseType)
        {

        }

        public Response(ResponseType responseType, T data) : base(responseType)
        {
            Data = data;
        }
        public Response(ResponseType responseType, string message, T data) : base(responseType, message)
        {
            Data = data;
        }
    }
}
