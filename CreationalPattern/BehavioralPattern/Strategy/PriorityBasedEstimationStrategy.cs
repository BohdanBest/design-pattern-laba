using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Strategy
{
    public class PriorityBasedEstimationStrategy : ITaskEstimationStrategy
    {
        public int EstimateComplexity(Task task)
        {
            int complexity = task.Priority * 100;
            Console.WriteLine($"Оцінка '{task.Description}' за пріоритетом: {complexity}");
            return complexity;
        }
    }
}