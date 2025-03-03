using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.Patterns.FactoryMethod
{
    public abstract class Employee
    {
        public abstract void Work();
    }
    public class Developer : Employee
    {
        public override void Work() => Console.WriteLine("Developer is working");
    }
    public class Designer : Employee
    {
        public override void Work() => Console.WriteLine("Designer is working");
    }
    public class Tester : Employee
    {
        public override void Work() => Console.WriteLine("Tester is working");
    }

    public abstract class EmployeeFactory
    {
        public abstract Employee CreateEmployee();
    }
    public class DeveloperFactory : EmployeeFactory
    {
        public override Employee CreateEmployee() => new Developer();
    }
    public class DesignerFactory : EmployeeFactory
    {
        public override Employee CreateEmployee() => new Designer();
    }
    public class TesterFactory : EmployeeFactory
    {
        public override Employee CreateEmployee() => new Tester();
    }
}