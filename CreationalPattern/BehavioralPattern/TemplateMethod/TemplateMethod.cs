using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.TemplateMethod
{
    public abstract class HiringProcess
    {
        public void Hire()
        {
            Interview();
            TechnicalTest();
            Offer();
        }
        protected abstract void TechnicalTest();
        private void Interview() => Console.WriteLine("Інтерв’ю...");
        private void Offer() => Console.WriteLine("Пропозиція офферу...");
    }

    public class DeveloperHiring : HiringProcess
    {
        protected override void TechnicalTest() => Console.WriteLine("Код-рев’ю та алгоритми...");
    }
}