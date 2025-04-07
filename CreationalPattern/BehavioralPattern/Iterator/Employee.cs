using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Iterator
{
    public class Employee
    {
        public string Name { get; }
        public int YearsOfExperience { get; }

        public Employee(string name, int yearsOfExperience)
        {
            Name = name;
            YearsOfExperience = yearsOfExperience;
        }

        public override string ToString() => $"{Name} (Досвід: {YearsOfExperience} роки)";
    }
}