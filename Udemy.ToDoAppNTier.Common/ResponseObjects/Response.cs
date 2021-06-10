﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ToDoAppNTier.Common.ResponseObjects
{
    public class Response : IResponse
    {
        public Response(ResponseType responseType, string message)
        {
            ResponseType = responseType;
            Message = message;
        }

        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }

        public string Message { get; set; }

        public ResponseType ResponseType { get; set; }
    }

    public enum ResponseType
    {
        Success,
        NotFound,
    }
}
