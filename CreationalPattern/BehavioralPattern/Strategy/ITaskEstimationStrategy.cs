using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Strategy
{
    public interface ITaskEstimationStrategy
    {
        int EstimateComplexity(Task task);
    }
}