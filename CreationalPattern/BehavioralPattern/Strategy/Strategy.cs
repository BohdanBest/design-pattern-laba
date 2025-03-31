using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Strategy
{
    public interface ITestingStrategy
    {
        void Test();
    }

    public class ManualTesting : ITestingStrategy
    {
        public void Test() => Console.WriteLine("Ручне тестування...");
    }

    public class Context
    {
        private ITestingStrategy _strategy;
        public void SetStrategy(ITestingStrategy strategy) => _strategy = strategy;
        public void ExecuteTest() => _strategy?.Test();
    }
}