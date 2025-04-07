using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Command
{
    public class RemoveTaskCommand : ICommand
    {
        private readonly TaskManager _taskManager;
        private readonly string _task;

        public RemoveTaskCommand(TaskManager taskManager, string task)
        {
            _taskManager = taskManager;
            _task = task;
        }

        public void Execute() => _taskManager.RemoveTask(_task);

        public void Undo() => _taskManager.AddTask(_task);
    }
}