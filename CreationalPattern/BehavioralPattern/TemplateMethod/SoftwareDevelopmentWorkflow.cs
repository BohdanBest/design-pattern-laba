using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.TemplateMethod
{
    public class SoftwareDevelopmentWorkflow : ProjectWorkflow
    {
        protected override void PerformTasks()
        {
            Console.WriteLine("Виконання задач: написання коду, тестування, деплоїмент.");
        }

        protected override void ReviewResults()
        {
            Console.WriteLine("Перегляд результатів: код-рев’ю та тестування продуктивності.");
        }
    }
}