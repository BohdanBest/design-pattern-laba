using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Command
{
    public class TaskManager
    {
        private readonly List<string> _tasks = new();

        public void AddTask(string task)
        {
            _tasks.Add(task);
            Console.WriteLine($"Додано задачу: {task}");
        }

        public void RemoveTask(string task)
        {
            if (_tasks.Remove(task))
                Console.WriteLine($"Видалено задачу: {task}");
            else
                Console.WriteLine($"Задача '{task}' не знайдена.");
        }

        public void ShowTasks()
        {
            Console.WriteLine("Поточні задачі: " + (_tasks.Count > 0 ? string.Join(", ", _tasks) : "немає"));
        }
    }
}