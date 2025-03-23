using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.StructuralPattern.Composite
{
    public interface IComponent
    {
        void Display();
    }

    public class Employee : IComponent
    {
        private readonly string _name;

        public Employee(string name) => _name = name;

        public void Display() => Console.WriteLine($"Співробітник: {_name}");
    }

    public class DepartmentComponent : IComponent
    {
        private readonly List<IComponent> _components = new();

        public void Add(IComponent component) => _components.Add(component);

        public void Display()
        {
            Console.WriteLine("Відділ:");
            foreach (var component in _components)
            {
                component.Display();
            }
        }
    }
}
