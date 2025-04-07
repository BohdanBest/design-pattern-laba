using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Strategy
{
    public class Task
    {
        public string Description { get; }
        public int EstimatedHours { get; } 
        public int Priority { get; }

        public Task(string description, int estimatedHours, int priority)
        {
            Description = description;
            EstimatedHours = estimatedHours;
            Priority = priority;
        }

        public override string ToString() => $"{Description} (Час: {EstimatedHours} год, Пріоритет: {Priority})";
    }
}