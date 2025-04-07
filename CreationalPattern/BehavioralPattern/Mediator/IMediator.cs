using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Mediator
{
    public interface IMediator
    {
        void Register(Department department);
        void SendRequest(Request request);
    }
}