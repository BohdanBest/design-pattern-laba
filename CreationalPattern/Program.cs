using CreationalPattern.BehavioralPattern.ChainOfResponsibility;
using CreationalPattern.BehavioralPattern.Command;
using CreationalPattern.BehavioralPattern.Iterator;
using CreationalPattern.BehavioralPattern.Mediator;
using CreationalPattern.BehavioralPattern.Memento;
using CreationalPattern.BehavioralPattern.Observer;
using CreationalPattern.BehavioralPattern.State;
using CreationalPattern.BehavioralPattern.Strategy;
using CreationalPattern.BehavioralPattern.TemplateMethod;
using CreationalPattern.BehavioralPattern.Visitor;


class Program
{
    static void Main()
    {
        Console.WriteLine("=== Behavioral Patterns ===");


        var teamLead = new TeamLead();
        var hr = new HR();
        teamLead.SetNext(hr);
        teamLead.ProcessRequest(new SalaryRequest { EmployeeName = "Іван", Amount = 800 });
        teamLead.ProcessRequest(new SalaryRequest { EmployeeName = "Олег", Amount = 1200 });


        var invoker = new Invoker();
        invoker.SetCommand(new DevelopFeatureCommand());
        invoker.ExecuteCommand();


        foreach (var employee in new EmployeeCollection())
            Console.WriteLine($"Ітератор: Співробітник {employee}");


        var mediator = new CompanyMediator();
        new Department(mediator).Send("Потрібен бекенд-розробник!");


        var project = new Project { State = "В розробці" };
        var memento = project.Save();
        project.Restore(memento);


        var subject = new ProjectSubject();
        subject.Attach(new EmployeeObserver());
        subject.Notify("Релиз завтра!");


        var projectContext = new ProjectContext();
        projectContext.SetState(new InDevelopmentState());
        projectContext.Request();


        var context = new Context();
        context.SetStrategy(new ManualTesting());
        context.ExecuteTest();


        new DeveloperHiring().Hire();


        var calculator = new SalaryCalculator();
        new Developer().Accept(calculator);
    }
}

