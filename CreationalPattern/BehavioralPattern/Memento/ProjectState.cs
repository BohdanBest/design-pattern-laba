using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Memento
{
    public class ProjectState
    {
        public string Name { get; }
        public string Status { get; }
        public DateTime Deadline { get; }

        public ProjectState(string name, string status, DateTime deadline)
        {
            Name = name;
            Status = status;
            Deadline = deadline;
        }

        public override string ToString() => $"Проєкт: {Name}, Статус: {Status}, Дедлайн: {Deadline:yyyy-MM-dd}";
    }
}