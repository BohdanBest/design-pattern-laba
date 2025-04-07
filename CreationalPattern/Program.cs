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
using Task = CreationalPattern.BehavioralPattern.Strategy.Task;

class Program
{
    static void Main()
    {
        DemonstrateChainOfResponsibility();
        DemonstrateCommand();
        DemonstrateIterator();
        DemonstrateMediator();
        DemonstrateMemento();
        DemonstrateObserver();
        DemonstrateState();
        DemonstrateStrategy();
        DemonstrateTemplateMethod();
        DemonstrateVisitor();
    }

    static void DemonstrateChainOfResponsibility()
    {
        Console.WriteLine("\n=== Chain of Responsibility ===");
        var teamLead = new TeamLead();
        var hr = new HR();
        teamLead.SetNext(hr);
        teamLead.ProcessRequest(new SalaryRequest("Іван", 800));
        teamLead.ProcessRequest(new SalaryRequest("Олег", 1200));
        teamLead.ProcessRequest(new SalaryRequest("Марія", 6000));
    }

    static void DemonstrateCommand()
    {
        Console.WriteLine("\n=== Command ===");
        var taskManager = new TaskManager();
        var invoker = new TaskInvoker();

        // Виконуємо команди
        invoker.ExecuteCommand(new AddTaskCommand(taskManager, "Реалізувати авторизацію"));
        taskManager.ShowTasks();

        invoker.ExecuteCommand(new AddTaskCommand(taskManager, "Додати API"));
        taskManager.ShowTasks();

        invoker.ExecuteCommand(new RemoveTaskCommand(taskManager, "Реалізувати авторизацію"));
        taskManager.ShowTasks();

        // Скасовуємо дії
        Console.WriteLine("\nСкасовуємо останню команду:");
        invoker.UndoLastCommand();
        taskManager.ShowTasks();

        Console.WriteLine("\nСкасовуємо ще одну команду:");
        invoker.UndoLastCommand();
        taskManager.ShowTasks();

        Console.WriteLine("\nСкасовуємо ще раз (немає команд):");
        invoker.UndoLastCommand();
    }

    static void DemonstrateIterator()
    {
        Console.WriteLine("\n=== Iterator ===");
        var collection = new EmployeeCollection();
        collection.AddEmployee(new Employee("Іван", 2));
        collection.AddEmployee(new Employee("Марія", 5));
        collection.AddEmployee(new Employee("Петро", 1));
        collection.AddEmployee(new Employee("Олена", 7));

        Console.WriteLine("Усі співробітники:");
        var allIterator = collection.CreateIterator();
        while (allIterator.MoveNext())
        {
            Console.WriteLine(allIterator.Current);
        }

        Console.WriteLine("\nСпівробітники з досвідом від 5 років:");
        var experiencedIterator = collection.CreateIterator(5);
        while (experiencedIterator.MoveNext())
        {
            Console.WriteLine(experiencedIterator.Current);
        }

        // Показуємо Reset
        Console.WriteLine("\nСкидаємо ітератор і повторюємо:");
        experiencedIterator.Reset();
        while (experiencedIterator.MoveNext())
        {
            Console.WriteLine(experiencedIterator.Current);
        }
    }

    static void DemonstrateMediator()
    {
        Console.WriteLine("\n=== Mediator ===");
        var mediator = new CompanyMediator();

        var itDept = new Department("IT");
        var hrDept = new Department("HR");
        var financeDept = new Department("Finance");

        mediator.Register(itDept);
        mediator.Register(hrDept);
        mediator.Register(financeDept);

        Console.WriteLine("IT надсилає запит на найм розробника:");
        itDept.Send(RequestType.HireDeveloper, "Потрібен бекенд-розробник!");

        Console.WriteLine("\nFinance надсилає запит на оновлення бюджету:");
        financeDept.Send(RequestType.UpdateBudget, "Збільшити бюджет на $5000");

        Console.WriteLine("\nHR надсилає загальне повідомлення:");
        hrDept.Send(RequestType.GeneralMessage, "Усі на корпоратив!");
    }

