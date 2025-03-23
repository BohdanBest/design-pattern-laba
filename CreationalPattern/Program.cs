using CreationalPattern.StructuralPattern.Adapter;
using CreationalPattern.StructuralPattern.Bridge;
using CreationalPattern.StructuralPattern.Composite;
using CreationalPattern.StructuralPattern.Decorator;
using CreationalPattern.StructuralPattern.Facade;
using CreationalPattern.StructuralPattern.Flyweight;
using CreationalPattern.StructuralPattern.Proxy;


class Program
{
    static void Main(string[] args)
    {
        // Structural Patterns
        Console.WriteLine("\n=== Structural Patterns ===");

        // Adapter
        var legacyEmployee = new LegacyEmployee();
        var employeeAdapter = new EmployeeAdapter(legacyEmployee);
        Console.WriteLine($"Адаптер: {employeeAdapter.GetName()}");

        // Bridge
        var developmentDepartment = new DevelopmentDepartment(new DevelopmentManager());
        developmentDepartment.AssignEmployee();

        // Composite
        var devDepartment = new DepartmentComponent();
        devDepartment.Add(new Employee("Іван"));
        devDepartment.Add(new Employee("Марія"));
        devDepartment.Display();

        // Decorator
        var teamLead = new TeamLeadDecorator(new Developer());
        teamLead.Work();

        // Facade
        var companyFacade = new CompanyFacade();
        CompanyFacade.StartCompany();

        // Flyweight
        var roleFactory = new RoleFactory();
        var role = roleFactory.GetRole("Розробник");
        role.Display("Олександр");

        // Proxy
        var employeeProxy = new EmployeeProxy();
        employeeProxy.Work();
    }
}