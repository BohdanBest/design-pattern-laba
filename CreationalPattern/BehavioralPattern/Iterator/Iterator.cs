using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.BehavioralPattern.Iterator
{
    public class EmployeeCollection : IEnumerable<string>
    {
        private readonly List<string> _employees = ["Іван", "Марія", "Петро"];

        public IEnumerator<string> GetEnumerator() => _employees.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}