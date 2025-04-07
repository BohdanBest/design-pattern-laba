using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Memento
{

    public class ProjectMemento
    {
        private readonly ProjectState _state;
        public string Comment { get; }

        public ProjectMemento(ProjectState state, string comment)
        {
            _state = state;
            Comment = comment;
        }

        public ProjectState GetState() => _state;
    }

    
}