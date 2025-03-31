using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.State
{
    public interface IProjectState
    {
        void Handle(ProjectContext context);
    }

    public class InDevelopmentState : IProjectState
    {
        public void Handle(ProjectContext context) => Console.WriteLine("Проект у стадії розробки.");
    }

    public class ProjectContext
    {
        private IProjectState _state;
        public void SetState(IProjectState state) => _state = state;
        public void Request() => _state?.Handle(this);
    }
}