using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.State
{
    public class ProjectContext
    {
        private IProjectState _state;
        public List<string> Tasks { get; } = new();

        public ProjectContext()
        {
            _state = new InDevelopmentState();
        }

        public void SetState(IProjectState state) => _state = state;

        public void AddTask(string task) => _state.AddTask(this, task);
        public void TestTask(string task) => _state.TestTask(this, task);
        public void Complete() => _state.Complete(this);

        public void ShowTasks()
        {
            Console.WriteLine("Поточні задачі: " + (Tasks.Count > 0 ? string.Join(", ", Tasks) : "немає"));
        }
    }
}