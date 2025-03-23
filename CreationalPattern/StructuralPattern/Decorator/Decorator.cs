using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.StructuralPattern.Decorator
{
    public interface IEmployee
    {
        void Work();
    }

    public class Developer : IEmployee
    {
        public void Work() => Console.WriteLine("Розробник пише код.");
    }

    public class EmployeeDecorator : IEmployee
    {
        private readonly IEmployee _employee;

        public EmployeeDecorator(IEmployee employee) => _employee = employee;

        public virtual void Work() => _employee.Work();
    }

    public class TeamLeadDecorator : EmployeeDecorator
    {
        public TeamLeadDecorator(IEmployee employee) : base(employee) { }

        public override void Work()
        {
            base.Work();
            Console.WriteLine("Керує командою.");
        }
    }
}
