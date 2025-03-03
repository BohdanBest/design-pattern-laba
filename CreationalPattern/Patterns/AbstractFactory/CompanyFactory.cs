using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.Patterns.AbstractFactory
{
    public interface IRole
    {
        void PerformDuty();
    }
    public interface IDepartment { void AssignDepartment(); }

    public class DeveloperRole : IRole
    {
        public void PerformDuty() => Console.WriteLine("Developer is working");
    }
    public class DeveloperDepartment : IDepartment
    {
        public void AssignDepartment() => Console.WriteLine("Developer department is assigned");
    }
    public class DesignerRole : IRole
    {
        public void PerformDuty() => Console.WriteLine("Designer is working");
    }
    public class DesignerDepartment : IDepartment
    {
        public void AssignDepartment() => Console.WriteLine("Design department is assigned");
    }
    public class TesterRole : IRole
    {
        public void PerformDuty() => Console.WriteLine("Tester is working");
    }
    public class TesterDepartment : IDepartment
    {
        public void AssignDepartment() => Console.WriteLine("Tester department is assigned");
    }

    public abstract class CompanyFactory
    {
        public abstract IRole CreateRole();
        public abstract IDepartment CreateDepartment();
    }

    public class DeveloperFactoryMethod : CompanyFactory
    {
        public override IRole CreateRole() => new DeveloperRole();
        public override IDepartment CreateDepartment() => new DeveloperDepartment();
    }

    public class DesignerFactoryMethod : CompanyFactory
    {
        public override IRole CreateRole() => new DesignerRole();
        public override IDepartment CreateDepartment() => new DesignerDepartment();
    }

    public class TesterFactoryMethod : CompanyFactory
    {
        public override IRole CreateRole() => new TesterRole();
        public override IDepartment CreateDepartment() => new TesterDepartment();
    }

}