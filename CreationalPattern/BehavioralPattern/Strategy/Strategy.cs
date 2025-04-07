using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Strategy
{
    public class TaskProcessor
    {
        private ITaskEstimationStrategy _strategy;

        public TaskProcessor(ITaskEstimationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ITaskEstimationStrategy strategy) => _strategy = strategy;

        public int ProcessTask(Task task)
        {
            return _strategy.EstimateComplexity(task);
        }
    }
}