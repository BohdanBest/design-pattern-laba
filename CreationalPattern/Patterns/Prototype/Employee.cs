using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.Patterns.Prototype
{
    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Employee(string Name, string Role)
        {
            this.Name = Name;
            this.Role = Role;
        }

        public object Clone() => new Employee(Name, Role);

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}, Role: {Role},");
        }

        internal void InputData()
        {
            throw new NotImplementedException();
        }
    }
}