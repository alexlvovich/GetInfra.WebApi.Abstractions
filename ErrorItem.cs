using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions
{
    public class ErrorItem
    {
        public ErrorItem(string message) : this(message, string.Empty)
        {

        }


        public ErrorItem(string message, string stack)
        {
            Message = message;
            Stack = stack;
        }
        public string Message { get; set; }

        public string Stack { get; set; }
    }
}
