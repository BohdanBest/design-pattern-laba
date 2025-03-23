using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.StructuralPattern.Bridge
{
    public interface IEmployeeManager
    {
        void Manage();
    }
    public abstract class Department
    {
        protected IEmployeeManager EmployeeManager;

        protected Department(IEmployeeManager employeeManager)
        {
            EmployeeManager = employeeManager;
        }

        public abstract void AssignEmployee();
    }

    public class DevelopmentManager : IEmployeeManager
    {
        public void Manage() => Console.WriteLine("Керування розробниками.");
    }

    public class DevelopmentDepartment : Department
    {
        public DevelopmentDepartment(IEmployeeManager employeeManager) : base(employeeManager) { }

        public override void AssignEmployee()
        {
            Console.WriteLine("Призначення співробітника до відділу розробки:");
            EmployeeManager.Manage();
        }
    }
}
