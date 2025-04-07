using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Mediator
{
    public class Department
    {
        public string Name { get; }
        private IMediator _mediator;

        public Department(string name)
        {
            Name = name;
        }

        public void SetMediator(IMediator mediator) => _mediator = mediator;

        public void Send(RequestType type, string message)
        {
            var request = new Request(type, message, this);
            _mediator?.SendRequest(request);
        }

        public void ReceiveRequest(Request request)
        {
            Console.WriteLine($"{Name} отримав запит від {request.Sender.Name}: {request.Message}");
        }
    }
}