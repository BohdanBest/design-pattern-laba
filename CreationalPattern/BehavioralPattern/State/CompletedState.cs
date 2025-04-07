using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.State
{
    public class CompletedState : IProjectState
    {
        public void AddTask(ProjectContext context, string task)
        {
            Console.WriteLine("Проєкт завершено. Додавання задач неможливе.");
        }

        public void TestTask(ProjectContext context, string task)
        {
            Console.WriteLine("Проєкт завершено. Тестування неможливе.");
        }

        public void Complete(ProjectContext context)
        {
            Console.WriteLine("Проєкт уже завершено!");
        }
    }
}