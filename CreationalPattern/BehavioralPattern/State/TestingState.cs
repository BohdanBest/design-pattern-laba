using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.State
{

    public class TestingState : IProjectState
    {
        public void AddTask(ProjectContext context, string task)
        {
            Console.WriteLine("Додавання задач недоступне у стані 'Тестування'.");
        }

        public void TestTask(ProjectContext context, string task)
        {
            if (context.Tasks.Contains(task))
            {
                Console.WriteLine($"Тестуємо задачу: {task}");
                context.Tasks.Remove(task);
                if (context.Tasks.Count == 0)
                {
                    Console.WriteLine("Усі задачі протестовано. Переходимо до стану 'Завершено'.");
                    context.SetState(new CompletedState());
                }
            }
            else
            {
                Console.WriteLine($"Задача '{task}' не знайдена.");
            }
        }

        public void Complete(ProjectContext context)
        {
            Console.WriteLine("Завершення неможливе, поки є непротестовані задачі.");
        }
    }
}