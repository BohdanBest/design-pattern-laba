using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Memento
{
    public class ProjectMemento
    {
        public string State { get; }
        public ProjectMemento(string state) => State = state;
    }

    public class Project
    {
        public string State { get; set; }
        public ProjectMemento Save() => new(State);
        public void Restore(ProjectMemento memento) => State = memento.State;
    }
}