using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.State
{
    public class InDevelopmentState : IProjectState
    {
        public void AddTask(ProjectContext context, string task)
        {
            Console.WriteLine($"Додано задачу: {task}");
            context.Tasks.Add(task);
            if (context.Tasks.Count >= 3)
            {
                Console.WriteLine("Достатньо задач для тестування. Переходимо до стану 'Тестування'.");
                context.SetState(new TestingState());
            }
        }

        public void TestTask(ProjectContext context, string task)
        {
            Console.WriteLine("Тестування недоступне у стані 'В розробці'.");
        }

        public void Complete(ProjectContext context)
        {
            Console.WriteLine("Завершення неможливе у стані 'В розробці'.");
        }
    }
}