using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Iterator
{

    public class EmployeeCollection
    {
        private readonly List<Employee> _employees = new();

        public void AddEmployee(Employee employee) => _employees.Add(employee);

        public IEmployeeIterator CreateIterator(int minExperience = 0) => new ExperiencedEmployeeIterator(_employees, minExperience);

        public int Count => _employees.Count;
    }
}