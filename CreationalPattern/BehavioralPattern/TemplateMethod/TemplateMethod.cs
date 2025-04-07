using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.TemplateMethod
{
    public abstract class ProjectWorkflow
    {
        public void ExecuteProject()
        {
            PlanProject();
            PerformTasks();
            ReviewResults();
            FinalizeProject();
        }
        private void PlanProject()
        {
            Console.WriteLine("Планування проєкту: визначення цілей і ресурсів.");
        }

        protected abstract void PerformTasks();

        protected virtual void ReviewResults()
        {
            Console.WriteLine("Перегляд результатів: базова перевірка якості.");
        }

        private void FinalizeProject()
        {
            Console.WriteLine("Завершення проєкту: підготовка звітів і закриття.");
        }
    }
}