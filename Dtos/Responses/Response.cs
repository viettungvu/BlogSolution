﻿namespace Dtos.Responses
{
    public class Response
    {
        public virtual bool Success { get; set; }
        public string Message { get; set; }

        public Response(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }

    public class Response<T> : Response
    {
        public T Data { get; set; }

        public Response(bool success, string message) : base(success, message)
        {
        }
    }
}