    static void DemonstrateMemento()
    {
        Console.WriteLine("\n=== Memento ===");
        var project = new Project("CRM System", "В розробці", new DateTime(2025, 12, 31));
        var history = new ProjectHistory();

        Console.WriteLine(project);
        history.Save(project, "Початковий стан");

        project.Update("CRM System v2", "Тестування", new DateTime(2026, 1, 15));
        Console.WriteLine(project);
        history.Save(project, "Додано тестування");

        project.Update("CRM System v2", "Завершено", new DateTime(2026, 1, 10));
        Console.WriteLine(project);
        history.Save(project, "Проєкт завершено");

        history.ShowHistory();

        history.Restore(project, 0); // Відновлюємо початковий стан
        Console.WriteLine(project);

    }

    static void DemonstrateObserver()
    {
        Console.WriteLine("\n=== Observer ===");
        var project = new ProjectSubject("CRM System", "В розробці", new DateTime(2025, 12, 31));
        var employee = new EmployeeObserver("Іван");
        var manager = new ManagerObserver("Олег");

        project.Attach(employee);
        project.Attach(manager);

        Console.WriteLine("Початковий стан:");
        Console.WriteLine(project);

        project.ChangeStatus("Тестування");
        project.ChangeDeadline(new DateTime(2026, 1, 15));
        project.ChangeName("CRM System v2");

        Console.WriteLine("\nВід’єднуємо співробітника:");
        project.Detach(employee);
        project.ChangeStatus("Завершено");
    }

    static void DemonstrateState()
    {
        Console.WriteLine("\n=== State ===");
        var project = new ProjectContext();

        Console.WriteLine("Спочатку додаємо задачі:");
        project.AddTask("Реалізувати авторизацію");
        project.ShowTasks();
        project.AddTask("Додати API");
        project.ShowTasks();
        project.AddTask("Оптимізувати базу даних");
        project.ShowTasks();

        Console.WriteLine("\nСпробуємо завершити проєкт:");
        project.Complete();

        Console.WriteLine("\nТестуємо задачі:");
        project.TestTask("Реалізувати авторизацію");
        project.ShowTasks();
        project.TestTask("Додати неіснуючу задачу");
        project.TestTask("Додати API");
        project.ShowTasks();
        project.TestTask("Оптимізувати базу даних");
        project.ShowTasks();

        Console.WriteLine("\nСпробуємо додати задачу після завершення:");
        project.AddTask("Нова задача");
        project.Complete();
    }

    static void DemonstrateStrategy()
    {
        Console.WriteLine("\n=== Strategy ===");
        var task = new Task("Реалізувати авторизацію через OAuth", 5, 8);
        Console.WriteLine($"Задача: {task}");

        var processor = new TaskProcessor(new SimpleEstimationStrategy());
        Console.WriteLine("Оцінка за простою стратегією:");
        processor.ProcessTask(task);

        processor.SetStrategy(new TimeBasedEstimationStrategy());
        Console.WriteLine("Оцінка за часом:");
        processor.ProcessTask(task);

        processor.SetStrategy(new PriorityBasedEstimationStrategy());
        Console.WriteLine("Оцінка за пріоритетом:");
        processor.ProcessTask(task);
    }

    static void DemonstrateTemplateMethod()
    {
        Console.WriteLine("\n=== Template Method ===");
        Console.WriteLine("Робочий процес для розробки програмного забезпечення:");
        var softwareWorkflow = new SoftwareDevelopmentWorkflow();
        softwareWorkflow.ExecuteProject();

        Console.WriteLine("\nРобочий процес для маркетингової кампанії:");
        var marketingWorkflow = new MarketingCampaignWorkflow();
        marketingWorkflow.ExecuteProject();
    }

    static void DemonstrateVisitor()
    {
        Console.WriteLine("\n=== Visitor ===");
        var employees = new IEmployee[]
        {
                new Developer("Іван", 3, 6000),
                new Manager("Олег", 5, 7)
        };

        var salaryCalculator = new SalaryCalculator();
        var performanceEvaluator = new PerformanceEvaluator();

        Console.WriteLine("Обчислення зарплати:");
        foreach (var employee in employees)
        {
            employee.Accept(salaryCalculator);
        }

        Console.WriteLine("\nОцінка продуктивності:");
        foreach (var employee in employees)
        {
            employee.Accept(performanceEvaluator);
        }

        Console.WriteLine("\nІнформація про працівників:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}