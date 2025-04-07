using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Memento
{
    public class Project
    {
        public string Name { get; private set; }
        public string Status { get; private set; }
        public DateTime Deadline { get; private set; }

        public Project(string name, string status, DateTime deadline)
        {
            Name = name;
            Status = status;
            Deadline = deadline;
        }

        public void Update(string name, string status, DateTime deadline)
        {
            Name = name;
            Status = status;
            Deadline = deadline;
        }

        public ProjectMemento Save(string comment) => new(new ProjectState(Name, Status, Deadline), comment);

        public void Restore(ProjectMemento memento)
        {
            var state = memento.GetState();
            Name = state.Name;
            Status = state.Status;
            Deadline = state.Deadline;
        }

        public override string ToString() => $"Поточний стан: {Name}, {Status}, {Deadline:yyyy-MM-dd}";
    }
}