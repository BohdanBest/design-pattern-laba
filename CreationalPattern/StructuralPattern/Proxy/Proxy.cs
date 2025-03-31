using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.StructuralPattern.Proxy
{
    public interface IEmployee
    {
        void Work();
    }
    public class RealEmployee : IEmployee
    {
        public void Work() => Console.WriteLine("Співробітник працює.");
    }
    
    public class EmployeeProxy : IEmployee
    {
        private RealEmployee _realEmployee;

        public void Work()
        {
            _realEmployee ??= new RealEmployee();
            _realEmployee.Work();
        }
    }
}