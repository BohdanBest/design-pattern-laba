using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string message);
    }

    public class CompanyMediator : IMediator
    {
        public void Notify(object sender, string message)
        {
            Console.WriteLine($"Mediator: {sender.GetType().Name} відправив повідомлення - '{message}'");
        }
    }

    public class Department
    {
        private readonly IMediator _mediator;
        public Department(IMediator mediator) => _mediator = mediator;
        public void Send(string message) => _mediator.Notify(this, message);
    }
}