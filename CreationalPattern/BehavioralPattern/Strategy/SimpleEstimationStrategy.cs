using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Strategy
{
    public class SimpleEstimationStrategy : ITaskEstimationStrategy
    {
        public int EstimateComplexity(Task task)
        {
            int wordCount = task.Description.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            int complexity = wordCount * 10;
            Console.WriteLine($"Оцінка '{task.Description}' за кількістю слів: {complexity}");
            return complexity;
        }
    }
}