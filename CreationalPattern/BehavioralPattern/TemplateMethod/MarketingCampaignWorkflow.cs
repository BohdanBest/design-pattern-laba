using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.TemplateMethod
{
    public class MarketingCampaignWorkflow : ProjectWorkflow
    {
        protected override void PerformTasks()
        {
            Console.WriteLine("Виконання задач: створення контенту, запуск реклами, аналіз аудиторії.");
        }

        protected override void ReviewResults()
        {
            Console.WriteLine("Перегляд результатів: аналіз ROI та відгуків клієнтів.");
        }
    }
}