using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.StructuralPattern.Flyweight
{
    public class Role
    {
        public string Title { get; }
        public Role(string title) => Title = title;
        public void Display(string name) => Console.WriteLine($"{name} - {Title}");
    }

    public class RoleFactory
    {
        private readonly Dictionary<string, Role> _roles = new();

        public Role GetRole(string title)
        {
            if (!_roles.ContainsKey(title))
            {
                _roles[title] = new Role(title);
            }
            return _roles[title];
        }
    }
}