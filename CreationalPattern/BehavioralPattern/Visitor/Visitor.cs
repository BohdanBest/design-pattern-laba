using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Visitor
{
    public class SalaryCalculator : IEmployeeVisitor
    {
        public void Visit(Developer developer)
        {
            decimal salary = 2000 + (developer.YearsOfExperience * 500) + (developer.LinesOfCodeWritten / 1000 * 100);
            Console.WriteLine($"Зарплата для {developer.Name}: ${salary}");
        }

        public void Visit(Manager manager)
        {
            decimal salary = 3000 + (manager.YearsOfExperienceInManagement * 700) + (manager.ProjectsManaged * 200);
            Console.WriteLine($"Зарплата для {manager.Name}: ${salary}");
        }
    }

    public class PerformanceEvaluator : IEmployeeVisitor
    {
        public void Visit(Developer developer)
        {
            string performance = developer.LinesOfCodeWritten > 5000 ? "Висока" : "Середня";
            Console.WriteLine($"Продуктивність {developer.Name}: {performance}");
        }

        public void Visit(Manager manager)
        {
            string performance = manager.ProjectsManaged > 5 ? "Висока" : "Середня";
            Console.WriteLine($"Продуктивність {manager.Name}: {performance}");
        }
    }

}