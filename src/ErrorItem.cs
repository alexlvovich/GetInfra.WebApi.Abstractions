using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions
{
    public class ErrorItem
    {
        public ErrorItem() : this(string.Empty, string.Empty, string.Empty)
        {

        }
        public ErrorItem(string message) : this(message, string.Empty, string.Empty)
        {

        }

        public ErrorItem(string message, string stack) : this(message, stack, string.Empty)
        {

        }


        public ErrorItem(string message, string stack, string correlationId)
        {
            Message = message;
            Stack = stack;
            CorrelationId = correlationId;
        }
        public string Message { get; set; }

        public string Stack { get; set; }

        /// <summary>
        /// trace accross microservices
        /// </summary>
        public string CorrelationId { get; set; }
    }
}
