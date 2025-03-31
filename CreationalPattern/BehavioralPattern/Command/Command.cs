using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Command
{
    public interface ICommand
    {
        void Execute();
    }

    public class DevelopFeatureCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Розробник: Реалізую нову функцію...");
    }

    public class Invoker
    {
        private ICommand _command;
        public void SetCommand(ICommand command) => _command = command;
        public void ExecuteCommand() => _command?.Execute();
    }
}