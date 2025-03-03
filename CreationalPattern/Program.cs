using System;
using CreationalPattern.Patterns.AbstractFactory;
using CreationalPattern.Patterns.Builder;
using CreationalPattern.Patterns.FactoryMethod;
using CreationalPattern.Patterns.Prototype;
using CreationalPattern.Patterns.Singleton;

namespace CreationalPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------Singleton Pattern------");
            var company = Company.Instance;
            company.StartWork();

            Console.WriteLine("\n------Factory Method Pattern------");
            EmployeeFactory developerFactory = new DeveloperFactory();
            var developer = developerFactory.CreateEmployee();
            developer.Work();

            EmployeeFactory designerFactory = new DesignerFactory();
            var designer = designerFactory.CreateEmployee();
            designer.Work();

            EmployeeFactory testerFactory = new TesterFactory();
            var tester = testerFactory.CreateEmployee();
            tester.Work();

            Console.WriteLine("\n------Abstract Method Pattern------");
            CompanyFactory companyFactory = new DeveloperFactoryMethod();
            var devRole = companyFactory.CreateRole();
            var devDepartment = companyFactory.CreateDepartment();
            devRole.PerformDuty();
            devDepartment.AssignDepartment();

            Console.WriteLine("\n=== Builder ===");
            var project = new ProjectBuilder()
                .SetName("Сайт для компанії")
                .SetBudget(100000)
                .AddTeamMember("Іван")
                .AddTeamMember("Марія")
                .Build();
            project.DisplayInfo();

            Console.WriteLine("\n=== Prototype ===");
            var originalEmployee = new Patterns.Prototype.Employee { Name = "Олександр", Role = "Розробник" };
            var clonedEmployee = (Patterns.Prototype.Employee)originalEmployee.Clone();
            clonedEmployee.Name = "Петро";
            Console.WriteLine($"Оригінальний співробітник: {originalEmployee.Name}, {originalEmployee.Role}");
            Console.WriteLine($"Клонований співробітник: {clonedEmployee.Name}, {clonedEmployee.Role}");




        }
    }
}


