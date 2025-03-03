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

        public object Clone() => MemberwiseClone();

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}, Role: {Role},");
        }
    }
}