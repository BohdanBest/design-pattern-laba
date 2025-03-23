using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPattern.StructuralPattern.Adapter
{
    public interface IEmployee
    {
        string GetName();
    }
    public class LegacyEmployee
    {
        public string GetFullName() => "John Doe";
    }

    public class EmployeeAdapter : IEmployee
    {
        private readonly LegacyEmployee _legacyEmployee;

        public EmployeeAdapter(LegacyEmployee legacyEmployee)
        {
            _legacyEmployee = legacyEmployee;
        }

        public string GetName() => _legacyEmployee.GetFullName();
    }
}

