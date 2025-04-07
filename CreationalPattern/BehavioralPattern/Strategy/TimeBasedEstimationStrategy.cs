using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Strategy
{
    public class TimeBasedEstimationStrategy : ITaskEstimationStrategy
    {
        public int EstimateComplexity(Task task)
        {
            int complexity = task.EstimatedHours * 50;
            Console.WriteLine($"Оцінка '{task.Description}' за часом: {complexity}");
            return complexity;
        }
    }
}