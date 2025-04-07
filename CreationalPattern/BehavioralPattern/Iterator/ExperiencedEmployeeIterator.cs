using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Iterator
{
    public class ExperiencedEmployeeIterator : IEmployeeIterator
    {
        private readonly List<Employee> _employees;
        private int _position = -1;
        private readonly int _minExperience;

        public ExperiencedEmployeeIterator(List<Employee> employees, int minExperience)
        {
            _employees = employees;
            _minExperience = minExperience;
        }

        public bool MoveNext()
        {
            while (_position + 1 < _employees.Count)
            {
                _position++;
                if (_employees[_position].YearsOfExperience >= _minExperience)
                    return true;
            }
            return false;
        }

        public Employee Current => _position >= 0 && _position < _employees.Count ? _employees[_position] : null;

        public void Reset() => _position = -1;
    }
}