using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Mediator
{
    public class Request
    {
        public RequestType Type { get; }
        public string Message { get; }
        public Department Sender { get; }

        public Request(RequestType type, string message, Department sender)
        {
            Type = type;
            Message = message;
            Sender = sender;
        }
    }

}